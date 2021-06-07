using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtomasyonModern.DOMAIN
{
    public class Bolum
    {
        int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        string adi;

        public string Adi
        {
            get { return adi; }
            set { adi = value; }
        }
        string tel;
        public string Tel
        {
            get { return tel; }
            set { tel = value; }
        }

        public Bolum(int p1, string p2, string p3)
        {
            // TODO: Complete member initialization
            this.Id = p1;
            this.Adi = p2;
            this.Tel = p3;
        }
        public Bolum(string gAd, string gTel)
        {
            // TODO: Complete member initialization
            this.Adi = gAd;
            this.Tel = gTel;
        }
        public override string ToString()
        {
            return this.Adi;
        }

    }
}
