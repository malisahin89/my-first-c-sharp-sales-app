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
    class personelDAO
    {
        internal System.Collections.ArrayList personelleriGetir()
        {
            ArrayList okunanPersoneller = new ArrayList();
            MySqlCommand komutum = new MySqlCommand("select * from personel", (new dbBaglanti()).baglantiGetir());
            MySqlDataReader okunan = komutum.ExecuteReader();
            while (okunan.Read())
            {
                okunanPersoneller.Add(new Personel(Convert.ToInt32(okunan[0]), okunan[1].ToString(), okunan[2].ToString(), okunan[3].ToString(), Convert.ToInt32(okunan[4])));
            }
            return okunanPersoneller;
        }
        internal void personeliKaydet(Personel personel)
        {
            (new MySqlCommand("insert into personel (personelAd,personelTel,personelAdres,bolumNo) values ('" + personel.Ad + "','" + personel.Tel + "','" + personel.Adres + "'," + personel.BolumNo + ")", (new dbBaglanti()).baglantiGetir())).ExecuteNonQuery();
        }
        internal void personelSil(int gId)
        {
            (new MySqlCommand("delete from personel where personelId=" + gId, (new dbBaglanti()).baglantiGetir())).ExecuteNonQuery();
        }

        internal void personelGuncelle(Personel per)
        {
            (new MySqlCommand("update personel set personelAd='" + per.Ad + "', personelTel='" + per.Tel + "', personelAdres='" + per.Adres + "', bolumNo='" + per.BolumNo + "' where personelId=" + per.Id, (new dbBaglanti()).baglantiGetir())).ExecuteNonQuery();
        }
    }
}
