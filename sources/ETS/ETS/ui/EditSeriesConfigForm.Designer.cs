using ETS.datasets;
namespace ETS.ui
{
    partial class EditSeriesConfigForm
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
            this.grdConfigs = new System.Windows.Forms.DataGridView();
            this.orderTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderTypesDataSet = new ETS.datasets.OrderTypesDataSet();
            this.selectSeriesConfigsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.seriesConfigDataSet = new ETS.datasets.SeriesConfigDataSet();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.orderTypeTableAdapter = new ETS.datasets.OrderTypesDataSetTableAdapters.OrderTypeTableAdapter();
            this.selectSeriesConfigsTableAdapter = new ETS.datasets.SeriesConfigDataSetTableAdapters.SelectSeriesConfigsTableAdapter();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.length = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stimulusOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxInt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minintDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textbeforeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textafterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.editStimSet = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clmStimulusOrder = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clmTest = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdConfigs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderTypesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectSeriesConfigsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seriesConfigDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // grdConfigs
            // 
            this.grdConfigs.AutoGenerateColumns = false;
            this.grdConfigs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdConfigs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.length,
            this.stimulusOrder,
            this.maxInt,
            this.id,
            this.minintDataGridViewTextBoxColumn,
            this.textbeforeDataGridViewTextBoxColumn,
            this.textafterDataGridViewTextBoxColumn,
            this.orderTypeDataGridViewTextBoxColumn,
            this.editStimSet,
            this.clmStimulusOrder,
            this.clmTest});
            this.grdConfigs.DataSource = this.selectSeriesConfigsBindingSource;
            this.grdConfigs.Location = new System.Drawing.Point(12, 12);
            this.grdConfigs.Name = "grdConfigs";
            this.grdConfigs.Size = new System.Drawing.Size(943, 272);
            this.grdConfigs.TabIndex = 0;
            this.grdConfigs.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdConfigs_CellClick);
            this.grdConfigs.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.grdConfigs_DataError);
            // 
            // orderTypeBindingSource
            // 
            this.orderTypeBindingSource.DataMember = "OrderType";
            this.orderTypeBindingSource.DataSource = this.orderTypesDataSet;
            // 
            // orderTypesDataSet
            // 
            this.orderTypesDataSet.DataSetName = "OrderTypesDataSet";
            this.orderTypesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // selectSeriesConfigsBindingSource
            // 
            this.selectSeriesConfigsBindingSource.DataMember = "SelectSeriesConfigs";
            this.selectSeriesConfigsBindingSource.DataSource = this.seriesConfigDataSet;
            // 
            // seriesConfigDataSet
            // 
            this.seriesConfigDataSet.DataSetName = "SeriesConfigDataSet";
            this.seriesConfigDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(570, 308);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(651, 308);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // orderTypeTableAdapter
            // 
            this.orderTypeTableAdapter.ClearBeforeFill = true;
            // 
            // selectSeriesConfigsTableAdapter
            // 
            this.selectSeriesConfigsTableAdapter.ClearBeforeFill = true;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            // 
            // length
            // 
            this.length.DataPropertyName = "length";
            this.length.HeaderText = "length";
            this.length.Name = "length";
            this.length.Visible = false;
            // 
            // stimulusOrder
            // 
            this.stimulusOrder.DataPropertyName = "stimulusOrder";
            this.stimulusOrder.HeaderText = "stimulusOrder";
            this.stimulusOrder.Name = "stimulusOrder";
            this.stimulusOrder.Visible = false;
            // 
            // maxInt
            // 
            this.maxInt.DataPropertyName = "max_int";
            this.maxInt.HeaderText = "Max Interval";
            this.maxInt.Name = "maxInt";
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // minintDataGridViewTextBoxColumn
            // 
            this.minintDataGridViewTextBoxColumn.DataPropertyName = "min_int";
            this.minintDataGridViewTextBoxColumn.HeaderText = "Min Interval";
            this.minintDataGridViewTextBoxColumn.Name = "minintDataGridViewTextBoxColumn";
            // 
            // textbeforeDataGridViewTextBoxColumn
            // 
            this.textbeforeDataGridViewTextBoxColumn.DataPropertyName = "text_before";
            this.textbeforeDataGridViewTextBoxColumn.HeaderText = "Text Before Series";
            this.textbeforeDataGridViewTextBoxColumn.Name = "textbeforeDataGridViewTextBoxColumn";
            // 
            // textafterDataGridViewTextBoxColumn
            // 
            this.textafterDataGridViewTextBoxColumn.DataPropertyName = "text_after";
            this.textafterDataGridViewTextBoxColumn.HeaderText = "Text After Serries";
            this.textafterDataGridViewTextBoxColumn.Name = "textafterDataGridViewTextBoxColumn";
            // 
            // orderTypeDataGridViewTextBoxColumn
            // 
            this.orderTypeDataGridViewTextBoxColumn.DataPropertyName = "orderType";
            this.orderTypeDataGridViewTextBoxColumn.DataSource = this.orderTypeBindingSource;
            this.orderTypeDataGridViewTextBoxColumn.DisplayMember = "name";
            this.orderTypeDataGridViewTextBoxColumn.HeaderText = "Order Type";
            this.orderTypeDataGridViewTextBoxColumn.Name = "orderTypeDataGridViewTextBoxColumn";
            this.orderTypeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.orderTypeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.orderTypeDataGridViewTextBoxColumn.ValueMember = "name";
            // 
            // editStimSet
            // 
            this.editStimSet.HeaderText = "Stimulus Set";
            this.editStimSet.Name = "editStimSet";
            this.editStimSet.Text = "Edit";
            this.editStimSet.UseColumnTextForButtonValue = true;
            // 
            // clmStimulusOrder
            // 
            this.clmStimulusOrder.HeaderText = "Stimulus Order";
            this.clmStimulusOrder.Name = "clmStimulusOrder";
            this.clmStimulusOrder.Text = "Edit";
            this.clmStimulusOrder.UseColumnTextForButtonValue = true;
            // 
            // clmTest
            // 
            this.clmTest.HeaderText = "Test";
            this.clmTest.Name = "clmTest";
            // 
            // EditSeriesConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 343);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grdConfigs);
            this.Name = "EditSeriesConfigForm";
            this.Text = "EditSeriesConfigForm";
            this.Load += new System.EventHandler(this.EditSeriesConfigForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdConfigs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderTypesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectSeriesConfigsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seriesConfigDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdConfigs;
        private SeriesConfigDataSet seriesConfigDataSet;
        private System.Windows.Forms.BindingSource selectSeriesConfigsBindingSource;
        private ETS.datasets.SeriesConfigDataSetTableAdapters.SelectSeriesConfigsTableAdapter selectSeriesConfigsTableAdapter;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private OrderTypesDataSet orderTypesDataSet;
        private System.Windows.Forms.BindingSource orderTypeBindingSource;
        private ETS.datasets.OrderTypesDataSetTableAdapters.OrderTypeTableAdapter orderTypeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn length;
        private System.Windows.Forms.DataGridViewTextBoxColumn stimulusOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxInt;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn minintDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn textbeforeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn textafterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn orderTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn editStimSet;
        private System.Windows.Forms.DataGridViewButtonColumn clmStimulusOrder;
        private System.Windows.Forms.DataGridViewButtonColumn clmTest;
    }
}