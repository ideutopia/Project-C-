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
    public partial class Konverter_Waktu : Form
    {
        public Konverter_Waktu()
        {
            InitializeComponent();
        }

        private void btKonversi_Click(object sender, EventArgs e)
        {
            try
            {
                bool cekSatuan = ((radioMilidetik.Checked == true) || (radioDetik.Checked == true) || (radioMenit.Checked == true) || (radioJam.Checked == true)||(radioHari.Checked==true));
                bool cekKonversi = ((radioMilidetikKonversi.Checked == true) || (radioDetikKonversi.Checked == true) || (radioMenitKonversi.Checked == true) || (radioJamKonversi.Checked == true)||(radioHariKonversi.Checked==true));
                if ((radioMilidetik.Checked == true) && (radioMilidetikKonversi.Checked == true))
                {
                    tbWaktuKonversi.Text = tbWaktuAwal.Text;
                }
                else if ((radioMilidetik.Checked == true) && (radioDetikKonversi.Checked == true))
                {
                    double hasilKonversi = Convert.ToDouble(tbWaktuAwal.Text) /1000;
                    tbWaktuKonversi.Text = hasilKonversi.ToString();
                }
                else if ((radioMilidetik.Checked == true) && (radioMenitKonversi.Checked == true))
                {
                    double hasilKonversi = Convert.ToDouble(tbWaktuAwal.Text) * 60* Math.Pow(10,3);
                    tbWaktuKonversi.Text = hasilKonversi.ToString();
                }

                else if ((radioMilidetik.Checked == true) && (radioJamKonversi.Checked == true))
                {
                    double hasilKonversi = Convert.ToDouble(tbWaktuAwal.Text) * 3600 * Math.Pow(10,3);
                    tbWaktuKonversi.Text = hasilKonversi.ToString();
                }
                else if((radioMilidetik.Checked==true)&&(radioHariKonversi.Checked==true)) {
                    double hasilKonversi = Convert.ToDouble(tbWaktuAwal.Text) * 3600 * Math.Pow(10, 3)*24;
                    tbWaktuKonversi.Text = hasilKonversi.ToString();
                }
                //masuk ke Detik
                else if ((radioDetik.Checked == true) && (radioMilidetikKonversi.Checked == true))
                {
                    double hasilKonversi = Convert.ToDouble(tbWaktuAwal.Text) * (1 * Math.Pow(10, 3));
                    tbWaktuKonversi.Text = hasilKonversi.ToString();
                }
                else if ((radioDetik.Checked == true) && (radioDetikKonversi.Checked == true))
                {
                    tbWaktuKonversi.Text = tbWaktuAwal.Text;
                }
                else if ((radioDetik.Checked == true) && (radioMenitKonversi.Checked == true))
                {
                    double hasilKonversi = Convert.ToDouble(tbWaktuAwal.Text)/60;
                    tbWaktuKonversi.Text = hasilKonversi.ToString();
                }
                else if ((radioDetik.Checked == true) && (radioJamKonversi.Checked == true))
                {
                    double hasilKonversi = Convert.ToDouble(tbWaktuAwal.Text) /(60*60);
                    tbWaktuKonversi.Text = hasilKonversi.ToString();
                }
                else if ((radioDetik.Checked == true) && (radioHariKonversi.Checked == true))
                {
                    double hasilKonversi = Convert.ToDouble(tbWaktuAwal.Text) / (60 * 60 *24);
                    tbWaktuKonversi.Text = hasilKonversi.ToString();
                }
                //masuk ke menit
                else if ((radioMenit.Checked == true) && (radioMilidetikKonversi.Checked == true))
                {
                    double hasilKonversi = Convert.ToDouble(tbWaktuAwal.Text) * (60*1000);
                    tbWaktuKonversi.Text = hasilKonversi.ToString();
                }
                else if ((radioMenit.Checked == true) && (radioDetikKonversi.Checked == true))
                {
                    double hasilKonversi = Convert.ToDouble(tbWaktuAwal.Text) * (60);
                    tbWaktuKonversi.Text = hasilKonversi.ToString();
                }
                else if ((radioMenit.Checked == true) && (radioMenitKonversi.Checked == true))
                {
                    tbWaktuKonversi.Text = tbWaktuKonversi.Text;
                }
                else if ((radioMenit.Checked == true) && (radioJamKonversi.Checked == true))
                {
                    double hasilKonversi = Convert.ToDouble(tbWaktuAwal.Text) / 60;
                    tbWaktuKonversi.Text = hasilKonversi.ToString();
                }
                else if ((radioMenit.Checked == true)&&(radioHariKonversi.Checked==true)){
                    double hasilKonversi = Convert.ToDouble(tbWaktuAwal.Text) / (60*24);
                    tbWaktuKonversi.Text = hasilKonversi.ToString();
                }
                //masuk ke Jam
                else if ((radioJam.Checked == true) && (radioMilidetikKonversi.Checked == true))
                {
                    double hasilKonversi = Convert.ToDouble(tbWaktuAwal.Text) * (60*60*1000);
                    tbWaktuKonversi.Text = hasilKonversi.ToString();
                }
                else if ((radioJam.Checked == true) && (radioDetikKonversi.Checked == true))
                {
                    double hasilKonversi = Convert.ToDouble(tbWaktuAwal.Text) * 3600;
                    tbWaktuKonversi.Text = hasilKonversi.ToString();
                }
                else if ((radioJam.Checked == true) && (radioMenitKonversi.Checked == true))
                {
                    double hasilKonversi = Convert.ToDouble(tbWaktuAwal.Text) * 60;
                    tbWaktuKonversi.Text = hasilKonversi.ToString();
                }
                else if ((radioJam.Checked == true) && (radioJamKonversi.Checked == true))
                {
                    tbWaktuKonversi.Text = tbWaktuAwal.Text;
                }
                else if ((radioJam.Checked==true)&&(radioHari.Checked==true))
                {
                    double hasilKonversi = Convert.ToDouble(tbWaktuAwal.Text) / 24;
                    tbWaktuKonversi.Text = hasilKonversi.ToString();
                }
                //masuk ke Hari
                else if ((radioHari.Checked == true) && (radioMilidetikKonversi.Checked == true))
                {
                    double hasilKonversi = Convert.ToDouble(tbWaktuAwal.Text) * (1000 * 60 * 60 * 24);
                    tbWaktuKonversi.Text = hasilKonversi.ToString();
                }
                else if ((radioHari.Checked == true) && (radioDetikKonversi.Checked == true))
                {
                    double hasilKonversi = Convert.ToDouble(tbWaktuAwal.Text) * (60 * 60 * 24);
                    tbWaktuKonversi.Text = hasilKonversi.ToString();
                }
                else if ((radioHari.Checked == true) && (radioMenitKonversi.Checked == true))
                {
                    double hasilKonversi = Convert.ToDouble(tbWaktuAwal.Text) * (60 * 24);
                    tbWaktuKonversi.Text = hasilKonversi.ToString();
                }
                else if ((radioHari.Checked == true) && (radioJamKonversi.Checked == true))
                {
                    double hasilKonversi = Convert.ToDouble(tbWaktuAwal.Text) * 24;
                    tbWaktuKonversi.Text = hasilKonversi.ToString();
                }
                else if ((radioHari.Checked == true) && (radioHariKonversi.Checked = true))
                {
                    tbWaktuKonversi.Text = tbWaktuAwal.Text;
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

        private void KonversiWaktuDua_Click(object sender, EventArgs e)
        {
            try
            {
                bool cekSatuan = ((radioHariDua.Checked == true) || (radioBulan.Checked == true) || (radioTahun.Checked == true) || (radioWindu.Checked == true) || (radioAbad.Checked == true));
                bool cekKonversi = ((radioHariDuaKonversi.Checked == true) || (radioBulanKonversi.Checked == true) || (radioTahunKonversi.Checked == true) || (radioWinduKonversi.Checked == true) || (radioAbadKonversi.Checked == true));
                if ((radioHariDua.Checked == true) && (radioHariDuaKonversi.Checked == true))
                {
                    tbWaktuKonversiDua.Text = tbWaktuAwalDua.Text;
                }
                else if ((radioHariDua.Checked == true) && (radioBulanKonversi.Checked == true))
                {
                    double hasilKonversi = Convert.ToDouble(tbWaktuAwalDua.Text) / 30.41;
                    tbWaktuKonversiDua.Text = hasilKonversi.ToString();
                }
                else if ((radioHariDua.Checked == true) && (radioTahunKonversi.Checked == true))
                {
                    double hasilKonversi = Convert.ToDouble(tbWaktuAwalDua.Text) / 365;
                    tbWaktuKonversiDua.Text = hasilKonversi.ToString();
                }

                else if ((radioHariDua.Checked == true) && (radioWinduKonversi.Checked == true))
                {
                    double hasilKonversi = Convert.ToDouble(tbWaktuAwalDua.Text) / ((365*6)+(366*2));
                    tbWaktuKonversiDua.Text = hasilKonversi.ToString();
                }
                else if ((radioHariDua.Checked == true) && (radioAbadKonversi.Checked == true))
                {
                    double hasilKonversi = Convert.ToDouble(tbWaktuAwalDua.Text)/ ((365 * 75) + (366 * 25));
                    tbWaktuKonversiDua.Text = hasilKonversi.ToString();
                }
                //masuk ke Bulan
                else if ((radioBulan.Checked == true) && (radioHariDuaKonversi.Checked == true))
                {
                    double hasilKonversi = Convert.ToDouble(tbWaktuAwalDua.Text) * 30.41;
                    tbWaktuKonversiDua.Text = hasilKonversi.ToString();
                }
                else if ((radioBulan.Checked == true) && (radioBulanKonversi.Checked == true))
                {
                    tbWaktuKonversiDua.Text = tbWaktuAwalDua.Text;
                }
                else if ((radioBulan.Checked == true) && (radioTahunKonversi.Checked == true))
                {
                    double hasilKonversi = Convert.ToDouble(tbWaktuAwalDua.Text) / 12;
                    tbWaktuKonversiDua.Text = hasilKonversi.ToString();
                }
                else if ((radioBulan.Checked == true) && (radioWinduKonversi.Checked == true))
                {
                    double hasilKonversi = Convert.ToDouble(tbWaktuAwalDua.Text) / (8 * 12);
                    tbWaktuKonversiDua.Text = hasilKonversi.ToString();
                }
                else if ((radioBulan.Checked == true) && (radioAbadKonversi.Checked == true))
                {
                    double hasilKonversi = Convert.ToDouble(tbWaktuAwalDua.Text) / (12 * 100);
                    tbWaktuKonversiDua.Text = hasilKonversi.ToString();
                }

                //masuk ke tahun
                else if ((radioTahun.Checked == true) && (radioHariDuaKonversi.Checked == true))
                {
                    double hasilKonversi = Convert.ToDouble(tbWaktuAwalDua.Text) * 365.25;
                    tbWaktuKonversiDua.Text = hasilKonversi.ToString();
                }
                else if ((radioTahun.Checked == true) && (radioBulanKonversi.Checked == true))
                {
                    double hasilKonversi = Convert.ToDouble(tbWaktuAwalDua.Text) * 12;
                    tbWaktuKonversiDua.Text = hasilKonversi.ToString();
                }
                else if ((radioTahun.Checked == true) && (radioTahunKonversi.Checked == true))
                {
                    tbWaktuKonversiDua.Text = tbWaktuAwalDua.Text;
                }
                else if ((radioTahun.Checked == true) && (radioWinduKonversi.Checked == true))
                {
                    double hasilKonversi = Convert.ToDouble(tbWaktuAwalDua.Text) / 8;
                    tbWaktuKonversiDua.Text = hasilKonversi.ToString();
                }
                else if ((radioTahun.Checked == true)&&(radioAbadKonversi.Checked == true))
                {
                    double hasilKonversi = Convert.ToDouble(tbWaktuAwalDua.Text) / 100;
                    tbWaktuKonversiDua.Text = hasilKonversi.ToString();
                }
                //masuk ke Windu
                else if ((radioWindu.Checked == true) && (radioHariDuaKonversi.Checked == true))
                {
                    double hasilKonversi = Convert.ToDouble(tbWaktuAwalDua.Text) * ((365*6)+(366*2));
                    tbWaktuKonversiDua.Text = hasilKonversi.ToString();
                }
                else if ((radioWindu.Checked == true) && (radioBulanKonversi.Checked == true))
                {
                    double hasilKonversi = Convert.ToDouble(tbWaktuAwalDua.Text) * (12*8);
                    tbWaktuKonversiDua.Text = hasilKonversi.ToString();
                }
                else if ((radioWindu.Checked == true) && (radioTahunKonversi.Checked == true))
                {
                    double hasilKonversi = Convert.ToDouble(tbWaktuAwalDua.Text) * 8;
                    tbWaktuKonversiDua.Text = hasilKonversi.ToString();
                }
                else if ((radioWindu.Checked == true) && (radioWinduKonversi.Checked == true))
                {
                    tbWaktuKonversiDua.Text = tbWaktuAwalDua.Text;
                }
                else if ((radioWindu.Checked == true) && (radioAbadKonversi.Checked = true))
                {
                    double hasilKonversi = Convert.ToDouble(tbWaktuAwalDua.Text) /12.5;
                    tbWaktuKonversiDua.Text = hasilKonversi.ToString();
                }
                //masuk ke Abad
                else if ((radioAbad.Checked == true) && (radioHariDuaKonversi.Checked == true))
                {
                    double hasilKonversi = Convert.ToDouble(tbWaktuAwalDua.Text) * ((365*75)+(366*25));
                    tbWaktuKonversiDua.Text = hasilKonversi.ToString();
                }
                else if ((radioAbad.Checked == true) && (radioBulanKonversi.Checked == true))
                {
                    double hasilKonversi = Convert.ToDouble(tbWaktuAwalDua.Text) * (12*100);
                    tbWaktuKonversiDua.Text = hasilKonversi.ToString();
                }
                else if ((radioAbad.Checked == true) && (radioTahunKonversi.Checked == true))
                {
                    double hasilKonversi = Convert.ToDouble(tbWaktuAwalDua.Text) * (100);
                    tbWaktuKonversiDua.Text = hasilKonversi.ToString();
                }
                else if ((radioAbad.Checked == true) && (radioWinduKonversi.Checked == true))
                {
                    double hasilKonversi = Convert.ToDouble(tbWaktuAwalDua.Text) * 12.5;
                    tbWaktuKonversiDua.Text = hasilKonversi.ToString();
                }
                else if ((radioAbad.Checked == true) && (radioAbadKonversi.Checked == true))
                {
                    tbWaktuKonversiDua.Text = tbWaktuKonversiDua.Text;
                }

            }
            catch (FormatException x)
            {
                MessageBox.Show("Input yang anda masukkan bukan angka");
            }
        }
    }
}
