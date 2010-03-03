namespace ETS
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.videoPreferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabBar = new System.Windows.Forms.TabControl();
            this.tabCapture = new System.Windows.Forms.TabPage();
            this.tabPreferences = new System.Windows.Forms.TabPage();
            this.captureImageBox = new Emgu.CV.UI.ImageBox();
            this.menuStrip1.SuspendLayout();
            this.tabBar.SuspendLayout();
            this.tabCapture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.captureImageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(791, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.videoPreferencesToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // videoPreferencesToolStripMenuItem
            // 
            this.videoPreferencesToolStripMenuItem.Name = "videoPreferencesToolStripMenuItem";
            this.videoPreferencesToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.videoPreferencesToolStripMenuItem.Text = "Video preferences";
            // 
            // tabBar
            // 
            this.tabBar.Controls.Add(this.tabCapture);
            this.tabBar.Controls.Add(this.tabPreferences);
            this.tabBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabBar.Location = new System.Drawing.Point(0, 24);
            this.tabBar.Name = "tabBar";
            this.tabBar.SelectedIndex = 0;
            this.tabBar.Size = new System.Drawing.Size(791, 253);
            this.tabBar.TabIndex = 4;
            // 
            // tabCapture
            // 
            this.tabCapture.Controls.Add(this.captureImageBox);
            this.tabCapture.Location = new System.Drawing.Point(4, 22);
            this.tabCapture.Name = "tabCapture";
            this.tabCapture.Padding = new System.Windows.Forms.Padding(3);
            this.tabCapture.Size = new System.Drawing.Size(783, 227);
            this.tabCapture.TabIndex = 0;
            this.tabCapture.Text = "Capture";
            this.tabCapture.UseVisualStyleBackColor = true;
            // 
            // tabPreferences
            // 
            this.tabPreferences.Location = new System.Drawing.Point(4, 22);
            this.tabPreferences.Name = "tabPreferences";
            this.tabPreferences.Padding = new System.Windows.Forms.Padding(3);
            this.tabPreferences.Size = new System.Drawing.Size(783, 227);
            this.tabPreferences.TabIndex = 1;
            this.tabPreferences.Text = "Preferences";
            this.tabPreferences.UseVisualStyleBackColor = true;
            // 
            // captureImageBox
            // 
            this.captureImageBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.captureImageBox.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.Minimum;
            this.captureImageBox.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.Default;
            this.captureImageBox.Location = new System.Drawing.Point(3, 3);
            this.captureImageBox.Name = "captureImageBox";
            this.captureImageBox.Size = new System.Drawing.Size(777, 221);
            this.captureImageBox.TabIndex = 3;
            this.captureImageBox.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 277);
            this.Controls.Add(this.tabBar);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabBar.ResumeLayout(false);
            this.tabCapture.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.captureImageBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem videoPreferencesToolStripMenuItem;
        private System.Windows.Forms.TabControl tabBar;
        private System.Windows.Forms.TabPage tabCapture;
        private System.Windows.Forms.TabPage tabPreferences;
        private Emgu.CV.UI.ImageBox captureImageBox;
    }
}

