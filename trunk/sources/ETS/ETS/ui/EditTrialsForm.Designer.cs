namespace ETS.ui
{
    partial class EditTrialsForm
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
            this.patientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientsDataSet = new ETS.datasets.PatientsDataSet();
            this.selectTrialsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.trialsDataSet = new ETS.TrialsDataSet();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.selectTrialsTableAdapter = new ETS.TrialsDataSetTableAdapters.SelectTrialsTableAdapter();
            this.patientsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientsTableAdapter = new ETS.datasets.PatientsDataSetTableAdapters.PatientsTableAdapter();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patient_name = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.videofilenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdTrials)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectTrialsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trialsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grdTrials
            // 
            this.grdTrials.AutoGenerateColumns = false;
            this.grdTrials.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTrials.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.patient_name,
            this.dateDataGridViewTextBoxColumn,
            this.videofilenameDataGridViewTextBoxColumn});
            this.grdTrials.DataSource = this.selectTrialsBindingSource;
            this.grdTrials.Location = new System.Drawing.Point(12, 12);
            this.grdTrials.Name = "grdTrials";
            this.grdTrials.Size = new System.Drawing.Size(445, 206);
            this.grdTrials.TabIndex = 0;
            // 
            // patientsBindingSource
            // 
            this.patientsBindingSource.DataMember = "Patients";
            this.patientsBindingSource.DataSource = this.patientsDataSet;
            // 
            // patientsDataSet
            // 
            this.patientsDataSet.DataSetName = "PatientsDataSet";
            this.patientsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(382, 227);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(301, 227);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // selectTrialsTableAdapter
            // 
            this.selectTrialsTableAdapter.ClearBeforeFill = true;
            // 
            // patientsDataSetBindingSource
            // 
            this.patientsDataSetBindingSource.DataSource = this.patientsDataSet;
            this.patientsDataSetBindingSource.Position = 0;
            // 
            // patientsTableAdapter
            // 
            this.patientsTableAdapter.ClearBeforeFill = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Trial Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // patient_name
            // 
            this.patient_name.DataPropertyName = "patient_name";
            this.patient_name.DataSource = this.patientsBindingSource;
            this.patient_name.DisplayMember = "shortname";
            this.patient_name.HeaderText = "Patient Name";
            this.patient_name.Name = "patient_name";
            this.patient_name.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.patient_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.patient_name.ValueMember = "shortname";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // videofilenameDataGridViewTextBoxColumn
            // 
            this.videofilenameDataGridViewTextBoxColumn.DataPropertyName = "video_filename";
            this.videofilenameDataGridViewTextBoxColumn.HeaderText = "Video Filename";
            this.videofilenameDataGridViewTextBoxColumn.Name = "videofilenameDataGridViewTextBoxColumn";
            // 
            // EditTrialsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 262);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.grdTrials);
            this.Name = "EditTrialsForm";
            this.Text = "EditTrialsForm";
            this.Load += new System.EventHandler(this.EditTrialsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdTrials)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectTrialsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trialsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdTrials;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private TrialsDataSet trialsDataSet;
        private System.Windows.Forms.BindingSource selectTrialsBindingSource;
        private TrialsDataSetTableAdapters.SelectTrialsTableAdapter selectTrialsTableAdapter;
        private datasets.PatientsDataSet patientsDataSet;
        private System.Windows.Forms.BindingSource patientsDataSetBindingSource;
        private System.Windows.Forms.BindingSource patientsBindingSource;
        private datasets.PatientsDataSetTableAdapters.PatientsTableAdapter patientsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn patient_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn videofilenameDataGridViewTextBoxColumn;
    }
}