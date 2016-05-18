namespace WSPRepackage
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btn_src = new System.Windows.Forms.Button();
            this.btn_dir = new System.Windows.Forms.Button();
            this.btn_repackage = new System.Windows.Forms.Button();
            this.txt_source = new System.Windows.Forms.TextBox();
            this.txt_output = new System.Windows.Forms.TextBox();
            this.txt_wspname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lnk_promo = new System.Windows.Forms.LinkLabel();
            this.img_header = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.img_header)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_src
            // 
            this.btn_src.Location = new System.Drawing.Point(434, 96);
            this.btn_src.Name = "btn_src";
            this.btn_src.Size = new System.Drawing.Size(75, 23);
            this.btn_src.TabIndex = 0;
            this.btn_src.Text = "Browse";
            this.btn_src.UseVisualStyleBackColor = true;
            this.btn_src.Click += new System.EventHandler(this.btn_src_Click);
            // 
            // btn_dir
            // 
            this.btn_dir.Location = new System.Drawing.Point(434, 136);
            this.btn_dir.Name = "btn_dir";
            this.btn_dir.Size = new System.Drawing.Size(75, 23);
            this.btn_dir.TabIndex = 1;
            this.btn_dir.Text = "Browse";
            this.btn_dir.UseVisualStyleBackColor = true;
            this.btn_dir.Click += new System.EventHandler(this.btn_dir_Click);
            // 
            // btn_repackage
            // 
            this.btn_repackage.Location = new System.Drawing.Point(432, 226);
            this.btn_repackage.Name = "btn_repackage";
            this.btn_repackage.Size = new System.Drawing.Size(75, 23);
            this.btn_repackage.TabIndex = 2;
            this.btn_repackage.Text = "Repackage";
            this.btn_repackage.UseVisualStyleBackColor = true;
            this.btn_repackage.Click += new System.EventHandler(this.btn_repackage_Click);
            // 
            // txt_source
            // 
            this.txt_source.Location = new System.Drawing.Point(121, 98);
            this.txt_source.Name = "txt_source";
            this.txt_source.Size = new System.Drawing.Size(307, 20);
            this.txt_source.TabIndex = 3;
            // 
            // txt_output
            // 
            this.txt_output.Location = new System.Drawing.Point(121, 138);
            this.txt_output.Name = "txt_output";
            this.txt_output.Size = new System.Drawing.Size(307, 20);
            this.txt_output.TabIndex = 4;
            // 
            // txt_wspname
            // 
            this.txt_wspname.Location = new System.Drawing.Point(121, 175);
            this.txt_wspname.Name = "txt_wspname";
            this.txt_wspname.Size = new System.Drawing.Size(307, 20);
            this.txt_wspname.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Source Directory";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Output Directory";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "WSP Name";
            // 
            // lnk_promo
            // 
            this.lnk_promo.ActiveLinkColor = System.Drawing.Color.DodgerBlue;
            this.lnk_promo.AutoSize = true;
            this.lnk_promo.LinkColor = System.Drawing.Color.DodgerBlue;
            this.lnk_promo.Location = new System.Drawing.Point(15, 236);
            this.lnk_promo.Name = "lnk_promo";
            this.lnk_promo.Size = new System.Drawing.Size(119, 13);
            this.lnk_promo.TabIndex = 9;
            this.lnk_promo.TabStop = true;
            this.lnk_promo.Text = "HANDS ON SharePoint";
            this.lnk_promo.VisitedLinkColor = System.Drawing.Color.DodgerBlue;
            this.lnk_promo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // img_header
            // 
            this.img_header.Image = global::WSPRepackage.Properties.Resources.Header;
            this.img_header.Location = new System.Drawing.Point(12, 9);
            this.img_header.Name = "img_header";
            this.img_header.Size = new System.Drawing.Size(497, 68);
            this.img_header.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.img_header.TabIndex = 10;
            this.img_header.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 261);
            this.Controls.Add(this.img_header);
            this.Controls.Add(this.lnk_promo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_wspname);
            this.Controls.Add(this.txt_output);
            this.Controls.Add(this.txt_source);
            this.Controls.Add(this.btn_repackage);
            this.Controls.Add(this.btn_dir);
            this.Controls.Add(this.btn_src);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SharePoint WSP Repackage";
            ((System.ComponentModel.ISupportInitialize)(this.img_header)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btn_src;
        private System.Windows.Forms.Button btn_dir;
        private System.Windows.Forms.Button btn_repackage;
        private System.Windows.Forms.TextBox txt_source;
        private System.Windows.Forms.TextBox txt_output;
        private System.Windows.Forms.TextBox txt_wspname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel lnk_promo;
        private System.Windows.Forms.PictureBox img_header;
    }
}

