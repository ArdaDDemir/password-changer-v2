namespace Password_Changer_v2
{
    partial class loading
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loading));
            this.load = new System.Windows.Forms.Timer(this.components);
            this.close_btn = new System.Windows.Forms.Label();
            this.loading_pic = new System.Windows.Forms.PictureBox();
            this.github_pic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.loading_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.github_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // load
            // 
            this.load.Enabled = true;
            this.load.Interval = 7500;
            this.load.Tick += new System.EventHandler(this.load_Tick);
            // 
            // close_btn
            // 
            this.close_btn.AutoSize = true;
            this.close_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.close_btn.ForeColor = System.Drawing.Color.White;
            this.close_btn.Location = new System.Drawing.Point(221, 9);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(17, 21);
            this.close_btn.TabIndex = 0;
            this.close_btn.Text = "x";
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // loading_pic
            // 
            this.loading_pic.Image = global::Password_Changer_v2.Properties.Resources.adturn;
            this.loading_pic.Location = new System.Drawing.Point(60, 61);
            this.loading_pic.Name = "loading_pic";
            this.loading_pic.Size = new System.Drawing.Size(127, 111);
            this.loading_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.loading_pic.TabIndex = 1;
            this.loading_pic.TabStop = false;
            // 
            // github_pic
            // 
            this.github_pic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.github_pic.Image = global::Password_Changer_v2.Properties.Resources.github;
            this.github_pic.Location = new System.Drawing.Point(200, 201);
            this.github_pic.Name = "github_pic";
            this.github_pic.Size = new System.Drawing.Size(50, 49);
            this.github_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.github_pic.TabIndex = 4;
            this.github_pic.TabStop = false;
            this.github_pic.Click += new System.EventHandler(this.github_pic_Click);
            // 
            // loading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(250, 250);
            this.Controls.Add(this.github_pic);
            this.Controls.Add(this.loading_pic);
            this.Controls.Add(this.close_btn);
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "loading";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ArdaDDemir";
            this.Load += new System.EventHandler(this.loading_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loading_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.github_pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer load;
        private Label close_btn;
        private PictureBox loading_pic;
        private PictureBox github_pic;
    }
}