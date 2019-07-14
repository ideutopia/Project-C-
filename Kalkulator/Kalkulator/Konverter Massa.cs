using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator
{
    public partial class Konverter_Massa : Form
    {
        public Konverter_Massa()
        {
            InitializeComponent();
        }

        private void Konverter_Massa_Load(object sender, EventArgs e)
        {

        }

        private void angka1_Click(object sender, EventArgs e)
        {
            textBox1.Text += angka1.Text;
        }

        private void angka2_Click(object sender, EventArgs e)
        {
            textBox1.Text += angka2.Text;
        }

        private void angka3_Click(object sender, EventArgs e)
        {
            textBox1.Text += angka3.Text;
        }

        private void angka4_Click(object sender, EventArgs e)
        {
            textBox1.Text += angka4.Text;
        }

        private void angka5_Click(object sender, EventArgs e)
        {
            textBox1.Text += angka5.Text;
        }

        private void angka6_Click(object sender, EventArgs e)
        {
            textBox1.Text += angka6.Text;
        }

        private void angka7_Click(object sender, EventArgs e)
        {
            textBox1.Text += angka7.Text;
        }

        private void angka8_Click(object sender, EventArgs e)
        {
            textBox1.Text += angka8.Text;
        }

        private void angka9_Click(object sender, EventArgs e)
        {
            textBox1.Text += angka9.Text;
        }

        private void tandaKoma_Click(object sender, EventArgs e)
        {
            textBox1.Text += tandaKoma.Text;
        }

        private void angka0_Click(object sender, EventArgs e)
        {
            textBox1.Text += angka0.Text;
        }

        private void btDel_Click(object sender, EventArgs e)
        {
            string cur = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
            textBox1.Text = cur;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {
            bool cekRadioSatuanAsal = ((karatSatu.Checked == true) || (poundSatu.Checked == true) || (onsSatu.Checked == true) || (miligramSatu.Checked == true)
                || (sentigramSatu.Checked == true) || (desigramSatu.Checked == true) || (gramSatu.Checked == true) || (dekagramSatu.Checked == true) || (hektogramSatu.Checked == true)
                ||(hektogramSatu.Checked==true)|| (kilogramSatu.Checked == true) || (kuintalSatu.Checked == true) ||(tonSatu.Checked==true));
            bool cekRadioSatuanKonversi = ((karatDua.Checked == true) || (poundDua.Checked == true) || (onsDua.Checked == true) || (miligramDua.Checked == true)
                || (sentigramDua.Checked == true) || (desigramDua.Checked == true) || (gramDua.Checked == true) || (dekagramDua.Checked == true) || (hektogramSatu.Checked == true)
                || (hektogramDua.Checked == true) || (kilogramDua.Checked == true) || (kuintalDua.Checked == true) || (tonDua.Checked == true));
            if((cekRadioSatuanAsal == true) && (cekRadioSatuanKonversi == true))
            {
                try
                {
                    if ((karatSatu.Checked == true) && (karatDua.Checked == true))
                    {
                        textBox2.Text = textBox1.Text;

                    }
                    else if ((karatSatu.Checked == true) && (poundDua.Checked == true))
                    {
                        double value = Convert.ToDouble(textBox1.Text);
                        double hasil = (double)value / 2267.962;
                        textBox2.Text = hasil.ToString();
                    }
                    else if ((karatSatu.Checked) && (onsDua.Checked == true))
                    {
                        double value = Convert.ToDouble(textBox1.Text);
                        double hasil = (double)value /141.7476;
                        textBox2.Text = hasil.ToString();
                    }
                    else if ((karatSatu.Checked) && (miligramDua.Checked == true))
                    {
                        double value = Convert.ToDouble(textBox1.Text);
                        double hasil = value * 200;
                        textBox2.Text = hasil.ToString();
                    }
                    else if ((karatSatu.Checked) && (sentigramDua.Checked == true))
                    {
                        double value = Convert.ToDouble(textBox1.Text);
                        double hasil = value * 20;
                        textBox2.Text = hasil.ToString();
                    }
                    else if((karatSatu.Checked) && (desigramDua.Checked == true))
                    {
                        double value = Convert.ToDouble(textBox1.Text);
                        double hasil = value * 2;
                        textBox2.Text = hasil.ToString();
                    }
                    else if((karatSatu.Checked) && (gramDua.Checked == true)){
                        double value = Convert.ToDouble(textBox1.Text);
                        double hasil = value * (2*Math.Pow(10,-1));
                        textBox2.Text = hasil.ToString();
                    }
                    else if((karatSatu.Checked) && (dekagramDua.Checked == true))
                    {
                        double value = Convert.ToDouble(textBox1.Text);
                        double hasil = value * (2*Math.Pow(10, -2));
                        textBox2.Text = hasil.ToString();
                    }
                    else if((karatSatu.Checked) && (hektogramDua.Checked == true))
                    {
                        double value = Convert.ToDouble(textBox1.Text);
                        double hasil = value * (2 * Math.Pow(10, -3));
                        textBox2.Text = hasil.ToString();
                    }
                    else if((karatSatu.Checked) && (kilogramDua.Checked == true))
                    {
                        double value = Convert.ToDouble(textBox1.Text);
                        double hasil = value * (2 * Math.Pow(10, -4));
                        textBox2.Text = hasil.ToString();
                    }
                    else if((karatSatu.Checked) && (kuintalDua.Checked == true))
                    {
                        double value = Convert.ToDouble(textBox1.Text);
                        double hasil = value * (2 * Math.Pow(10, -6));
                        textBox2.Text = hasil.ToString();
                    }
                    else if((karatSatu.Checked) && (tonDua.Checked == true))
                    {
                        double value = Convert.ToDouble(textBox1.Text);
                        double hasil = value * (2 * Math.Pow(10, -7));
                        textBox2.Text = hasil.ToString();

                    }
                    //masuk kebagian pound
                    else if ((poundSatu.Checked == true) && (karatDua.Checked == true))
                    {
                        double value = Convert.ToDouble(textBox1.Text);
                        double hasil = (double)value * 2267.962;
                        textBox2.Text = hasil.ToString();
                    }
                    else if((poundSatu.Checked == true) && (poundDua.Checked == true)){
                        textBox1.Text = textBox2.Text;
                    }
                    else if ((poundSatu.Checked == true) && (onsDua.Checked == true))
                    {
                        double value = Convert.ToDouble(textBox1.Text);
                        double hasil = (double)value * (Math.Pow(10, 4) * 453.5924);
                        textBox2.Text = hasil.ToString();
                    }
                    else if((poundSatu.Checked == true) && (miligramDua.Checked == true))
                    {
                        double value = Convert.ToDouble(textBox1.Text);
                        double hasil = (double)value * (Math.Pow(10, 3) * 453.5924);
                        textBox2.Text = hasil.ToString();
                    }
                    else if ((poundSatu.Checked == true) && (sentigramDua.Checked == true))
                    {
                        double value = Convert.ToDouble(textBox1.Text);
                        double hasil = (double)value * (Math.Pow(10, 2) * 453.5924);
                        textBox2.Text = hasil.ToString();

                    }
                    else if ((poundSatu.Checked == true) && (desigramDua.Checked == true))
                    {
                        double value = Convert.ToDouble(textBox1.Text);
                        double hasil = (double)value * (Math.Pow(10,1)*453.5924);
                        textBox2.Text = hasil.ToString();

                    }
                    else if ((poundSatu.Checked == true) && (gramDua.Checked == true))
                    {
                        double value = Convert.ToDouble(textBox1.Text);
                        double hasil = (double)value * 453.5924;
                        textBox2.Text = hasil.ToString();
                    }
                    else if ((poundSatu.Checked == true) && (dekagramDua.Checked == true))
                    {
                        double value = Convert.ToDouble(textBox1.Text);
                        double hasil = (double)value * (Math.Pow(10,-1)*453.5924);
                        textBox2.Text = hasil.ToString();
                    }
                    else if ((poundSatu.Checked == true) && (hektogramDua.Checked == true))
                    {
                        double value = Convert.ToDouble(textBox1.Text);
                        double hasil = (double)value * (Math.Pow(10, -2) * 453.5924);
                        textBox2.Text = hasil.ToString();
                    }
                    else if ((poundSatu.Checked == true) && (kilogramDua.Checked == true))
                    {
                        double value = Convert.ToDouble(textBox1.Text);
                        double hasil = (double)value * (Math.Pow(10, -3) * 453.5924);
                        textBox2.Text = hasil.ToString();
                    }
                    else if ((poundSatu.Checked == true) && (kuintalDua.Checked == true))
                    {
                        double value = Convert.ToDouble(textBox1.Text);
                        double hasil = (double)value * (Math.Pow(10, -5) * 453.5924);
                        textBox2.Text = hasil.ToString();
                    }
                    else if ((poundSatu.Checked == true) && (tonDua.Checked == true))
                    {
                        double value = Convert.ToDouble(textBox1.Text);
                        double hasil = (double)value * (Math.Pow(10, -6) * 453.5924);
                        textBox2.Text = hasil.ToString();

                    }
                    //masuk bagian ons
                    else if ((onsSatu.Checked == true) && (karatDua.Checked == true))
                    {
                        double value = Convert.ToDouble(textBox1.Text);
                        double hasil = (double)value * 141.7476;
                        textBox2.Text = hasil.ToString();
                    }
                    else if ((onsSatu.Checked == true) && (poundDua.Checked == true))
                    {
                        double value = Convert.ToDouble(textBox1.Text);
                        double hasil = (double)value *(Math.Pow(10,-2)*625);
                        textBox2.Text = hasil.ToString();
                    }
                    else if ((onsSatu.Checked == true) && (onsDua.Checked == true))
                    {
                        textBox2.Text = textBox1.Text;
                    }
                    else if ((onsSatu.Checked == true) && (miligramDua.Checked == true))
                    {
                        double value = Convert.ToDouble(textBox1.Text);
                        double hasil = (double)value * (Math.Pow(10, 3) * 28.34952);
                        textBox2.Text = hasil.ToString();
                    }
                    else if ((onsSatu.Checked == true) && (sentigramDua.Checked == true))
                    {
                        double value = Convert.ToDouble(textBox1.Text);
                        double hasil = (double)value * (Math.Pow(10, 2) * 28.34952);
                        textBox2.Text = hasil.ToString();
                    }
                    else if ((onsSatu.Checked == true) && (desigramDua.Checked == true))
                    {
                        double value = Convert.ToDouble(textBox1.Text);
                        double hasil = (double)value * (Math.Pow(10, 1) * 28.34952);
                        textBox2.Text = hasil.ToString();
                    }
                    else if ((onsSatu.Checked == true) && (gramDua.Checked == true))
                    {
                        double value = Convert.ToDouble(textBox1.Text);
                        double hasil = (double)value * (Math.Pow(10, 0) * 28.34952);
                        textBox2.Text = hasil.ToString();
                    }
                    else if ((onsSatu.Checked == true) && (dekagramDua.Checked == true))
                    {
                        double value = Convert.ToDouble(textBox1.Text);
                        double hasil = (double)value * (Math.Pow(10, -1) * 28.34952);
                        textBox2.Text = hasil.ToString();
                    }
                    else if ((onsSatu.Checked == true) && (hektogramDua.Checked == true))
                    {
                        double value = Convert.ToDouble(textBox1.Text);
                        double hasil = (double)value * (Math.Pow(10, -2) * 28.34952);
                        textBox2.Text = hasil.ToString();
                    }
                    else if ((onsSatu.Checked == true) && (kilogramDua.Checked == true))
                    {
                        double value = Convert.ToDouble(textBox1.Text);
                        double hasil = (double)value * (Math.Pow(10, -3) * 28.34952);
                        textBox2.Text = hasil.ToString();
                    }
                    else if ((onsSatu.Checked == true) && (kuintalDua.Checked == true))
                    {
                        double value = Convert.ToDouble(textBox1.Text);
                        double hasil = (double)value * (Math.Pow(10, -5) * 28.34952);
                        textBox2.Text = hasil.ToString();
                    }
                    else if ((onsSatu.Checked == true) && (tonDua.Checked == true))
                    {
                        double value = Convert.ToDouble(textBox1.Text);
                        double hasil = (double)value * (Math.Pow(10, -6) * 28.34952);
                        textBox2.Text = hasil.ToString();
                    }
                    //masuk ke miligram
                    else if ((miligramSatu.Checked == true) && (karatDua.Checked == true))
                    {
                        double value = Convert.ToDouble(textBox1.Text);
                        double hasil = value / 200;
                        textBox2.Text = hasil.ToString();
                    }
                    else if ((miligramSatu.Checked == true) && (poundDua.Checked == true))
                    {
                        double value = Convert.ToDouble(textBox1.Text);
                        double hasil = (double)value / (Math.Pow(10, 3) * 453.5924);
                        textBox2.Text = hasil.ToString();
                    }
                    else if ((miligramSatu.Checked == true) && (onsDua.Checked == true))
                    {
                        double value = Convert.ToDouble(textBox1.Text);
                        double hasil = (double)value / (Math.Pow(10, 3) * 28.34952);
                        textBox2.Text = hasil.ToString();
                    }
                    else if ((miligramSatu.Checked == true) && (miligramDua.Checked == true))
                    {
                        textBox2.Text = textBox1.Text;
                    }
                    else if ((miligramSatu.Checked == true) && (sentigramDua.Checked == true))
                    {
                        double value = Convert.ToDouble(textBox1.Text);
                        double hasil = value / 10;
                        textBox2.Text = hasil.ToString();

                    }
                    else if ((miligramSatu.Checked == true) && (desigramDua.Checked == true))
                    {
                        double value = Convert.ToDouble(textBox1.Text);
                        double hasil = value / Math.Pow(10,2);
                        textBox2.Text = hasil.ToString();

                    }
                    else if ((miligramSatu.Checked == true) && (gramDua.Checked == true))
                    {
                        double value = Convert.ToDouble(textBox1.Text);
                        double hasil = value / Math.Pow(10, 3);
                        textBox2.Text = hasil.ToString();
                    }
                    else if ((miligramSatu.Checked == true) && (dekagramDua.Checked == true))
                    {
                        double value = Convert.ToDouble(textBox1.Text);
                        double hasil = value / Math.Pow(10, 4);
                        textBox2.Text = hasil.ToString();
                    }
                    else if ((miligramSatu.Checked == true) && (hektogramDua.Checked == true))
                    {
                        double value = Convert.ToDouble(textBox1.Text);
                        double hasil = value / Math.Pow(10, 5);
                        textBox2.Text = hasil.ToString();
                    }
                    else if ((miligramSatu.Checked == true) && (kilogramDua.Checked == true))
                    {
                        double value = Convert.ToDouble(textBox1.Text);
                        double hasil = value / Math.Pow(10, 6);
                        textBox2.Text = hasil.ToString();
                    }
                    else if ((miligramSatu.Checked == true) && (kuintalDua.Checked == true))
                    {
                        double value = Convert.ToDouble(textBox1.Text);
                        double hasil = value / Math.Pow(10, 8);
                        textBox2.Text = hasil.ToString();
                    }
                    else if ((miligramSatu.Checked == true) && (tonDua.Checked == true))
                    {
                        double value = Convert.ToDouble(textBox1.Text);
                        double hasil = value / Math.Pow(10, 9);
                        textBox2.Text = hasil.ToString();
                    }
                    //masuk ke sentigram
                    else if ((sentigramSatu.Checked == true) && (karatDua.Checked == true))
                    {
                        double value = Convert.ToDouble(textBox1.Text);
                        double hasil = value / 20;
                        textBox2.Text = hasil.ToString();
                    }
                    else if ((sentigramSatu.Checked == true) && (poundDua.Checked == true))
                    {
                        double value = Convert.ToDouble(textBox1.Text);
                        double hasil = (double)value / (Math.Pow(10, 2) * 453.5924);
                        textBox2.Text = hasil.ToString();
                    }
                    else if ((sentigramSatu.Checked == true) && (onsDua.Checked == true))
                    {
                        double value = Convert.ToDouble(textBox1.Text);
                        double hasil = (double)value / (Math.Pow(10, 2) * 28.34952);
                        textBox2.Text = hasil.ToString();
                    }
                    else if ((sentigramSatu.Checked == true) && (miligramDua.Checked == true))
                    {
                        double value = Convert.ToDouble(textBox1.Text);
                        double hasil = value * Math.Pow(10, 1);
                        textBox2.Text = hasil.ToString();
                    }
                    else if ((sentigramSatu.Checked == true) && (sentigramDua.Checked == true))
                    {

                        textBox2.Text = textBox1.Text;
                    }
                    else if ((sentigramSatu.Checked == true) && (desigramDua.Checked == true))
                    {
                        double value = Convert.ToDouble(textBox1.Text);
                        double hasil = value / Math.Pow(10, 1);
                        textBox2.Text = hasil.ToString();
                    }
                    else if ((sentigramSatu.Checked == true) && (gramDua.Checked == true))
                    {
                        double value = Convert.ToDouble(textBox1.Text);
                        double hasil = value / Math.Pow(10, 2);
                        textBox2.Text = hasil.ToString();
                    }
                    else if ((sentigramSatu.Checked == true) && (dekagramDua.Checked == true))
                    {
                        double value = Convert.ToDouble(textBox1.Text);
                        double hasil = value / Math.Pow(10, 3);
                        textBox2.Text = hasil.ToString();
                    }
                    else if ((sentigramSatu.Checked == true) && (hektogramDua.Checked == true))
                    {
                        double value = Convert.ToDouble(textBox1.Text);
                        double hasil = value / Math.Pow(10, 4);
                        textBox2.Text = hasil.ToString();
                    }
                    else if ((sentigramSatu.Checked == true) && (kilogramDua.Checked == true))
                    {
                        double value = Convert.ToDouble(textBox1.Text);
                        double hasil = value / Math.Pow(10, 5);
                        textBox2.Text = hasil.ToString();
                    }
                    else if ((sentigramSatu.Checked == true) && (kuintalDua.Checked == true))
                    {
                        double value = Convert.ToDouble(textBox1.Text);
                        double hasil = value / Math.Pow(10, 7);
                        textBox2.Text = hasil.ToString();
                    }
                    else if ((sentigramSatu.Checked == true) && (tonDua.Checked == true))
                    {
                        double value = Convert.ToDouble(textBox1.Text);
                        double hasil = value / Math.Pow(10, 8);
                        textBox2.Text = hasil.ToString();
                    }
                    //masuk ke desigram
                    else if ((desigramSatu.Checked == true) && (karatDua.Checked == true))
                    {
                        double value = Convert.ToDouble(textBox1.Text);
                        double hasil = value / 2;
                        textBox2.Text = hasil.ToString();
                    }
                    else if ((desigramSatu.Checked == true) && (poundDua.Checked == true))
                    {
                        double value = Convert.ToDouble(textBox1.Text);
                        double hasil = (double)value / (Math.Pow(10, 1) * 453.5924);
                        textBox2.Text = hasil.ToString();

                    }
                    else if ((desigramSatu.Checked == true) && (onsDua.Checked == true))
                    {
                        double value = Convert.ToDouble(textBox1.Text);
                        double hasil = (double)value / (Math.Pow(10, 1) * 28.34952);
                        textBox2.Text = hasil.ToString();
                    }
                    else if ((desigramSatu.Checked == true) && (miligramDua.Checked == true))
                    {
                        double value = Convert.ToDouble(textBox1.Text);
                        double hasil = value * Math.Pow(10, 2);
                        textBox2.Text = hasil.ToString();
                    }
                    else if ((desigramSatu.Checked == true) && (sentigramDua.Checked == true))
                    {
                        double value = Convert.ToDouble(textBox1.Text);
                        double hasil = value * Math.Pow(10, 1);
                        textBox2.Text = hasil.ToString();
                    }
                    else if ((desigramSatu.Checked == true) && (desigramDua.Checked == true))
                    {
                       
                        textBox2.Text = textBox1.Text;
                    }
                    else if ((desigramSatu.Checked == true) && (gramDua.Checked == true))
                    {
                        double value = Convert.ToDouble(textBox1.Text);
                        double hasil = value / Math.Pow(10, 1);
                        textBox2.Text = hasil.ToString();
                    }
                    else if ((desigramSatu.Checked == true) && (dekagramDua.Checked == true))
                    {
                        double value = Convert.ToDouble(textBox1.Text);
                        double hasil = value / Math.Pow(10, 2);
                        textBox2.Text = hasil.ToString();
                    }
                    else if ((desigramSatu.Checked == true) && (hektogramDua.Checked == true))
                    {
                        double value = Convert.ToDouble(textBox1.Text);
                        double hasil = value / Math.Pow(10, 3);
                        textBox2.Text = hasil.ToString();
                    }
                    else if ((desigramSatu.Checked == true) && (kilogramDua.Checked == true))
                    {
                        double value = Convert.ToDouble(textBox1.Text);
                        double hasil = value / Math.Pow(10, 4);
                        textBox2.Text = hasil.ToString();
                    }
                    else if ((desigramSatu.Checked == true) && (kuintalDua.Checked == true))
                    {
                        double value = Convert.ToDouble(textBox1.Text);
                        double hasil = value / Math.Pow(10, 6);
                        textBox2.Text = hasil.ToString();
                    }
                    else if ((desigramSatu.Checked == true) && (tonDua.Checked == true))
                    {
                        double value = Convert.ToDouble(textBox1.Text);
                        double hasil = value / Math.Pow(10, 7);
                        textBox2.Text = hasil.ToString();
                    }
                    //masuk ke gram
                    else if ((gramSatu.Checked == true) && (karatDua.Checked == true))
                    {
                        double value = Convert.ToDouble(textBox1.Text);
                        double hasil = value / 0.2;
                        textBox2.Text = hasil.ToString();
                    }
                    else if ((gramSatu.Checked == true) && (poundDua.Checked == true))
                    {
                        double value = Convert.ToDouble(textBox1.Text);
                        double hasil = (double)value / (Math.Pow(10, 0) * 453.5924);
                        textBox2.Text = hasil.ToString();

                    }
                    else if ((gramSatu.Checked == true) && (onsDua.Checked == true))
                    {
                        double value = Convert.ToDouble(textBox1.Text);
                        double hasil = (double)value / (Math.Pow(10, 0) * 28.34952);
                        textBox2.Text = hasil.ToString();

                    }
                    else if ((gramSatu.Checked == true) && (miligramDua.Checked == true))
                    {
                        double value = Convert.ToDouble(textBox1.Text);
                        double hasil = value * Math.Pow(10, 3);
                        textBox2.Text = hasil.ToString();
                    }
                    else if ((gramSatu.Checked == true) && (sentigramDua.Checked == true))
                    {
                        double value = Convert.ToDouble(textBox1.Text);
                        double hasil = value * Math.Pow(10, 2);
                        textBox2.Text = hasil.ToString();
                    }
                    else if ((gramSatu.Checked == true) && (desigramDua.Checked == true))
                    {
                        double value = Convert.ToDouble(textBox1.Text);
                        double hasil = value * Math.Pow(10, 1);
                        textBox2.Text = hasil.ToString();
                    }
                    else if ((gramSatu.Checked == true) && (gramDua.Checked == true))
                    {
                        textBox2.Text = textBox1.Text;
                    }
                    else if ((gramSatu.Checked == true) && (dekagramDua.Checked == true))
                    {
                        double value = Convert.ToDouble(textBox1.Text);
                        double hasil = value / Math.Pow(10, 1);
                        textBox2.Text = hasil.ToString();
                    }
                    else if ((gramSatu.Checked == true) && (hektogramDua.Checked == true))
                    {
                        double value = Convert.ToDouble(textBox1.Text);
                        double hasil = value / Math.Pow(10, 2);
                        textBox2.Text = hasil.ToString();
                    }
                    else if ((gramSatu.Checked == true) && (kilogramDua.Checked == true))
                    {
                        double value = Convert.ToDouble(textBox1.Text);
                        double hasil = value / Math.Pow(10, 3);
                        textBox2.Text = hasil.ToString();
                    }
                    else if ((gramSatu.Checked == true) && (kuintalDua.Checked == true))
                    {
                        double value = Convert.ToDouble(textBox1.Text);
                        double hasil = value / Math.Pow(10, 5);
                        textBox2.Text = hasil.ToString();
                    }
                    else if ((gramSatu.Checked == true) && (tonDua.Checked == true))
                    {
                        double value = Convert.ToDouble(textBox1.Text);
                        double hasil = value / Math.Pow(10, 6);
                        textBox2.Text = hasil.ToString();
                    }
                    //masuk ke dekagram
                    else if ((dekagramSatu.Checked == true) && (karatDua.Checked == true))
                    {
                        double value = Convert.ToDouble(textBox1.Text);
                        double hasil = value / 0.02;
                        textBox2.Text = hasil.ToString();
                    }
                    else if ((dekagramSatu.Checked == true) && (poundDua.Checked == true))
                    {
                        double value = Convert.ToDouble(textBox1.Text);
                        double hasil = (double)value / (Math.Pow(10, -1) * 453.5924);
                        textBox2.Text = hasil.ToString();

                    }
                    else if ((dekagramSatu.Checked == true) && (onsDua.Checked == true))
                    {
                        double value = Convert.ToDouble(textBox1.Text);
                        double hasil = (double)value / (Math.Pow(10, -1) * 28.34952);
                        textBox2.Text = hasil.ToString();
                    }
                    else if ((dekagramSatu.Checked == true) && (miligramDua.Checked == true))
                    {
                        double value = Convert.ToDouble(textBox1.Text);
                        double hasil = value * Math.Pow(10, 4);
                        textBox2.Text = hasil.ToString();
                    }
                    else if ((dekagramSatu.Checked == true) && (sentigramDua.Checked == true))
                    {
                        double value = Convert.ToDouble(textBox1.Text);
                        double hasil = value * Math.Pow(10, 3);
                        textBox2.Text = hasil.ToString();
                    }
                    else if ((dekagramSatu.Checked == true) && (desigramDua.Checked == true))
                    {
                        double value = Convert.ToDouble(textBox1.Text);
                        double hasil = value * Math.Pow(10, 2);
                        textBox2.Text = hasil.ToString();
                    }
                    else if ((dekagramSatu.Checked == true) && (gramDua.Checked == true))
                    {
                        double value = Convert.ToDouble(textBox1.Text);
                        double hasil = value * Math.Pow(10, 1);
                        textBox2.Text = hasil.ToString();
                    }
                    else if ((dekagramSatu.Checked == true) && (dekagramDua.Checked == true))
                    {
                        textBox2.Text = textBox1.Text;
                    }
                    else if ((dekagramSatu.Checked == true) && (hektogramDua.Checked == true))
                    {
                        double value = Convert.ToDouble(textBox1.Text);
                        double hasil = value / Math.Pow(10, 1);
                        textBox2.Text = hasil.ToString();
                    }
                    else if ((dekagramSatu.Checked == true) && (kilogramDua.Checked == true))
                    {
                        double value = Convert.ToDouble(textBox1.Text);
                        double hasil = value / Math.Pow(10, 2);
                        textBox2.Text = hasil.ToString();
                    }
                    else if ((dekagramSatu.Checked == true) && (kuintalDua.Checked == true))
                    {
                        double value = Convert.ToDouble(textBox1.Text);
                        double hasil = value / Math.Pow(10, 4);
                        textBox2.Text = hasil.ToString();
                    }
                    else if ((dekagramSatu.Checked == true) && (tonDua.Checked == true))
                    {
                        double value = Convert.ToDouble(textBox1.Text);
                        double hasil = value / Math.Pow(10, 5);
                        textBox2.Text = hasil.ToString();
                    }
                    //masuk ke hektogram
                    else if ((hektogramSatu.Checked == true) && (karatDua.Checked == true))
                    {
                        double value = Convert.ToDouble(textBox1.Text);
                        double hasil = value / 0.002;
                        textBox2.Text = hasil.ToString();
                    }
                    else if ((hektogramSatu.Checked == true) && (poundDua.Checked == true))
                    {
                        double value = Convert.ToDouble(textBox1.Text);
                        double hasil = (double)value / (Math.Pow(10, -2) * 453.5924);
                        textBox2.Text = hasil.ToString();
                    }
                    else if ((hektogramSatu.Checked == true) && (onsDua.Checked == true))
                    {
                        double value = Convert.ToDouble(textBox1.Text);
                        double hasil = (double)value / (Math.Pow(10, -2) * 28.34952);
                        textBox2.Text = hasil.ToString();
                    }
                    else if ((hektogramSatu.Checked == true) && (miligramDua.Checked == true))
                    {
                        double value = Convert.ToDouble(textBox1.Text);
                        double hasil = value * Math.Pow(10, 5);
                        textBox2.Text = hasil.ToString();
                    }
                    else if ((hektogramSatu.Checked == true) && (sentigramDua.Checked == true))
                    {
                        double value = Convert.ToDouble(textBox1.Text);
                        double hasil = value * Math.Pow(10, 4);
                        textBox2.Text = hasil.ToString();
                    }
                    else if ((hektogramSatu.Checked == true) && (desigramDua.Checked == true))
                    {
                        double value = Convert.ToDouble(textBox1.Text);
                        double hasil = value * Math.Pow(10, 3);
                        textBox2.Text = hasil.ToString();
                    }
                    else if ((hektogramSatu.Checked == true) && (gramDua.Checked == true))
                    {
                        double value = Convert.ToDouble(textBox1.Text);
                        double hasil = value * Math.Pow(10, 2);
                        textBox2.Text = hasil.ToString();
                    }
                    else if ((hektogramSatu.Checked == true) && (dekagramDua.Checked == true))
                    {
                        double value = Convert.ToDouble(textBox1.Text);
                        double hasil = value * Math.Pow(10, 1);
                        textBox2.Text = hasil.ToString();
                    }
                    else if ((hektogramSatu.Checked == true) && (hektogramDua.Checked == true))
                    {
                        textBox2.Text = textBox1.Text;
                    }
                    else if ((hektogramSatu.Checked == true) && (kilogramDua.Checked == true))
                    {
                        double value = Convert.ToDouble(textBox1.Text);
                        double hasil = value / Math.Pow(10, 1);
                        textBox2.Text = hasil.ToString();
                    }
                    else if ((hektogramSatu.Checked == true) && (kuintalDua.Checked == true))
                    {
                        double value = Convert.ToDouble(textBox1.Text);
                        double hasil = value / Math.Pow(10, 3);
                        textBox2.Text = hasil.ToString();
                    }
                    else if ((hektogramSatu.Checked == true) && (tonDua.Checked == true))
                    {
                        double value = Convert.ToDouble(textBox1.Text);
                        double hasil = value / Math.Pow(10, 4);
                        textBox2.Text = hasil.ToString();
                    }
                    //masuk ke kilogram
                    
                    else if ((kilogramSatu.Checked == true) && (karatDua.Checked == true))
                    {
                        double value = Convert.ToDouble(textBox1.Text);
                        double hasil = value / 0.0002;
                        textBox2.Text = hasil.ToString();
                    }
                    else if ((kilogramSatu.Checked == true) && (poundDua.Checked == true))
                    {
                        double value = Convert.ToDouble(textBox1.Text);
                        double hasil = (double)value / (Math.Pow(10, -3) * 453.5924);
                        textBox2.Text = hasil.ToString();

                    }
                    else if ((kilogramSatu.Checked == true) && (onsDua.Checked == true))
                    {
                        double value = Convert.ToDouble(textBox1.Text);
                        double hasil = (double)value / (Math.Pow(10, -3) * 28.34952);
                        textBox2.Text = hasil.ToString();

                    }
                    else if ((kilogramSatu.Checked == true) && (miligramDua.Checked == true))
                    {
                        double value = Convert.ToDouble(textBox1.Text);
                        double hasil = value * Math.Pow(10, 6);
                        textBox2.Text = hasil.ToString();
                    }
                    else if ((kilogramSatu.Checked == true) && (sentigramDua.Checked == true))
                    {
                        double value = Convert.ToDouble(textBox1.Text);
                        double hasil = value * Math.Pow(10, 5);
                        textBox2.Text = hasil.ToString();
                    }
                    else if ((kilogramSatu.Checked == true) && (desigramDua.Checked == true))
                    {
                        double value = Convert.ToDouble(textBox1.Text);
                        double hasil = value * Math.Pow(10, 4);
                        textBox2.Text = hasil.ToString();
                    }
                    else if ((kilogramSatu.Checked == true) && (gramDua.Checked == true))
                    {
                        double value = Convert.ToDouble(textBox1.Text);
                        double hasil = value * Math.Pow(10, 3);
                        textBox2.Text = hasil.ToString();
                    }
                    else if ((kilogramSatu.Checked == true) && (dekagramDua.Checked == true))
                    {
                        double value = Convert.ToDouble(textBox1.Text);
                        double hasil = value * Math.Pow(10, 2);
                        textBox2.Text = hasil.ToString();
                    }
                    else if ((kilogramSatu.Checked == true) && (hektogramDua.Checked == true))
                    {   
                        double value = Convert.ToDouble(textBox1.Text);
                        double hasil = value * Math.Pow(10, 1);
                        textBox2.Text = hasil.ToString();
                        
                    }
                    else if ((kilogramSatu.Checked == true) && (kilogramDua.Checked == true))
                    {
                        textBox2.Text = textBox1.Text;
                    }
                    else if ((kilogramSatu.Checked == true) && (kuintalDua.Checked == true))
                    {
                        double value = Convert.ToDouble(textBox1.Text);
                        double hasil = value / Math.Pow(10, 2);
                        textBox2.Text = hasil.ToString();
                    }
                    else if ((kilogramSatu.Checked == true) && (tonDua.Checked == true))
                    {
                        double value = Convert.ToDouble(textBox1.Text);
                        double hasil = value / Math.Pow(10, 3);
                        textBox2.Text = hasil.ToString();
                    }
                    //masuk bagian kuintal
                    else if ((kilogramSatu.Checked == true) && (karatDua.Checked == true))
                    {
                        double value = Convert.ToDouble(textBox1.Text);
                        double hasil = value / 0.000002;
                        textBox2.Text = hasil.ToString();
                    }
                    else if ((kilogramSatu.Checked == true) && (poundDua.Checked == true))
                    {
                        double value = Convert.ToDouble(textBox1.Text);
                        double hasil = (double)value / (Math.Pow(10, -6) * 453.5924);
                        textBox2.Text = hasil.ToString();
                    }
                    else if ((kilogramSatu.Checked == true) && (onsDua.Checked == true))
                    {
                        double value = Convert.ToDouble(textBox1.Text);
                        double hasil = (double)value / (Math.Pow(10, -6) * 28.34952);
                        textBox2.Text = hasil.ToString();
                    }
                    else if ((kuintalSatu.Checked == true) && (miligramDua.Checked == true))
                    {
                        double value = Convert.ToDouble(textBox1.Text);
                        double hasil = value * Math.Pow(10, 8);
                        textBox2.Text = hasil.ToString();
                    }
                    else if ((kuintalSatu.Checked == true) && (sentigramDua.Checked == true))
                    {
                        double value = Convert.ToDouble(textBox1.Text);
                        double hasil = value * Math.Pow(10, 7);
                        textBox2.Text = hasil.ToString();
                    }
                    else if ((kuintalSatu.Checked == true) && (desigramDua.Checked == true))
                    {
                        double value = Convert.ToDouble(textBox1.Text);
                        double hasil = value * Math.Pow(10, 6);
                        textBox2.Text = hasil.ToString();
                    }
                    else if ((kuintalSatu.Checked == true) && (gramDua.Checked == true))
                    {
                        double value = Convert.ToDouble(textBox1.Text);
                        double hasil = value * Math.Pow(10, 5);
                        textBox2.Text = hasil.ToString();
                    }
                    else if ((kuintalSatu.Checked == true) && (dekagramDua.Checked == true))
                    {
                        double value = Convert.ToDouble(textBox1.Text);
                        double hasil = value * Math.Pow(10, 4);
                        textBox2.Text = hasil.ToString();
                    }
                    else if ((kuintalSatu.Checked == true) && (hektogramDua.Checked == true))
                    {   
                        double value = Convert.ToDouble(textBox1.Text);
                        double hasil = value * Math.Pow(10, 3);
                        textBox2.Text = hasil.ToString();
                        
                    }
                    else if ((kuintalSatu.Checked == true) && (kilogramDua.Checked == true))
                    {
                        double value = Convert.ToDouble(textBox1.Text);
                        double hasil = value * Math.Pow(10, 2);
                        textBox2.Text = hasil.ToString();
                    }
                    else if ((kuintalSatu.Checked == true) && (kuintalDua.Checked == true))
                    {
                        textBox2.Text = textBox1.Text;
                    }
                    else if ((kuintalSatu.Checked == true) && (tonDua.Checked == true))
                    {
                        double value = Convert.ToDouble(textBox1.Text);
                        double hasil = value / Math.Pow(10, 1);
                        textBox2.Text = hasil.ToString();
                    }
                    //masuk bagian ton
                    else if ((kilogramSatu.Checked == true) && (karatDua.Checked == true))
                    {
                        double value = Convert.ToDouble(textBox1.Text);
                        double hasil = value / 0.0000005;
                        textBox2.Text = hasil.ToString();
                    }
                    else if ((kilogramSatu.Checked == true) && (poundDua.Checked == true))
                    {
                        double value = Convert.ToDouble(textBox1.Text);
                        double hasil = (double)value / (Math.Pow(10, -7) * 453.5924);
                        textBox2.Text = hasil.ToString();

                    }
                    else if ((kilogramSatu.Checked == true) && (onsDua.Checked == true))
                    {
                        double value = Convert.ToDouble(textBox1.Text);
                        double hasil = (double)value / (Math.Pow(10, -7) * 28.34952);
                        textBox2.Text = hasil.ToString();
                    }
                    else if ((tonSatu.Checked == true) && (miligramDua.Checked == true))
                    {
                        double value = Convert.ToDouble(textBox1.Text);
                        double hasil = value * Math.Pow(10, 9);
                        textBox2.Text = hasil.ToString();
                    }
                    else if ((tonSatu.Checked == true) && (sentigramDua.Checked == true))
                    {
                        double value = Convert.ToDouble(textBox1.Text);
                        double hasil = value * Math.Pow(10, 8);
                        textBox2.Text = hasil.ToString();
                    }
                    else if ((tonSatu.Checked == true) && (desigramDua.Checked == true))
                    {
                        double value = Convert.ToDouble(textBox1.Text);
                        double hasil = value * Math.Pow(10, 7);
                        textBox2.Text = hasil.ToString();
                    }
                    else if ((tonSatu.Checked == true) && (gramDua.Checked == true))
                    {
                        double value = Convert.ToDouble(textBox1.Text);
                        double hasil = value * Math.Pow(10, 6);
                        textBox2.Text = hasil.ToString();
                    }
                    else if ((tonSatu.Checked == true) && (dekagramDua.Checked == true))
                    {
                        double value = Convert.ToDouble(textBox1.Text);
                        double hasil = value * Math.Pow(10, 5);
                        textBox2.Text = hasil.ToString();
                    }
                    else if ((tonSatu.Checked == true) && (hektogramDua.Checked == true))
                    {   
                        double value = Convert.ToDouble(textBox1.Text);
                        double hasil = value * Math.Pow(10, 4);
                        textBox2.Text = hasil.ToString();
                        
                    }
                    else if ((tonSatu.Checked == true) && (kilogramDua.Checked == true))
                    {
                        double value = Convert.ToDouble(textBox1.Text);
                        double hasil = value * Math.Pow(10, 3);
                        textBox2.Text = hasil.ToString();
                    }
                    else if ((tonSatu.Checked == true) && (kuintalDua.Checked == true))
                    {
                        double value = Convert.ToDouble(textBox1.Text);
                        double hasil = value * Math.Pow(10, 1);
                        textBox2.Text = hasil.ToString();
                    }
                    else if ((tonSatu.Checked == true) && (tonDua.Checked == true))
                    {
                        
                        textBox2.Text = textBox1.Text;
                    }
                     










                }
                catch (FormatException x)
                {
                    MessageBox.Show("Masukkan tidak sah");
                    textBox1.Text = null;
                }
            }
            else
            {
                MessageBox.Show("Masukkan pilihan satuan");
            }
        }
    }
}
