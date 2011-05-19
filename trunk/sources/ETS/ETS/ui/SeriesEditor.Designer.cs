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
            this.btnRecord = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCapture)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxCapture
            // 
            this.pbxCapture.Location = new System.Drawing.Point(12, 12);
            this.pbxCapture.Name = "pbxCapture";
            this.pbxCapture.Size = new System.Drawing.Size(640, 480);
            this.pbxCapture.TabIndex = 2;
            this.pbxCapture.TabStop = false;
            // 
            // btnAddTemplate
            // 
            this.btnAddTemplate.Location = new System.Drawing.Point(673, 74);
            this.btnAddTemplate.Name = "btnAddTemplate";
            this.btnAddTemplate.Size = new System.Drawing.Size(88, 51);
            this.btnAddTemplate.TabIndex = 3;
            this.btnAddTemplate.Text = "Add Template";
            this.btnAddTemplate.UseVisualStyleBackColor = true;
            this.btnAddTemplate.Click += new System.EventHandler(this.btnAddTemplate_Click);
            // 
            // btnRecord
            // 
            this.btnRecord.AccessibleDescription = "asdfasdfds";
            this.btnRecord.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRecord.BackgroundImage")));
            this.btnRecord.Location = new System.Drawing.Point(673, 12);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(44, 44);
            this.btnRecord.TabIndex = 4;
            this.btnRecord.UseVisualStyleBackColor = true;
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // btnPause
            // 
            this.btnPause.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPause.BackgroundImage")));
            this.btnPause.Location = new System.Drawing.Point(723, 12);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(44, 44);
            this.btnPause.TabIndex = 5;
            this.btnPause.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnStart.BackgroundImage")));
            this.btnStart.Location = new System.Drawing.Point(773, 12);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(44, 44);
            this.btnStart.TabIndex = 6;
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // btnEnd
            // 
            this.btnEnd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEnd.BackgroundImage")));
            this.btnEnd.Location = new System.Drawing.Point(823, 12);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(44, 44);
            this.btnEnd.TabIndex = 7;
            this.btnEnd.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(767, 74);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(99, 50);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "Reset Capture";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // SeriesEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 506);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnRecord);
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
        private System.Windows.Forms.Button btnRecord;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Button btnReset;
    }
}