using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAndAbst
{
    class Program
    {
        static void Main(string[] args)
        {
            Kare kare = new Kare(3);
            kare.yazdir();
            Console.ReadLine();
            
        }
    }
    interface Isekil
    {
        double Alan { get; set; }
        double Cevre { get; set; }
        double Hacim { get; set; }
        void yazdir();
        
    }
}
