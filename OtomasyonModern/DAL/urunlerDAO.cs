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
    class urunlerDAO
    {
        public ArrayList urunOku()
        {
            ArrayList okunanUrun = new ArrayList();
            MySqlCommand komutum = new MySqlCommand("select * from urun", (new dbBaglanti()).baglantiGetir());
            MySqlDataReader okunan = komutum.ExecuteReader();
            while (okunan.Read())
            {
                okunanUrun.Add(new urun(Convert.ToInt32(okunan[0]), okunan[1].ToString(), Convert.ToInt32(okunan[2])));
            }
            return okunanUrun;
        }
        internal void urunKaydet(urun u)
        {
            (new MySqlCommand("insert into urun (urunAd,urunFiyat) values ('" + u.UrunAd + "','" + u.UrunFiyat + "')", (new dbBaglanti().baglantiGetir()))).ExecuteNonQuery();
        }
        internal void urunSil(int gId)
        {
            (new MySqlCommand("delete from urun where urunId=" + gId, (new dbBaglanti()).baglantiGetir())).ExecuteNonQuery();
        }
        internal void urunGuncelle(urun u)
        {
            (new MySqlCommand("update urun set urunAd='" + u.UrunAd + "', urunFiyat='" + u.UrunFiyat + "' where urunId=" + u.UrunId, (new dbBaglanti()).baglantiGetir())).ExecuteNonQuery();
        }
    }
}
