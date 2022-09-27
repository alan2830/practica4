using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int centigrados, farenheit;

            Console.WriteLine("dame los centigrados");
            centigrados = Convert.ToInt32(Console.ReadLine());
            farenheit = (centigrados * 9 / 5 + 32);
            Console.WriteLine("escribiste:" + centigrados + "que es igual a:" + farenheit +"");
            Console.ReadLine();
        }
    }
}
