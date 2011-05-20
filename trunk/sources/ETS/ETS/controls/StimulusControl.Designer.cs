namespace ETS.controls
{
    partial class StimulusControl
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
            this.btnViewInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnViewInfo
            // 
            this.btnViewInfo.Location = new System.Drawing.Point(4, 4);
            this.btnViewInfo.Name = "btnViewInfo";
            this.btnViewInfo.Size = new System.Drawing.Size(20, 42);
            this.btnViewInfo.TabIndex = 0;
            this.btnViewInfo.Text = "s";
            this.btnViewInfo.UseVisualStyleBackColor = true;
            // 
            // StimulusControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnViewInfo);
            this.Name = "StimulusControl";
            this.Size = new System.Drawing.Size(26, 49);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnViewInfo;
    }
}
