using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proje
{
    public partial class Form4 : Form
    {
        public event EventHandler<string> DataSent;
        public Form4()
        {
            InitializeComponent();
        }

        private void btn_anasayfa_Click(object sender, EventArgs e)
        {
            Form1 yeni = new Form1();
            yeni.Show();
            this.Hide();
        }
        
        private void btn_gider_ekle_Click(object sender, EventArgs e )
        {
            string data = txt_gider_ekle.Text;
            DataSent?.Invoke(this, data);
            MessageBox.Show("Gider tipi eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
