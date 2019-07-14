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
    public partial class Konverter_Luas : Form
    {
        public Konverter_Luas()
        {
            InitializeComponent();
        }

        private void btKonversi_Click(object sender, EventArgs e)
        {
            try
            {
                bool cekSatuan = ((radioMeter.Checked == true) || (radioHektar.Checked == true) || (radioKiloMeter.Checked == true) || (radioAcre.Checked == true));
                bool cekKonversi = ((radioMeterKonversi.Checked==true)||(radioHektarKonversi.Checked==true)||(radioKilometerKonversi.Checked==true)||(radioAcreKonversi.Checked==true));
                if ((cekSatuan == true) && (cekKonversi == true))
                {
                    if ((radioMeter.Checked == true) && (radioMeterKonversi.Checked == true))
                    {
                        tbJarakKonversi.Text = tbJarakAwal.Text;
                    }
                    else if ((radioMeter.Checked == true) && (radioHektarKonversi.Checked == true))
                    {
                        double hasilKonversi = Convert.ToDouble(tbJarakAwal.Text) * 0.0001;
                        tbJarakKonversi.Text = hasilKonversi.ToString();
                    }
                    else if ((radioMeter.Checked == true) && (radioKilometerKonversi.Checked == true))
                    {
                        double hasilKonversi = Convert.ToDouble(tbJarakAwal.Text) * 0.000001;
                        tbJarakKonversi.Text = hasilKonversi.ToString();
                    }

                    else if ((radioMeter.Checked == true) && (radioAcreKonversi.Checked == true))
                    {
                        double hasilKonversi = Convert.ToDouble(tbJarakAwal.Text) * 0.000247;
                        tbJarakKonversi.Text = hasilKonversi.ToString();
                    }
                    //masuk ke Pascal
                    else if ((radioHektar.Checked == true) && (radioMeterKonversi.Checked == true))
                    {
                        double hasilKonversi = Convert.ToDouble(tbJarakAwal.Text) * (1 * Math.Pow(10, 4));
                        tbJarakKonversi.Text = hasilKonversi.ToString();
                    }
                    else if ((radioHektar.Checked == true) && (radioHektarKonversi.Checked == true))
                    {
                        tbJarakKonversi.Text = tbJarakAwal.Text;
                    }
                    else if ((radioHektar.Checked == true) && (radioKilometerKonversi.Checked == true))
                    {
                        double hasilKonversi = Convert.ToDouble(tbJarakAwal.Text) * (1 * Math.Pow(10, -2));
                        tbJarakKonversi.Text = hasilKonversi.ToString();
                    }
                    else if ((radioHektar.Checked == true) && (radioAcreKonversi.Checked == true))
                    {
                        double hasilKonversi = Convert.ToDouble(tbJarakAwal.Text) * 2.471054;
                        tbJarakKonversi.Text = hasilKonversi.ToString();
                    }
                    //MASUK KE BAROMETER
                    else if ((radioKiloMeter.Checked == true) && (radioMeterKonversi.Checked == true))
                    {
                        double hasilKonversi = Convert.ToDouble(tbJarakAwal.Text) * (1*Math.Pow(10,6));
                        tbJarakKonversi.Text = hasilKonversi.ToString();
                    }
                    else if ((radioKiloMeter.Checked == true) && (radioHektarKonversi.Checked == true))
                    {
                        double hasilKonversi = Convert.ToDouble(tbJarakAwal.Text) * (1 * Math.Pow(10, 2));
                        tbJarakKonversi.Text = hasilKonversi.ToString();
                    }
                    else if ((radioKiloMeter.Checked == true) && (radioKilometerKonversi.Checked == true))
                    {
                        tbJarakKonversi.Text = tbJarakKonversi.Text;
                    }
                    else if ((radioKiloMeter.Checked == true) && (radioAcreKonversi.Checked == true))
                    {
                        double hasilKonversi = Convert.ToDouble(tbJarakAwal.Text) * 247.1054;
                        tbJarakKonversi.Text = hasilKonversi.ToString();
                    }
                    //masuk ke milimeter raksa
                    else if ((radioAcre.Checked == true) && (radioMeterKonversi.Checked == true))
                    {
                        double hasilKonversi = Convert.ToDouble(tbJarakAwal.Text) * 4046.856;
                        tbJarakKonversi.Text = hasilKonversi.ToString();
                    }
                    else if ((radioAcre.Checked == true) && (radioHektarKonversi.Checked == true))
                    {
                        double hasilKonversi = Convert.ToDouble(tbJarakAwal.Text) * 0.4046856;
                        tbJarakKonversi.Text = hasilKonversi.ToString();
                    }
                    else if ((radioAcre.Checked == true) && (radioKilometerKonversi.Checked == true))
                    {
                        double hasilKonversi = Convert.ToDouble(tbJarakAwal.Text) * 0.004047;
                        tbJarakKonversi.Text = hasilKonversi.ToString();
                    }
                    else if ((radioAcre.Checked == true) && (radioAcreKonversi.Checked == true))
                    {
                        tbJarakKonversi.Text = tbJarakAwal.Text;
                    }

                }
                else
                {
                    MessageBox.Show("Silahkan pilih satuan");
                }
            }
            catch(FormatException x)
            {
                MessageBox.Show("Input yang anda masukkan bukan angka");
            }
        }
    }
}
