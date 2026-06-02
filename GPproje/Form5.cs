using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPproje
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Önerilerimizin sizi memnun etmesine çok mutlu olduk. Geri bildirimin için teşekkürler!", "Geri Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yaşadığınız olumsuz durum için üzgün olduğumuzu belirtmek isteriz. Daha iyi bir versiyonumuz için bildirimleriniz değerli! Teşekkür ederiz.", "Geri Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
