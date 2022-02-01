
namespace Ornek1
{
    partial class SayfaForm
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
            this.pnlAlinacaklar = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlAlinananlar = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(58, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alınacaklar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(280, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Alınanlar";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(199, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 307);
            this.label3.TabIndex = 2;
            // 
            // pnlAlinacaklar
            // 
            this.pnlAlinacaklar.AllowDrop = true;
            this.pnlAlinacaklar.Location = new System.Drawing.Point(12, 65);
            this.pnlAlinacaklar.Name = "pnlAlinacaklar";
            this.pnlAlinacaklar.Size = new System.Drawing.Size(171, 300);
            this.pnlAlinacaklar.TabIndex = 4;
            this.pnlAlinacaklar.DragDrop += new System.Windows.Forms.DragEventHandler(this.pnlAlinacaklar_DragDrop);
            this.pnlAlinacaklar.DragOver += new System.Windows.Forms.DragEventHandler(this.pnlAlinacaklar_DragOver);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(12, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(392, 13);
            this.label4.TabIndex = 5;
            // 
            // pnlAlinananlar
            // 
            this.pnlAlinananlar.AllowDrop = true;
            this.pnlAlinananlar.Location = new System.Drawing.Point(220, 65);
            this.pnlAlinananlar.Name = "pnlAlinananlar";
            this.pnlAlinananlar.Size = new System.Drawing.Size(171, 300);
            this.pnlAlinananlar.TabIndex = 5;
            this.pnlAlinananlar.DragDrop += new System.Windows.Forms.DragEventHandler(this.pnlAlinacaklar_DragDrop);
            this.pnlAlinananlar.DragOver += new System.Windows.Forms.DragEventHandler(this.pnlAlinacaklar_DragOver);
            // 
            // SayfaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 398);
            this.Controls.Add(this.pnlAlinananlar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pnlAlinacaklar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SayfaForm";
            this.Text = "SayfaForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlAlinacaklar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlAlinananlar;
    }
}