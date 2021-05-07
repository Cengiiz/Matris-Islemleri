
namespace Matrisler
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.amatrisi = new System.Windows.Forms.Button();
            this.bmatrisi = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.boyut = new System.Windows.Forms.TextBox();
            this.tersi = new System.Windows.Forms.Button();
            this.yazdirma = new System.Windows.Forms.Button();
            this.transpozz = new System.Windows.Forms.Button();
            this.okuma = new System.Windows.Forms.Button();
            this.carpma = new System.Windows.Forms.Button();
            this.izibulma = new System.Windows.Forms.Button();
            this.gosterge = new System.Windows.Forms.RichTextBox();
            this.toplama = new System.Windows.Forms.Button();
            this.islem = new System.Windows.Forms.Label();
            this.yazdir = new System.Windows.Forms.Button();
            this.oku = new System.Windows.Forms.Button();
            this.carp = new System.Windows.Forms.Button();
            this.topla = new System.Windows.Forms.Button();
            this.transpoz = new System.Windows.Forms.Button();
            this.izibul = new System.Windows.Forms.Button();
            this.tersinial = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(369, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(388, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "MATRIS ISLEMLERI";
            // 
            // amatrisi
            // 
            this.amatrisi.BackColor = System.Drawing.Color.Chartreuse;
            this.amatrisi.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.amatrisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.amatrisi.ForeColor = System.Drawing.SystemColors.Desktop;
            this.amatrisi.Location = new System.Drawing.Point(908, 108);
            this.amatrisi.Name = "amatrisi";
            this.amatrisi.Size = new System.Drawing.Size(124, 70);
            this.amatrisi.TabIndex = 1;
            this.amatrisi.Text = "1. Matrisi giriniz";
            this.amatrisi.UseVisualStyleBackColor = false;
            this.amatrisi.Visible = false;
            this.amatrisi.Click += new System.EventHandler(this.amatrisi_Click);
            // 
            // bmatrisi
            // 
            this.bmatrisi.BackColor = System.Drawing.Color.Chartreuse;
            this.bmatrisi.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.bmatrisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bmatrisi.ForeColor = System.Drawing.SystemColors.Desktop;
            this.bmatrisi.Location = new System.Drawing.Point(1042, 108);
            this.bmatrisi.Name = "bmatrisi";
            this.bmatrisi.Size = new System.Drawing.Size(124, 70);
            this.bmatrisi.TabIndex = 2;
            this.bmatrisi.Text = "1. Matrisi giriniz";
            this.bmatrisi.UseVisualStyleBackColor = false;
            this.bmatrisi.Visible = false;
            this.bmatrisi.Click += new System.EventHandler(this.bmatrisi_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(702, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(293, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "Matris boyutunu giriniz:";
            this.label2.Visible = false;
            // 
            // boyut
            // 
            this.boyut.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.boyut.Location = new System.Drawing.Point(1001, 77);
            this.boyut.Multiline = true;
            this.boyut.Name = "boyut";
            this.boyut.Size = new System.Drawing.Size(42, 31);
            this.boyut.TabIndex = 5;
            this.boyut.Visible = false;
            // 
            // tersi
            // 
            this.tersi.BackColor = System.Drawing.Color.Aquamarine;
            this.tersi.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.tersi.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tersi.ForeColor = System.Drawing.SystemColors.Desktop;
            this.tersi.Location = new System.Drawing.Point(73, 143);
            this.tersi.Name = "tersi";
            this.tersi.Size = new System.Drawing.Size(124, 70);
            this.tersi.TabIndex = 8;
            this.tersi.Text = "Matris tersi alma ";
            this.tersi.UseVisualStyleBackColor = false;
            this.tersi.Click += new System.EventHandler(this.tersi_Click);
            // 
            // yazdirma
            // 
            this.yazdirma.BackColor = System.Drawing.Color.Aquamarine;
            this.yazdirma.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.yazdirma.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yazdirma.ForeColor = System.Drawing.SystemColors.Desktop;
            this.yazdirma.Location = new System.Drawing.Point(12, 67);
            this.yazdirma.Name = "yazdirma";
            this.yazdirma.Size = new System.Drawing.Size(124, 70);
            this.yazdirma.TabIndex = 6;
            this.yazdirma.Text = "Matris yazdırma ";
            this.yazdirma.UseVisualStyleBackColor = false;
            this.yazdirma.Click += new System.EventHandler(this.yazdirma_Click);
            // 
            // transpozz
            // 
            this.transpozz.BackColor = System.Drawing.Color.Aquamarine;
            this.transpozz.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.transpozz.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.transpozz.ForeColor = System.Drawing.SystemColors.Desktop;
            this.transpozz.Location = new System.Drawing.Point(333, 143);
            this.transpozz.Name = "transpozz";
            this.transpozz.Size = new System.Drawing.Size(124, 70);
            this.transpozz.TabIndex = 11;
            this.transpozz.Text = "Matris transpoze ";
            this.transpozz.UseVisualStyleBackColor = false;
            this.transpozz.Click += new System.EventHandler(this.transpozz_Click);
            // 
            // okuma
            // 
            this.okuma.BackColor = System.Drawing.Color.Aquamarine;
            this.okuma.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.okuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.okuma.ForeColor = System.Drawing.SystemColors.Desktop;
            this.okuma.Location = new System.Drawing.Point(142, 67);
            this.okuma.Name = "okuma";
            this.okuma.Size = new System.Drawing.Size(124, 70);
            this.okuma.TabIndex = 10;
            this.okuma.Text = "Matris okuma ";
            this.okuma.UseVisualStyleBackColor = false;
            this.okuma.Click += new System.EventHandler(this.okuma_Click);
            // 
            // carpma
            // 
            this.carpma.BackColor = System.Drawing.Color.Aquamarine;
            this.carpma.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.carpma.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.carpma.ForeColor = System.Drawing.SystemColors.Desktop;
            this.carpma.Location = new System.Drawing.Point(403, 67);
            this.carpma.Name = "carpma";
            this.carpma.Size = new System.Drawing.Size(124, 70);
            this.carpma.TabIndex = 9;
            this.carpma.Text = "Matris çarpma ";
            this.carpma.UseVisualStyleBackColor = false;
            this.carpma.Click += new System.EventHandler(this.carpma_Click);
            // 
            // izibulma
            // 
            this.izibulma.BackColor = System.Drawing.Color.Aquamarine;
            this.izibulma.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.izibulma.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.izibulma.ForeColor = System.Drawing.SystemColors.Desktop;
            this.izibulma.Location = new System.Drawing.Point(203, 143);
            this.izibulma.Name = "izibulma";
            this.izibulma.Size = new System.Drawing.Size(124, 70);
            this.izibulma.TabIndex = 12;
            this.izibulma.Text = "Matris izi bulma ";
            this.izibulma.UseVisualStyleBackColor = false;
            this.izibulma.Click += new System.EventHandler(this.izibulma_Click);
            // 
            // gosterge
            // 
            this.gosterge.Location = new System.Drawing.Point(10, 305);
            this.gosterge.Name = "gosterge";
            this.gosterge.Size = new System.Drawing.Size(985, 310);
            this.gosterge.TabIndex = 13;
            this.gosterge.Text = "";
            this.gosterge.Visible = false;
            // 
            // toplama
            // 
            this.toplama.BackColor = System.Drawing.Color.Aquamarine;
            this.toplama.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.toplama.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toplama.ForeColor = System.Drawing.SystemColors.Desktop;
            this.toplama.Location = new System.Drawing.Point(273, 67);
            this.toplama.Name = "toplama";
            this.toplama.Size = new System.Drawing.Size(124, 70);
            this.toplama.TabIndex = 14;
            this.toplama.Text = "Matris toplama";
            this.toplama.UseVisualStyleBackColor = false;
            this.toplama.Click += new System.EventHandler(this.toplama_Click);
            // 
            // islem
            // 
            this.islem.AutoSize = true;
            this.islem.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.islem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.islem.Location = new System.Drawing.Point(578, 126);
            this.islem.Name = "islem";
            this.islem.Size = new System.Drawing.Size(77, 31);
            this.islem.TabIndex = 15;
            this.islem.Text = "islem";
            this.islem.Visible = false;
            // 
            // yazdir
            // 
            this.yazdir.BackColor = System.Drawing.Color.Aquamarine;
            this.yazdir.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.yazdir.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yazdir.ForeColor = System.Drawing.SystemColors.Desktop;
            this.yazdir.Location = new System.Drawing.Point(962, 184);
            this.yazdir.Name = "yazdir";
            this.yazdir.Size = new System.Drawing.Size(124, 70);
            this.yazdir.TabIndex = 16;
            this.yazdir.Text = "KAYDET";
            this.yazdir.UseVisualStyleBackColor = false;
            this.yazdir.Visible = false;
            this.yazdir.Click += new System.EventHandler(this.yazdir_Click);
            // 
            // oku
            // 
            this.oku.BackColor = System.Drawing.Color.Aquamarine;
            this.oku.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.oku.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.oku.ForeColor = System.Drawing.SystemColors.Desktop;
            this.oku.Location = new System.Drawing.Point(12, 229);
            this.oku.Name = "oku";
            this.oku.Size = new System.Drawing.Size(124, 70);
            this.oku.TabIndex = 17;
            this.oku.Text = "GOSTER";
            this.oku.UseVisualStyleBackColor = false;
            this.oku.Visible = false;
            this.oku.Click += new System.EventHandler(this.oku_Click);
            // 
            // carp
            // 
            this.carp.BackColor = System.Drawing.Color.Aquamarine;
            this.carp.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.carp.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.carp.ForeColor = System.Drawing.SystemColors.Desktop;
            this.carp.Location = new System.Drawing.Point(962, 184);
            this.carp.Name = "carp";
            this.carp.Size = new System.Drawing.Size(124, 70);
            this.carp.TabIndex = 19;
            this.carp.Text = "CARP";
            this.carp.UseVisualStyleBackColor = false;
            this.carp.Visible = false;
            this.carp.Click += new System.EventHandler(this.carp_Click);
            // 
            // topla
            // 
            this.topla.BackColor = System.Drawing.Color.Aquamarine;
            this.topla.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.topla.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.topla.ForeColor = System.Drawing.SystemColors.Desktop;
            this.topla.Location = new System.Drawing.Point(962, 184);
            this.topla.Name = "topla";
            this.topla.Size = new System.Drawing.Size(124, 70);
            this.topla.TabIndex = 18;
            this.topla.Text = "TOPLA";
            this.topla.UseVisualStyleBackColor = false;
            this.topla.Visible = false;
            this.topla.Click += new System.EventHandler(this.topla_Click);
            // 
            // transpoz
            // 
            this.transpoz.BackColor = System.Drawing.Color.Aquamarine;
            this.transpoz.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.transpoz.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.transpoz.ForeColor = System.Drawing.SystemColors.Desktop;
            this.transpoz.Location = new System.Drawing.Point(962, 184);
            this.transpoz.Name = "transpoz";
            this.transpoz.Size = new System.Drawing.Size(124, 70);
            this.transpoz.TabIndex = 22;
            this.transpoz.Text = "TRANSPOZ";
            this.transpoz.UseVisualStyleBackColor = false;
            this.transpoz.Visible = false;
            this.transpoz.Click += new System.EventHandler(this.transpoz_Click);
            // 
            // izibul
            // 
            this.izibul.BackColor = System.Drawing.Color.Aquamarine;
            this.izibul.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.izibul.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.izibul.ForeColor = System.Drawing.SystemColors.Desktop;
            this.izibul.Location = new System.Drawing.Point(962, 184);
            this.izibul.Name = "izibul";
            this.izibul.Size = new System.Drawing.Size(124, 70);
            this.izibul.TabIndex = 21;
            this.izibul.Text = "IZI BUL";
            this.izibul.UseVisualStyleBackColor = false;
            this.izibul.Visible = false;
            this.izibul.Click += new System.EventHandler(this.izibul_Click);
            // 
            // tersinial
            // 
            this.tersinial.BackColor = System.Drawing.Color.Aquamarine;
            this.tersinial.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.tersinial.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tersinial.ForeColor = System.Drawing.SystemColors.Desktop;
            this.tersinial.Location = new System.Drawing.Point(962, 184);
            this.tersinial.Name = "tersinial";
            this.tersinial.Size = new System.Drawing.Size(124, 70);
            this.tersinial.TabIndex = 20;
            this.tersinial.Text = "TERSINI AL";
            this.tersinial.UseVisualStyleBackColor = false;
            this.tersinial.Visible = false;
            this.tersinial.Click += new System.EventHandler(this.tersinial_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(750, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(427, 299);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(1178, 612);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.transpoz);
            this.Controls.Add(this.izibul);
            this.Controls.Add(this.tersinial);
            this.Controls.Add(this.carp);
            this.Controls.Add(this.topla);
            this.Controls.Add(this.oku);
            this.Controls.Add(this.yazdir);
            this.Controls.Add(this.islem);
            this.Controls.Add(this.toplama);
            this.Controls.Add(this.gosterge);
            this.Controls.Add(this.izibulma);
            this.Controls.Add(this.transpozz);
            this.Controls.Add(this.okuma);
            this.Controls.Add(this.carpma);
            this.Controls.Add(this.tersi);
            this.Controls.Add(this.yazdirma);
            this.Controls.Add(this.boyut);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bmatrisi);
            this.Controls.Add(this.amatrisi);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.DarkBlue;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button amatrisi;
        private System.Windows.Forms.Button bmatrisi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox boyut;
        private System.Windows.Forms.Button tersi;
        private System.Windows.Forms.Button yazdirma;
        private System.Windows.Forms.Button transpozz;
        private System.Windows.Forms.Button okuma;
        private System.Windows.Forms.Button carpma;
        private System.Windows.Forms.Button izibulma;
        private System.Windows.Forms.RichTextBox gosterge;
        private System.Windows.Forms.Button toplama;
        private System.Windows.Forms.Label islem;
        private System.Windows.Forms.Button yazdir;
        private System.Windows.Forms.Button oku;
        private System.Windows.Forms.Button carp;
        private System.Windows.Forms.Button topla;
        private System.Windows.Forms.Button transpoz;
        private System.Windows.Forms.Button izibul;
        private System.Windows.Forms.Button tersinial;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

