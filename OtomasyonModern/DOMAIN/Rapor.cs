using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtomasyonModern.DOMAIN
{
    class Rapor
    {
        int p1, p6, p7, elemanSay;
        string p4, p2, p3, p5;
        private int p;
        public int P1
        {
            get { return p1; }
            set { p1 = value; }
        }

        public string P2
        {
            get { return p2; }
            set { p2 = value; }
        }

        public string P3
        {
            get { return p3; }
            set { p3 = value; }
        }

        public string P4
        {
            get { return p4; }
            set { p4 = value; }
        }

        public string P5
        {
            get { return p5; }
            set { p5 = value; }
        }

        public int P6
        {
            get { return p6; }
            set { p6 = value; }
        }

        public int P7
        {
            get { return p7; }
            set { p7 = value; }
        }
        public int ElemanSay
        {
            get { return elemanSay; }
            set { elemanSay = value; }
        }
        public Rapor(int p1, string p2, string p3, string p4, string p5, int p6, int p7)
        {
            // TODO: Complete member initialization
            this.p1 = p1;
            this.p2 = p2;
            this.p3 = p3;
            this.p4 = p4;
            this.p5 = p5;
            this.p6 = p6;
            this.p7 = p7;
        }

        public Rapor(int elemanSay)
        {
            // TODO: Complete member initialization
            this.p = elemanSay;
        }
    }
}
