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
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
        }
        
        static double angka1,angka2,angka3,angka4,angka5,angka6,angka7,angka8,angka9,angka0,bil1,bil2,hasil;
        byte operand;
        static string formula;
        static string[] value;

        private void btsubs_Click(object sender, EventArgs e)
        {
            
            tbCalc.Text += btsubs.Text;
            operand = 2;
        }

        private void btMul_Click(object sender, EventArgs e)
        {
            tbCalc.Text += btMul.Text;
            operand = 3;
        }

        private void btDiv_Click(object sender, EventArgs e)
        {
            StringBuilder letakOperator = new StringBuilder(tbCalc.Text);
            letakOperator.Insert(tbCalc.Text.Length, '/');
            tbCalc.Text = letakOperator.ToString();
            operand = 4;

        }

        private void btdel_Click(object sender, EventArgs e)
        {
            tbCalc.Text = null;
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            try
            {
                string cur = tbCalc.Text.Remove(tbCalc.Text.Length - 1, 1);
                tbCalc.Text = cur;
            }catch (ArgumentOutOfRangeException x)
            {
                MessageBox.Show("Field telah null");
            }
        }

        private void btTitik_Click(object sender, EventArgs e)
        {
            tbCalc.Text += btTitik.Text;
            
        }

        private void suhuToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Konverter_Suhu frame = new Konverter_Suhu();
            frame.ShowDialog();
            this.Close();
        }

        private void btMod_Click(object sender, EventArgs e)
        {
            tbCalc.Text += btMod.Text;
            operand = 5;
        }

        private void btRoot_Click(object sender, EventArgs e)
        {
            double value = Convert.ToDouble(tbCalc.Text);
            double hasil = Math.Sqrt(value);
            tbCalc.Text = hasil.ToString();
        }

        private void kuadratX_Click(object sender, EventArgs e)
        {
            double value = Convert.ToDouble(tbCalc.Text);
            double hasil = value * value;
            tbCalc.Text = hasil.ToString();
        }

        private void faktorial_Click(object sender, EventArgs e)
        {
            double i, number, fact;
            number = Convert.ToDouble(tbCalc.Text);
            fact = number;
            for (i = number - 1; i >= 1; i--)
            {
                fact = fact * i;
            }
            tbCalc.Text = fact.ToString();


            
        }

        private void btEquals_Click(object sender, EventArgs e)
        {   
           
           
       
            switch (operand)
             {
                 case 1 :
                    try
                    {
                        formula = tbCalc.Text;
                        value = formula.Split('+');
                        bil1 = Convert.ToDouble(value[0]);
                        bil2 = Convert.ToDouble(value[1]);

                        hasil = bil1 + bil2;
                        tbCalc.Text = hasil.ToString();
                    }
                    catch(FormatException x)
                    {
                        MessageBox.Show("Masukkan field bukan angka");
                    }
                    finally
                    {
                        tbCalc.Text = null;
                    }
                     break;
                 case 2:
                    try
                    {
                        formula = tbCalc.Text;
                        value = formula.Split('-');
                        bil1 = Convert.ToDouble(value[0]);
                        bil2 = Convert.ToDouble(value[1]);

                        hasil = bil1 - bil2;
                        tbCalc.Text = hasil.ToString();
                    }
                    catch(FormatException x)
                    {
                        MessageBox.Show("Masukkan field bukan angka");
                    }
                    finally
                    {
                        tbCalc.Text = null;
                    }
                    break;
                 case 3:
                    try
                    {
                        formula = tbCalc.Text;
                        value = formula.Split('*');
                        bil1 = Convert.ToDouble(value[0]);
                        bil2 = Convert.ToDouble(value[1]);

                        hasil = bil1 * bil2;
                        tbCalc.Text = hasil.ToString();
                    }
                    catch(FormatException x)
                    {
                        MessageBox.Show("Masukkan field bukan angka");
                    }
                    finally
                    {
                        tbCalc.Text = null;
                    }
                    break;
                 case 4:
                    try
                    {


                        formula = tbCalc.Text;
                        value = formula.Split('/');
                        bil1 = Convert.ToDouble(value[0]);
                        bil2 = Convert.ToDouble(value[1]);

                        hasil = bil1 / bil2;
                        tbCalc.Text = hasil.ToString();
                    }
                    catch(FormatException x)
                    {
                        MessageBox.Show("Masukkan field bukan angka");
                        tbCalc.Text = null;
                    }
                    catch(DivideByZeroException x)
                    {
                        tbCalc.Text = "tak hingga";
                    }
                    break;
                case 5:
                    formula = tbCalc.Text;
                    value = formula.Split('%');
                    bil1 = Convert.ToDouble(value[0]);
                    bil2 = Convert.ToDouble(value[1]);

                    hasil = bil1 % bil2;
                    tbCalc.Text = hasil.ToString();
                    break;
                case 6:
                    formula = tbCalc.Text;
                    value = formula.Split('^');
                    bil1 = Convert.ToDouble(value[0]);
                    bil2 = Convert.ToDouble(value[1]);

                    /*for (int i = 0; i <= (int)bil2; i++)
                    {
                        bil1 *= bil1; 
                    }
                    hasil = bil1;
                    //hasil = bil1 % bil2;
                    */
                    hasil = Math.Pow(bil1, bil2); 
                    tbCalc.Text = hasil.ToString();
                    break;
             }
             


        }

        private void zakatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            penghitungZakat frameZakat = new penghitungZakat();
            frameZakat.ShowDialog();
        }

        private void massaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Konverter_Massa frame = new Konverter_Massa();
            frame.ShowDialog();
        }

        private void situsWebToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Untuk kritik saran dapat kunjungi di\nwww.ideutopia.github.io");
        }

        private void tekananToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Konverter_Tekanan frame = new Konverter_Tekanan();
            frame.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void kecepatanToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Konverter_Kecepatan frame = new Konverter_Kecepatan();
            frame.ShowDialog();
        }

        private void luasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Konverter_Luas frame = new Konverter_Luas();
            frame.ShowDialog();
        }

        private void waktuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Konverter_Waktu frame = new Konverter_Waktu();
            frame.ShowDialog();
        }

        private void versiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kalkulator++ \n V 0.1 \n" +
                "Update Terakhir 14 Juli 2019");
        }

        private void zakatToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            penghitungZakat frameZakat = new penghitungZakat();
            frameZakat.ShowDialog();
        }

        private void seperX_Click(object sender, EventArgs e)
        {
            try
            {
                double value = 1/Convert.ToDouble(tbCalc.Text);
                tbCalc.Text = value.ToString();
            }
            catch(FormatException x)
            {
                MessageBox.Show("Input yang anda masukkan bukan angka ");
            }
            catch(NullReferenceException x)
            {
                MessageBox.Show("Isian kosong");
            }
        }

        private void volumeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Konverter_Volume frame = new Konverter_Volume();
            frame.ShowDialog();
        }

        private void pangkatY_Click(object sender, EventArgs e)
        {
            //double value = Convert.ToDouble(tbCalc.Text);
            pangkatY.Text = "^";
            tbCalc.Text += pangkatY.Text;
            operand = 6;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {


            tbCalc.Text += btAdd.Text;
            operand = 1;
        }

        private void btNol_Click(object sender, EventArgs e)
        {
            angka0 = Convert.ToDouble(btNol.Text);
            tbCalc.Text += btNol.Text;
        }

        private void bt9_Click(object sender, EventArgs e)
        {
            angka9 = Convert.ToDouble(bt9.Text);
            tbCalc.Text += bt9.Text;
        }

        private void bt8_Click(object sender, EventArgs e)
        {
            angka8 = Convert.ToDouble(bt8.Text);
            tbCalc.Text += bt8.Text;
        }

        private void bt7_Click(object sender, EventArgs e)
        {
            angka7 = Convert.ToDouble(bt7.Text);
            tbCalc.Text += bt7.Text;
        }

        private void bt6_Click(object sender, EventArgs e)
        {
            angka6 = Convert.ToDouble(bt6.Text);
            tbCalc.Text += bt6.Text;
        }

        private void bt5_Click(object sender, EventArgs e)
        {
            angka5 = Convert.ToDouble(bt5.Text);
            tbCalc.Text += bt5.Text;
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            angka2 = Convert.ToDouble(bt2.Text);
            tbCalc.Text += bt2.Text;
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            angka3 = Convert.ToDouble(bt1.Text);
            tbCalc.Text += bt3.Text;
            
        }

        private void bt4_Click(object sender, EventArgs e)
        {
            angka4 = Convert.ToDouble(bt1.Text);
            tbCalc.Text += bt4.Text;
            
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            angka1 = Convert.ToDouble(bt1.Text);
            tbCalc.Text += bt1.Text;
        }
        
    }
}
