namespace ETS.controls
{
    partial class AdvancedSlider
    {
        /// <summary> 
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Обязательный метод для поддержки конструктора - не изменяйте 
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblText = new System.Windows.Forms.Label();
            this.slider = new System.Windows.Forms.TrackBar();
            this.lblValue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.slider)).BeginInit();
            this.SuspendLayout();
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(3, 4);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(40, 13);
            this.lblText.TabIndex = 0;
            this.lblText.Text = "%text%";
            // 
            // slider
            // 
            this.slider.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.slider.Location = new System.Drawing.Point(52, 4);
            this.slider.Maximum = 1000;
            this.slider.Name = "slider";
            this.slider.Size = new System.Drawing.Size(263, 45);
            this.slider.TabIndex = 1;
            this.slider.TickStyle = System.Windows.Forms.TickStyle.None;
            this.slider.ValueChanged += new System.EventHandler(this.slider_ValueChanged);
            // 
            // lblValue
            // 
            this.lblValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblValue.AutoSize = true;
            this.lblValue.Location = new System.Drawing.Point(321, 4);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(40, 13);
            this.lblValue.TabIndex = 2;
            this.lblValue.Text = "%text%";
            // 
            // AdvancedSlider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblValue);
            this.Controls.Add(this.slider);
            this.Controls.Add(this.lblText);
            this.Name = "AdvancedSlider";
            this.Size = new System.Drawing.Size(373, 47);
            ((System.ComponentModel.ISupportInitialize)(this.slider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.TrackBar slider;
        private System.Windows.Forms.Label lblValue;
    }
}
