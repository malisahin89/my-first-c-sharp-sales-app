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
    class bolumService
    {
        public ArrayList bolumleriGetir()
        {
            return (new bolumDAO()).bolumleriOku();
        }
        internal void bolumKaydet(string p1, string p2)
        {
            (new bolumDAO()).bolumKaydet(new Bolum(p1, p2));
        }

        internal void bolumSil(int gId)
        {
            (new bolumDAO()).bolumuSil(gId);
        }

        internal void bolumGuncelle(int p1, string p2, string p3)
        {
            (new bolumDAO()).bolumGuncelle(new Bolum(p1, p2, p3));
        }
    }
}
