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
    public partial class Konverter_Suhu : Form
    {
        public Konverter_Suhu()
        {
            InitializeComponent();
        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {
            bool kuantitasSatu = ((reamurSatu.Checked) || (CelciusSatu.Checked) || (kelvinSatu.Checked)||(fahrenheitSatu.Checked));
            bool kuantitasDua = ((reamurDua.Checked) || (celciusDua.Checked) || (kelvinDua.Checked) || (fahrenheitDua.Checked));
            if ((kuantitasSatu == true)&&(kuantitasDua==true))
            {
                //double h = -6;
                //MessageBox.Show(h.ToString());
                try
                {

                    if ((CelciusSatu.Checked == true) && (celciusDua.Checked == true))
                    {
                        double hasil = Convert.ToDouble(textBox1.Text);
                        textBox2.Text = hasil.ToString();

                    }
                    else if ((CelciusSatu.Checked == true) && (fahrenheitDua.Checked == true))
                    {
                        double value = Convert.ToDouble(textBox1.Text);
                        double hasil = (double)9 / 5 * value + 32;
                        textBox2.Text = hasil.ToString();
                    }
                    else if ((fahrenheitSatu.Checked == true) && (celciusDua.Checked == true))
                    {
                        double value = Convert.ToDouble(textBox1.Text);
                        double hasil = (double)5 / 9 * value - 32;
                        textBox2.Text = hasil.ToString();
                    }
                    else if ((fahrenheitSatu.Checked == true) && (fahrenheitDua.Checked == true))
                    {
                        double hasil = Convert.ToDouble(textBox1.Text);
                        textBox2.Text = hasil.ToString();
                    }
                    else if ((CelciusSatu.Checked == true) && (reamurDua.Checked == true))
                    {
                        double value = Convert.ToDouble(textBox1.Text);
                        double hasil = (double)4 / 5 * value;
                        textBox2.Text = hasil.ToString();

                    }
                    else if ((CelciusSatu.Checked == true) && (kelvinDua.Checked == true))
                    {
                        double value = Convert.ToDouble(textBox1.Text);
                        double hasil = value + 273.15;
                        textBox2.Text = hasil.ToString();
                    }
                    else if ((fahrenheitSatu.Checked == true) && (reamurDua.Checked == true))
                    {
                        double value = Convert.ToDouble(textBox1.Text);
                        double hasil = 4 / 9 * value - 32;
                        textBox2.Text = hasil.ToString();
                    }
                    else if ((fahrenheitSatu.Checked == true) && (kelvinDua.Checked == true))
                    {
                        double value = Convert.ToDouble(textBox1.Text);
                        double hasil = (value - 32) * 5 / 9 + 273.15;
                        textBox2.Text = hasil.ToString();
                    }
                    else if ((reamurSatu.Checked == true) && (celciusDua.Checked == true))
                    {
                        double value = Convert.ToDouble(textBox1.Text);
                        double hasil = (double)5 / 4 * value;
                        textBox2.Text = hasil.ToString();
                    }
                    else if ((reamurSatu.Checked == true) && (fahrenheitDua.Checked == true))
                    {
                        double value = Convert.ToDouble(textBox1.Text);
                        double hasil = (double)9 / 4 * value + 32;
                        textBox2.Text = hasil.ToString();
                    }
                    else if ((reamurSatu.Checked == true) && (reamurDua.Checked == true))
                    {
                        double value = Convert.ToDouble(textBox1.Text);
                        double hasil = (double)value;
                        textBox2.Text = hasil.ToString();

                    }
                    else if ((reamurSatu.Checked == true) && (kelvinDua.Checked))
                    {
                        double value = Convert.ToDouble(textBox1.Text);
                        double hasil = (double)5 / 4 * value + 273.15;
                        textBox2.Text = hasil.ToString();
                    }
                    else if ((kelvinSatu.Checked == true) && (celciusDua.Checked == true))
                    {
                        double value = Convert.ToDouble(textBox1.Text);
                        double hasil = value - 273.15;
                        textBox2.Text = hasil.ToString();
                    }
                    else if ((kelvinSatu.Checked == true) && (fahrenheitDua.Checked == true))
                    {
                        double value = Convert.ToDouble(textBox1.Text);
                        double hasil = (value - 273.15) * (double)9 / 5 + 32;
                        textBox2.Text = hasil.ToString();
                    }
                    else if ((kelvinSatu.Checked == true) && (reamurDua.Checked == true))
                    {
                        double value = Convert.ToDouble(textBox1.Text);
                        double hasil = (value - 273.15) * (double)4 / 5;
                        textBox2.Text = hasil.ToString();
                    }
                    else if ((kelvinSatu.Checked == true) && (kelvinDua.Checked == true))
                    {
                        double value = Convert.ToDouble(textBox1.Text);
                        double hasil = value;
                        textBox2.Text = hasil.ToString();
                    }
                }
                catch (FormatException x)
                {
                    string formula = textBox1.Text;
                    string[] value = formula.Split('-');
                    //MessageBox.Show(value[value.Length - 1]);
                    //foreach (string val in value)
                    
                   //{
                        //MessageBox.Show(val);
                   // }
                    
                    StringBuilder exception = new StringBuilder(value[value.Length-1]);
                    exception.Insert(0, '-');
                    //exception.Remove(1,textBox1.Text.Length-2);
                    textBox1.Text = exception.ToString();
                }
                
                
            }
            else
            {
                MessageBox.Show("Silahkan pilih pilihan satuan");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {


        }

        private void kelvinSatu_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void samaDengan_Click(object sender, EventArgs e)
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

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
        }

        private void btDel_Click(object sender, EventArgs e)
        {
            string cur = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
            textBox1.Text = cur;
        }

        private void positifNegatif_Click(object sender, EventArgs e)
        {
            StringBuilder tanda = new StringBuilder(textBox1.Text,0);

                tanda.Insert(0, '-');
                textBox1.Text = tanda.ToString();
                
               

            
            
        } 
    }
}
