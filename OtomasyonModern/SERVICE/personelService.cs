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
    class 
        personelService
    {

        internal ArrayList personelleriOku()
        {
            return (new personelDAO()).personelleriGetir();
        }

        internal void personelKaydet(string gAd, string gTel, string gAdres, int gBolNo)
        {
            (new personelDAO()).personeliKaydet(new Personel(gAd,gTel,gAdres,gBolNo));
        }

        internal void personelSil(int gId)
        {
            (new personelDAO()).personelSil(gId);
        }
        internal void personelGuncelle(string p1, string p2, string p3,int p4,int p5)
        {
            (new personelDAO()).personelGuncelle(new Personel(p1, p2, p3, p4, p5));
        }

    }
}
