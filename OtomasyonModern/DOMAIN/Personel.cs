using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtomasyonModern.DOMAIN
{
    class Personel
    {
        public Personel(int gId, string gAd, string gTel, string gAdres, int gBolumNo)
        {
            this.Id = gId;
            this.Ad = gAd;
            this.Tel = gTel;
            this.Adres = gAdres;
            this.BolumNo = gBolumNo;
        }

        public Personel(string gAd, string gTel, string gAdres, int gBolNo)
        {
            this.Ad = gAd;
            this.Tel = gTel;
            this.Adres = gAdres;
            this.BolumNo = gBolNo;
        }

        public Personel(string p1, string p2, string p3, int p4, int p5)
        {
            this.Ad = p1;
            this.Tel = p2;
            this.Adres = p3;
            this.bolumNo = p4;
            this.Id= p5;
        }

        int id, bolumNo;
        string ad, tel, adres;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
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
        public int BolumNo
        {
            get { return bolumNo; }
            set { bolumNo = value; }
        }
        public override string ToString()
        {
            return this.Ad;
        }
    }
}
