using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMHESAPMAKINASI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*islem yapabilmek icin double adinda ve string olarak degisken olusturduk*/
        double ilksayi;
        string islem;
        /*textboxta ki deger 0 yada 1 ise veya bos ise butondaki deger gosterilecek*/
        private void button1_Click(object sender, EventArgs e)
        {
            /*ekrandaki rakam olarak sıfır yazılacak ve bos ise 1 degeri yazılabilir*/
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "1";
            }
            else
            {
                /*butandan gelen degeri tekrardan metin olarak ekrana gosterdik*/
                textBox1.Text = textBox1.Text + "1";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text = textBox1.Text + "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text = textBox1.Text + "3";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text = textBox1.Text + "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text = textBox1.Text + "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text = textBox1.Text + "6";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text = textBox1.Text + "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text = textBox1.Text + "8";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text = textBox1.Text + "9";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text = textBox1.Text + "0";
            }
        }
        /*timer kullanma sebebi daha duzgu olmasi ve textboxta sayilar ne kadar cok
         girilirse o kadar sekil alip duzene devam edecektir*/
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (textBox1.TextLength==7)
            {
                textBox1.Font = new Font("Microsoft Sans Serif", 30);
            }
            else if (textBox1.TextLength==14)
            {
                textBox1.Font = new Font("Microsoft Sans Serif", 15);
            }
            /*buradaki 1 sayisi textboxtaki girilen sayilarin silindigi anda 
             textboxin eski haline getirmeye yarar*/
            else if (textBox1.TextLength==1)
            {
                textBox1.Font = new Font("Microsoft Sans Serif", 37);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*form uzerinden timer kodunu calistirdik*/
            timer1.Start();
        }
        /*+ sembolune basıldıgı zaman yazpacak oldugu islem kodlaridir girilen sayiyi
         donusturup ekranda gostermis olduk*/
        private void btnarti_Click(object sender, EventArgs e)
        {
            ilksayi = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            islem = "+";
        }

        private void btneksi_Click(object sender, EventArgs e)
        {
            ilksayi = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            islem = "-";
        }

        private void btncarp_Click(object sender, EventArgs e)
        {
            ilksayi = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            islem = "*";
        }

        private void btnbolme_Click(object sender, EventArgs e)
        {
            ilksayi = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            islem = "/";
        }
        /*yapılan butun islemleri temizlememize yarar*/
        private void btnclear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }
        /*ilk basta alinan degeri tutup ardindan ikinci sayiyi girmek icin
         olusturdugumuz kod yapısı ilk ve ikinci sayilari islem yapmaya tabi tuttuk*/
        private void btnesit_Click(object sender, EventArgs e)
        {
            double ikincisayi = Convert.ToDouble(textBox1.Text);
            double sonuc;
            if (islem=="+")
            {
                sonuc = ilksayi + ikincisayi;
                textBox1.Text = Convert.ToString(sonuc);
                ilksayi = sonuc;
            }
            if (islem == "-")
            {
                sonuc = ilksayi - ikincisayi;
                textBox1.Text = Convert.ToString(sonuc);
                ilksayi = sonuc;
            }
            if (islem == "*")
            {
                sonuc = ilksayi * ikincisayi;
                textBox1.Text = Convert.ToString(sonuc);
                ilksayi = sonuc;
            }
            if (islem == "/")
            {
                if (ikincisayi==0)
                {
                    textBox1.Text = "Hata";
                }
                else
                {
                    sonuc = ilksayi / ikincisayi;
                    textBox1.Text = Convert.ToString(sonuc);
                    ilksayi = sonuc;
                }
                
            }
        }
        /*virgullu islem yaptırmaya yarar*/
        private void btnvirgul_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ",";
        }
    }
}
