namespace PersonelKayıt
{
    partial class Frmİstatistik
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
            this.LblToplamPersonel = new System.Windows.Forms.Label();
            this.LblEvliPersonel = new System.Windows.Forms.Label();
            this.LblBekarPersonel = new System.Windows.Forms.Label();
            this.LblSehirSayısı = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.LblToplamMaas = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.LblOrtalamaMaas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Toplam Personel Sayısı:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Evli Personel Sayısı:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 55);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Bekar Personel Sayısı:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(96, 78);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Şehir Sayısı:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblToplamPersonel
            // 
            this.LblToplamPersonel.AutoSize = true;
            this.LblToplamPersonel.Location = new System.Drawing.Point(203, 9);
            this.LblToplamPersonel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblToplamPersonel.Name = "LblToplamPersonel";
            this.LblToplamPersonel.Size = new System.Drawing.Size(20, 23);
            this.LblToplamPersonel.TabIndex = 0;
            this.LblToplamPersonel.Text = "0";
            this.LblToplamPersonel.Click += new System.EventHandler(this.LblToplamPersonel_Click);
            // 
            // LblEvliPersonel
            // 
            this.LblEvliPersonel.AutoSize = true;
            this.LblEvliPersonel.Location = new System.Drawing.Point(203, 32);
            this.LblEvliPersonel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblEvliPersonel.Name = "LblEvliPersonel";
            this.LblEvliPersonel.Size = new System.Drawing.Size(20, 23);
            this.LblEvliPersonel.TabIndex = 0;
            this.LblEvliPersonel.Text = "0";
            this.LblEvliPersonel.Click += new System.EventHandler(this.label6_Click);
            // 
            // LblBekarPersonel
            // 
            this.LblBekarPersonel.AutoSize = true;
            this.LblBekarPersonel.Location = new System.Drawing.Point(203, 55);
            this.LblBekarPersonel.Name = "LblBekarPersonel";
            this.LblBekarPersonel.Size = new System.Drawing.Size(20, 23);
            this.LblBekarPersonel.TabIndex = 1;
            this.LblBekarPersonel.Text = "0";
            // 
            // LblSehirSayısı
            // 
            this.LblSehirSayısı.AutoSize = true;
            this.LblSehirSayısı.Location = new System.Drawing.Point(203, 78);
            this.LblSehirSayısı.Name = "LblSehirSayısı";
            this.LblSehirSayısı.Size = new System.Drawing.Size(20, 23);
            this.LblSehirSayısı.TabIndex = 2;
            this.LblSehirSayısı.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(78, 101);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 23);
            this.label9.TabIndex = 0;
            this.label9.Text = "Toplam Maaş:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblToplamMaas
            // 
            this.LblToplamMaas.AutoSize = true;
            this.LblToplamMaas.Location = new System.Drawing.Point(203, 101);
            this.LblToplamMaas.Name = "LblToplamMaas";
            this.LblToplamMaas.Size = new System.Drawing.Size(20, 23);
            this.LblToplamMaas.TabIndex = 2;
            this.LblToplamMaas.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(63, 124);
            this.label11.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(135, 23);
            this.label11.TabIndex = 0;
            this.label11.Text = "Ortalama Maaş:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblOrtalamaMaas
            // 
            this.LblOrtalamaMaas.AutoSize = true;
            this.LblOrtalamaMaas.Location = new System.Drawing.Point(203, 124);
            this.LblOrtalamaMaas.Name = "LblOrtalamaMaas";
            this.LblOrtalamaMaas.Size = new System.Drawing.Size(20, 23);
            this.LblOrtalamaMaas.TabIndex = 2;
            this.LblOrtalamaMaas.Text = "0";
            // 
            // Frmİstatistik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 288);
            this.Controls.Add(this.LblOrtalamaMaas);
            this.Controls.Add(this.LblToplamMaas);
            this.Controls.Add(this.LblSehirSayısı);
            this.Controls.Add(this.LblBekarPersonel);
            this.Controls.Add(this.LblEvliPersonel);
            this.Controls.Add(this.LblToplamPersonel);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Frmİstatistik";
            this.Text = "Frmİstatistik";
            this.Load += new System.EventHandler(this.Frmİstatistik_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblToplamPersonel;
        private System.Windows.Forms.Label LblEvliPersonel;
        private System.Windows.Forms.Label LblBekarPersonel;
        private System.Windows.Forms.Label LblSehirSayısı;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label LblToplamMaas;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label LblOrtalamaMaas;
    }
}