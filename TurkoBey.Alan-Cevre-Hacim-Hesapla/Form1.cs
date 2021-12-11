using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TurkoBey.Alan_Cevre_Hacim_Hesapla
{
    public partial class Form1 : Form
    {
        Hesaplama hesaplama = new Hesaplama();
        public Form1()
        {
            InitializeComponent();
        }
  /*

[Hacim] Küp
[Hacim] Küre
[Hacim] Silindir
[Hacim] Koni
[Hacim] Kare Piramit*/
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (listBox1.SelectedItem.ToString() == "[ Alan ] Eş Kenar Üçgen")
                {
                    Clear();
                    Label1.Visible = true;
                    Label3.Visible = true;
                    txtA.Visible = true;
                    txtH.Visible = true;
                }
                else if (listBox1.SelectedItem.ToString() == "[ Alan ] Üçgen")
                {
                    Clear();
                    Label1.Visible = true;
                    Label3.Visible = true;
                    txtA.Visible = true;
                    txtH.Visible = true;
                }
                else if (listBox1.SelectedItem.ToString() == "[ Alan ] Kare")
                {
                    Clear();
                    Label1.Visible = true;
                    txtA.Visible = true;
                }
                else if (listBox1.SelectedItem.ToString() == "[ Alan ] Dikdörtgen")
                {
                    Clear();
                    Label1.Visible = true;
                    Label3.Visible = true;
                    txtA.Visible = true;
                    txtH.Visible = true;
                }
                else if (listBox1.SelectedItem.ToString() == "[ Alan ] Daire")
                {
                    Clear();
                    Label1.Visible = true;
                    txtA.Visible = true;
                }
                else if (listBox1.SelectedItem.ToString() == "[ Alan ] Yamuk")
                {
                    Clear();
                    Label1.Visible = true;
                    Label2.Visible = true;
                    Label3.Visible = true;
                    txtA.Visible = true;
                    txtB.Visible = true;
                    txtH.Visible = true;
                }
                else if (listBox1.SelectedItem.ToString() == "[ Çevre ] Eş Kenar Üçgen")
                {
                    Clear();
                    Label1.Visible = true;
                    txtA.Visible = true;
                }
                else if (listBox1.SelectedItem.ToString() == "[ Çevre ] Kare")
                {
                    Clear();
                    Label1.Visible = true;
                    txtA.Visible = true;
                }
                else if (listBox1.SelectedItem.ToString() == "[ Çevre ] Dikdörtgen")
                {
                    Clear();
                    Label1.Visible = true;
                    Label3.Visible = true;
                    txtA.Visible = true;
                    txtH.Visible = true;
                }
                else if (listBox1.SelectedItem.ToString() == "[ Çevre ] Beşgen")
                {
                    Clear();
                    Label1.Visible = true;
                    Label3.Visible = true;
                    txtA.Visible = true;
                    txtH.Visible = true;
                }
                else if (listBox1.SelectedItem.ToString() == "[ Çevre ] Altıgen")
                {
                    Clear();
                    Label1.Visible = true;
                    Label3.Visible = true;
                    txtA.Visible = true;
                    txtH.Visible = true;
                }
                else if (listBox1.SelectedItem.ToString() == "[ Çevre ] Sekizgen")
                {
                    Clear();
                    Label1.Visible = true;
                    Label3.Visible = true;
                    txtA.Visible = true;
                    txtH.Visible = true;
                }
                else if (listBox1.SelectedItem.ToString() == "[ Çevre ] Çeşitkenar Yamuk")
                {
                    Clear();
                    Label1.Visible = true;
                    Label2.Visible = true;
                    Label3.Visible = true;
                    Label4.Visible = true;
                    txtA.Visible = true;
                    txtB.Visible = true;
                    txtC.Visible = true;
                    txtH.Visible = true;
                }
                else if (listBox1.SelectedItem.ToString() == "[ Çevre ] İkizkenar Yamuk")
                {
                    Clear();
                    Label1.Visible = true;
                    Label2.Visible = true;
                    Label3.Visible = true;
                    txtA.Visible = true;
                    txtB.Visible = true;
                    txtH.Visible = true;
                }
                else if (listBox1.SelectedItem.ToString() == "[ Çevre ] Paralelkenar")
                {
                    Clear();
                    Label1.Visible = true;
                    Label2.Visible = true;
                    txtA.Visible = true;
                    txtB.Visible = true;
                }
                else if (listBox1.SelectedItem.ToString() == "[ Çevre ] Eş Kenar Dikdörtgen")
                {
                    Clear();
                    Label1.Visible = true;
                    txtA.Visible = true;
                }
                else if (listBox1.SelectedItem.ToString() == "[ Çevre ] Elips")
                {
                    Clear();
                    Label1.Visible = true;
                    Label2.Visible = true;
                    txtA.Visible = true;
                    txtB.Visible = true;
                    txtA.Text = "Yatay Yarıçap (r)";
                    txtB.Text = "Dikey Yarıçap (a)";
                }
                else if (listBox1.SelectedItem.ToString() == "[ Hacim ] Dikdörtgenler Prizması")
                {
                    Clear();
                    Label1.Visible = true;
                    Label2.Visible = true;
                    Label3.Visible = true;
                    txtA.Visible = true;
                    txtB.Visible = true;
                    txtH.Visible = true;
                }

                else
                {
                    MessageBox.Show("Seçim yapınız..");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Seçim yapınız.. 2");
                throw;
            }
        }
        private void Clear()
        {
            Label1.Visible = false;
            Label2.Visible = false;
            Label3.Visible = false;
            Label4.Visible = false;
            txtA.Visible = false;
            txtB.Visible = false;
            txtC.Visible = false;
            txtH.Visible = false; 
            txtA.Text = "";
            txtB.Text = "";
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == 0)
            {
                string result = (txtA.Text != "" && txtC.Text != "") ? txtSonuc.Text = EsKenarUcgenAlanHesapla() : UyariMesajVer();
            }
            else if (listBox1.SelectedIndex == 1)
            {
                string result = (txtA.Text != "" && txtC.Text != "") ? txtSonuc.Text = ucgenAlanHesapla() : UyariMesajVer();
            }
            else if (listBox1.SelectedIndex == 2)
            {
                string result = (txtA.Text != "") ? txtSonuc.Text = kareAlanHesapla() : UyariMesajVer();
            }
            else if (listBox1.SelectedIndex == 3)
            {
                string result = (txtA.Text != "" && txtH.Text != "") ? txtSonuc.Text = dikdortgenAlanHesapla() : UyariMesajVer();
            }
            else if (listBox1.SelectedIndex == 4)
            {
                string result = (txtA.Text != "") ? txtSonuc.Text = daireHesapla() : UyariMesajVer();
            }
            else if (listBox1.SelectedIndex == 5)
            {
                string result = (txtA.Text != "" && txtB.Text != "" && txtC.Text != "") ? txtSonuc.Text = yamukAlanHesapla() : UyariMesajVer();
            }
            else if (listBox1.SelectedIndex == 6)
            {
                string result = txtA.Text != "" ? txtSonuc.Text = ucgenCevreHesapla() : UyariMesajVer();
            }
            else if (listBox1.SelectedIndex == 7)
            {
                string result = (txtA.Text != "") ? txtSonuc.Text = kareCevreHesapla() : UyariMesajVer();
            }
            else if (listBox1.SelectedIndex == 8)
            {
                string result = (txtA.Text != "" && txtC.Text != "") ? txtSonuc.Text = dikdortgenCevreHesapla() : UyariMesajVer();
            }
            else if (listBox1.SelectedIndex == 9)
            {
                string result = (txtA.Text != "") ? txtSonuc.Text = besgenCevreHesapla() : UyariMesajVer();
            }
            else if (listBox1.SelectedIndex == 10)
            {
                string result = (txtA.Text != "") ? txtSonuc.Text = altigenCevreHesapla() : UyariMesajVer();
            }
            else if (listBox1.SelectedIndex == 11)
            {
                string result = (txtA.Text != "") ? txtSonuc.Text = sekizgenCevreHesapla() : UyariMesajVer();
            }
            else if (listBox1.SelectedIndex == 12)
            {
                string result = (txtA.Text != "" && txtB.Text != "" && txtC.Text != "" && txtH.Text != "") ? txtSonuc.Text = cesitKenarYamukCevreHesapla() : UyariMesajVer();
            }
            else if (listBox1.SelectedIndex == 13)
            {
                string result = (txtA.Text != "" && txtH.Text != "") ? txtSonuc.Text = ikizKenarYamukCevreHesapla() : UyariMesajVer();
            }
            else if (listBox1.SelectedIndex == 14)
            {
                string result = (txtA.Text != "" && txtB.Text != "") ? txtSonuc.Text = parelelKenarYamukCevreHesapla() : UyariMesajVer();
            }
            else if (listBox1.SelectedIndex == 15)
            {
                string result = (txtA.Text != "") ? txtSonuc.Text = esKenarDortgenCevreHesapla() : UyariMesajVer();
            }
            else if (listBox1.SelectedIndex == 16)
            {
                string result = (txtA.Text != "") ? txtSonuc.Text = elipsCevreHesapla() : UyariMesajVer();
            }
            else if (listBox1.SelectedIndex == 17)
            {
                string result = (txtA.Text != "" && txtB.Text != "" && txtH.Text != "") ? txtSonuc.Text = dikdortgenlerPrizmasiHacimHesapla() : UyariMesajVer();
            }
            else if (listBox1.SelectedIndex == 18)
            {
                string result = (txtA.Text != "") ? txtSonuc.Text = kareHacimHesapla() : UyariMesajVer();
            }
        }

        #region CevreHesaplama
        private string ucgenCevreHesapla()
        {
            return hesaplama.ucgenCevreHesapla(Convert.ToInt32(txtA.Text)).ToString() + " cm2";
        }
        private string kareCevreHesapla()
        {
            return hesaplama.kareCevreHesapla(Convert.ToInt32(txtA.Text)).ToString() + " cm2";
        }
        private string dikdortgenCevreHesapla()
        {
            return hesaplama.dikdortgenCevreHesapla(Convert.ToInt32(txtA.Text), Convert.ToInt32(txtC.Text)).ToString() + " cm2";
        }
        private string besgenCevreHesapla()
        {
            return hesaplama.besgenCevreHesapla(Convert.ToInt32(txtA.Text)).ToString() + " cm2";
        }
        private string altigenCevreHesapla()
        {
            return hesaplama.altigenCevreHesapla(Convert.ToInt32(txtA.Text)).ToString() + " cm2";
        }
        private string sekizgenCevreHesapla()
        {
            return hesaplama.sekizgenCevreHesapla(Convert.ToInt32(txtA.Text)).ToString() + " cm2";
        }
        private string cesitKenarYamukCevreHesapla()
        {
            return hesaplama.cesitKenarYamukCevreHesapla(Convert.ToInt32(txtA.Text), Convert.ToInt32(txtB.Text), Convert.ToInt32(txtC.Text), Convert.ToInt32(txtH.Text)).ToString() + " cm";
        }
        private string ikizKenarYamukCevreHesapla()
        {
            return hesaplama.ikizKenarYamukCevreHesapla(Convert.ToInt32(txtA.Text), Convert.ToInt32(txtB.Text), Convert.ToInt32(txtH.Text)).ToString() + " cm";
        }
        private string parelelKenarYamukCevreHesapla()
        {
            return hesaplama.paralelKenarCevreHesapla(Convert.ToInt32(txtA.Text), Convert.ToInt32(txtB.Text)).ToString() + " cm";
        }
        private string esKenarDortgenCevreHesapla()
        {
            return hesaplama.esKenarDortgenCevreHesapla(Convert.ToInt32(txtA.Text)).ToString() + " cm";
        }
        private string elipsCevreHesapla()
        {
            return hesaplama.elipsCevreHesapla(Convert.ToDouble(txtA.Text), Convert.ToDouble(txtB.Text)).ToString() + " cm";
        }

        #endregion

        #region AlanHesaplama
        private string EsKenarUcgenAlanHesapla()
        {
            return hesaplama.EsKenarUcgenAlanHesapla(Convert.ToDouble(txtA.Text), Convert.ToDouble(txtC.Text)).ToString() + " cm2";
        }
        private string ucgenAlanHesapla()
        {
            return hesaplama.ucgenAlanHesapla(Convert.ToInt32(txtA.Text), Convert.ToInt32(txtC.Text)).ToString() + " cm2";
        }
        private string kareAlanHesapla()
        {
            return hesaplama.kareAlanHesapla(Convert.ToInt32(txtA.Text)).ToString() + " cm2";
        }
        private string dikdortgenAlanHesapla()
        {
            return hesaplama.dikdortgenAlanHesapla(Convert.ToInt32(txtA.Text), Convert.ToInt32(txtH.Text)).ToString() + " cm2";
        }
        private string daireHesapla()
        {
            return hesaplama.daireHesapla(Convert.ToInt32(txtA.Text)).ToString() + " cm2";
        }
        private string yamukAlanHesapla()
        {
            return hesaplama.yamukAlanHesapla(int.Parse(txtA.Text), int.Parse(txtB.Text), int.Parse(txtC.Text)).ToString() + " cm2";
        }
        #endregion

        #region HacimHesaplama
        private string dikdortgenlerPrizmasiHacimHesapla()
        {
            return hesaplama.dikdortgenlerPrizmasiHacimHesapla(Convert.ToInt32(txtA.Text), Convert.ToInt32(txtB.Text), Convert.ToInt32(txtH.Text)).ToString() + " cm3";
        }
        private string kareHacimHesapla()
        {
            return hesaplama.kareHacimHesapla(Convert.ToInt32(txtA.Text)).ToString() + " cm3";
        }
        #endregion
        private string UyariMesajVer()
        {
            string mesaj = "Değerleri girmeden hesaplama işlemi tamamlanamaz.";
            MessageBox.Show(mesaj);
            return mesaj;
        }

        private void txtA_Click(object sender, EventArgs e)
        {
            txtA.Text = "";
        }

        private void txtB_Click(object sender, EventArgs e)
        {
            txtB.Text = "";
        }
    }
}
