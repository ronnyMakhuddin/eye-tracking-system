namespace ETS.ui
{
    partial class SelectTrialform
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
            this.grdTrials = new System.Windows.Forms.DataGridView();
            this.selectTrialsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.trialsDataSet = new ETS.TrialsDataSet();
            this.trialsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.selectTrialsTableAdapter = new ETS.TrialsDataSetTableAdapters.SelectTrialsTableAdapter();
            this.selectTrialsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.clmTrialName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPatientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmVideoFileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPatientId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdTrials)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectTrialsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trialsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trialsDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectTrialsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // grdTrials
            // 
            this.grdTrials.AllowUserToAddRows = false;
            this.grdTrials.AllowUserToDeleteRows = false;
            this.grdTrials.AllowUserToResizeColumns = false;
            this.grdTrials.AllowUserToResizeRows = false;
            this.grdTrials.AutoGenerateColumns = false;
            this.grdTrials.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTrials.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmTrialName,
            this.clmPatientName,
            this.clmDate,
            this.clmId,
            this.clmVideoFileName,
            this.clmPatientId});
            this.grdTrials.DataSource = this.selectTrialsBindingSource1;
            this.grdTrials.Location = new System.Drawing.Point(12, 12);
            this.grdTrials.MultiSelect = false;
            this.grdTrials.Name = "grdTrials";
            this.grdTrials.ReadOnly = true;
            this.grdTrials.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdTrials.ShowEditingIcon = false;
            this.grdTrials.Size = new System.Drawing.Size(550, 238);
            this.grdTrials.TabIndex = 0;
            this.grdTrials.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grdTrials_CellMouseDoubleClick);
            // 
            // selectTrialsBindingSource
            // 
            this.selectTrialsBindingSource.DataMember = "SelectTrials";
            this.selectTrialsBindingSource.DataSource = this.trialsDataSet;
            // 
            // trialsDataSet
            // 
            this.trialsDataSet.DataSetName = "TrialsDataSet";
            this.trialsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // trialsDataSetBindingSource
            // 
            this.trialsDataSetBindingSource.DataSource = this.trialsDataSet;
            this.trialsDataSetBindingSource.Position = 0;
            // 
            // selectTrialsTableAdapter
            // 
            this.selectTrialsTableAdapter.ClearBeforeFill = true;
            // 
            // selectTrialsBindingSource1
            // 
            this.selectTrialsBindingSource1.DataMember = "SelectTrials";
            this.selectTrialsBindingSource1.DataSource = this.trialsDataSetBindingSource;
            // 
            // clmTrialName
            // 
            this.clmTrialName.DataPropertyName = "name";
            this.clmTrialName.HeaderText = "Trial Name";
            this.clmTrialName.Name = "clmTrialName";
            this.clmTrialName.ReadOnly = true;
            // 
            // clmPatientName
            // 
            this.clmPatientName.DataPropertyName = "patient_name";
            this.clmPatientName.HeaderText = "Patient Name";
            this.clmPatientName.Name = "clmPatientName";
            this.clmPatientName.ReadOnly = true;
            this.clmPatientName.Width = 200;
            // 
            // clmDate
            // 
            this.clmDate.DataPropertyName = "date";
            this.clmDate.HeaderText = "Date";
            this.clmDate.Name = "clmDate";
            this.clmDate.ReadOnly = true;
            // 
            // clmId
            // 
            this.clmId.DataPropertyName = "id";
            this.clmId.HeaderText = "id";
            this.clmId.Name = "clmId";
            this.clmId.ReadOnly = true;
            this.clmId.Visible = false;
            // 
            // clmVideoFileName
            // 
            this.clmVideoFileName.DataPropertyName = "video_filename";
            this.clmVideoFileName.HeaderText = "Video file name";
            this.clmVideoFileName.Name = "clmVideoFileName";
            this.clmVideoFileName.ReadOnly = true;
            // 
            // clmPatientId
            // 
            this.clmPatientId.DataPropertyName = "patient_id";
            this.clmPatientId.HeaderText = "patient_id";
            this.clmPatientId.Name = "clmPatientId";
            this.clmPatientId.ReadOnly = true;
            this.clmPatientId.Visible = false;
            // 
            // SelectTrialform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 262);
            this.Controls.Add(this.grdTrials);
            this.Name = "SelectTrialform";
            this.Text = "Select the trial from the list:";
            this.Load += new System.EventHandler(this.SelectTrialform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdTrials)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectTrialsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trialsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trialsDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectTrialsBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdTrials;
        private System.Windows.Forms.BindingSource trialsDataSetBindingSource;
        private TrialsDataSet trialsDataSet;
        private System.Windows.Forms.BindingSource selectTrialsBindingSource;
        private TrialsDataSetTableAdapters.SelectTrialsTableAdapter selectTrialsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTrialName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPatientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmVideoFileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPatientId;
        private System.Windows.Forms.BindingSource selectTrialsBindingSource1;
    }
}