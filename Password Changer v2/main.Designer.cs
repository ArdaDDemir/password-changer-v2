namespace Password_Changer_v2
{
    partial class main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.close_btn = new System.Windows.Forms.Label();
            this.github_pic = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Pass_txt = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.change_btn = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPasswd = new System.Windows.Forms.TextBox();
            this.txtPasswdAgain = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.github_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.change_btn.SuspendLayout();
            this.SuspendLayout();
            // 
            // close_btn
            // 
            this.close_btn.AutoSize = true;
            this.close_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.close_btn.ForeColor = System.Drawing.Color.White;
            this.close_btn.Location = new System.Drawing.Point(248, 9);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(17, 21);
            this.close_btn.TabIndex = 1;
            this.close_btn.Text = "x";
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // github_pic
            // 
            this.github_pic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.github_pic.Image = global::Password_Changer_v2.Properties.Resources.github;
            this.github_pic.Location = new System.Drawing.Point(227, 302);
            this.github_pic.Name = "github_pic";
            this.github_pic.Size = new System.Drawing.Size(50, 49);
            this.github_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.github_pic.TabIndex = 5;
            this.github_pic.TabStop = false;
            this.github_pic.Click += new System.EventHandler(this.github_pic_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Password_Changer_v2.Properties.Resources.adlogo;
            this.pictureBox1.Location = new System.Drawing.Point(31, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Pass_txt
            // 
            this.Pass_txt.AutoSize = true;
            this.Pass_txt.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Pass_txt.ForeColor = System.Drawing.Color.White;
            this.Pass_txt.Location = new System.Drawing.Point(31, 120);
            this.Pass_txt.Name = "Pass_txt";
            this.Pass_txt.Size = new System.Drawing.Size(54, 20);
            this.Pass_txt.TabIndex = 7;
            this.Pass_txt.Text = "Şifre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(31, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tekrar Şifre";
            // 
            // change_btn
            // 
            this.change_btn.BackColor = System.Drawing.Color.Transparent;
            this.change_btn.Controls.Add(this.label2);
            this.change_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.change_btn.Location = new System.Drawing.Point(28, 266);
            this.change_btn.Name = "change_btn";
            this.change_btn.Size = new System.Drawing.Size(163, 58);
            this.change_btn.TabIndex = 9;
            this.change_btn.Click += new System.EventHandler(this.change_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(20, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tekrar Şifre";
            // 
            // txtPasswd
            // 
            this.txtPasswd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPasswd.Location = new System.Drawing.Point(34, 151);
            this.txtPasswd.Name = "txtPasswd";
            this.txtPasswd.Size = new System.Drawing.Size(148, 16);
            this.txtPasswd.TabIndex = 10;
            // 
            // txtPasswdAgain
            // 
            this.txtPasswdAgain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPasswdAgain.Location = new System.Drawing.Point(34, 235);
            this.txtPasswdAgain.Name = "txtPasswdAgain";
            this.txtPasswdAgain.Size = new System.Drawing.Size(148, 16);
            this.txtPasswdAgain.TabIndex = 11;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Password_Changer_v2.Properties.Resources.background1;
            this.ClientSize = new System.Drawing.Size(275, 350);
            this.Controls.Add(this.txtPasswdAgain);
            this.Controls.Add(this.txtPasswd);
            this.Controls.Add(this.change_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Pass_txt);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.github_pic);
            this.Controls.Add(this.close_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "main";
            ((System.ComponentModel.ISupportInitialize)(this.github_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.change_btn.ResumeLayout(false);
            this.change_btn.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label close_btn;
        private PictureBox github_pic;
        private PictureBox pictureBox1;
        private Label Pass_txt;
        private Label label1;
        private Panel change_btn;
        private Label label2;
        private TextBox txtPasswd;
        private TextBox txtPasswdAgain;
    }
}