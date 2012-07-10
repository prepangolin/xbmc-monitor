using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections;

namespace XBMCLogging
{
    public partial class Form1 : Form
    {
        //Local Variables
        private string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\XBMC\\xbmc.log";
        private FileStream stream;
        private StreamReader reader;
        private Timer timer;

        //Arrays to hold True/False flags and names and colors for each selected state in the GUI
        //Intitalizing security levels [0:DEBUG, 1:INFO, 2:NOTICE, 3:WARNING, 4:ERROR, 5:FATAL]
        private string[] severityLevelsString = { "DEBUG:", "INFO:", "NOTICE:", "WARNING:", "ERROR:", "FATAL:" }; //Setting the name of each state
        private bool[] severityLevelsState = { true, true, true, true, true, true }; //Setting the state if each level
        private Color[][] severityLevelsColor = { new Color[] { Color.Black, Color.Black }, new Color[] { Color.Blue, Color.DarkBlue }, new Color[] { Color.Green, Color.DarkGreen }, new Color[] { Color.Orange, Color.Goldenrod }, new Color[] { Color.Red, Color.DarkRed }, new Color[] { Color.Gray, Color.Gray } }; //Setting the color and child color of each state


        private long lastLength = 0; //Save the last stream length to avoid duplicating content

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            logTextBox.ContextMenuStrip = logContextMenuStrip;
            //Initializing timer
            timer = new Timer();
            timer.Tick += new EventHandler(appendText);
            timer.Interval = 1000;
            timer.Start();
        }

        private void appendText(object sender, EventArgs e)
        {
            //Initializing stream
            stream = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            reader = new StreamReader(stream);
            //Reading the text already in the TextBox so it won't be appended again
            reader.Read(new char[lastLength], 0,(int)lastLength);
            //Reseting the last stream length
            lastLength = stream.Length;

            //TextBox Related variables for each line
            string line = "";
            Color mainColor = Color.Black;
            Color childColor = Color.Black;
            string severity = "";
            string lastSeverity = "";

            //Requested levels by the user
            ArrayList requestedLevels = new ArrayList();
            for (int i = 0; i < 6; i++)
                if (severityLevelsState[i])
                    requestedLevels.Add(severityLevelsString[i]);

            //Start looping through the stream
            while ((line = reader.ReadLine()) != null)
            {
                if (requestedLevels.Count > 0)
                {
                    //Building the RegEx
                    Match mainMatch = Regex.Match(line, "(" + string.Join(")|(", requestedLevels.ToArray()) + ")");
                    Match childMatch = Regex.Match(line, "(" + string.Join(")|(", severityLevelsString) + ")");

                    if (mainMatch.Success)
                    {
                        //Choosing the color
                        severity = mainMatch.Groups[0].Value;
                        int levelIndex;
                        for (levelIndex = 0; levelIndex < severityLevelsString.Length; levelIndex++)
                            if (severityLevelsString[levelIndex].Equals(severity))
                                break;
                        mainColor = severityLevelsColor[levelIndex][0];
                        childColor = severityLevelsColor[levelIndex][1];

                        //Appending and Coloring the TextBox
                        logTextBox.AppendText(line + Environment.NewLine);
                        logTextBox.SelectionStart = (logTextBox.TextLength - line.Length) - 1;
                        logTextBox.SelectionLength = line.Length;
                        logTextBox.SelectionColor = mainColor;
                    }
                    else
                        if (childMatch.Success)
                            severity = "";


                    //Check if the line is a description of the previous or an invalid request
                    //This is the description of the previous line
                    if ((!childMatch.Success) && !lastSeverity.Equals(""))
                    {
                        //Appending and Coloring the TextBox
                        logTextBox.AppendText(line + Environment.NewLine);
                        logTextBox.SelectionStart = (logTextBox.TextLength - line.Length) - 1;
                        logTextBox.SelectionLength = line.Length;
                        logTextBox.SelectionColor = childColor;
                    }

                    //Reseting the last match
                    lastSeverity = severity;

                    //Scrolling to End
                    scrollToEnd();
                }
            }
            reader.Close();
            stream.Close();
        }

        private void resetText(object sender, EventArgs e)
        {
            //This will read the whole log file again beacuse lastLength is set to zero
            logTextBox.Clear();
            lastLength = 0;
            this.appendText(sender, e);
        }

        private void scrollToEnd()
        {
            //Scrolling to End
            logTextBox.SelectionStart = logTextBox.Text.Length;
            logTextBox.ScrollToCaret();
        }

        //Resize window syncing with scrolling handling
        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            scrollToEnd();
        }

        //ContextMenuStrip Event Handling
        private void logTextBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                copyToolStripMenuItem.Enabled = (logTextBox.SelectedText.Length > 0);
                logTextBox.ContextMenuStrip.Show(logTextBox, new Point(e.X, e.Y));
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            logTextBox.Copy();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Fixing a carret not showing
            logTextBox.Select();
            logTextBox.SelectAll();
        }

        //CheckBox state handling
        private void checkBox_CheckStateChanged(object sender, EventArgs e)
        {
            //Casting the sender to be able to retrieve its Tag
            CheckBox cb = (CheckBox)sender;
            //Setting the State of the checked level depending on its Tag value [0:DEBUG, 1:INFO, 2:NOTICE, 3:WARNING, 4:ERROR, 5:FATAL]
            severityLevelsState[Int32.Parse(cb.Tag.ToString())] = cb.Checked;
            //Reseting Text
            this.resetText(sender, e);
        }

        //Clear log handling
        private void clearButton_Click(object sender, EventArgs e)
        {
            //Checking if the file is being used by another process
            if (fileIsLocked())
                logTextBox.Clear();
            else
            {
                //Deciding whether to virtually clear the window or delete the contents of the log too; only if the file is not locked by another process
                DialogResult dr = MessageBox.Show("This will clear the log Window.\nDo you want to clear the contents of the \"xbmc.log\" file as-well ?", "Clear !", MessageBoxButtons.YesNoCancel);
                if (dr == DialogResult.Yes)
                {
                    File.WriteAllText(path, String.Empty);
                    this.resetText(sender, e);
                }
                else if (dr == DialogResult.No)
                {
                    logTextBox.Clear();
                }
            }
        }

        private bool fileIsLocked()
        {
            FileStream stream = null;
            try
            {
                stream = new FileStream(path, FileMode.Open, FileAccess.ReadWrite, FileShare.None);
            }
            catch (IOException)
            {
                return true;
            }
            finally
            {
                if (stream != null)
                    stream.Close();
            }
            return false;
        }
    }
}
