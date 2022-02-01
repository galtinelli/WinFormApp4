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
    public partial class NotForm : Form
    {
        public NotForm()
        {
            InitializeComponent();
        }
        public Form1 anaForm;
        private void btnNotEkle_Click(object sender, EventArgs e)
        {
            anaForm = (Form1)this.Owner;
            ((SayfaForm)anaForm.ActiveMdiChild).YeniMaddeEkle(txtNot.Text);
            this.Hide();
            txtNot.Text = "";
        }

        private void NotForm_Load(object sender, EventArgs e)
        {
            txtNot.MaxLength = 140;
            lblKalan.Text = txtNot.MaxLength.ToString();
        }

        private void txtNot_TextChanged(object sender, EventArgs e)
        {
            lblKalan.Text = (txtNot.MaxLength - txtNot.Text.Length).ToString();
        }
    }
}
