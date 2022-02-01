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
    public partial class SayfaForm : Form
    {
        public SayfaForm()
        {
            InitializeComponent();
        }

        public void YeniMaddeEkle(string mesaj)
        {
            Label yeni = new Label();
            yeni.AutoSize = true;
            yeni.Text = mesaj;
            yeni.BorderStyle = BorderStyle.FixedSingle;
            yeni.MouseDown += Yeni_MouseDown;
            yeni.Top = EklenecegiYer(pnlAlinacaklar);
            pnlAlinacaklar.Controls.Add(yeni);
        }

        private int EklenecegiYer(Panel pnlAlinacaklar)
        {
            int toplam = 0;

            foreach (Control item in pnlAlinacaklar.Controls)
            {
                toplam += item.Height;
            }
            return toplam;
        }

        private void Yeni_MouseDown(object sender, MouseEventArgs e)
        {
            Label basilanYer = (Label)sender;
            basilanYer.DoDragDrop(sender, DragDropEffects.Move);

        }

        private void pnlAlinacaklar_DragDrop(object sender, DragEventArgs e)
        {
            Label lbl = (Label)e.Data.GetData(typeof(Label));
            lbl.Top = EklenecegiYer((Panel)sender);
            ((Panel)lbl.Parent).Controls.Remove(lbl);
            ((Panel)sender).Controls.Add(lbl);

        }

        private void pnlAlinanlar_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;

        }

        private void pnlAlinanlar_DragEnter(object sender, DragEventArgs e)
        {

            Label lbl = (Label)e.Data.GetData(typeof(Label));
            lbl.Top = EklenecegiYer((Panel)sender);
            ((Panel)sender).Controls.Add(lbl);
        }

        private void pnlAlinacaklar_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }
    }
}
