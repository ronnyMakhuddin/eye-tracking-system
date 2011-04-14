namespace ETS.ui
{
    partial class SeriesConfigProcessForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SeriesConfigProcessForm));
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.pbxPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Interval = 10;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // pbxPicture
            // 
            this.pbxPicture.Image = ((System.Drawing.Image)(resources.GetObject("pbxPicture.Image")));
            this.pbxPicture.Location = new System.Drawing.Point(15, 35);
            this.pbxPicture.Name = "pbxPicture";
            this.pbxPicture.Size = new System.Drawing.Size(207, 161);
            this.pbxPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxPicture.TabIndex = 1;
            this.pbxPicture.TabStop = false;
            // 
            // SeriesConfigProcessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 266);
            this.Controls.Add(this.pbxPicture);
            this.Controls.Add(this.label1);
            this.Name = "SeriesConfigProcessForm";
            this.Text = "SeriesConfigProcessForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SeriesConfigProcessForm_FormClosing);
            this.Resize += new System.EventHandler(this.SeriesConfigProcessForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pbxPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbxPicture;
    }
}