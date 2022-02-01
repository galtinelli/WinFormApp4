using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ornek1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tsmYeniForm_Click(object sender, EventArgs e)
        {
            SayfaForm sayfaForm = new SayfaForm();
            sayfaForm.MdiParent = this;
            sayfaForm.Show();

            tsmYeniNot.Enabled = true;
        }

        private void tsmYeniNot_Click(object sender, EventArgs e)
        {

            NotForm notForm = new NotForm();
            notForm.Owner = this;
            notForm.ShowDialog();
        }
    }
}
