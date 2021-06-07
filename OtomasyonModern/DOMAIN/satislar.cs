using OtomasyonModern.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtomasyonModern.DOMAIN
{
    public class satislar
    {

        int personelId, musteriId, urunId, satisAdet;
        decimal tutar;
        string tarih;

        public int PersonelId
        {
            get { return personelId; }
            set { personelId = value; }
        }

        public int MusteriId
        {
            get { return musteriId; }
            set { musteriId = value; }
        }

        public int UrunId
        {
            get { return urunId; }
            set { urunId = value; }
        }

        public int SatisAdet
        {
            get { return satisAdet; }
            set { satisAdet = value; }
        }


        public decimal Tutar
        {
            get { return tutar; }
            set { tutar = value; }
        }


        public string Tarih
        {
            get { return tarih; }
            set { tarih = value; }
        }

        public satislar(int gPersonelID, int gMusteriID, int gUrunID, int gSatisAdet, decimal gTutar, string gTarih)
        {
            this.PersonelId = gPersonelID;
            this.MusteriId = gMusteriID;
            this.UrunId = gUrunID;
            this.SatisAdet = gSatisAdet;
            this.Tutar = gTutar;
            this.Tarih = gTarih;
        }
    }

}