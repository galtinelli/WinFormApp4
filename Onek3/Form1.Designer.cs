
namespace Onek3
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
            this.txtDosyaYolu = new System.Windows.Forms.TextBox();
            this.btnYazdir = new System.Windows.Forms.Button();
            this.btnOku = new System.Windows.Forms.Button();
            this.txtMein = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnDosyaSec
            // 
            this.btnDosyaSec.Location = new System.Drawing.Point(363, 24);
            this.btnDosyaSec.Name = "btnDosyaSec";
            this.btnDosyaSec.Size = new System.Drawing.Size(75, 23);
            this.btnDosyaSec.TabIndex = 0;
            this.btnDosyaSec.Text = "Dosya Seç";
            this.btnDosyaSec.UseVisualStyleBackColor = true;
            this.btnDosyaSec.Click += new System.EventHandler(this.btnDosyaSec_Click);
            // 
            // txtDosyaYolu
            // 
            this.txtDosyaYolu.BackColor = System.Drawing.SystemColors.Control;
            this.txtDosyaYolu.Location = new System.Drawing.Point(40, 26);
            this.txtDosyaYolu.Name = "txtDosyaYolu";
            this.txtDosyaYolu.Size = new System.Drawing.Size(299, 20);
            this.txtDosyaYolu.TabIndex = 1;
            // 
            // btnYazdir
            // 
            this.btnYazdir.Location = new System.Drawing.Point(40, 112);
            this.btnYazdir.Name = "btnYazdir";
            this.btnYazdir.Size = new System.Drawing.Size(152, 47);
            this.btnYazdir.TabIndex = 2;
            this.btnYazdir.Text = "Dosyaya Yazdır";
            this.btnYazdir.UseVisualStyleBackColor = true;
            this.btnYazdir.Click += new System.EventHandler(this.btnYazdir_Click);
            // 
            // btnOku
            // 
            this.btnOku.Location = new System.Drawing.Point(281, 112);
            this.btnOku.Name = "btnOku";
            this.btnOku.Size = new System.Drawing.Size(157, 47);
            this.btnOku.TabIndex = 3;
            this.btnOku.Text = "Dosyadan Oku";
            this.btnOku.UseVisualStyleBackColor = true;
            this.btnOku.Click += new System.EventHandler(this.btnOku_Click);
            // 
            // txtMein
            // 
            this.txtMein.Location = new System.Drawing.Point(40, 176);
            this.txtMein.Name = "txtMein";
            this.txtMein.Size = new System.Drawing.Size(398, 145);
            this.txtMein.TabIndex = 4;
            this.txtMein.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 346);
            this.Controls.Add(this.txtMein);
            this.Controls.Add(this.btnOku);
            this.Controls.Add(this.btnYazdir);
            this.Controls.Add(this.txtDosyaYolu);
            this.Controls.Add(this.btnDosyaSec);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDosyaSec;
        private System.Windows.Forms.TextBox txtDosyaYolu;
        private System.Windows.Forms.Button btnYazdir;
        private System.Windows.Forms.Button btnOku;
        private System.Windows.Forms.RichTextBox txtMein;
    }
}

