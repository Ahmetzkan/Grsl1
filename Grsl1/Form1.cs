using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grsl1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double boy, kilo, sonuc;
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Boş bırakmayınız!");
            }
            else
            {


                boy = double.Parse(textBox1.Text);
                kilo = Convert.ToDouble(textBox2.Text);
                boy = boy / 100;
                sonuc = kilo / (boy * boy);

                label8.Text = sonuc.ToString();



                if (radioButton1.Checked == true)
                {

                    if (sonuc < 18)
                    {
                        label9.Text = "Zayıfsınız, " + "normal kilonuza dönmeniz tavsiye edilir.";
                        pictureBox1.Image = Image.FromFile("C:\\Users\\A\\source\\repos\\Görsel Programlama 1\\Görsel Programlama 1\\zayıf.png");
                    }

                    else if (sonuc >= 18 && sonuc < 25)
                    {
                        label9.Text = "Normal kilodasınız, " + "kilonuzu korumanız tavsiye edilir.";
                        pictureBox1.Image = Image.FromFile("C:\\Users\\A\\source\\repos\\Görsel Programlama 1\\Görsel Programlama 1\\normal.png");
                    }

                    else if (sonuc >= 25 && sonuc < 30)
                    {
                        label9.Text = "Tombiksiniz, " + "kilo vermeniz tavsiye edilir.";
                        pictureBox1.Image = Image.FromFile("C:\\Users\\A\\source\\repos\\Görsel Programlama 1\\Görsel Programlama 1\\tombik.jpg");
                    }

                    else if (sonuc >= 30)
                    {
                        label9.Text = "Fazla tombiksiniz, " + "kilo vermeniz tavsiye edilir.";
                        pictureBox1.Image = Image.FromFile("C:\\Users\\A\\source\\repos\\Görsel Programlama 1\\Görsel Programlama 1\\tombik.jpg");
                    }

                }

                //Değerler farklı olması adına Kadınların kilo değer sonuçlarını 5 puan alttan başlattım.

                else if (radioButton2.Checked == true)
                {
                    if (sonuc < 15)
                    {
                        label9.Text = "Zayıfsınız, " + "normal kilonuza dönmeniz tavsiye edilir.";
                        pictureBox1.Image = Image.FromFile("C:\\Users\\A\\source\\repos\\Görsel Programlama 1\\Görsel Programlama 1\\zayıfk.png");
                    }

                    else if (sonuc >= 15 && sonuc < 20)
                    {
                        label9.Text = "Normal kilodasınız, " + "kilonuzu korumanız tavsiye edilir.";
                        pictureBox1.Image = Image.FromFile("C:\\Users\\A\\source\\repos\\Görsel Programlama 1\\Görsel Programlama 1\\normal.png");
                    }

                    else if (sonuc >= 20 && sonuc < 25)
                    {
                        label9.Text = "Tombiksiniz, " + "kilo vermeniz tavsiye edilir.";
                        pictureBox1.Image = Image.FromFile("C:\\Users\\A\\source\\repos\\Görsel Programlama 1\\Görsel Programlama 1\\tombik.jpg");
                    }

                    else if (sonuc >= 25)
                    {
                        label9.Text = "Fazla tombiksiniz, " + "kilo vermeniz tavsiye edilir.";
                        pictureBox1.Image = Image.FromFile("C:\\Users\\A\\source\\repos\\Görsel Programlama 1\\Görsel Programlama 1\\tombik.jpg");
                    }
                }


            }
        }
    }
}
