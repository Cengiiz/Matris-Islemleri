using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matrisler
{
    public partial class Form1                                                                                                                                                                                                                                           : Form
    {
        public Form1()
        {
            InitializeComponent();
            using (System.IO.StreamWriter dosya = new System.IO.StreamWriter("ISLEMLER.txt"))
            {

            }
        }
        float[,] matrisa;
        float[,] matrisb;
        int boyutt;
        private void toplama_Click(object sender, EventArgs e)
        {
            amatrisi.Text = "1.Matrisi Gir";
            bmatrisi.Text = "2.Matrisi Gir";
            label2.Visible = true;
            boyut.Visible = true;
            amatrisi.Visible = true;
            bmatrisi.Visible = true;
            islem.Text = "TOPLAMA:";
            islem.Visible = true;
            topla.Visible = true;
            carp.Visible = false;
            yazdir.Visible = false;
            oku.Visible = false;
            tersinial.Visible = false;
            izibul.Visible = false;
            transpoz.Visible = false;
            pictureBox2.Visible = false;
            gosterge.Visible = false;
        }

        private void amatrisi_Click(object sender, EventArgs e)
        {
            boyutt = int.Parse(boyut.Text);
            matrisa = new float[boyutt, boyutt];

            for (int i = 0; i < boyutt; i++)
            {
                for (int j = 0; j < boyutt; j++)
                {
                    matrisa[i, j] = int.Parse(Microsoft.VisualBasic.Interaction.InputBox((i + 1) + ". Satir" + (j + 1) + ". Sutuna sayi giriniz", "1. Matrisi olusturma", "", 40, 40));
                }
            }
        }

        private void bmatrisi_Click(object sender, EventArgs e)
        {
            boyutt = int.Parse(boyut.Text);

            matrisb = new float[boyutt, boyutt];
            for (int i = 0; i < boyutt; i++)
            {
                for (int j = 0; j < boyutt; j++)
                {
                    matrisb[i, j] = int.Parse(Microsoft.VisualBasic.Interaction.InputBox((i + 1) + ". Satir" + (j + 1) + ". Sutuna sayi giriniz", "2. Matrisi olusturma", "", 40, 40));
                }
            }
        }

        private void topla_Click(object sender, EventArgs e)
        {
            float[,] sonuc = new float[boyutt, boyutt];
            sonuc = Matrisislemleri.Toplama(matrisa, matrisb, boyutt);

            using (System.IO.StreamWriter dosya = new System.IO.StreamWriter("ISLEMLER.txt", true))
            {
                dosya.WriteLine("1.Matris:");
                for (int i = 0; i < boyutt; i++)
                {
                    for (int j = 0; j < boyutt; j++)
                    {
                        dosya.Write(matrisa[i, j] + " ");
                    }
                    dosya.WriteLine();
                }
                dosya.WriteLine("2.matris:");
                for (int i = 0; i < boyutt; i++)
                {
                    for (int j = 0; j < boyutt; j++)
                    {
                        dosya.Write(matrisb[i, j] + " ");
                    }
                    dosya.WriteLine();
                }
                dosya.WriteLine("Toplam:");
                for (int i = 0; i < boyutt; i++)
                {
                    for (int j = 0; j < boyutt; j++)
                    {
                        dosya.Write(sonuc[i, j] + " ");
                    }
                    dosya.WriteLine();
                }
            }
         MessageBox.Show("Islem basariyla txt dosyasina kaydedildi", "Matris Islemleri");


        }

        private void carpma_Click(object sender, EventArgs e)
        {
            amatrisi.Text = "1.Matrisi Gir";
            bmatrisi.Text = "2.Matrisi Gir";
            label2.Visible = true;
            boyut.Visible = true;
            amatrisi.Visible = true;
            bmatrisi.Visible = true;
            islem.Text = "CARPMA:";
            islem.Visible = true;
            topla.Visible = false;
            carp.Visible = true;
            yazdir.Visible = false;
            oku.Visible = false;
            tersinial.Visible = false;
            izibul.Visible = false;
            transpoz.Visible = false;
            pictureBox2.Visible = false;
            gosterge.Visible = false;
        }

        private void carp_Click(object sender, EventArgs e)
        {
            float[,] sonuc = new float[boyutt, boyutt];
            sonuc = Matrisislemleri.Carpma(matrisa, matrisb, boyutt);


            using (System.IO.StreamWriter dosya = new System.IO.StreamWriter("ISLEMLER.txt", true))
            {
                dosya.WriteLine("1.Matris:");
                for (int i = 0; i < boyutt; i++)
                {
                    for (int j = 0; j < boyutt; j++)
                    {
                        dosya.Write(matrisa[i, j] + " ");
                    }
                    dosya.WriteLine();
                }
                dosya.WriteLine("2.matris:");
                for (int i = 0; i < boyutt; i++)
                {
                    for (int j = 0; j < boyutt; j++)
                    {
                        dosya.Write(matrisb[i, j] + " ");
                    }
                    dosya.WriteLine();
                }
                dosya.WriteLine("Carpma:");
                for (int i = 0; i < boyutt; i++)
                {
                    for (int j = 0; j < boyutt; j++)
                    {
                        dosya.Write(sonuc[i, j] + " ");
                    }
                    dosya.WriteLine();
                }
            }
            MessageBox.Show("Islem basariyla txt dosyasina kaydedildi", "Matris Islemleri");


        }

        private void yazdirma_Click(object sender, EventArgs e)
        {
            amatrisi.Text = "Matrisi Gir";
            label2.Visible = true;
            boyut.Visible = true;
            amatrisi.Visible = true;
            bmatrisi.Visible = false;
            islem.Text = "Txt dosyasina kaydet:";
            islem.Visible = true;
            topla.Visible = false;
            carp.Visible = false;
            yazdir.Visible = true;
            oku.Visible = false;
            tersinial.Visible = false;
            izibul.Visible = false;
            transpoz.Visible = false;
            pictureBox2.Visible = false;
            gosterge.Visible = false;

        }

        private void yazdir_Click(object sender, EventArgs e)
        {
            int sonuc = Matrisislemleri.Yazma(matrisa, boyutt);
            if (sonuc == 1)
            {
                MessageBox.Show("Basariyla kaydedildi", "Matris Kaydetme");
            }

        }

        private void okuma_Click(object sender, EventArgs e)
        {
            amatrisi.Text = "Txt Dosyasini goster";
            label2.Visible = false;
            boyut.Visible = false;
            amatrisi.Visible = false;
            bmatrisi.Visible = false;
            islem.Text = "Txt dosyasina kaydet:";
            islem.Visible = false;
            topla.Visible = false;
            carp.Visible = false;
            yazdir.Visible = false;
            oku.Visible = true;
            tersinial.Visible = false;
            izibul.Visible = false;
            transpoz.Visible = false;
            gosterge.Visible = true;
            pictureBox2.Visible = true;
        }

        private void oku_Click(object sender, EventArgs e)
        {
           
            string[] metin=Matrisislemleri.Goster();
            int uzunluk = metin.Length;
            for(int i = 0; i < uzunluk; i++)
            {
                gosterge.Text = gosterge.Text + metin[i];
                gosterge.Text = gosterge.Text + "\r\n";
            }

        }

        private void izibulma_Click(object sender, EventArgs e)
        {
            amatrisi.Text = "Matrisi Gir";
            label2.Visible = true;
            boyut.Visible = true;
            amatrisi.Visible = true;
            bmatrisi.Visible = false;
            islem.Text = "Izi bulma islemi:";
            islem.Visible = true;
            topla.Visible = false;
            carp.Visible = false;
            yazdir.Visible = false;
            oku.Visible = false;
            tersinial.Visible = false;
            izibul.Visible = true;
            transpoz.Visible = false;
            pictureBox2.Visible = false;
            gosterge.Visible = false;

        }

        private void izibul_Click(object sender, EventArgs e)
        {
            using (System.IO.StreamWriter dosya = new System.IO.StreamWriter("ISLEMLER.txt", true))
            {
                float sonuc = Matrisislemleri.Izinibul(matrisa, boyutt);
                
                dosya.WriteLine("Izi bulunan Matris:");
                for (int i = 0; i < boyutt; i++)
                {
                    for (int j = 0; j < boyutt; j++)
                    {
                        dosya.Write(matrisa[i, j] + " ");
                    }
                    dosya.WriteLine();
                }
                dosya.WriteLine("Sonuc:"+sonuc);  
            }
            MessageBox.Show("Islem basariyla txt dosyasina kaydedildi", "Matris Islemleri");
        }

        private void tersi_Click(object sender, EventArgs e)
        {
            amatrisi.Text = "Matrisi Gir";
            label2.Visible = true;
            boyut.Visible = true;
            amatrisi.Visible = true;
            bmatrisi.Visible = false;
            islem.Text = "Tersini al :";
            islem.Visible = true;
            topla.Visible = false;
            carp.Visible = false;
            yazdir.Visible = false;
            oku.Visible = false;
            tersinial.Visible = true;
            izibul.Visible = false;
            transpoz.Visible = false;
            pictureBox2.Visible = false;
            gosterge.Visible = false;

        }
       
        private void tersinial_Click(object sender, EventArgs e)
        {
            using (System.IO.StreamWriter dosya = new System.IO.StreamWriter("ISLEMLER.txt", true))
            {
                float[,] birim = new float[boyutt, boyutt];
                dosya.WriteLine("Tersi alinan Matris:");
                for (int i = 0; i < boyutt; i++)
                {
                    for (int j = 0; j < boyutt; j++)
                    {
                        dosya.Write(matrisa[i, j] + " ");
                    }
                    dosya.WriteLine();
                }
                birim = Matrisislemleri.Tersinial(matrisa, boyutt);
                dosya.WriteLine("Sonuc matrisi:");
                for (int i = 0; i < boyutt; i++)
                {
                    for (int j = 0; j < boyutt; j++)
                    {
                        dosya.Write(birim[i, j] + "       ");
                    }
                    dosya.WriteLine();
                }
            }
            MessageBox.Show("Islem basariyla txt dosyasina kaydedildi", "Matris Islemleri");
        }

        private void transpozz_Click(object sender, EventArgs e)
        {
            amatrisi.Text = "Matrisi Gir";
            label2.Visible = true;
            boyut.Visible = true;
            amatrisi.Visible = true;
            bmatrisi.Visible = false;
            islem.Text = "Transpoz islemi:";
            islem.Visible = true;
            topla.Visible = false;
            carp.Visible = false;
            yazdir.Visible = false;
            oku.Visible = false;
            tersinial.Visible = false;
            izibul.Visible = false;
            transpoz.Visible = true;
            pictureBox2.Visible = false;
            gosterge.Visible = false;


        }

        private void transpoz_Click(object sender, EventArgs e)
        {
            float[,] transpoz = Matrisislemleri.Transpoz(matrisa, boyutt);
            using (System.IO.StreamWriter dosya = new System.IO.StreamWriter("ISLEMLER.txt", true))
            {
                dosya.WriteLine(" Transpozesi hesaplanan Matris:");
                for (int i = 0; i < boyutt; i++)
                {
                    for (int j = 0; j < boyutt; j++)
                    {
                        dosya.Write(matrisa[i, j] + " ");
                    }
                    dosya.WriteLine();
                }
                dosya.WriteLine("Matris transpoze :");
                for (int i = 0; i < boyutt; i++)
                {
                    for (int j = 0; j < boyutt; j++)
                    {
                        dosya.Write(transpoz[i, j] + "       ");
                    }
                    dosya.WriteLine();
                }


            }
            MessageBox.Show("Islem basariyla txt dosyasina kaydedildi", "Matris Islemleri");
        }
    }
}

