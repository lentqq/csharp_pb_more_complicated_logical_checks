using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine().ToLower();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());

            int fuul = rows * columns;
            double income = -1;

            switch (type)
            {
                 case "premiere":income = fuul * 12.00;break;
                 case "normal":income = fuul * 7.50;break;
                 case "discount":income = fuul * 5.00;break;                
            }

            Console.WriteLine("{0:f2}",income);
            
        }
    }
}
