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
    public partial class ArabaEkle : Form
    {
        public ArabaEkle()
        {
            InitializeComponent();
        }
        private void ArabaEkle_Load(object sender, EventArgs e)
        {
            cmbRenk.Items.Add(Color.Black);
            cmbRenk.Items.Add(Color.Red);
            cmbRenk.Items.Add(Color.Purple);
            cmbRenk.Items.Add(Color.MediumAquamarine);
            cmbRenk.Items.Add(Color.White);
            //foreach (System.Reflection.PropertyInfo prop in typeof(Color).GetProperties())
            //{
            //    if (prop.PropertyType.FullName == "System.Drawing.Color")
            //        cmbRenk.Items.Add(prop.Name);
            //}
        }


        //private void cmbRenk_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    ArabaIslemleri arabaIslemleri = new ArabaIslemleri();
        //    Color renk = Color.FromName(cmbRenk.Text);
        //}

        public Form1 anaForm;
        private void btnArabaEkle_Click(object sender, EventArgs e)
        {
            anaForm = (Form1)this.Owner;
            ((ArabaIslemleri)anaForm.ActiveMdiChild).YeniArabaEkle(txtArabaMarkasi.Text, (Color)cmbRenk.SelectedItem);
            this.Hide();
            txtArabaMarkasi.Text = "";
            cmbRenk.SelectedItem = -1;
        }
    }
}
