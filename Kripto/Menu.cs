using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace Kripto
{
    public partial class Menu : MetroForm
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            KriptoMesaj k = new KriptoMesaj();
            k.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

            Kripto_decoder kd = new Kripto_decoder();
            kd.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Cripto_Menu k_m = new Cripto_Menu();
            k_m.ShowDialog();
        }
       
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.ayyildiz.org/");
        }
    }
}
