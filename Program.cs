using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Korki_u_Dawida
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj tekst");
            StringOperation Palindrom = new StringOperation();
            Palindrom.Palindrom();
            Console.ReadKey();
        }        
    }
}
