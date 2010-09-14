namespace ETS.ui
{
    partial class SettingsForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.sldAnalHeight = new ETS.controls.AdvancedSlider();
            this.sldAnalWidth = new ETS.controls.AdvancedSlider();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.sldRealHeight = new ETS.controls.AdvancedSlider();
            this.sldRealWidth = new ETS.controls.AdvancedSlider();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(420, 280);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Capture Sizes";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.sldAnalHeight);
            this.groupBox3.Controls.Add(this.sldAnalWidth);
            this.groupBox3.Location = new System.Drawing.Point(6, 148);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(401, 120);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Analytic capture size";
            // 
            // sldAnalHeight
            // 
            this.sldAnalHeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sldAnalHeight.CaptionText = "Height";
            this.sldAnalHeight.Location = new System.Drawing.Point(18, 67);
            this.sldAnalHeight.Maximum = 1000;
            this.sldAnalHeight.Minimum = 0;
            this.sldAnalHeight.Name = "sldAnalHeight";
            this.sldAnalHeight.Size = new System.Drawing.Size(375, 44);
            this.sldAnalHeight.TabIndex = 1;
            this.sldAnalHeight.Value = 0;
            // 
            // sldAnalWidth
            // 
            this.sldAnalWidth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sldAnalWidth.CaptionText = "Width";
            this.sldAnalWidth.Location = new System.Drawing.Point(18, 18);
            this.sldAnalWidth.Maximum = 1000;
            this.sldAnalWidth.Minimum = 0;
            this.sldAnalWidth.Name = "sldAnalWidth";
            this.sldAnalWidth.Size = new System.Drawing.Size(375, 39);
            this.sldAnalWidth.TabIndex = 0;
            this.sldAnalWidth.Value = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.sldRealHeight);
            this.groupBox2.Controls.Add(this.sldRealWidth);
            this.groupBox2.Location = new System.Drawing.Point(6, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(401, 120);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Overall capture size";
            // 
            // sldRealHeight
            // 
            this.sldRealHeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sldRealHeight.CaptionText = "Height";
            this.sldRealHeight.Location = new System.Drawing.Point(18, 67);
            this.sldRealHeight.Maximum = 1000;
            this.sldRealHeight.Minimum = 0;
            this.sldRealHeight.Name = "sldRealHeight";
            this.sldRealHeight.Size = new System.Drawing.Size(375, 44);
            this.sldRealHeight.TabIndex = 1;
            this.sldRealHeight.Value = 0;
            // 
            // sldRealWidth
            // 
            this.sldRealWidth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sldRealWidth.CaptionText = "Width";
            this.sldRealWidth.Location = new System.Drawing.Point(18, 18);
            this.sldRealWidth.Maximum = 1000;
            this.sldRealWidth.Minimum = 0;
            this.sldRealWidth.Name = "sldRealWidth";
            this.sldRealWidth.Size = new System.Drawing.Size(375, 39);
            this.sldRealWidth.TabIndex = 0;
            this.sldRealWidth.Value = 0;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 305);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SettingsForm_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private ETS.controls.AdvancedSlider sldAnalHeight;
        private ETS.controls.AdvancedSlider sldAnalWidth;
        private System.Windows.Forms.GroupBox groupBox2;
        private ETS.controls.AdvancedSlider sldRealHeight;
        private ETS.controls.AdvancedSlider sldRealWidth;
    }
}