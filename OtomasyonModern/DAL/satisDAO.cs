using MySql.Data.MySqlClient;
using OtomasyonModern.DOMAIN;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtomasyonModern.DAL
{
    class satisDAO
    {
        internal void satisKaydet(satislar s)
        {
            (new MySqlCommand("INSERT INTO satis (personelId,musteriId,tarih,urunId,satisAdet,tutar) VALUES ('" + s.PersonelId + "','" + s.MusteriId + "','" + s.Tarih + "','" + s.UrunId + "','" + s.SatisAdet + "','" + s.Tutar + "')", (new dbBaglanti()).baglantiGetir())).ExecuteNonQuery();

        }
    }
}