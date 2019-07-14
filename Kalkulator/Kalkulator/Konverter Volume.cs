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
    public partial class Konverter_Volume : Form
    {
        public Konverter_Volume()
        {
            InitializeComponent();
        }

        private void btKonversi_Click(object sender, EventArgs e)
        {
            try
            {
                bool cekSatuan = ((radioLiter.Checked == true) || (radioMeter.Checked == true) || (radioGalon.Checked == true) || (radioSendokMakan.Checked == true));
                bool cekKonversi = ((radioLiterKonversi.Checked == true) || (radioMeterKonversi.Checked == true) || (radioGalonKonversi.Checked == true) || (radioSendokMakanKonversi.Checked == true));
                if ((cekSatuan == true) && (cekKonversi == true))
                {
                    if ((radioLiter.Checked == true) && (radioLiterKonversi.Checked == true))
                    {
                        tbVolumeKonversi.Text = tbVolumeAwal.Text;
                    }
                    else if ((radioLiter.Checked == true) && (radioMeterKonversi.Checked == true))
                    {
                        double hasilKonversi = Convert.ToDouble(tbVolumeAwal.Text) * 0.001;
                        tbVolumeKonversi.Text = hasilKonversi.ToString();
                    }
                    else if ((radioLiter.Checked == true) && (radioGalonKonversi.Checked == true))
                    {
                        double hasilKonversi = Convert.ToDouble(tbVolumeAwal.Text) * 0.264172;
                        tbVolumeKonversi.Text = hasilKonversi.ToString();
                    }

                    else if ((radioLiter.Checked == true) && (radioSendokMakanKonversi.Checked == true))
                    {
                        double hasilKonversi = Convert.ToDouble(tbVolumeAwal.Text) * 67.62;
                        tbVolumeKonversi.Text = hasilKonversi.ToString();
                    }
                    
                    else if ((radioMeter.Checked == true) && (radioLiterKonversi.Checked == true))
                    {
                        double hasilKonversi = Convert.ToDouble(tbVolumeAwal.Text) * (1 * Math.Pow(10, 3));
                        tbVolumeKonversi.Text = hasilKonversi.ToString();
                    }
                    else if ((radioMeter.Checked == true) && (radioMeterKonversi.Checked == true))
                    {
                        tbVolumeKonversi.Text = tbVolumeAwal.Text;
                    }
                    else if ((radioMeter.Checked == true) && (radioGalonKonversi.Checked == true))
                    {
                        double hasilKonversi = Convert.ToDouble(tbVolumeAwal.Text) * 264.172;
                        tbVolumeKonversi.Text = hasilKonversi.ToString();
                    }
                    else if ((radioMeter.Checked == true) && (radioSendokMakanKonversi.Checked == true))
                    {
                        double hasilKonversi = Convert.ToDouble(tbVolumeAwal.Text) * 56.312;
                        tbVolumeKonversi.Text = hasilKonversi.ToString();
                    }
                    
                    else if ((radioGalon.Checked == true) && (radioLiterKonversi.Checked == true))
                    {
                        double hasilKonversi = Convert.ToDouble(tbVolumeAwal.Text) * 3.78;
                        tbVolumeKonversi.Text = hasilKonversi.ToString();
                    }
                    else if ((radioGalon.Checked == true) && (radioMeterKonversi.Checked == true))
                    {
                        double hasilKonversi = Convert.ToDouble(tbVolumeAwal.Text) * 0.003785;
                        tbVolumeKonversi.Text = hasilKonversi.ToString();
                    }
                    else if ((radioGalon.Checked == true) && (radioGalonKonversi.Checked == true))
                    {
                        tbVolumeKonversi.Text = tbVolumeAwal.Text;
                    }
                    else if ((radioGalon.Checked == true) && (radioSendokMakanKonversi.Checked == true))
                    {
                        double hasilKonversi = Convert.ToDouble(tbVolumeAwal.Text) * 256;
                        tbVolumeKonversi.Text = hasilKonversi.ToString();
                    }
                    
                    else if ((radioSendokMakan.Checked == true) && (radioLiterKonversi.Checked == true))
                    {
                        double hasilKonversi = Convert.ToDouble(tbVolumeAwal.Text) * 0.14787;
                        tbVolumeKonversi.Text = hasilKonversi.ToString();
                    }
                    else if ((radioSendokMakan.Checked == true) && (radioMeterKonversi.Checked == true))
                    {
                        double hasilKonversi = Convert.ToDouble(tbVolumeAwal.Text) * 0.000015;
                        tbVolumeKonversi.Text = hasilKonversi.ToString();
                    }
                    else if ((radioSendokMakan.Checked == true) && (radioGalonKonversi.Checked == true))
                    {
                        double hasilKonversi = Convert.ToDouble(tbVolumeAwal.Text) * 0.003906;
                        tbVolumeKonversi.Text = hasilKonversi.ToString();
                    }
                    else if ((radioSendokMakan.Checked == true) && (radioSendokMakanKonversi.Checked == true))
                    {
                        tbVolumeKonversi.Text = tbVolumeAwal.Text;
                    }

                }
                else
                {
                    MessageBox.Show("Silahkan pilih satuan");
                }
            }
            catch (FormatException x)
            {
                MessageBox.Show("Input yang anda masukkan bukan angka");
            }
        }
    }
}
