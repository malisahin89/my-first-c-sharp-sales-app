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
    class urunService
    {
        internal ArrayList urunOku()
        {
            return new urunlerDAO().urunOku();
        }
        internal void urunKaydet(string gUrunAd, int gUrunFiyat)
        {
            new urunlerDAO().urunKaydet(new urun(gUrunAd, gUrunFiyat));
        }
        internal void urunSil(int gID)
        {
            (new urunlerDAO()).urunSil(gID);
        }
        internal void urunGuncelle(int gID, string gUrunAd, int gUrunFiyat)
        {
            new urunlerDAO().urunGuncelle(new urun(gID, gUrunAd, gUrunFiyat));
        }
    }
}
