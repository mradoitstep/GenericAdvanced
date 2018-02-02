using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericAdvanced
{
    class SpravcaAut<T> where T : Auto
    {
         public  void PrehodMotor(T auto1,T auto2)
        {
            // prehodenie motorov 
            int temp = auto1.VykonMotoru;
            auto1.VykonMotoru = auto2.VykonMotoru;
            auto2.VykonMotoru = temp;


        }
    }
}
