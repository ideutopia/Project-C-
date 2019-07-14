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
    public partial class Konverter_Tekanan : Form
    {
        public Konverter_Tekanan()
        {
            InitializeComponent();
        }

        private void btKonversi_Click(object sender, EventArgs e)
        {
            try
            {
                bool cekSatuan = ((radioAtm.Checked == true) || (radioPascal.Checked == true) || (radioBar.Checked == true) || (radioMmHg.Checked == true));
                bool cekSatuanKonversi = ((radioAtmKonversi.Checked == true) || (radioPascalKonversi.Checked == true) || (radioBarKonversi.Checked == true) || (radioMmHgKonversi.Checked == true));
                if ((cekSatuan == true) && (cekSatuanKonversi == true))
                {
                    if ((radioAtm.Checked == true) && (radioAtmKonversi.Checked == true))
                    {
                        tbTekananKonversi.Text = tbtekananAwal.Text;
                    }
                    else if ((radioAtm.Checked == true) && (radioPascalKonversi.Checked == true))
                    {
                        double hasilKonversi = Convert.ToDouble(tbtekananAwal.Text) * 101325;
                        tbTekananKonversi.Text = hasilKonversi.ToString();
                    }
                    else if ((radioAtm.Checked == true) && (radioBarKonversi.Checked == true))
                    {
                        double hasilKonversi = Convert.ToDouble(tbtekananAwal.Text) * 1.01325;
                        tbTekananKonversi.Text = hasilKonversi.ToString();
                    }

                    else if ((radioAtm.Checked == true) && (radioMmHgKonversi.Checked == true))
                    {
                        double hasilKonversi = Convert.ToDouble(tbtekananAwal.Text) * 760.1275;
                        tbTekananKonversi.Text = hasilKonversi.ToString();
                    }
                    //masuk ke Pascal
                    else if ((radioPascal.Checked == true) && (radioAtmKonversi.Checked == true))
                    {
                        double hasilKonversi = Convert.ToDouble(tbtekananAwal.Text)*(9.869*Math.Pow(10,-6));
                        tbTekananKonversi.Text = hasilKonversi.ToString();
                    }
                    else if ((radioPascal.Checked == true) && (radioPascalKonversi.Checked == true))
                    {
                        tbTekananKonversi.Text = tbtekananAwal.Text;
                    }
                    else if ((radioPascal.Checked == true) && (radioBarKonversi.Checked == true))
                    {
                        double hasilKonversi = Convert.ToDouble(tbtekananAwal.Text) * (1*Math.Pow(10,-5));
                        tbTekananKonversi.Text = hasilKonversi.ToString();
                    }
                    else if ((radioPascal.Checked == true) && (radioMmHgKonversi.Checked == true))
                    {
                        double hasilKonversi = Convert.ToDouble(tbtekananAwal.Text) * 0.0075;
                        tbTekananKonversi.Text = hasilKonversi.ToString();
                    }
                    //MASUK KE BAROMETER
                    else if ((radioBar.Checked == true) && (radioAtmKonversi.Checked == true))
                    {
                        double hasilKonversi = Convert.ToDouble(tbtekananAwal.Text) * 0.986923;
                        tbTekananKonversi.Text = hasilKonversi.ToString();
                    }
                    else if ((radioBar.Checked == true) && (radioPascalKonversi.Checked == true))
                    {
                        double hasilKonversi = Convert.ToDouble(tbtekananAwal.Text) * (1 * Math.Pow(10, 5));
                        tbTekananKonversi.Text = hasilKonversi.ToString();
                    }
                    else if ((radioBar.Checked == true) && (radioBarKonversi.Checked == true))
                    {
                        tbTekananKonversi.Text = tbTekananKonversi.Text;
                    }
                    else if ((radioBar.Checked == true) && (radioMmHgKonversi.Checked == true))
                    {
                        double hasilKonversi = Convert.ToDouble(tbtekananAwal.Text) * 750.1875;
                        tbTekananKonversi.Text = hasilKonversi.ToString();
                    }
                    //masuk ke milimeter raksa
                    else if ((radioMmHg.Checked == true) && (radioAtmKonversi.Checked == true))
                    {
                        double hasilKonversi = Convert.ToDouble(tbtekananAwal.Text) / 760;
                        tbTekananKonversi.Text = hasilKonversi.ToString();
                    }
                    else if ((radioMmHg.Checked == true) && (radioPascalKonversi.Checked == true))
                    {
                        double hasilKonversi = Convert.ToDouble(tbtekananAwal.Text) * 133.3;
                        tbTekananKonversi.Text = hasilKonversi.ToString();
                    }
                    else if ((radioMmHg.Checked == true) && (radioBarKonversi.Checked == true))
                    {
                        double hasilKonversi = Convert.ToDouble(tbtekananAwal.Text) * 0.00133;
                        tbTekananKonversi.Text = hasilKonversi.ToString();
                    }
                    else if ((radioMmHg.Checked == true) && (radioMmHgKonversi.Checked == true))
                    {
                        tbTekananKonversi.Text = tbtekananAwal.Text;
                    }

                }
                else
                {
                    MessageBox.Show("Silahkan pilih satuan");
                }
            }catch(FormatException x)
            {
                MessageBox.Show("Masukkan yang anda input bukan angka");
            }
         }

    }
}
