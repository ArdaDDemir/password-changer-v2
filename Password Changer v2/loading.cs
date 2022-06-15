using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password_Changer_v2
{
    public partial class loading : Form
    {
        public loading()
        {
            InitializeComponent();
        }

        private void loading_Load(object sender, EventArgs e)
        {
            //Zamanlayıcı başlama
            load.Start();

        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            //Kapatma Butonu
            Environment.Exit(0);

        }

        private void load_Tick(object sender, EventArgs e)
        {
            //Form değiştirme
            main ff = new main();
            ff.Show();
            this.Hide();
            //zamanlayıcı durma
            load.Stop();

        }

        private void github_pic_Click(object sender, EventArgs e)
        {
            //Link Açma
            System.Diagnostics.Process.Start("https://github.com/ArdaDDemir");

        }
    }
}
