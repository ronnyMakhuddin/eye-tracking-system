namespace ETS.controls
{
    partial class TemplateControl
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
            this.grpItems = new System.Windows.Forms.GroupBox();
            this.image = new Emgu.CV.UI.ImageBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.grpItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
            this.SuspendLayout();
            // 
            // grpItems
            // 
            this.grpItems.Controls.Add(this.btnDelete);
            this.grpItems.Controls.Add(this.image);
            this.grpItems.Location = new System.Drawing.Point(4, 5);
            this.grpItems.Name = "grpItems";
            this.grpItems.Size = new System.Drawing.Size(294, 80);
            this.grpItems.TabIndex = 0;
            this.grpItems.TabStop = false;
            // 
            // image
            // 
            this.image.Location = new System.Drawing.Point(6, 19);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(148, 55);
            this.image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.image.TabIndex = 2;
            this.image.TabStop = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(196, 33);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // TemplateControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grpItems);
            this.Name = "TemplateControl";
            this.Size = new System.Drawing.Size(299, 86);
            this.grpItems.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpItems;
        private Emgu.CV.UI.ImageBox image;
        private System.Windows.Forms.Button btnDelete;

    }
}
