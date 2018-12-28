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
            Daire daire = new Daire(3);
            daire.yazdir();
            Console.ReadLine();
            
        }
    }
   
}
