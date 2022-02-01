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
    public partial class ArabaIslemleri : Form
    {
        public ArabaIslemleri()
        {
            InitializeComponent();
        }

        public void YeniArabaEkle(string arabaMarkasi,Color arabaRengi)
        {
            Button yeni = new Button();
            yeni.Text = arabaMarkasi;
            yeni.ForeColor = arabaRengi;
            yeni.Width = pnlSatilacaklar.Width;
            yeni.Height = 35;
            yeni.FlatStyle = FlatStyle.Flat;

            yeni.MouseDown += Yeni_MouseDown;
            yeni.Top = EklenecegiYer(pnlSatilacaklar);
            pnlSatilacaklar.Controls.Add(yeni);
        }
        private int EklenecegiYer(Panel pnlSatilacaklar)
        {
            int toplam = 0;

            foreach (Control item in pnlSatilacaklar.Controls)
            {
                toplam += item.Height;
            }
            return toplam;
        }

        private void Yeni_MouseDown(object sender, MouseEventArgs e)
        {
            Button basilanYer = (Button)sender;
            basilanYer.DoDragDrop(sender, DragDropEffects.Move);
        }

        private void pnlSatilacaklar_DragDrop(object sender, DragEventArgs e)
        {

            Button btn = (Button)e.Data.GetData(typeof(Button));
            btn.Top = EklenecegiYer((Panel)sender);
            ((Panel)btn.Parent).Controls.Remove(btn);
            ((Panel)sender).Controls.Add(btn);
        }

        private void pnlSatilacaklar_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

    }
}
