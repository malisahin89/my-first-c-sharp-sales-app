using OtomasyonModern.DAL;
using OtomasyonModern.DOMAIN;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtomasyonModern.SERVICE
{
    class musteriService
    {

        internal ArrayList musteriOku()
        {
            return (new musteriDAO()).musteriGetir();
        }


        internal void musteriKaydet(string gAd, string gTel, string gAdres)
        {
            (new musteriDAO()).musteriKaydet(new Musteri(gAd, gTel, gAdres));
        }

        internal void musteriSil(int gId)
        {
            (new musteriDAO()).musteriSil(gId);
        }
        internal void musteriGuncelle(int p1, string p2, string p3, string p4)
        {
            (new musteriDAO()).musteriGuncelle(new Musteri(p1, p2, p3, p4));
        }

    }
}
