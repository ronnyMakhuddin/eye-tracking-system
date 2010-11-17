namespace ETS.ui
{
    partial class EditStimulusSetForm
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
            this.grdSet = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdSet)).BeginInit();
            this.SuspendLayout();
            // 
            // grdSet
            // 
            this.grdSet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSet.Location = new System.Drawing.Point(12, 12);
            this.grdSet.Name = "grdSet";
            this.grdSet.Size = new System.Drawing.Size(537, 159);
            this.grdSet.TabIndex = 0;
            // 
            // EditStimulusSetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 226);
            this.Controls.Add(this.grdSet);
            this.Name = "EditStimulusSetForm";
            this.Text = "EditStimulusSetForm";
            ((System.ComponentModel.ISupportInitialize)(this.grdSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdSet;
    }
}