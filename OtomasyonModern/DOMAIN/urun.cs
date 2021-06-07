using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtomasyonModern.DOMAIN
{
    class urun
    {
        int urunId, urunFiyat;
        string urunAd;


        public int UrunId
        {
            get { return urunId; }
            set { urunId = value; }
        }
        public string UrunAd
        {
            get { return urunAd; }
            set { urunAd = value; }
        }
        public int UrunFiyat
        {
            get { return urunFiyat; }
            set { urunFiyat = value; }
        }
        private int miktar;

        public int Miktar
        {
            get { return miktar; }
            set { miktar = value; }
        }

        private decimal tutar;
        public decimal Tutar
        {
            get { return tutar; }
            set { tutar = value; }
        }
        public urun(int gUrunID, string gUrunAd, int gUrunFiyat)
        {
            this.UrunId = gUrunID;
            this.UrunAd = gUrunAd;
            this.UrunFiyat = gUrunFiyat;
        }
        public urun(string gUrunAd, int gUrunFiyat)
        {
            this.UrunAd = gUrunAd;
            this.UrunFiyat = gUrunFiyat;
        }
    }
}
