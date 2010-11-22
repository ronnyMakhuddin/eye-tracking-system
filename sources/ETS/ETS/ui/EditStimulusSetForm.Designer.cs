namespace ETS.ui
{
    partial class EditStimulusSetForm
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
            this.grdSet = new System.Windows.Forms.DataGridView();
            this.selectStimulusesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stimDataSet = new ETS.datasets.StimDataSet();
            this.selectStimulusSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stimulusSetDataSet = new ETS.StimulusSetDataSet();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.selectStimulusesTableAdapter = new ETS.datasets.StimDataSetTableAdapters.SelectStimulusesTableAdapter();
            this.selectStimulusSetTableAdapter = new ETS.StimulusSetDataSetTableAdapters.SelectStimulusSetTableAdapter();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.series_config_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectStimulusesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stimDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectStimulusSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stimulusSetDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // grdSet
            // 
            this.grdSet.AutoGenerateColumns = false;
            this.grdSet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.series_config_id});
            this.grdSet.DataSource = this.selectStimulusSetBindingSource;
            this.grdSet.Location = new System.Drawing.Point(12, 12);
            this.grdSet.Name = "grdSet";
            this.grdSet.Size = new System.Drawing.Size(219, 159);
            this.grdSet.TabIndex = 0;
            this.grdSet.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.grdSet_RowsAdded);
            // 
            // selectStimulusesBindingSource
            // 
            this.selectStimulusesBindingSource.DataMember = "SelectStimuluses";
            this.selectStimulusesBindingSource.DataSource = this.stimDataSet;
            // 
            // stimDataSet
            // 
            this.stimDataSet.DataSetName = "StimDataSet";
            this.stimDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // selectStimulusSetBindingSource
            // 
            this.selectStimulusSetBindingSource.DataMember = "SelectStimulusSet";
            this.selectStimulusSetBindingSource.DataSource = this.stimulusSetDataSet;
            // 
            // stimulusSetDataSet
            // 
            this.stimulusSetDataSet.DataSetName = "StimulusSetDataSet";
            this.stimulusSetDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(156, 189);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click_1);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(64, 189);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // selectStimulusesTableAdapter
            // 
            this.selectStimulusesTableAdapter.ClearBeforeFill = true;
            // 
            // selectStimulusSetTableAdapter
            // 
            this.selectStimulusSetTableAdapter.ClearBeforeFill = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.DataSource = this.selectStimulusesBindingSource;
            this.nameDataGridViewTextBoxColumn.DisplayMember = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.nameDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.nameDataGridViewTextBoxColumn.ValueMember = "name";
            // 
            // series_config_id
            // 
            this.series_config_id.DataPropertyName = "series_config_id";
            this.series_config_id.HeaderText = "series_config_id";
            this.series_config_id.Name = "series_config_id";
            this.series_config_id.Visible = false;
            // 
            // EditStimulusSetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 226);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.grdSet);
            this.Name = "EditStimulusSetForm";
            this.Text = "EditStimulusSetForm";
            this.Load += new System.EventHandler(this.EditStimulusSetForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectStimulusesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stimDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectStimulusSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stimulusSetDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdSet;
        private System.Windows.Forms.BindingSource selectStimulusSetBindingSource;
        private StimulusSetDataSet stimulusSetDataSet;
        private StimulusSetDataSetTableAdapters.SelectStimulusSetTableAdapter selectStimulusSetTableAdapter;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private datasets.StimDataSet stimDataSet;
        private System.Windows.Forms.BindingSource selectStimulusesBindingSource;
        private datasets.StimDataSetTableAdapters.SelectStimulusesTableAdapter selectStimulusesTableAdapter;
        private System.Windows.Forms.DataGridViewComboBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn series_config_id;
    }
}