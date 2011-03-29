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
            this.pnlItems = new System.Windows.Forms.Panel();
            this.btnAddStimul = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblInterval = new System.Windows.Forms.Label();
            this.lblLength = new System.Windows.Forms.Label();
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
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
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
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(217, 469);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // pnlItems
            // 
            this.pnlItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlItems.AutoScroll = true;
            this.pnlItems.Location = new System.Drawing.Point(13, 78);
            this.pnlItems.Name = "pnlItems";
            this.pnlItems.Size = new System.Drawing.Size(360, 385);
            this.pnlItems.TabIndex = 2;
            // 
            // btnAddStimul
            // 
            this.btnAddStimul.Location = new System.Drawing.Point(136, 469);
            this.btnAddStimul.Name = "btnAddStimul";
            this.btnAddStimul.Size = new System.Drawing.Size(75, 23);
            this.btnAddStimul.TabIndex = 3;
            this.btnAddStimul.Text = "Add stimul";
            this.btnAddStimul.UseVisualStyleBackColor = true;
            this.btnAddStimul.Click += new System.EventHandler(this.btnAddStimul_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Interval:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Series length:";
            // 
            // lblInterval
            // 
            this.lblInterval.AutoSize = true;
            this.lblInterval.Location = new System.Drawing.Point(98, 20);
            this.lblInterval.Name = "lblInterval";
            this.lblInterval.Size = new System.Drawing.Size(35, 13);
            this.lblInterval.TabIndex = 6;
            this.lblInterval.Text = "label3";
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(101, 45);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(35, 13);
            this.lblLength.TabIndex = 7;
            this.lblLength.Text = "label4";
            // 
            // EditStimulusOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 504);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.lblInterval);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddStimul);
            this.Controls.Add(this.pnlItems);
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
            this.PerformLayout();

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
        private System.Windows.Forms.Panel pnlItems;
        private System.Windows.Forms.Button btnAddStimul;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblInterval;
        private System.Windows.Forms.Label lblLength;
    }
}