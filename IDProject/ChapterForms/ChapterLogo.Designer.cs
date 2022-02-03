namespace IDProject.ChapterForms
{
    partial class ChapterLogo
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
            this.btnsearch = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.picimage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picimage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(9, 275);
            this.btnsearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(131, 40);
            this.btnsearch.TabIndex = 34;
            this.btnsearch.Text = "Browse";
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(146, 275);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(143, 40);
            this.simpleButton1.TabIndex = 35;
            this.simpleButton1.Text = "Save";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // picimage
            // 
            this.picimage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picimage.Image = global::IDProject.Properties.Resources._10708863_elegant_vintage_background_;
            this.picimage.Location = new System.Drawing.Point(9, 9);
            this.picimage.Margin = new System.Windows.Forms.Padding(0);
            this.picimage.Name = "picimage";
            this.picimage.Size = new System.Drawing.Size(280, 255);
            this.picimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picimage.TabIndex = 33;
            this.picimage.TabStop = false;
            // 
            // ChapterLogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 326);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.picimage);
            this.Name = "ChapterLogo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChapterLogo";
            this.Load += new System.EventHandler(this.ChapterLogo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picimage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picimage;
        private DevExpress.XtraEditors.SimpleButton btnsearch;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}