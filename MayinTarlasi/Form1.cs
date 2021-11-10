using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MayinTarlasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Button> btnlar = new List<Button>();
        Random rnd = new Random();
        int skor=0;
        private void Form1_Load(object sender, EventArgs e)
        {
            TamDoldur();
        }
        void TamDoldur()
        {
            lblScore.Text = skor.ToString();
            Doldur();
            MayinAta();
        }
        void Doldur()
        {
            for (int i = 0; i < 100; i++)
            {
                Button btn = new Button();
                btn.Height = 20;
                btn.Width = 20;
                btn.Name = i.ToString();
                btn.Tag = 0;
                btnlar.Add(btn);
                btn.Click += Btn_Click;
                flpMayinAlani.Controls.Add(btn);
            }
        }
        void MayinAta()
        {
            int mayinSayisi = 0;

            while (mayinSayisi < 20)
            {
                int sayi = rnd.Next(0, 100);
                foreach (Button b in btnlar)
                {
                    if (b.Name == sayi.ToString())
                    {
                        b.Tag = 1;
                        mayinSayisi++;
                    }
                }

                //if ((int)btnlar[sayi].Tag == 0)
                //{
                //    btnlar[sayi].Tag = 1;
                //    mayinSayisi++;
                //}
            }
        }
        void Temizle()
        {
            flpMayinAlani.Controls.Clear();
            skor = 0;
            lblScore.Text = skor.ToString();
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if ((int)btn.Tag == 1)
            {
                btn.BackColor = Color.Red;
                MessageBox.Show("Oyun bitti skorunuz:" + skor);
                skor = 0;
                lblScore.Text = skor.ToString();
                OyunEngelle();
            }
            else
            {
                btn.BackColor = Color.Green;
                skor += 10;
                lblScore.Text = skor.ToString();
            }
        }
        void OyunEngelle()
        {
            foreach (Button item in flpMayinAlani.Controls)
            {
                item.Enabled = false;
            }
        }

        private void btnYeniOyun_Click(object sender, EventArgs e)
        {
            Temizle();
            TamDoldur();
        }
    }
}
