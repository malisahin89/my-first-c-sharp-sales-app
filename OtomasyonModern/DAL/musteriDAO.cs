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
    class musteriDAO
    {
        internal System.Collections.ArrayList musteriGetir()
        {
            ArrayList okunanMusteri = new ArrayList();
            MySqlCommand komutum = new MySqlCommand("select * from musteri", (new dbBaglanti()).baglantiGetir());
            MySqlDataReader okunan = komutum.ExecuteReader();
            while (okunan.Read())
            {
                okunanMusteri.Add(new Musteri(Convert.ToInt32(okunan[0]), okunan[1].ToString(), okunan[2].ToString(), okunan[3].ToString()));
            }
            return okunanMusteri;
        }

        internal void musteriKaydet(Musteri mus)
        {
            (new MySqlCommand("insert into musteri (musteriAd,musteriTel,musteriAdres) values ('" + mus.Ad + "','" + mus.Tel + "','" + mus.Adres + "')", (new dbBaglanti()).baglantiGetir())).ExecuteNonQuery();
        }



        internal void musteriSil(int gId)
        {
            (new MySqlCommand("delete from musteri where musteriId=" + gId, (new dbBaglanti()).baglantiGetir())).ExecuteNonQuery();
        }

        internal void musteriGuncelle(Musteri mus)
        {
            (new MySqlCommand("update musteri set musteriAd='" + mus.Ad + "', musteriTel='" + mus.Tel + "', musteriAdres='" + mus.Adres + "' where musteriId=" + mus.Id, (new dbBaglanti()).baglantiGetir())).ExecuteNonQuery();
        }
    }
}
