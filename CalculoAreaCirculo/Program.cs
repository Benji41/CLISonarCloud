using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoAreaCirculo
{
    class Program
    {
        //algo
        static void Main(string[] args)
        {
            Double area=-1;
            float radio = -1;
            //algo
            Console.WriteLine("Introduzca la longitud del radio:");
            radio = (float)Convert.ToDouble(Console.ReadLine());
            area = radio * Math.PI / 2;
            Console.WriteLine("Area del circulo:"+area);
            //algo#2
            Console.ReadLine();
        }
    }
}
