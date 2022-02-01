using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ornek2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tsmArabaEkle.Enabled = false;
        }

        private void arabaEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ArabaEkle arabaEkle = new ArabaEkle();
            arabaEkle.Owner = this;
            arabaEkle.ShowDialog();

            
        }

        private void tsmArabaIslemleri_Click(object sender, EventArgs e)
        {

            ArabaIslemleri arabaIslemleri = new ArabaIslemleri();
            arabaIslemleri.MdiParent = this;
            arabaIslemleri.Show();
            tsmArabaEkle.Enabled = true;
        }

        private void tsmCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
