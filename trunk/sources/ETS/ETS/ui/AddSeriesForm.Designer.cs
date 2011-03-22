namespace ETS.ui
{
    partial class AddSeriesForm
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
            this.txtSeriesName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbSeriesConfig = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.seriesConfigDataSet = new ETS.datasets.SeriesConfigDataSet();
            this.seriesConfigDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.selectSeriesConfigsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.selectSeriesConfigsTableAdapter = new ETS.datasets.SeriesConfigDataSetTableAdapters.SelectSeriesConfigsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.seriesConfigDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seriesConfigDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectSeriesConfigsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSeriesName
            // 
            this.txtSeriesName.Location = new System.Drawing.Point(123, 25);
            this.txtSeriesName.Name = "txtSeriesName";
            this.txtSeriesName.Size = new System.Drawing.Size(213, 20);
            this.txtSeriesName.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(49, 28);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(68, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Series name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select Series Config:";
            // 
            // cmbSeriesConfig
            // 
            this.cmbSeriesConfig.DataSource = this.selectSeriesConfigsBindingSource;
            this.cmbSeriesConfig.DisplayMember = "name";
            this.cmbSeriesConfig.FormattingEnabled = true;
            this.cmbSeriesConfig.Location = new System.Drawing.Point(123, 66);
            this.cmbSeriesConfig.Name = "cmbSeriesConfig";
            this.cmbSeriesConfig.Size = new System.Drawing.Size(213, 21);
            this.cmbSeriesConfig.TabIndex = 3;
            this.cmbSeriesConfig.ValueMember = "name";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(261, 130);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(180, 130);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // seriesConfigDataSet
            // 
            this.seriesConfigDataSet.DataSetName = "SeriesConfigDataSet";
            this.seriesConfigDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // seriesConfigDataSetBindingSource
            // 
            this.seriesConfigDataSetBindingSource.DataSource = this.seriesConfigDataSet;
            this.seriesConfigDataSetBindingSource.Position = 0;
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
            // AddSeriesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 165);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.cmbSeriesConfig);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtSeriesName);
            this.Name = "AddSeriesForm";
            this.Text = "Add new series:";
            this.Load += new System.EventHandler(this.AddSeriesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.seriesConfigDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seriesConfigDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectSeriesConfigsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSeriesName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbSeriesConfig;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.BindingSource seriesConfigDataSetBindingSource;
        private datasets.SeriesConfigDataSet seriesConfigDataSet;
        private System.Windows.Forms.BindingSource selectSeriesConfigsBindingSource;
        private datasets.SeriesConfigDataSetTableAdapters.SelectSeriesConfigsTableAdapter selectSeriesConfigsTableAdapter;
    }
}