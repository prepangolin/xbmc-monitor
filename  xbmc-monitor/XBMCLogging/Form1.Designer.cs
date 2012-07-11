namespace XBMCLogging
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.line = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.fatalCheckBox = new System.Windows.Forms.CheckBox();
            this.errorCheckBox = new System.Windows.Forms.CheckBox();
            this.warningCheckBox = new System.Windows.Forms.CheckBox();
            this.noticeCheckBox = new System.Windows.Forms.CheckBox();
            this.infoCheckBox = new System.Windows.Forms.CheckBox();
            this.debugCheckBox = new System.Windows.Forms.CheckBox();
            this.logTextBox = new System.Windows.Forms.RichTextBox();
            this.logContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.locationTextBox = new System.Windows.Forms.TextBox();
            this.locationLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.locationToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.logContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.line);
            this.groupBox1.Controls.Add(this.clearButton);
            this.groupBox1.Controls.Add(this.fatalCheckBox);
            this.groupBox1.Controls.Add(this.errorCheckBox);
            this.groupBox1.Controls.Add(this.warningCheckBox);
            this.groupBox1.Controls.Add(this.noticeCheckBox);
            this.groupBox1.Controls.Add(this.infoCheckBox);
            this.groupBox1.Controls.Add(this.debugCheckBox);
            this.groupBox1.Font = new System.Drawing.Font("Trebuchet MS", 8.25F);
            this.groupBox1.Location = new System.Drawing.Point(1159, 29);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(110, 329);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Severity Levels";
            // 
            // line
            // 
            this.line.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.line.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.line.Location = new System.Drawing.Point(5, 209);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(100, 2);
            this.line.TabIndex = 7;
            this.line.Text = "line";
            // 
            // clearButton
            // 
            this.clearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.clearButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.clearButton.FlatAppearance.BorderSize = 0;
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearButton.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.ForeColor = System.Drawing.Color.Gray;
            this.clearButton.Image = global::XBMCLogging.Properties.Resources.log;
            this.clearButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.clearButton.Location = new System.Drawing.Point(14, 223);
            this.clearButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(82, 94);
            this.clearButton.TabIndex = 6;
            this.clearButton.Text = "Clear Log";
            this.clearButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // fatalCheckBox
            // 
            this.fatalCheckBox.AutoSize = true;
            this.fatalCheckBox.Checked = true;
            this.fatalCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.fatalCheckBox.ForeColor = System.Drawing.Color.Gray;
            this.fatalCheckBox.Location = new System.Drawing.Point(6, 165);
            this.fatalCheckBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fatalCheckBox.Name = "fatalCheckBox";
            this.fatalCheckBox.Size = new System.Drawing.Size(57, 20);
            this.fatalCheckBox.TabIndex = 5;
            this.fatalCheckBox.Tag = "5";
            this.fatalCheckBox.Text = "FATAL";
            this.fatalCheckBox.UseVisualStyleBackColor = true;
            this.fatalCheckBox.CheckStateChanged += new System.EventHandler(this.checkBox_CheckStateChanged);
            // 
            // errorCheckBox
            // 
            this.errorCheckBox.AutoSize = true;
            this.errorCheckBox.Checked = true;
            this.errorCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.errorCheckBox.ForeColor = System.Drawing.Color.Red;
            this.errorCheckBox.Location = new System.Drawing.Point(6, 137);
            this.errorCheckBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.errorCheckBox.Name = "errorCheckBox";
            this.errorCheckBox.Size = new System.Drawing.Size(59, 20);
            this.errorCheckBox.TabIndex = 4;
            this.errorCheckBox.Tag = "4";
            this.errorCheckBox.Text = "ERROR";
            this.errorCheckBox.UseVisualStyleBackColor = true;
            this.errorCheckBox.CheckStateChanged += new System.EventHandler(this.checkBox_CheckStateChanged);
            // 
            // warningCheckBox
            // 
            this.warningCheckBox.AutoSize = true;
            this.warningCheckBox.Checked = true;
            this.warningCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.warningCheckBox.ForeColor = System.Drawing.Color.Orange;
            this.warningCheckBox.Location = new System.Drawing.Point(6, 108);
            this.warningCheckBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.warningCheckBox.Name = "warningCheckBox";
            this.warningCheckBox.Size = new System.Drawing.Size(74, 20);
            this.warningCheckBox.TabIndex = 3;
            this.warningCheckBox.Tag = "3";
            this.warningCheckBox.Text = "WARNING";
            this.warningCheckBox.UseVisualStyleBackColor = true;
            this.warningCheckBox.CheckStateChanged += new System.EventHandler(this.checkBox_CheckStateChanged);
            // 
            // noticeCheckBox
            // 
            this.noticeCheckBox.AutoSize = true;
            this.noticeCheckBox.Checked = true;
            this.noticeCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.noticeCheckBox.ForeColor = System.Drawing.Color.Green;
            this.noticeCheckBox.Location = new System.Drawing.Point(6, 80);
            this.noticeCheckBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.noticeCheckBox.Name = "noticeCheckBox";
            this.noticeCheckBox.Size = new System.Drawing.Size(65, 20);
            this.noticeCheckBox.TabIndex = 2;
            this.noticeCheckBox.Tag = "2";
            this.noticeCheckBox.Text = "NOTICE";
            this.noticeCheckBox.UseVisualStyleBackColor = true;
            this.noticeCheckBox.CheckStateChanged += new System.EventHandler(this.checkBox_CheckStateChanged);
            // 
            // infoCheckBox
            // 
            this.infoCheckBox.AutoSize = true;
            this.infoCheckBox.Checked = true;
            this.infoCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.infoCheckBox.ForeColor = System.Drawing.Color.Blue;
            this.infoCheckBox.Location = new System.Drawing.Point(6, 52);
            this.infoCheckBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.infoCheckBox.Name = "infoCheckBox";
            this.infoCheckBox.Size = new System.Drawing.Size(52, 20);
            this.infoCheckBox.TabIndex = 1;
            this.infoCheckBox.Tag = "1";
            this.infoCheckBox.Text = "INFO";
            this.infoCheckBox.UseVisualStyleBackColor = true;
            this.infoCheckBox.CheckStateChanged += new System.EventHandler(this.checkBox_CheckStateChanged);
            // 
            // debugCheckBox
            // 
            this.debugCheckBox.AutoSize = true;
            this.debugCheckBox.Checked = true;
            this.debugCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.debugCheckBox.ForeColor = System.Drawing.Color.Black;
            this.debugCheckBox.Location = new System.Drawing.Point(6, 23);
            this.debugCheckBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.debugCheckBox.Name = "debugCheckBox";
            this.debugCheckBox.Size = new System.Drawing.Size(60, 20);
            this.debugCheckBox.TabIndex = 0;
            this.debugCheckBox.Tag = "0";
            this.debugCheckBox.Text = "DEBUG";
            this.debugCheckBox.UseVisualStyleBackColor = true;
            this.debugCheckBox.CheckStateChanged += new System.EventHandler(this.checkBox_CheckStateChanged);
            // 
            // logTextBox
            // 
            this.logTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.logTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.logTextBox.Location = new System.Drawing.Point(0, 24);
            this.logTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.logTextBox.Name = "logTextBox";
            this.logTextBox.ReadOnly = true;
            this.logTextBox.Size = new System.Drawing.Size(1158, 334);
            this.logTextBox.TabIndex = 2;
            this.logTextBox.Text = "";
            this.logTextBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.logTextBox_MouseDown);
            // 
            // logContextMenuStrip
            // 
            this.logContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.selectAllToolStripMenuItem});
            this.logContextMenuStrip.Name = "logContextMenuStrip";
            this.logContextMenuStrip.Size = new System.Drawing.Size(123, 48);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.selectAllToolStripMenuItem.Text = "Select All";
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
            // 
            // locationTextBox
            // 
            this.locationTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.locationTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.locationTextBox.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationTextBox.Location = new System.Drawing.Point(72, 2);
            this.locationTextBox.Name = "locationTextBox";
            this.locationTextBox.ReadOnly = true;
            this.locationTextBox.Size = new System.Drawing.Size(1197, 20);
            this.locationTextBox.TabIndex = 3;
            this.locationToolTip.SetToolTip(this.locationTextBox, "Click to change the location.");
            this.locationTextBox.Click += new System.EventHandler(this.locationTextBox_Click);
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationLabel.Location = new System.Drawing.Point(4, 4);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(62, 16);
            this.locationLabel.TabIndex = 4;
            this.locationLabel.Text = "Location : ";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(0, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1270, 2);
            this.label2.TabIndex = 8;
            this.label2.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1270, 359);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.locationLabel);
            this.Controls.Add(this.logTextBox);
            this.Controls.Add(this.locationTextBox);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 8.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(800, 397);
            this.Name = "Form1";
            this.Text = "XBMC Monitor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResizeEnd += new System.EventHandler(this.Form1_ResizeEnd);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.logContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox infoCheckBox;
        private System.Windows.Forms.CheckBox debugCheckBox;
        private System.Windows.Forms.CheckBox fatalCheckBox;
        private System.Windows.Forms.CheckBox errorCheckBox;
        private System.Windows.Forms.CheckBox warningCheckBox;
        private System.Windows.Forms.CheckBox noticeCheckBox;
        private System.Windows.Forms.RichTextBox logTextBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label line;
        private System.Windows.Forms.ContextMenuStrip logContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.TextBox locationTextBox;
        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip locationToolTip;

    }
}

