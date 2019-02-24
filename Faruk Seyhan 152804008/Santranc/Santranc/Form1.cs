using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Santranc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int ButonAdi = 0,sayac=0;
        private void btnOlustur_Click(object sender, EventArgs e)
        {
            if (cmbBuyukluk.Text!="")
            {
                flowLayoutPanel1.Controls.Clear();
                int kare = Convert.ToInt16(cmbBuyukluk.Text);
                flowLayoutPanel1.Width = kare * 30;
                flowLayoutPanel1.Height = kare * 30;
                for (int i = 0; i < kare; i++)
                {
                    for (int j = 0; j < kare; j++)
                    {
                        ButonEkle(new Point(i, j));
                    }
                }
            }
            else
            {
                MessageBox.Show("Büyüklük değerini giriniz.");
            }
        }
        public void ButonEkle(Point loc)
        {
            //Dinamik buton oluştur.
            sayac = 0;
            Button btn = new Button();
            btn.BackColor = Color.White;
            btn.Size = new Size(30, 30);
            flowLayoutPanel1.Controls.Add(btn);
            btn.Margin = new Padding(0);
            btn.Location = loc;
            btn.Name = ButonAdi.ToString();
            btn.Click += Btn_Click;
            ButonAdi++;
        }
        private void Btn_Click(object sender, EventArgs e)
        {
            sayac++;
            int kare = Convert.ToInt16(cmbBuyukluk.Text);
            int a = -1, b = -1, c = -1, d = -1;
            Button btn = (sender as Button);
            btn.Text = sayac.ToString();
            for (int i = 0; i < kare*kare; i++)
            {
                if (flowLayoutPanel1.Controls[i].Name == btn.Name)
                {
                    if (i > (kare + kare - 1) && i % kare < kare - 1 && flowLayoutPanel1.Controls[i - (kare + kare - 1)].Text == "")//2 üst 1 sağ
                    {
                        flowLayoutPanel1.Controls[i - (kare + kare - 1)].BackColor = Color.Green;
                        flowLayoutPanel1.Controls[i - (kare + kare - 1)].Enabled = true;
                    }
                    if (i > (kare + kare - 1) && i % kare > 0 && flowLayoutPanel1.Controls[i - (kare + kare + 1)].Text == "")//2üst 1 sol
                    {
                        flowLayoutPanel1.Controls[i - (kare + kare + 1)].BackColor = Color.Green;
                        flowLayoutPanel1.Controls[i - (kare + kare + 1)].Enabled = true;
                    }
                    if (i > (kare - 1) && i % kare < kare - 2 && flowLayoutPanel1.Controls[i - (kare - 2)].Text == "")//1 üst 2 sağ
                    {
                        flowLayoutPanel1.Controls[i - (kare - 2)].BackColor = Color.Green;
                        flowLayoutPanel1.Controls[i - (kare - 2)].Enabled = true;
                    }
                    if (i > (kare - 1) && i % kare > 1 && flowLayoutPanel1.Controls[i - (kare + 2)].Text == "")//1 üst 2 sol
                    {
                        flowLayoutPanel1.Controls[i - (kare + 2)].BackColor = Color.Green;
                        flowLayoutPanel1.Controls[i - (kare + 2)].Enabled = true;
                    }
                    if (i < (kare*kare - (kare * 2)) && i % kare > 0 && flowLayoutPanel1.Controls[i + (kare + kare - 1)].Text == "")//2 alt 1 sol
                    {
                        flowLayoutPanel1.Controls[i + kare + kare - 1].BackColor = Color.Green;
                        flowLayoutPanel1.Controls[i + kare + kare - 1].Enabled = true;
                        a = i + kare + kare - 1;
                    }
                    if (i < (kare * kare - (kare * 2)) && i % kare < kare-1 && flowLayoutPanel1.Controls[i + (kare + kare + 1)].Text == "")//2 alt 1 sağ
                    {
                        flowLayoutPanel1.Controls[i + kare + kare + 1].BackColor = Color.Green;
                        flowLayoutPanel1.Controls[i + kare + kare + 1].Enabled = true;
                        b = i + kare + kare + 1;
                    }
                    if (i < (kare * kare - kare) && i % kare > 1 && flowLayoutPanel1.Controls[i + (kare - 2)].Text == "")//1 alt 2 sol
                    {
                        flowLayoutPanel1.Controls[i + kare - 2].BackColor = Color.Green;
                        flowLayoutPanel1.Controls[i + kare - 2].Enabled = true;
                        c = i + kare - 2;
                    }
                    if (i < (kare * kare - kare) && i % kare < kare-2 && flowLayoutPanel1.Controls[i + kare + 2].Text == "")//1 alt 2 sağ
                    {
                        flowLayoutPanel1.Controls[i + kare + 2].BackColor = Color.Green;
                        flowLayoutPanel1.Controls[i + kare + 2].Enabled = true;
                        d = i + kare + 2;
                    }
                    if (i==kare*kare)
                    {
                        MessageBox.Show("Oyun Bitti!");
                    }
                }
                if (i != a && i != b && i != c && i != d)
                {
                    flowLayoutPanel1.Controls[i].Enabled = false;
                    flowLayoutPanel1.Controls[i].BackColor = Color.White;
                }
            }
            int s = 0, kazandin = 0; ;
            for (int i = 0; i < kare * kare; i++)
            {
                if (flowLayoutPanel1.Controls[i].BackColor != Color.Green)
                {
                    s++;
                }
                if (s==kare*kare)
                {
                    MessageBox.Show("Kaybettin!");
                }
                if (flowLayoutPanel1.Controls[i].Text != "")
                {
                    kazandin++;
                }
                if (kazandin==kare*kare)
                {
                    MessageBox.Show("Tebrikler Kazandınız!");
                }
            }
            for (int i = 0; i < kare*kare; i++)
            {
                if (flowLayoutPanel1.Controls[i].Text != "")
                {
                    flowLayoutPanel1.Controls[i].BackColor = Color.Orange;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
