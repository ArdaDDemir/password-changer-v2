using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.DirectoryServices;

namespace Password_Changer_v2
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            //Kapatma Butonu
            Environment.Exit(0);
        }
        //Şifre değiştirme kısmı
        public void ChangePassword(string new_password)
        {
            try
            {
                new DirectoryEntry("WinNT://" + Environment.MachineName.ToString()).Children.Find(Environment.UserName).Invoke("SetPassword", (object)new_password);
                int num = (int)MessageBox.Show("Şifreniz başarıyla değiştirildi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                int num = (int)MessageBox.Show("Şifreniz değiştirilirken bir hata meydana geldi!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }
        //Şifre değiştirme Bitiş
        private void github_pic_Click(object sender, EventArgs e)
        {
            //Link Açma
            System.Diagnostics.Process.Start("https://github.com/ArdaDDemir");

        }

        private void change_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.txtPasswd.Text) || string.IsNullOrWhiteSpace(this.txtPasswdAgain.Text))
            {
                int num1 = (int)MessageBox.Show("Alanlar boş olamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else if (this.txtPasswd.Text != this.txtPasswdAgain.Text)
            {
                int num2 = (int)MessageBox.Show("Şifreler uyuşmuyor!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else if (this.txtPasswd.Text.Length < 6)
            {
                int num3 = (int)MessageBox.Show("Yeni şifre 6 karakterden kısa olamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
                this.ChangePassword(this.txtPasswdAgain.Text);
        }
    }
}
