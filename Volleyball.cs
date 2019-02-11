using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string year = Console.ReadLine();
            int hollydays = int.Parse(Console.ReadLine());
            int weekensdHome = int.Parse(Console.ReadLine());
            int weekendsSofia = 48 - weekensdHome;

            double playhollydays = hollydays * 2.0 / 3;
            double playSofia = weekendsSofia *( 3.0 / 4)+playhollydays;
            double sumplay = playSofia + weekensdHome;
            double sumplay1 = sumplay * 0.15+sumplay;

            if (year == "leap")
            {
                Console.WriteLine(Math.Truncate(sumplay1));
            }
            else if (year == "normal")
            {
                Console.WriteLine(Math.Truncate(sumplay));
            }
        }

    }
}
