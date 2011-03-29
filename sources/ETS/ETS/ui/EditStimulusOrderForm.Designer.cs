namespace ETS.ui
{
    partial class EditStimulusOrderForm
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
            this.stimulusSetDataSet = new ETS.StimulusSetDataSet();
            this.selectStimulusSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.selectStimulusSetTableAdapter = new ETS.StimulusSetDataSetTableAdapters.SelectStimulusSetTableAdapter();
            this.selectStimulusesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stimDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stimDataSet = new ETS.datasets.StimDataSet();
            this.selectStimulusesTableAdapter = new ETS.datasets.StimDataSetTableAdapters.SelectStimulusesTableAdapter();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.stimulusSetDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectStimulusSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectStimulusesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stimDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stimDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // stimulusSetDataSet
            // 
            this.stimulusSetDataSet.DataSetName = "StimulusSetDataSet";
            this.stimulusSetDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // selectStimulusSetBindingSource
            // 
            this.selectStimulusSetBindingSource.DataMember = "SelectStimulusSet";
            this.selectStimulusSetBindingSource.DataSource = this.stimulusSetDataSet;
            // 
            // selectStimulusSetTableAdapter
            // 
            this.selectStimulusSetTableAdapter.ClearBeforeFill = true;
            // 
            // selectStimulusesBindingSource
            // 
            this.selectStimulusesBindingSource.DataMember = "SelectStimuluses";
            this.selectStimulusesBindingSource.DataSource = this.stimDataSetBindingSource;
            // 
            // stimDataSetBindingSource
            // 
            this.stimDataSetBindingSource.DataSource = this.stimDataSet;
            this.stimDataSetBindingSource.Position = 0;
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
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(298, 469);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(217, 469);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // EditStimulusOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 504);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.Name = "EditStimulusOrderForm";
            this.Text = "Select Stimulus Order";
            this.Load += new System.EventHandler(this.EditStimulusOrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stimulusSetDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectStimulusSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectStimulusesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stimDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stimDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource selectStimulusSetBindingSource;
        private StimulusSetDataSet stimulusSetDataSet;
        private StimulusSetDataSetTableAdapters.SelectStimulusSetTableAdapter selectStimulusSetTableAdapter;
        private System.Windows.Forms.BindingSource stimDataSetBindingSource;
        private datasets.StimDataSet stimDataSet;
        private System.Windows.Forms.BindingSource selectStimulusesBindingSource;
        private datasets.StimDataSetTableAdapters.SelectStimulusesTableAdapter selectStimulusesTableAdapter;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
    }
}