using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Onek3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*
         *File Stream İşlemleri
         
        Bu sınıf ile diskte bulunan bir dosyaya ulaşım sağlanır. StreamWriter ve StreamReader ile de açılan dosya üzerinde yazma veya okuma işlemleride yapılabilir.
        * Dosya üzerinde metin tabanlı veya byte tabanlı işlemler yapılabilir.
        * Read() yada ReadByte() metotları byte düzeyinde veri okumamızı sağlayan metotlardır.
        * ReadByte() okuma yapamazsa geriye -1 döndürür.
         */

        string filePath;
        private void btnYazdir_Click(object sender, EventArgs e)
        {
            //Açılan bağlantı kapatılmazsa üzerinde başka işlem yapılamaz

            StreamReader streamReader = new StreamReader(filePath);
            string gelenYazi = streamReader.ReadToEnd();
            streamReader.Close();

            StreamWriter streamWriter = new StreamWriter(filePath);
            streamWriter.Write(gelenYazi += "\n" + txtMein.Text);
            streamWriter.Close();

            txtMein.Text = "";

        }

        private void btnOku_Click(object sender, EventArgs e)
        {
            StreamReader streamReader = new StreamReader(filePath);
            txtMein.Text = streamReader.ReadToEnd();
            streamReader.Close();


        }

        private void btnDosyaSec_Click(object sender, EventArgs e)
        {

            //Dosya seçme ekranı
            OpenFileDialog fd = new OpenFileDialog();

            //Sadece txt dosyaları için uzantı verilir
           // fd.Filter = "Metin Dosyaları | *.txt" ;
            fd.Filter = "Metin Dosyaları (*.txt)|*.txt|Tüm Dosyalar(*.*) |*.*";
            fd.ShowDialog();


            //filepath isimli değişkenin içine FileDialog'da seçilen dizini atayalım
            filePath = fd.FileName;

            txtDosyaYolu.Text = filePath;
        }
    }
}
