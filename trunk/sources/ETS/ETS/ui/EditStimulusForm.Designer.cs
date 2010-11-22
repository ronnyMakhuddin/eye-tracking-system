using ETS.datasets;
namespace ETS.ui
{
    partial class EditStimulusForm
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
            this.grdStimuluses = new System.Windows.Forms.DataGridView();
            this.stimulusTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stimulusTypeDataSet = new ETS.datasets.StimulusTypeDataSet();
            this.selectStimulusesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stimDataSet = new ETS.datasets.StimDataSet();
            this.selectStimulusesTableAdapter = new ETS.datasets.StimDataSetTableAdapters.SelectStimulusesTableAdapter();
            this.stimulusTypeTableAdapter = new ETS.datasets.StimulusTypeDataSetTableAdapters.StimulusTypeTableAdapter();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.prob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdStimuluses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stimulusTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stimulusTypeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectStimulusesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stimDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // grdStimuluses
            // 
            this.grdStimuluses.AllowUserToResizeColumns = false;
            this.grdStimuluses.AllowUserToResizeRows = false;
            this.grdStimuluses.AutoGenerateColumns = false;
            this.grdStimuluses.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grdStimuluses.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.grdStimuluses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdStimuluses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.filenameDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.prob});
            this.grdStimuluses.DataSource = this.selectStimulusesBindingSource;
            this.grdStimuluses.Location = new System.Drawing.Point(12, 12);
            this.grdStimuluses.Name = "grdStimuluses";
            this.grdStimuluses.Size = new System.Drawing.Size(647, 213);
            this.grdStimuluses.TabIndex = 0;
            this.grdStimuluses.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdStimuluses_CellClick);
            this.grdStimuluses.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.grdStimuluses_DataError);
            // 
            // stimulusTypeBindingSource
            // 
            this.stimulusTypeBindingSource.DataMember = "StimulusType";
            this.stimulusTypeBindingSource.DataSource = this.stimulusTypeDataSet;
            // 
            // stimulusTypeDataSet
            // 
            this.stimulusTypeDataSet.DataSetName = "StimulusTypeDataSet";
            this.stimulusTypeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // selectStimulusesTableAdapter
            // 
            this.selectStimulusesTableAdapter.ClearBeforeFill = true;
            // 
            // stimulusTypeTableAdapter
            // 
            this.stimulusTypeTableAdapter.ClearBeforeFill = true;
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(396, 238);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(481, 238);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 200;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 200;
            // 
            // filenameDataGridViewTextBoxColumn
            // 
            this.filenameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.filenameDataGridViewTextBoxColumn.DataPropertyName = "filename";
            this.filenameDataGridViewTextBoxColumn.HeaderText = "Filename";
            this.filenameDataGridViewTextBoxColumn.MinimumWidth = 200;
            this.filenameDataGridViewTextBoxColumn.Name = "filenameDataGridViewTextBoxColumn";
            this.filenameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.filenameDataGridViewTextBoxColumn.Width = 200;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "type";
            this.typeDataGridViewTextBoxColumn.DataSource = this.stimulusTypeBindingSource;
            this.typeDataGridViewTextBoxColumn.DisplayMember = "name";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.typeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.typeDataGridViewTextBoxColumn.ValueMember = "name";
            // 
            // prob
            // 
            this.prob.DataPropertyName = "prob";
            this.prob.HeaderText = "prob";
            this.prob.Name = "prob";
            // 
            // EditStimulusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 273);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grdStimuluses);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditStimulusForm";
            this.Text = "Edit Stimuluses";
            this.Load += new System.EventHandler(this.EditStimulusForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdStimuluses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stimulusTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stimulusTypeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectStimulusesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stimDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdStimuluses;
        private StimDataSet stimDataSet;
        private System.Windows.Forms.BindingSource selectStimulusesBindingSource;
        private ETS.datasets.StimDataSetTableAdapters.SelectStimulusesTableAdapter selectStimulusesTableAdapter;
        private StimulusTypeDataSet stimulusTypeDataSet;
        private System.Windows.Forms.BindingSource stimulusTypeBindingSource;
        private ETS.datasets.StimulusTypeDataSetTableAdapters.StimulusTypeTableAdapter stimulusTypeTableAdapter;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn filenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prob;
    }
}