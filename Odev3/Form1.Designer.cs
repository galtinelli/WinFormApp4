
namespace Odev3
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDosyaSec = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnSifrele = new System.Windows.Forms.Button();
            this.btnAktar = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnDosyayaYaz = new System.Windows.Forms.Button();
            this.btnGoruntule = new System.Windows.Forms.Button();
            this.rtxtDosya = new System.Windows.Forms.RichTextBox();
            this.rtxtGirilenYazi = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pcbResim = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pcbResim)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDosyaSec
            // 
            this.btnDosyaSec.Location = new System.Drawing.Point(561, 32);
            this.btnDosyaSec.Name = "btnDosyaSec";
            this.btnDosyaSec.Size = new System.Drawing.Size(75, 23);
            this.btnDosyaSec.TabIndex = 0;
            this.btnDosyaSec.Text = "Dosya Seç";
            this.btnDosyaSec.UseVisualStyleBackColor = true;
            this.btnDosyaSec.Click += new System.EventHandler(this.btnDosyaSec_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(561, 82);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 1;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnSifrele
            // 
            this.btnSifrele.Location = new System.Drawing.Point(283, 74);
            this.btnSifrele.Name = "btnSifrele";
            this.btnSifrele.Size = new System.Drawing.Size(128, 39);
            this.btnSifrele.TabIndex = 2;
            this.btnSifrele.Text = "Şifrelenecek Klasör Seç ve Şifrele";
            this.btnSifrele.UseVisualStyleBackColor = true;
            this.btnSifrele.Click += new System.EventHandler(this.btnSifrele_Click);
            // 
            // btnAktar
            // 
            this.btnAktar.Location = new System.Drawing.Point(441, 82);
            this.btnAktar.Name = "btnAktar";
            this.btnAktar.Size = new System.Drawing.Size(96, 23);
            this.btnAktar.TabIndex = 3;
            this.btnAktar.Text = "Resim Aktar";
            this.btnAktar.UseVisualStyleBackColor = true;
            this.btnAktar.Click += new System.EventHandler(this.btnAktar_Click);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(33, 32);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(522, 20);
            this.txtPath.TabIndex = 4;
            // 
            // btnDosyayaYaz
            // 
            this.btnDosyayaYaz.Location = new System.Drawing.Point(153, 82);
            this.btnDosyayaYaz.Name = "btnDosyayaYaz";
            this.btnDosyayaYaz.Size = new System.Drawing.Size(111, 23);
            this.btnDosyayaYaz.TabIndex = 5;
            this.btnDosyayaYaz.Text = "Dosyaya Yaz";
            this.btnDosyayaYaz.UseVisualStyleBackColor = true;
            this.btnDosyayaYaz.Click += new System.EventHandler(this.btnDosyayaYaz_Click);
            // 
            // btnGoruntule
            // 
            this.btnGoruntule.Location = new System.Drawing.Point(23, 82);
            this.btnGoruntule.Name = "btnGoruntule";
            this.btnGoruntule.Size = new System.Drawing.Size(112, 23);
            this.btnGoruntule.TabIndex = 6;
            this.btnGoruntule.Text = "Dosya Görüntüle";
            this.btnGoruntule.UseVisualStyleBackColor = true;
            this.btnGoruntule.Click += new System.EventHandler(this.btnGoruntule_Click);
            // 
            // rtxtDosya
            // 
            this.rtxtDosya.Location = new System.Drawing.Point(241, 162);
            this.rtxtDosya.Name = "rtxtDosya";
            this.rtxtDosya.Size = new System.Drawing.Size(170, 205);
            this.rtxtDosya.TabIndex = 7;
            this.rtxtDosya.Text = "";
            // 
            // rtxtGirilenYazi
            // 
            this.rtxtGirilenYazi.Location = new System.Drawing.Point(33, 162);
            this.rtxtGirilenYazi.Name = "rtxtGirilenYazi";
            this.rtxtGirilenYazi.Size = new System.Drawing.Size(160, 205);
            this.rtxtGirilenYazi.TabIndex = 8;
            this.rtxtGirilenYazi.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Eklemek İstediğiniz Yazı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(293, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Dosya İçeriği";
            // 
            // pcbResim
            // 
            this.pcbResim.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pcbResim.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pcbResim.Location = new System.Drawing.Point(461, 162);
            this.pcbResim.Name = "pcbResim";
            this.pcbResim.Size = new System.Drawing.Size(175, 205);
            this.pcbResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbResim.TabIndex = 11;
            this.pcbResim.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(504, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Eklediğiniz Resim";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(677, 393);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pcbResim);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtxtGirilenYazi);
            this.Controls.Add(this.rtxtDosya);
            this.Controls.Add(this.btnGoruntule);
            this.Controls.Add(this.btnDosyayaYaz);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.btnAktar);
            this.Controls.Add(this.btnSifrele);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnDosyaSec);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbResim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDosyaSec;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnSifrele;
        private System.Windows.Forms.Button btnAktar;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnDosyayaYaz;
        private System.Windows.Forms.Button btnGoruntule;
        private System.Windows.Forms.RichTextBox rtxtDosya;
        private System.Windows.Forms.RichTextBox rtxtGirilenYazi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pcbResim;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

