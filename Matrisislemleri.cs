using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrisler
{
    static class Matrisislemleri
    {
        public static float[,] Toplama(float[,] a, float[,] b, int boyut)
        {

            float[,] toplam = new float[boyut, boyut];
            for (int i = 0; i < boyut; i++)
            {
                for (int j = 0; j < boyut; j++)
                {
                    toplam[i,j] = a[i,j] + b[i,j];
                }
            }
            return toplam;
        }
        public static float[,] Carpma(float [,] a,float[,] b,int boyut)
        {
            float[,] carpim = new float[boyut, boyut];
            for (int i = 0; i < boyut; i++)
            {
                for (int j = 0; j < boyut; j++)
                {
                    for (int k = 0; k < boyut; k++)
                    {
                        carpim[i, j] += a[i, k] * b[k, j];
                    }
                }
            }
            return carpim;
        }
        public static int Yazma(float[,] a,float boyut)
        {
            using (System.IO.StreamWriter dosya = new System.IO.StreamWriter("ISLEMLER.txt", true))
            {
                dosya.WriteLine("Girilen Matris:");
                for (int i = 0; i < boyut; i++)
                {
                    for (int j = 0; j < boyut; j++)
                    {
                        dosya.Write(a[i, j] + " ");
                    }
                    dosya.WriteLine();
                }
                
            }
            return 1;
        }
        public static string[] Goster()
        {
            string dosyayolu = "ISLEMLER.txt";
            string[] metin = System.IO.File.ReadAllLines(dosyayolu);
            return metin;
        }
        public static float[,] Tersinial(float[,] b,int boyut)
        {
            float[,] birim = new float[boyut, boyut];
            float[,] a = b;
            for (int i = 0; i < boyut; i++)
            {
                for (int j = 0; j < boyut; j++)
                {
                    if (i == j)
                    {
                        birim[i, j] = 1;
                    }
                    else
                    {
                        birim[i, j] = 0;
                    }
                }

            }
            float y = 0, k = 0;
            for (int i = 0; i < boyut; i++)
            {
                y = a[i, i];
                for (int j = 0; j < boyut; j++)
                {
                    a[i, j] = a[i, j] / y;
                    birim[i, j] = birim[i, j] / y;
                }
                for (int q = 0; q < boyut; q++)
                {
                    if (q != i)
                    {
                        k = a[q, i];
                        for (int j = 0; j < boyut; j++)
                        {
                            a[q, j] = a[q, j] - (a[i, j] * k);
                            birim[q, j] = birim[q, j] - (birim[i, j] * k);
                        }
                    }
                }
            }
            return birim;
            
            
        }
        public static float Izinibul(float[,] a,int boyut)
        {
            float sonuc=0, asal = 0, yedek = 0;
            for(int i = 0; i < boyut; i++)
            {
                for(int j = 0; j < boyut; j++)
                {
                    if (i == j)
                    {
                        asal += a[i, j];
                    }
                    else if (i + j +1== boyut)
                    {
                        yedek += a[i, j];
                    }
                }
                
            sonuc = asal +yedek;
            }
            
            
            return sonuc;

        }
        public static float[,] Transpoz(float[,] a,int boyut)
        {
            float[,] transpoz = new float[boyut, boyut];
            for(int i = 0; i < boyut; i++)
            {
                for(int j = 0; j < boyut; j++)
                {
                    transpoz[i, j] = a[j, i];
                }
            }
            
            return transpoz;
        }
    
    
    
    
    }
}
