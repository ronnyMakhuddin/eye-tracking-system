namespace ETS.ui
{
    partial class EditSeriesConfigs
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
            this.grdSeriesConfig = new System.Windows.Forms.DataGridView();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.seriesConfigDataSet = new ETS.SeriesConfigDataSet();
            this.selectSeriesConfigsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.selectSeriesConfigsTableAdapter = new ETS.SeriesConfigDataSetTableAdapters.SelectSeriesConfigsTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxintDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minintDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textbeforeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textafterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdSeriesConfig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seriesConfigDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectSeriesConfigsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grdSeriesConfig
            // 
            this.grdSeriesConfig.AutoGenerateColumns = false;
            this.grdSeriesConfig.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSeriesConfig.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.maxintDataGridViewTextBoxColumn,
            this.minintDataGridViewTextBoxColumn,
            this.textbeforeDataGridViewTextBoxColumn,
            this.textafterDataGridViewTextBoxColumn,
            this.orderTypeDataGridViewTextBoxColumn});
            this.grdSeriesConfig.DataSource = this.selectSeriesConfigsBindingSource;
            this.grdSeriesConfig.Location = new System.Drawing.Point(12, 12);
            this.grdSeriesConfig.Name = "grdSeriesConfig";
            this.grdSeriesConfig.Size = new System.Drawing.Size(818, 242);
            this.grdSeriesConfig.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(755, 287);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(674, 287);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // seriesConfigDataSet
            // 
            this.seriesConfigDataSet.DataSetName = "SeriesConfigDataSet";
            this.seriesConfigDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // selectSeriesConfigsBindingSource
            // 
            this.selectSeriesConfigsBindingSource.DataMember = "SelectSeriesConfigs";
            this.selectSeriesConfigsBindingSource.DataSource = this.seriesConfigDataSet;
            // 
            // selectSeriesConfigsTableAdapter
            // 
            this.selectSeriesConfigsTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maxintDataGridViewTextBoxColumn
            // 
            this.maxintDataGridViewTextBoxColumn.DataPropertyName = "max_int";
            this.maxintDataGridViewTextBoxColumn.HeaderText = "max_int";
            this.maxintDataGridViewTextBoxColumn.Name = "maxintDataGridViewTextBoxColumn";
            // 
            // minintDataGridViewTextBoxColumn
            // 
            this.minintDataGridViewTextBoxColumn.DataPropertyName = "min_int";
            this.minintDataGridViewTextBoxColumn.HeaderText = "min_int";
            this.minintDataGridViewTextBoxColumn.Name = "minintDataGridViewTextBoxColumn";
            // 
            // textbeforeDataGridViewTextBoxColumn
            // 
            this.textbeforeDataGridViewTextBoxColumn.DataPropertyName = "text_before";
            this.textbeforeDataGridViewTextBoxColumn.HeaderText = "text_before";
            this.textbeforeDataGridViewTextBoxColumn.Name = "textbeforeDataGridViewTextBoxColumn";
            // 
            // textafterDataGridViewTextBoxColumn
            // 
            this.textafterDataGridViewTextBoxColumn.DataPropertyName = "text_after";
            this.textafterDataGridViewTextBoxColumn.HeaderText = "text_after";
            this.textafterDataGridViewTextBoxColumn.Name = "textafterDataGridViewTextBoxColumn";
            // 
            // orderTypeDataGridViewTextBoxColumn
            // 
            this.orderTypeDataGridViewTextBoxColumn.DataPropertyName = "orderType";
            this.orderTypeDataGridViewTextBoxColumn.HeaderText = "orderType";
            this.orderTypeDataGridViewTextBoxColumn.Name = "orderTypeDataGridViewTextBoxColumn";
            // 
            // EditSeriesConfigs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 322);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.grdSeriesConfig);
            this.Name = "EditSeriesConfigs";
            this.Text = "EditSeriesConfigs";
            this.Load += new System.EventHandler(this.EditSeriesConfigs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdSeriesConfig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seriesConfigDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectSeriesConfigsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdSeriesConfig;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private SeriesConfigDataSet seriesConfigDataSet;
        private System.Windows.Forms.BindingSource selectSeriesConfigsBindingSource;
        private ETS.SeriesConfigDataSetTableAdapters.SelectSeriesConfigsTableAdapter selectSeriesConfigsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxintDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn minintDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn textbeforeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn textafterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderTypeDataGridViewTextBoxColumn;
    }
}