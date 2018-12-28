using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAndAbst
{
    class Daire : Sekil
    {
        private double yaricap;


        public double Yaricap
        
        {
            get { return yaricap; }
            set { yaricap = value; }
        }
        public Daire(double r)
        {
            yaricap = r;
            this.Alan = Math.PI * Math.Pow(yaricap, 2);
            this.Cevre = 2 * Math.PI * yaricap;
        }

    }
}
