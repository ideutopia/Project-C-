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
    public partial class Konverter_Kecepatan : Form
    {
        public Konverter_Kecepatan()
        {
            InitializeComponent();
        }

        private void btKonversi_Click(object sender, EventArgs e)
        {
            bool cekSatuanAwal = ((radioMeter.Checked == true) || (radioKilometer.Checked == true) || (radioMil.Checked == true) || (radioKnot.Checked == true));
            bool cekSatuanKonversi = ((radioMeterKonversi.Checked == true) || (radioKilometerKonversi.Checked == true) || (radioMilKonversi.Checked == true) || (radioKnotKonversi.Checked == true));
            try
            {


                if ((cekSatuanAwal == true) && (cekSatuanKonversi == true))
                {
                    if ((radioMeter.Checked == true) && (radioMeterKonversi.Checked == true))
                    {
                        tbKecepatanKonversi.Text = tbKecepatanAwal.Text;
                    }
                    else if ((radioMeter.Checked == true) && (radioKilometerKonversi.Checked == true)) 
                    {
                        double hasil = Convert.ToDouble(tbKecepatanAwal.Text) * 3.6;
                        tbKecepatanKonversi.Text = hasil.ToString();
                    }
                    else if ((radioMeter.Checked == true) && (radioMilKonversi.Checked == true))
                    {
                        double hasil = Convert.ToDouble(tbKecepatanAwal.Text) * 2.237136;
                        tbKecepatanKonversi.Text = hasil.ToString();
                    }
                    else if ((radioMeter.Checked == true) && (radioKnotKonversi.Checked == true))
                    {
                        double hasil = Convert.ToDouble(tbKecepatanAwal.Text) * 1.944012;
                        tbKecepatanKonversi.Text = hasil.ToString();
                    }
                    //masuk ke KM
                    else if ((radioKilometer.Checked == true) && (radioMeterKonversi.Checked == true))
                    {
                        double hasil = Convert.ToDouble(tbKecepatanAwal.Text) * 0.277;
                        tbKecepatanKonversi.Text = hasil.ToString();
                    }
                    else if ((radioKilometer.Checked == true) && (radioKilometerKonversi.Checked == true))
                    {
                        tbKecepatanKonversi.Text = tbKecepatanAwal.Text;
                    }
                    else if ((radioKilometer.Checked == true) && (radioMilKonversi.Checked == true))
                    {
                        double hasil = Convert.ToDouble(tbKecepatanAwal.Text) * 0.621427;
                        tbKecepatanKonversi.Text = hasil.ToString();
                    }
                    else if ((radioKilometer.Checked==true)&&(radioKnotKonversi.Checked==true))
                    {
                        double hasil = Convert.ToDouble(tbKecepatanAwal.Text) * 0.54003;
                        tbKecepatanKonversi.Text = hasil.ToString();
                    }
                    
                    else if ((radioMil.Checked == true) && (radioMeterKonversi.Checked == true))
                    {
                        double hasil = Convert.ToDouble(tbKecepatanAwal.Text) * 0.447;
                        tbKecepatanKonversi.Text = hasil.ToString();
                    }
                    else if ((radioMil.Checked == true) && (radioKilometerKonversi.Checked == true))
                    {
                         double hasil = Convert.ToDouble(tbKecepatanAwal.Text) * 1.6029;
                        tbKecepatanKonversi.Text = hasil.ToString();
                    }
                    else if ((radioMil.Checked == true) && (radioMilKonversi.Checked == true))
                    {
                       
                        tbKecepatanKonversi.Text = tbKecepatanAwal.Text;
                    }
                    else if ((radioMil.Checked==true)&&(radioKnotKonversi.Checked==true))
                    {
                        double hasil = Convert.ToDouble(tbKecepatanAwal.Text) * 0.8689;
                        tbKecepatanKonversi.Text = hasil.ToString();
                    }

                    //masuk ke Knot
                    else if ((radioKnot.Checked == true) && (radioMeterKonversi.Checked == true))
                    {
                        double hasil = Convert.ToDouble(tbKecepatanAwal.Text) * 0.5144;
                        tbKecepatanKonversi.Text = hasil.ToString();
                    }
                    else if ((radioKnot.Checked == true) && (radioKilometerKonversi.Checked == true))
                    {
                         double hasil = Convert.ToDouble(tbKecepatanAwal.Text) * 1.85184;
                        tbKecepatanKonversi.Text = hasil.ToString();
                    }
                    else if ((radioKnot.Checked == true) && (radioMilKonversi.Checked == true))
                    {
                       double hasil = Convert.ToDouble(tbKecepatanAwal.Text) * 1.150783;
                       tbKecepatanKonversi.Text = hasil.ToString();
                       
                    }
                    else if ((radioKnot.Checked==true)&&(radioKnotKonversi.Checked==true))
                    {
                        
                         tbKecepatanKonversi.Text = tbKecepatanAwal.Text;
                    }

                     
                }
                else
                {
                    MessageBox.Show("Silahkan pilih  Satuan");
                }
            }
            catch(FormatException a)
            {
                MessageBox.Show("Masukkan yang anda input bukan angka");
            }
        }
    }
}
