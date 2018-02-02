using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = 10;
            int b = 20;


            Console.WriteLine("pred {0},{1}", a, b);
            // davam ref aby kazda premenna bola predana odkazom 
            // aby vnutro funkcie ovplivnil povodne premmene
            Swapper.Swap<int>(ref a,ref b);
            Console.WriteLine("po {0},{1}", a, b);

            string s1 = "ahoj";
            string s2 = "cau";

            Console.WriteLine("pred {0},{1}", s1, s2);
            Swapper.Swap<string>(ref s1,ref s2);
            Console.WriteLine("po {0},{1}", s1, s2);

            Nakladak n1 = new Nakladak { VykonMotoru = 100 };
            Nakladak n2 = new Nakladak { VykonMotoru = 200 };

            Osobak o1 = new Osobak { VykonMotoru = 50 };
            Osobak o2 = new Osobak { VykonMotoru = 60 };


            SpravcaAut<Nakladak> spravcaNakladakov = new SpravcaAut<Nakladak>();
            SpravcaAut<Osobak> spravcaOsobakov = new SpravcaAut<Osobak>();
            spravcaOsobakov.PrehodMotor(o1, o2);
            spravcaNakladakov.PrehodMotor(n1, n2);


            Console.ReadLine();




        }
    }
}
