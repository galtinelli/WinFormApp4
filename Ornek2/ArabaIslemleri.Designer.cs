
namespace Ornek2
{
    partial class ArabaIslemleri
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlSatilacaklar = new System.Windows.Forms.Panel();
            this.pnlSatilanlar = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(46, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "SATILACAKLAR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(306, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "SATILANLAR";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Maroon;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(209, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 400);
            this.label3.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(12, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(424, 14);
            this.label4.TabIndex = 3;
            // 
            // pnlSatilacaklar
            // 
            this.pnlSatilacaklar.Location = new System.Drawing.Point(15, 73);
            this.pnlSatilacaklar.Name = "pnlSatilacaklar";
            this.pnlSatilacaklar.Size = new System.Drawing.Size(188, 346);
            this.pnlSatilacaklar.TabIndex = 4;
            this.pnlSatilacaklar.DragDrop += new System.Windows.Forms.DragEventHandler(this.pnlSatilacaklar_DragDrop);
            this.pnlSatilacaklar.DragOver += new System.Windows.Forms.DragEventHandler(this.pnlSatilacaklar_DragOver);
            // 
            // pnlSatilanlar
            // 
            this.pnlSatilanlar.Location = new System.Drawing.Point(231, 73);
            this.pnlSatilanlar.Name = "pnlSatilanlar";
            this.pnlSatilanlar.Size = new System.Drawing.Size(188, 346);
            this.pnlSatilanlar.TabIndex = 5;
            this.pnlSatilanlar.DragDrop += new System.Windows.Forms.DragEventHandler(this.pnlSatilacaklar_DragDrop);
            this.pnlSatilanlar.DragOver += new System.Windows.Forms.DragEventHandler(this.pnlSatilacaklar_DragOver);
            // 
            // ArabaIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 431);
            this.Controls.Add(this.pnlSatilanlar);
            this.Controls.Add(this.pnlSatilacaklar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ArabaIslemleri";
            this.Text = "ArabaIslemleri";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlSatilacaklar;
        private System.Windows.Forms.Panel pnlSatilanlar;
    }
}