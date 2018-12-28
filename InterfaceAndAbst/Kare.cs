using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAndAbst
{
    class Kare : Sekil
    {
        private double kenar;

        public double Kenar
        {
            get { return kenar; }
            set { kenar = value; }
        }
        public Kare(double k)
        {
            kenar = k;
            this.Alan = kenar * kenar;
            this.Cevre = 4 * kenar;
        }


    }
}
