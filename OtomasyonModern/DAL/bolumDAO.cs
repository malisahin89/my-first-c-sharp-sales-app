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
    class bolumDAO
    {
        public ArrayList bolumleriOku()
        {
            ArrayList okunanBolumler = new ArrayList();
            MySqlCommand komutum = new MySqlCommand("select * from bolum", (new dbBaglanti()).baglantiGetir());
            MySqlDataReader okunan = komutum.ExecuteReader();
            while (okunan.Read())
            {
                okunanBolumler.Add((new Bolum(Convert.ToInt32(okunan[0]), okunan[1].ToString(), okunan[2].ToString())));
            }
            return okunanBolumler;
        }

        internal void bolumKaydet(Bolum bolum)
        {
            (new MySqlCommand("insert into bolum (bolumAd,bolumTel) values ('" + bolum.Adi + "','" + bolum.Tel + "')", (new dbBaglanti().baglantiGetir()))).ExecuteNonQuery();
        }

        internal void bolumuSil(int gId)
        {
            (new MySqlCommand("delete from bolum where bolumId=" + gId, (new dbBaglanti()).baglantiGetir())).ExecuteNonQuery();
        }

        internal void bolumGuncelle(Bolum bolum)
        {
            (new MySqlCommand("update bolum set bolumAd='" + bolum.Adi + "', bolumTel='" + bolum.Tel + "' where bolumId=" + bolum.Id, (new dbBaglanti()).baglantiGetir())).ExecuteNonQuery();
        }
    }
}
