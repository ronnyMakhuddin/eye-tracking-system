namespace ETS.ui
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miNewTrial = new System.Windows.Forms.ToolStripMenuItem();
            this.miAddSeries = new System.Windows.Forms.ToolStripMenuItem();
            this.miEditSeries = new System.Windows.Forms.ToolStripMenuItem();
            this.miDeleteSeries = new System.Windows.Forms.ToolStripMenuItem();
            this.miClose = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miViewPatients = new System.Windows.Forms.ToolStripMenuItem();
            this.miEditStimuluses = new System.Windows.Forms.ToolStripMenuItem();
            this.miEditSeriesConfigs = new System.Windows.Forms.ToolStripMenuItem();
            this.editSeriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newSelectCommandBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.stimulusTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.newSelectCommandBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.trwTrials = new System.Windows.Forms.TreeView();
            this.strStatus = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblDbStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newSelectCommandBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stimulusTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newSelectCommandBindingSource)).BeginInit();
            this.strStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(749, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miNewTrial,
            this.miAddSeries,
            this.miEditSeries,
            this.miDeleteSeries,
            this.miClose});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // miNewTrial
            // 
            this.miNewTrial.Name = "miNewTrial";
            this.miNewTrial.Size = new System.Drawing.Size(140, 22);
            this.miNewTrial.Text = "Load Trial";
            this.miNewTrial.Click += new System.EventHandler(this.miNewTrial_Click);
            // 
            // miAddSeries
            // 
            this.miAddSeries.Name = "miAddSeries";
            this.miAddSeries.Size = new System.Drawing.Size(140, 22);
            this.miAddSeries.Text = "Add Series";
            this.miAddSeries.Visible = false;
            this.miAddSeries.Click += new System.EventHandler(this.miAddSeries_Click);
            // 
            // miEditSeries
            // 
            this.miEditSeries.Name = "miEditSeries";
            this.miEditSeries.Size = new System.Drawing.Size(140, 22);
            this.miEditSeries.Text = "Edit Series";
            this.miEditSeries.Visible = false;
            this.miEditSeries.Click += new System.EventHandler(this.miEditSeries_Click);
            // 
            // miDeleteSeries
            // 
            this.miDeleteSeries.Name = "miDeleteSeries";
            this.miDeleteSeries.Size = new System.Drawing.Size(140, 22);
            this.miDeleteSeries.Text = "Delete Series";
            this.miDeleteSeries.Visible = false;
            this.miDeleteSeries.Click += new System.EventHandler(this.miDeleteSeries_Click);
            // 
            // miClose
            // 
            this.miClose.Name = "miClose";
            this.miClose.Size = new System.Drawing.Size(140, 22);
            this.miClose.Text = "Close";
            this.miClose.Click += new System.EventHandler(this.miClose_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miViewPatients,
            this.miEditStimuluses,
            this.miEditSeriesConfigs,
            this.editSeriesToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // miViewPatients
            // 
            this.miViewPatients.Name = "miViewPatients";
            this.miViewPatients.Size = new System.Drawing.Size(171, 22);
            this.miViewPatients.Text = "Edit Patients";
            this.miViewPatients.Click += new System.EventHandler(this.miViewPatients_Click);
            // 
            // miEditStimuluses
            // 
            this.miEditStimuluses.Name = "miEditStimuluses";
            this.miEditStimuluses.Size = new System.Drawing.Size(171, 22);
            this.miEditStimuluses.Text = "Edit Stimuluses";
            this.miEditStimuluses.Click += new System.EventHandler(this.miEditStimuluses_Click);
            // 
            // miEditSeriesConfigs
            // 
            this.miEditSeriesConfigs.Name = "miEditSeriesConfigs";
            this.miEditSeriesConfigs.Size = new System.Drawing.Size(171, 22);
            this.miEditSeriesConfigs.Text = "Edit Series Configs";
            this.miEditSeriesConfigs.Click += new System.EventHandler(this.miEditSeriesConfigs_Click);
            // 
            // editSeriesToolStripMenuItem
            // 
            this.editSeriesToolStripMenuItem.Name = "editSeriesToolStripMenuItem";
            this.editSeriesToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.editSeriesToolStripMenuItem.Text = "Edit Trials";
            this.editSeriesToolStripMenuItem.Click += new System.EventHandler(this.editSeriesToolStripMenuItem_Click);
            // 
            // stimulusTypeBindingSource
            // 
            this.stimulusTypeBindingSource.DataMember = "StimulusType";
            // 
            // newSelectCommandBindingSource
            // 
            this.newSelectCommandBindingSource.DataMember = "NewSelectCommand";
            // 
            // trwTrials
            // 
            this.trwTrials.Location = new System.Drawing.Point(13, 28);
            this.trwTrials.Name = "trwTrials";
            this.trwTrials.Size = new System.Drawing.Size(161, 233);
            this.trwTrials.TabIndex = 1;
            this.trwTrials.DoubleClick += new System.EventHandler(this.trwTrials_DoubleClick);
            // 
            // strStatus
            // 
            this.strStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblDbStatus});
            this.strStatus.Location = new System.Drawing.Point(0, 281);
            this.strStatus.Name = "strStatus";
            this.strStatus.Size = new System.Drawing.Size(749, 22);
            this.strStatus.TabIndex = 2;
            this.strStatus.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(155, 17);
            this.toolStripStatusLabel1.Text = "Database connection status:";
            // 
            // lblDbStatus
            // 
            this.lblDbStatus.Name = "lblDbStatus";
            this.lblDbStatus.Size = new System.Drawing.Size(108, 17);
            this.lblDbStatus.Text = "%database status%";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 303);
            this.Controls.Add(this.strStatus);
            this.Controls.Add(this.trwTrials);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "ETS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newSelectCommandBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stimulusTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newSelectCommandBindingSource)).EndInit();
            this.strStatus.ResumeLayout(false);
            this.strStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miClose;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miViewPatients;
        private System.Windows.Forms.ToolStripMenuItem miEditStimuluses;
        private System.Windows.Forms.BindingSource newSelectCommandBindingSource1;
        private System.Windows.Forms.BindingSource newSelectCommandBindingSource;
        private System.Windows.Forms.BindingSource stimulusTypeBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn filenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn stTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripMenuItem miEditSeriesConfigs;
        private System.Windows.Forms.ToolStripMenuItem editSeriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miNewTrial;
        private System.Windows.Forms.TreeView trwTrials;
        private System.Windows.Forms.ToolStripMenuItem miAddSeries;
        private System.Windows.Forms.StatusStrip strStatus;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblDbStatus;
        private System.Windows.Forms.ToolStripMenuItem miEditSeries;
        private System.Windows.Forms.ToolStripMenuItem miDeleteSeries;
    }
}