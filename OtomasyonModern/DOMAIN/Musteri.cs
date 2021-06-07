using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtomasyonModern.DOMAIN
{
    class Musteri
    {
        public Musteri(string gAd, string gTel, string gAdres)
        {
            this.Ad = gAd;
            this.Tel = gTel;
            this.Adres = gAdres;
        }
        public Musteri(int gId, string gAd, string gTel, string gAdres)
        {
            this.Id = gId;
            this.Ad = gAd;
            this.Tel = gTel;
            this.Adres = gAdres;
        }
        int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        string ad, tel, adres;
        public string Ad
        {
            get { return ad; }
            set { ad = value; }
        }
        public string Tel
        {
            get { return tel; }
            set { tel = value; }
        }
        public string Adres
        {
            get { return adres; }
            set { adres = value; }
        }
        public override string ToString()
        {
            return this.Ad;
        }
    }
}