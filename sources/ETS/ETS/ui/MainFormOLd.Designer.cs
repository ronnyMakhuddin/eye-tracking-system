namespace ETS
{
    partial class MainFormOld
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFormOld));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openSessionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openTrialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miSave = new System.Windows.Forms.ToolStripMenuItem();
            this.miSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.captureImageBox = new Emgu.CV.UI.ImageBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lblMessages = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.btnAddTemplate = new System.Windows.Forms.ToolStripButton();
            this.btnClearTemplates = new System.Windows.Forms.ToolStripButton();
            this.btnStartRecording = new System.Windows.Forms.ToolStripButton();
            this.btnStopRecording = new System.Windows.Forms.ToolStripButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.trvSession = new System.Windows.Forms.TreeView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.captureImageBox)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(791, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openSessionToolStripMenuItem,
            this.openTrialToolStripMenuItem,
            this.miSave,
            this.miSaveAs,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openSessionToolStripMenuItem
            // 
            this.openSessionToolStripMenuItem.Name = "openSessionToolStripMenuItem";
            this.openSessionToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openSessionToolStripMenuItem.Text = "Open Session";
            this.openSessionToolStripMenuItem.Click += new System.EventHandler(this.openSessionToolStripMenuItem_Click);
            // 
            // openTrialToolStripMenuItem
            // 
            this.openTrialToolStripMenuItem.Name = "openTrialToolStripMenuItem";
            this.openTrialToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openTrialToolStripMenuItem.Text = "Open Trial";
            // 
            // miSave
            // 
            this.miSave.Name = "miSave";
            this.miSave.Size = new System.Drawing.Size(152, 22);
            this.miSave.Text = "Save";
            this.miSave.Click += new System.EventHandler(this.miSave_Click);
            // 
            // miSaveAs
            // 
            this.miSaveAs.Name = "miSaveAs";
            this.miSaveAs.Size = new System.Drawing.Size(152, 22);
            this.miSaveAs.Text = "Save As...";
            this.miSaveAs.Click += new System.EventHandler(this.miSaveAs_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // captureImageBox
            // 
            this.captureImageBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.captureImageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.captureImageBox.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.Minimum;
            this.captureImageBox.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.Default;
            this.captureImageBox.Location = new System.Drawing.Point(192, 52);
            this.captureImageBox.Name = "captureImageBox";
            this.captureImageBox.Size = new System.Drawing.Size(320, 240);
            this.captureImageBox.TabIndex = 4;
            this.captureImageBox.TabStop = false;
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblMessages});
            this.statusStrip.Location = new System.Drawing.Point(0, 435);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(791, 22);
            this.statusStrip.TabIndex = 5;
            this.statusStrip.Text = "statusStrip1";
            // 
            // lblMessages
            // 
            this.lblMessages.Name = "lblMessages";
            this.lblMessages.Size = new System.Drawing.Size(118, 17);
            this.lblMessages.Text = "toolStripStatusLabel1";
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddTemplate,
            this.btnClearTemplates,
            this.btnStartRecording,
            this.btnStopRecording});
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(791, 25);
            this.toolStrip.TabIndex = 6;
            this.toolStrip.Text = "toolStrip";
            // 
            // btnAddTemplate
            // 
            this.btnAddTemplate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnAddTemplate.Image = ((System.Drawing.Image)(resources.GetObject("btnAddTemplate.Image")));
            this.btnAddTemplate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddTemplate.Name = "btnAddTemplate";
            this.btnAddTemplate.Size = new System.Drawing.Size(83, 22);
            this.btnAddTemplate.Text = "Add template";
            this.btnAddTemplate.Click += new System.EventHandler(this.btnAddTemplate_Click);
            // 
            // btnClearTemplates
            // 
            this.btnClearTemplates.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnClearTemplates.Image = ((System.Drawing.Image)(resources.GetObject("btnClearTemplates.Image")));
            this.btnClearTemplates.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnClearTemplates.Name = "btnClearTemplates";
            this.btnClearTemplates.Size = new System.Drawing.Size(93, 22);
            this.btnClearTemplates.Text = "Clear templates";
            this.btnClearTemplates.Click += new System.EventHandler(this.btnClearTemplates_Click);
            // 
            // btnStartRecording
            // 
            this.btnStartRecording.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnStartRecording.Image = ((System.Drawing.Image)(resources.GetObject("btnStartRecording.Image")));
            this.btnStartRecording.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnStartRecording.Name = "btnStartRecording";
            this.btnStartRecording.Size = new System.Drawing.Size(89, 22);
            this.btnStartRecording.Text = "Start recording";
            this.btnStartRecording.Click += new System.EventHandler(this.btnStartRecording_Click);
            // 
            // btnStopRecording
            // 
            this.btnStopRecording.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnStopRecording.Image = ((System.Drawing.Image)(resources.GetObject("btnStopRecording.Image")));
            this.btnStopRecording.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnStopRecording.Name = "btnStopRecording";
            this.btnStopRecording.Size = new System.Drawing.Size(89, 22);
            this.btnStopRecording.Text = "Stop recording";
            this.btnStopRecording.Click += new System.EventHandler(this.btnStopRecording_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(518, 52);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(261, 240);
            this.textBox1.TabIndex = 14;
            // 
            // trvSession
            // 
            this.trvSession.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.trvSession.LabelEdit = true;
            this.trvSession.Location = new System.Drawing.Point(13, 53);
            this.trvSession.Name = "trvSession";
            this.trvSession.Size = new System.Drawing.Size(173, 379);
            this.trvSession.TabIndex = 15;
            this.trvSession.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.trvSession_AfterLabelEdit);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 457);
            this.Controls.Add(this.trvSession);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.captureImageBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "ETS";
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.captureImageBox)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private Emgu.CV.UI.ImageBox captureImageBox;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblMessages;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripButton btnAddTemplate;
        private System.Windows.Forms.ToolStripMenuItem miSave;
        private System.Windows.Forms.ToolStripMenuItem miSaveAs;
        private System.Windows.Forms.ToolStripMenuItem openSessionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openTrialToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton btnClearTemplates;
        private System.Windows.Forms.TreeView trvSession;
        private System.Windows.Forms.ToolStripButton btnStartRecording;
        private System.Windows.Forms.ToolStripButton btnStopRecording;
    }
}

