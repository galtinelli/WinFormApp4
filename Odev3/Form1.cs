using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odev3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string path;
        private void Form1_Load(object sender, EventArgs e)
        {
            btnDosyayaYaz.Enabled = btnGoruntule.Enabled = btnSil.Enabled = false;
        }

        private void btnDosyaSec_Click(object sender, EventArgs e)
        {
            //Dosya seçme ekranı
            OpenFileDialog fd = new OpenFileDialog();

            //Sadece txt dosyaları için uzantı verilir
            // fd.Filter = "Metin Dosyaları | *.txt" ;
            fd.Filter = "Metin Dosyaları (*.txt)|*.txt|Word(*.doc) |*.doc|Word(*.docx) |*.docx|Pdf(*.pdf) |*.pdf |Tüm Dosyalar(*.*) |*.*";

            fd.ShowDialog();

            //filepath isimli değişkenin içine FileDialog'da seçilen dizini atayalım
            path = fd.FileName;

            txtPath.Text = path;



            btnDosyayaYaz.Enabled = btnGoruntule.Enabled = btnSifrele.Enabled = btnSil.Enabled = true;
        }

        private void btnGoruntule_Click(object sender, EventArgs e)
        {
            StreamReader streamReader = new StreamReader(path);
            rtxtDosya.Text = streamReader.ReadToEnd();
            streamReader.Close();

        }
        string gelenYazi;
        private void btnDosyayaYaz_Click(object sender, EventArgs e)
        {

            //Açılan bağlantı kapatılmazsa üzerinde başka işlem yapılamaz

            StreamReader streamReader = new StreamReader(path);
            gelenYazi = streamReader.ReadToEnd();
            streamReader.Close();

            StreamWriter streamWriter = new StreamWriter(path);
            streamWriter.Write(gelenYazi += "\n" + rtxtGirilenYazi.Text);
            streamWriter.Close();

            rtxtDosya.Text = "";
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (File.Exists(path) == true)
            {
                File.Delete(path);
                MessageBox.Show("Seçilen dosya silinmiştir.");
            }
            else
                MessageBox.Show("Dosya Mevcut Değildir.");

        }
        private void btnAktar_Click(object sender, EventArgs e) //Dosyalar içerisinden resim seçerek pictureboxa eklenir.
        {
            openFileDialog1.Title = "Resim dosyası seçiniz";
            openFileDialog1.ShowDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                pcbResim.ImageLocation = openFileDialog1.FileName.ToString();

                MessageBox.Show("Seçmiş olduğunuz resim eklenmiştir.");
            }
            else
            {
                MessageBox.Show("Dosya seçilmemiştir.");
            }
        }
        private void btnSifrele_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog opf = new OpenFileDialog();
                opf.ShowDialog();

                string password = @"test123"; //şifre
                UnicodeEncoding UE = new UnicodeEncoding();
                byte[] key = UE.GetBytes(password);

                string cryptFile = @"C:\Users\Gamze\Desktop\Encrypted.txt";
                FileStream fsCrypt = new FileStream(cryptFile, FileMode.Create);

                RijndaelManaged RMCrypto = new RijndaelManaged();

                CryptoStream cs = new CryptoStream(fsCrypt, RMCrypto.CreateEncryptor(key, key), CryptoStreamMode.Write);

                FileStream fsln = new FileStream(opf.FileName, FileMode.Open);

                int data;
                while ((data = fsln.ReadByte()) != -1)
                    cs.WriteByte((byte)data);

                fsln.Close();
                cs.Close();
                fsCrypt.Close();

                MessageBox.Show("Şifreleme tamamlandı");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
        }

    }
}
