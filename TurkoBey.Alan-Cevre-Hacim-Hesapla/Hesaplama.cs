using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurkoBey.Alan_Cevre_Hacim_Hesapla
{
    class Hesaplama
    {
        public static double dResult { get; private set; }
        public int result { get; private set; }


        #region UcgenAlanHesapla
        public int ucgenAlanHesapla(int ucgenA, int ucgenH)
        {
            return result = UAlani(ucgenA, ucgenH);
        }
        public int UAlani(int UcgenA, int UcgenH)
        {
            return (UcgenA * UcgenH) / 2;
        }
        #endregion

        #region EsKenarUcgenAlanHesapla
        public double EsKenarUcgenAlanHesapla(double ucgenA, double ucgenH)
        {
            return dResult = EsKenarUAlani(ucgenA, ucgenH);
        }
        public double EsKenarUAlani(double UcgenA, double UcgenH)
        {
            return ((UcgenA * UcgenA) * (Math.Sqrt(3)) / 4);
        }
        #endregion

        #region KareAlanHesapla
        public int kareAlanHesapla(int kareA)
        {
            return result = KAlani(kareA);
        }
        public int KAlani(int KareA)
        {
            return KareA * KareA;
        }
        #endregion  

        #region DikAlanHesapla
        public int dikdortgenAlanHesapla(int dikA, int dikH)
        {
            return result = DikAlani(dikA, dikH);
        }
        private int DikAlani(int dikA, int dikH)
        {
            return dikA * dikH;
        }
        #endregion

        #region DaireHesapla
        public double daireHesapla(double yariCap)
        {
            return dResult = Math.Round(DAlani(yariCap), 5);
        }
        public double DAlani(double r)
        {
            return Math.PI * r * r;
        }
        #endregion

        #region YamukAlanHesapla
        public int yamukAlanHesapla(int dikA, int dikB, int dikH)
        {
            return result = YamukAlani(dikA, dikB, dikH);
        }
        private int YamukAlani(int dikA, int dikB, int dikH)
        {
            return ((dikA + dikB) * dikH / 2);
        }
        #endregion

        #region UcgenCevreHesapla
        public int ucgenCevreHesapla(int ucgenA)
        {
            return result = UCevre(ucgenA);
        }
        public int UCevre(int UcgenA)
        {
            return UcgenA * 3;
        }
        #endregion 

        #region KareCevreHesapla
        public int kareCevreHesapla(int kareC)
        {
            return result = KCevre(kareC);
        }
        public int KCevre(int KareC)
        {
            return KareC * 4;
        }
        #endregion

        #region DikCevreHesapla
        public int dikdortgenCevreHesapla(int dikA, int dikH)
        {
            return result = DikCevre(dikA, dikH);
        }
        public int DikCevre(int dikA, int dikH)
        {
            return (dikA + dikH) * 2;
        }
        #endregion

        #region BesgenCevreHesapla
        public int besgenCevreHesapla(int dikA)
        {
            return result = besgenCevre(dikA);
        }
        private int besgenCevre(int dikA)
        {
            return dikA * 5;
        }
        #endregion

        #region AltiCevreHesapla
        public int altigenCevreHesapla(int dikA)
        {
            return result = altigenCevre(dikA);
        }
        private int altigenCevre(int dikA)
        {
            return dikA * 6;
        }
        #endregion

        #region SekizgenCevreHesapla
        public int sekizgenCevreHesapla(int dikA)
        {
            return result = sekizgenCevre(dikA);
        }
        private int sekizgenCevre(int dikA)
        {
            return dikA * 8;
        }
        #endregion

        #region CesitKenarCevreHesapla
        public int cesitKenarYamukCevreHesapla(int dikA, int dikB, int dikC, int dikH)
        {
            return result = cesitKenarYamukCevre(dikA, dikB, dikC, dikH);
        }
        private int cesitKenarYamukCevre(int dikA, int dikB, int dikC, int dikH)
        {
            return dikA + dikB + dikC + dikH;
        }
        #endregion

        #region İkizKenarYamukCevreHesapla
        public int ikizKenarYamukCevreHesapla(int dikA, int dikB, int dikH)
        {
            return result = ikizKenarYamukCevre(dikA, dikB, dikH);
        }
        public int ikizKenarYamukCevre(int dikA, int dikB, int dikH)
        {
            return dikA + dikB + dikH;
        }
        #endregion

        #region ParalelKenarCevreHesapla
        public int paralelKenarCevreHesapla(int dikA, int dikB)
        {
            return result = paralelKenarCevre(dikA, dikB);
        }
        public int paralelKenarCevre(int dikA, int dikB)
        {
            return ((dikA + dikB) * 2);
        }
        #endregion

        #region esKenarDortgenCevreHesapla
        public int esKenarDortgenCevreHesapla(int dikA)
        {
            return result = esKenarDortgenCevre(dikA);
        }
        public int esKenarDortgenCevre(int dikA)
        {
            return (dikA * 4);
        }
        #endregion

        #region ElipsCevreHesapla
        public double elipsCevreHesapla(double dikA, double dikB)
        {
            return dResult = elipsCevre(dikA, dikB);
        }
        public double elipsCevre(double dikA, double dikB)
        {
            return Math.PI * (dikA + dikB) / 2;
        }
        #endregion

        #region DikdortgenlerPrizmasiHacimHesapla
        public int dikdortgenlerPrizmasiHacimHesapla(int dikA, int dikB, int dikH)
        {
            return result = dikdortgenlerPrizma(dikA, dikB, dikH);
        }
        public int dikdortgenlerPrizma(int dikA, int dikB, int dikH)
        {
            return dikA * dikB * dikH;
        }
        #endregion
       
        #region KareHacimHesapla
        public int kareHacimHesapla(int dikA)
        {
            return result = kareHacim(dikA);
        }
        public int kareHacim(int dikA)
        {
            return dikA * dikA * dikA;
        }
        #endregion
    }
}
