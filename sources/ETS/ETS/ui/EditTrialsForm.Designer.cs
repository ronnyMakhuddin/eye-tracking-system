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
            this.selectTrialsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.trialsDataSet = new ETS.TrialsDataSet();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.selectTrialsTableAdapter = new ETS.TrialsDataSetTableAdapters.SelectTrialsTableAdapter();
            this.patientsDataSet = new ETS.datasets.PatientsDataSet();
            this.patientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientsTableAdapter = new ETS.datasets.PatientsDataSetTableAdapters.PatientsTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.videofilenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdTrials)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectTrialsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trialsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grdTrials
            // 
            this.grdTrials.AutoGenerateColumns = false;
            this.grdTrials.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTrials.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.videofilenameDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.patientnameDataGridViewTextBoxColumn});
            this.grdTrials.DataSource = this.selectTrialsBindingSource;
            this.grdTrials.Location = new System.Drawing.Point(12, 12);
            this.grdTrials.Name = "grdTrials";
            this.grdTrials.Size = new System.Drawing.Size(559, 209);
            this.grdTrials.TabIndex = 0;
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
            // patientsDataSet
            // 
            this.patientsDataSet.DataSetName = "PatientsDataSet";
            this.patientsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // patientsBindingSource
            // 
            this.patientsBindingSource.DataMember = "Patients";
            this.patientsBindingSource.DataSource = this.patientsDataSet;
            // 
            // patientsTableAdapter
            // 
            this.patientsTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // videofilenameDataGridViewTextBoxColumn
            // 
            this.videofilenameDataGridViewTextBoxColumn.DataPropertyName = "video_filename";
            this.videofilenameDataGridViewTextBoxColumn.HeaderText = "video_filename";
            this.videofilenameDataGridViewTextBoxColumn.Name = "videofilenameDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // patientnameDataGridViewTextBoxColumn
            // 
            this.patientnameDataGridViewTextBoxColumn.DataPropertyName = "patient_name";
            this.patientnameDataGridViewTextBoxColumn.DataSource = this.patientsBindingSource;
            this.patientnameDataGridViewTextBoxColumn.DisplayMember = "shortname";
            this.patientnameDataGridViewTextBoxColumn.HeaderText = "patient_name";
            this.patientnameDataGridViewTextBoxColumn.Name = "patientnameDataGridViewTextBoxColumn";
            this.patientnameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.patientnameDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.patientnameDataGridViewTextBoxColumn.ValueMember = "shortname";
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
            ((System.ComponentModel.ISupportInitialize)(this.selectTrialsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trialsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdTrials;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientidDataGridViewTextBoxColumn;
        private TrialsDataSet trialsDataSet;
        private System.Windows.Forms.BindingSource selectTrialsBindingSource;
        private TrialsDataSetTableAdapters.SelectTrialsTableAdapter selectTrialsTableAdapter;
        private datasets.PatientsDataSet patientsDataSet;
        private System.Windows.Forms.BindingSource patientsBindingSource;
        private datasets.PatientsDataSetTableAdapters.PatientsTableAdapter patientsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn videofilenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn patientnameDataGridViewTextBoxColumn;
    }
}