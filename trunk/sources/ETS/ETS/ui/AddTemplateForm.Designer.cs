namespace ETS.ui
{
    partial class AddTemplateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddTemplateForm));
            this.sldLeftX = new ETS.controls.AdvancedSlider();
            this.sldLeftY = new ETS.controls.AdvancedSlider();
            this.sldRightX = new ETS.controls.AdvancedSlider();
            this.sldRightY = new ETS.controls.AdvancedSlider();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // sldLeftX
            // 
            this.sldLeftX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sldLeftX.CaptionText = "Left X";
            this.sldLeftX.Location = new System.Drawing.Point(13, 68);
            this.sldLeftX.Maximum = 1000;
            this.sldLeftX.Minimum = 0;
            this.sldLeftX.Name = "sldLeftX";
            this.sldLeftX.Size = new System.Drawing.Size(373, 47);
            this.sldLeftX.TabIndex = 0;
            this.sldLeftX.Value = 0;
            this.sldLeftX.ValueChanged += new ETS.controls.AdvancedSlider.ValueChangedEventHandler(this.sldLeftX_ValueChanged);
            // 
            // sldLeftY
            // 
            this.sldLeftY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sldLeftY.CaptionText = "Left Y";
            this.sldLeftY.Location = new System.Drawing.Point(13, 122);
            this.sldLeftY.Maximum = 1000;
            this.sldLeftY.Minimum = 0;
            this.sldLeftY.Name = "sldLeftY";
            this.sldLeftY.Size = new System.Drawing.Size(373, 47);
            this.sldLeftY.TabIndex = 1;
            this.sldLeftY.Value = 0;
            this.sldLeftY.ValueChanged += new ETS.controls.AdvancedSlider.ValueChangedEventHandler(this.sldLeftY_ValueChanged);
            // 
            // sldRightX
            // 
            this.sldRightX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sldRightX.CaptionText = "Right X";
            this.sldRightX.Location = new System.Drawing.Point(13, 176);
            this.sldRightX.Maximum = 1000;
            this.sldRightX.Minimum = 0;
            this.sldRightX.Name = "sldRightX";
            this.sldRightX.Size = new System.Drawing.Size(373, 47);
            this.sldRightX.TabIndex = 2;
            this.sldRightX.Value = 0;
            this.sldRightX.ValueChanged += new ETS.controls.AdvancedSlider.ValueChangedEventHandler(this.sldRightX_ValueChanged);
            // 
            // sldRightY
            // 
            this.sldRightY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sldRightY.CaptionText = "Right Y";
            this.sldRightY.Location = new System.Drawing.Point(13, 230);
            this.sldRightY.Maximum = 1000;
            this.sldRightY.Minimum = 0;
            this.sldRightY.Name = "sldRightY";
            this.sldRightY.Size = new System.Drawing.Size(373, 47);
            this.sldRightY.TabIndex = 3;
            this.sldRightY.Value = 0;
            this.sldRightY.ValueChanged += new ETS.controls.AdvancedSlider.ValueChangedEventHandler(this.sldRightY_ValueChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(310, 290);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(229, 289);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(73, 24);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(312, 20);
            this.txtName.TabIndex = 7;
            this.txtName.Text = "Untitled";
            // 
            // AddTemplateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 334);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.sldRightY);
            this.Controls.Add(this.sldRightX);
            this.Controls.Add(this.sldLeftY);
            this.Controls.Add(this.sldLeftX);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(200, 0);
            this.Name = "AddTemplateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Select template bounds";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ETS.controls.AdvancedSlider sldLeftX;
        private ETS.controls.AdvancedSlider sldLeftY;
        private ETS.controls.AdvancedSlider sldRightX;
        private ETS.controls.AdvancedSlider sldRightY;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
    }
}