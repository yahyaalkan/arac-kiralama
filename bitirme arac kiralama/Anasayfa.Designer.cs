namespace bitirme_arac_kiralama
{
    partial class Anasayfa
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Anasayfa));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMusteriEkle = new System.Windows.Forms.Button();
            this.btnAracEkle = new System.Windows.Forms.Button();
            this.btnAracListele = new System.Windows.Forms.Button();
            this.btnMusteriListele = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnSatis = new System.Windows.Forms.Button();
            this.btnSözlesme = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(120, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(780, 531);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnMusteriEkle
            // 
            this.btnMusteriEkle.Image = ((System.Drawing.Image)(resources.GetObject("btnMusteriEkle.Image")));
            this.btnMusteriEkle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMusteriEkle.Location = new System.Drawing.Point(12, 0);
            this.btnMusteriEkle.Name = "btnMusteriEkle";
            this.btnMusteriEkle.Size = new System.Drawing.Size(102, 74);
            this.btnMusteriEkle.TabIndex = 1;
            this.btnMusteriEkle.Text = "Müşteri Ekle";
            this.btnMusteriEkle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMusteriEkle.UseVisualStyleBackColor = true;
            this.btnMusteriEkle.Click += new System.EventHandler(this.btnMusteriEkle_Click);
            // 
            // btnAracEkle
            // 
            this.btnAracEkle.Image = ((System.Drawing.Image)(resources.GetObject("btnAracEkle.Image")));
            this.btnAracEkle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAracEkle.Location = new System.Drawing.Point(12, 163);
            this.btnAracEkle.Name = "btnAracEkle";
            this.btnAracEkle.Size = new System.Drawing.Size(102, 61);
            this.btnAracEkle.TabIndex = 1;
            this.btnAracEkle.Text = "Araç Kayıt";
            this.btnAracEkle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAracEkle.UseVisualStyleBackColor = true;
            this.btnAracEkle.Click += new System.EventHandler(this.btnAracEkle_Click);
            // 
            // btnAracListele
            // 
            this.btnAracListele.Image = ((System.Drawing.Image)(resources.GetObject("btnAracListele.Image")));
            this.btnAracListele.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAracListele.Location = new System.Drawing.Point(12, 230);
            this.btnAracListele.Name = "btnAracListele";
            this.btnAracListele.Size = new System.Drawing.Size(102, 75);
            this.btnAracListele.TabIndex = 1;
            this.btnAracListele.Text = "Araç Listele";
            this.btnAracListele.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAracListele.UseVisualStyleBackColor = true;
            this.btnAracListele.Click += new System.EventHandler(this.btnAracListele_Click);
            // 
            // btnMusteriListele
            // 
            this.btnMusteriListele.Image = ((System.Drawing.Image)(resources.GetObject("btnMusteriListele.Image")));
            this.btnMusteriListele.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMusteriListele.Location = new System.Drawing.Point(12, 80);
            this.btnMusteriListele.Name = "btnMusteriListele";
            this.btnMusteriListele.Size = new System.Drawing.Size(102, 77);
            this.btnMusteriListele.TabIndex = 1;
            this.btnMusteriListele.Text = "Müşteri Listele";
            this.btnMusteriListele.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMusteriListele.UseVisualStyleBackColor = true;
            this.btnMusteriListele.Click += new System.EventHandler(this.btnMusteriListele_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.Image = ((System.Drawing.Image)(resources.GetObject("btnCikis.Image")));
            this.btnCikis.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCikis.Location = new System.Drawing.Point(12, 456);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(102, 75);
            this.btnCikis.TabIndex = 1;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnSatis
            // 
            this.btnSatis.Image = ((System.Drawing.Image)(resources.GetObject("btnSatis.Image")));
            this.btnSatis.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSatis.Location = new System.Drawing.Point(12, 384);
            this.btnSatis.Name = "btnSatis";
            this.btnSatis.Size = new System.Drawing.Size(102, 66);
            this.btnSatis.TabIndex = 1;
            this.btnSatis.Text = "Satış";
            this.btnSatis.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSatis.UseVisualStyleBackColor = true;
            this.btnSatis.Click += new System.EventHandler(this.btnSatis_Click);
            // 
            // btnSözlesme
            // 
            this.btnSözlesme.Image = ((System.Drawing.Image)(resources.GetObject("btnSözlesme.Image")));
            this.btnSözlesme.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSözlesme.Location = new System.Drawing.Point(12, 311);
            this.btnSözlesme.Name = "btnSözlesme";
            this.btnSözlesme.Size = new System.Drawing.Size(102, 67);
            this.btnSözlesme.TabIndex = 1;
            this.btnSözlesme.Text = "Sözleşme";
            this.btnSözlesme.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSözlesme.UseVisualStyleBackColor = true;
            this.btnSözlesme.Click += new System.EventHandler(this.btnSözlesme_Click);
            // 
            // Anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(896, 533);
            this.Controls.Add(this.btnSözlesme);
            this.Controls.Add(this.btnSatis);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnMusteriListele);
            this.Controls.Add(this.btnAracListele);
            this.Controls.Add(this.btnAracEkle);
            this.Controls.Add(this.btnMusteriEkle);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Anasayfa";
            this.Text = "Anasayfa";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnMusteriEkle;
        private System.Windows.Forms.Button btnAracEkle;
        private System.Windows.Forms.Button btnAracListele;
        private System.Windows.Forms.Button btnMusteriListele;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnSatis;
        private System.Windows.Forms.Button btnSözlesme;
    }
}

