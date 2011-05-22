namespace ETS.controls
{
    partial class CaptureSlider
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.slider = new System.Windows.Forms.TrackBar();
            this.lblTime = new System.Windows.Forms.Label();
            this.btnIncrease = new System.Windows.Forms.Button();
            this.btnDecrease = new System.Windows.Forms.Button();
            this.cmbStimuluses = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.slider)).BeginInit();
            this.SuspendLayout();
            // 
            // slider
            // 
            this.slider.LargeChange = 40;
            this.slider.Location = new System.Drawing.Point(1, 49);
            this.slider.Name = "slider";
            this.slider.Size = new System.Drawing.Size(603, 42);
            this.slider.SmallChange = 40;
            this.slider.TabIndex = 0;
            this.slider.ValueChanged += new System.EventHandler(this.slider_ValueChanged);
            // 
            // lblTime
            // 
            this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(307, 78);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(42, 13);
            this.lblTime.TabIndex = 2;
            this.lblTime.Text = "%time%";
            // 
            // btnIncrease
            // 
            this.btnIncrease.Location = new System.Drawing.Point(609, 29);
            this.btnIncrease.Name = "btnIncrease";
            this.btnIncrease.Size = new System.Drawing.Size(25, 23);
            this.btnIncrease.TabIndex = 3;
            this.btnIncrease.Text = "+";
            this.btnIncrease.UseVisualStyleBackColor = true;
            this.btnIncrease.Click += new System.EventHandler(this.btnIncrease_Click);
            // 
            // btnDecrease
            // 
            this.btnDecrease.Location = new System.Drawing.Point(610, 58);
            this.btnDecrease.Name = "btnDecrease";
            this.btnDecrease.Size = new System.Drawing.Size(25, 23);
            this.btnDecrease.TabIndex = 4;
            this.btnDecrease.Text = "-";
            this.btnDecrease.UseVisualStyleBackColor = true;
            this.btnDecrease.Click += new System.EventHandler(this.btnDecrease_Click);
            // 
            // cmbStimuluses
            // 
            this.cmbStimuluses.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbStimuluses.FormattingEnabled = true;
            this.cmbStimuluses.Location = new System.Drawing.Point(138, 12);
            this.cmbStimuluses.Name = "cmbStimuluses";
            this.cmbStimuluses.Size = new System.Drawing.Size(466, 21);
            this.cmbStimuluses.TabIndex = 5;
            this.cmbStimuluses.SelectedValueChanged += new System.EventHandler(this.cmbStimuluses_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Select Stimulus Location:";
            // 
            // CaptureSlider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbStimuluses);
            this.Controls.Add(this.btnDecrease);
            this.Controls.Add(this.btnIncrease);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.slider);
            this.Name = "CaptureSlider";
            this.Size = new System.Drawing.Size(638, 94);
            ((System.ComponentModel.ISupportInitialize)(this.slider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar slider;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button btnIncrease;
        private System.Windows.Forms.Button btnDecrease;
        private System.Windows.Forms.ComboBox cmbStimuluses;
        private System.Windows.Forms.Label label1;
    }
}
