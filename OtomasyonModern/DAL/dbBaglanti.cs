using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtomasyonModern.DAL
{
    class dbBaglanti
    {
        internal MySqlConnection baglantiGetir()
        {
            MySqlConnection baglanti = new MySqlConnection("Server=localhost; Database=alisahindb; Uid=root;");
            baglanti.Open();
            return baglanti;
        }
    }
}
