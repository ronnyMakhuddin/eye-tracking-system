namespace ETS.ui
{
    partial class SeriesEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SeriesEditor));
            this.pbxCapture = new Emgu.CV.UI.ImageBox();
            this.btnAddTemplate = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCapture)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxCapture
            // 
            this.pbxCapture.Location = new System.Drawing.Point(13, 13);
            this.pbxCapture.Name = "pbxCapture";
            this.pbxCapture.Size = new System.Drawing.Size(370, 329);
            this.pbxCapture.TabIndex = 2;
            this.pbxCapture.TabStop = false;
            // 
            // btnAddTemplate
            // 
            this.btnAddTemplate.Location = new System.Drawing.Point(389, 13);
            this.btnAddTemplate.Name = "btnAddTemplate";
            this.btnAddTemplate.Size = new System.Drawing.Size(88, 51);
            this.btnAddTemplate.TabIndex = 3;
            this.btnAddTemplate.Text = "Add Template";
            this.btnAddTemplate.UseVisualStyleBackColor = true;
            this.btnAddTemplate.Click += new System.EventHandler(this.btnAddTemplate_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.Location = new System.Drawing.Point(389, 271);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(44, 44);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // SeriesEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 354);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAddTemplate);
            this.Controls.Add(this.pbxCapture);
            this.Name = "SeriesEditor";
            this.Text = "SeriesEditor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SeriesEditor_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pbxCapture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Emgu.CV.UI.ImageBox pbxCapture;
        private System.Windows.Forms.Button btnAddTemplate;
        private System.Windows.Forms.Button button1;
    }
}