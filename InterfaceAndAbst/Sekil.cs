using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAndAbst
{
    class Sekil : Isekil
    {
        private double cevre;
        private double alan;
        private double hacim;
        private string sekilTip;

        public double Cevre
        {
            get { return cevre; }
            set { cevre = value; }
        }
        public double Alan
        {
            get { return alan; }
            set { alan = value; }
        }
        public double Hacim
        {
            get { return hacim; }
            set { hacim = value; }
        }
        public string SekilTip
        {
            get
            {
                return sekilTip;
            }
            set
            {
                sekilTip = value;
            }
        }
        public Sekil()
        {

        }
        public void yazdir()
        {
            Console.WriteLine($"Alan : {Alan} \nÇevre : {Cevre} \nHacim: {Hacim}");
        }
    }
}
