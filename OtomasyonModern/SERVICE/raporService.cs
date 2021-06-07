using OtomasyonModern.DAL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtomasyonModern.SERVICE
{
    class raporService
    {
        internal ArrayList fiyatOku()
        {
            return new raporDAO().fiyatOku();
        }
    }
}
