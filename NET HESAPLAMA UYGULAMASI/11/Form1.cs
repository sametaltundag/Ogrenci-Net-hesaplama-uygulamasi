using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button_hesapla_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Öğrenci Bilgi Girişi Kilitlendi." + "\n"+ "Doğru ve Yanlışlarınızı sol taraftan girebilirsiniz..", "BİLGİLENDİRME");
            button_yenihesap.Enabled = true;
            button_hesapla.Enabled = false;

            txtAd.Enabled = false;
            txtSoyad.Enabled = false;
            txtNo.Enabled = false;
            txtSeviye.Enabled = false;

            matDogru.Enabled = true;
            matYanlis.Enabled= true;

            turkceDogru.Enabled = true;
            turkceYanlis.Enabled = true;

            sosyalDogru.Enabled = true;
            sosyalYanlis.Enabled = true;

            fenDogru.Enabled = true;
            fenYanlis.Enabled = true;
        }

        private void button_yenihesap_Click(object sender, EventArgs e)
        {
            string ad, soyad, no, seviye;
            int matD, matY, turkceD, turkceY, sosyalD, sosyalY, fenD, fenY;
            double netMat, netTurkce, netSosyal, netFen;
            int toplamdogru, toplamyanlis, toplamnet;

            ad = txtAd.Text;
            soyad = txtSoyad.Text;
            no = txtNo.Text;
            seviye = txtSeviye.Text;

            txtAd.Focus();
            matD = Convert.ToInt16(matDogru.Text);
            matY = Convert.ToInt16(matYanlis.Text);

            turkceD = Convert.ToInt16(turkceDogru.Text);
            turkceY = Convert.ToInt16(turkceYanlis.Text);

            sosyalD = Convert.ToInt16(sosyalDogru.Text);
            sosyalY = Convert.ToInt16(sosyalYanlis.Text);

            fenD = Convert.ToInt16(fenDogru.Text);
            fenY = Convert.ToInt16(fenYanlis.Text);

            netMat = matD - (matY / 4);
            netTurkce = turkceD - (turkceY / 4);
            netSosyal = sosyalD - (sosyalY / 4);
            netFen = fenD - (fenY / 4);

            sonucMat.Text = netMat.ToString();
            sonucTurkce.Text = netTurkce.ToString();
            sonucSosyal.Text = netSosyal.ToString();
            sonucFen.Text = netFen.ToString();

            toplamdogru = matD + turkceD + sosyalD + fenD;
            toplamDogru.Text = toplamdogru.ToString();

            toplamyanlis = matY + turkceY + sosyalY + fenY;
            toplamYanlis.Text = toplamyanlis.ToString();

            toplamnet = toplamdogru - (toplamyanlis / 4);
            toplamNet.Text = toplamnet.ToString();

            button_hesapla.Enabled = false;
            button_liste.Enabled = true;
            button_yenihesap.Enabled = false;

            label17.Visible = true;
            label11.Visible = true;
            label12.Visible = true;
            toplamDogru.Visible = true;
            toplamYanlis.Visible = true;
            toplamNet.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            label10.Visible = true;

            sonucMat.Visible = true;
            sonucTurkce.Visible = true;
            sonucFen.Visible = true;
            sonucSosyal.Visible = true;

        }

        private void matDogru_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void matYanlis_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void turkceDogru_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void turkceYanlis_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void sosyalDogru_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void fenDogru_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void sosyalYanlis_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void fenYanlis_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Öğrenci Adı: " + txtAd.Text + " " + "Soyadı: " + txtSoyad.Text);
            listBox1.Items.Add("Numarası: " + " " + txtNo.Text + " " + "Neti: " + toplamNet.Text);

            txtAd.Clear();
            txtSoyad.Clear();
            txtNo.Clear();

            matDogru.Text = "0";
            matYanlis.Text = "0";

            turkceDogru.Text = "0";
            turkceYanlis.Text = "0";

            sosyalDogru.Text = "0";
            sosyalYanlis.Text = "0";

            fenDogru.Text = "0";
            fenYanlis.Text = "0";


            toplamDogru.Text = "0";
            toplamYanlis.Text = "0";
            toplamNet.Text = "0";

            sonucMat.Text = "0";
            sonucTurkce.Text = "0";
            sonucSosyal.Text = "0";
            sonucFen.Text = "0";


            button_liste.Enabled = false;

            MessageBox.Show("İşlem tamamlanmıştır");
           

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            txtAd.Clear();
            txtSoyad.Clear();
            txtNo.Clear();
            txtSeviye.Text = "";



            matDogru.Clear();
            matYanlis.Clear();

            turkceDogru.Clear();
            turkceYanlis.Clear();

            sosyalDogru.Clear();
            sosyalYanlis.Clear();

            fenDogru.Clear();
            fenYanlis.Clear();


            matDogru.Enabled = false;
            matYanlis.Enabled = false;

            turkceDogru.Enabled = false;
            turkceYanlis.Enabled = false;

            fenDogru.Enabled = false;
            fenYanlis.Enabled = false;

            sosyalDogru.Enabled = false;
            sosyalYanlis.Enabled = false;

            txtAd.Enabled = true;
            txtSoyad.Enabled = true;
            txtSeviye.Enabled = true;
            txtNo.Enabled = true;

            

            txtAd.Enabled = true;
            txtSoyad.Enabled = true;
            txtSeviye.Enabled = true;
            txtNo.Enabled = true;

            label17.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            toplamDogru.Visible = false;
            toplamYanlis.Visible = false;
            toplamNet.Visible = false;

            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            sonucFen.Visible = false;
            sonucMat.Visible = false;
            sonucSosyal.Visible = false;
            sonucTurkce.Visible = false;


            button_hesapla.Enabled = true;
            button_yenihesap.Enabled = false;
            button_liste.Enabled = false;

            txtAd.Focus();
        }

        //INSTAGRAM ==>> samet_altundag63
        //INSTAGRAM ==>> samethecode
    }
}
