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
    class raporDAO
    {
        public ArrayList fiyatOku()
        {
            ArrayList okunanSatis = new ArrayList();
            MySqlCommand komutum = new MySqlCommand("SELECT s.satisId, p.personelAd, m.musteriAd, s.tarih, u.urunAd, s.satisAdet, s.tutar FROM satis AS s INNER JOIN musteri AS m ON s.musteriId = m.musteriId INNER JOIN urun AS u ON s.urunId = u.urunId inner join personel as p on s.personelId=p.personelId WHERE 1 ORDER BY m.musteriId", (new dbBaglanti()).baglantiGetir());
            MySqlDataReader okunan = komutum.ExecuteReader();
            while (okunan.Read())
            {
                okunanSatis.Add(new Rapor(
                    Convert.ToInt32(okunan[0]),
                    okunan[1].ToString(),
                    okunan[2].ToString(),
                    okunan[3].ToString(),
                    okunan[4].ToString(),
                    Convert.ToInt32(okunan[5]),Convert.ToInt32(okunan[6])));
            }
            return okunanSatis;
        }
    }
}
