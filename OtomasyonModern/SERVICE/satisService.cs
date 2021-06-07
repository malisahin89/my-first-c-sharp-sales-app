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
    class satisService
    {
        internal void satisKaydet(int gPersonelID, int gMusteriID, int gUrunID, int gSatisAdet, decimal gTutar, string gTarih)
        {
            new satisDAO().satisKaydet(new satislar(gPersonelID, gMusteriID, gUrunID, gSatisAdet, gTutar, gTarih));
        }
    }
}