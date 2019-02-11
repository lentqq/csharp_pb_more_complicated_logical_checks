using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Point_in_the_Figure
{
    class Program
    {
        static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            bool outFigure1 = (x < 0 || x > 3 * h) || (y < 0 || y > h);
            bool outFigure2 = (x < h || x > 2 * h) || (y < h || y > 4 * h);

            bool inFigure1 = (x > 0 && x < 3 * h) && (y > 0 && y < h);
            bool inFigure2 = (x > h && x < 2 * h) && (y > h && y < 4 * h);

            bool onBorder = (x > h && x < 2 * h) && y == h;

            if (outFigure1 && outFigure2)
            {
                Console.WriteLine("outside");
            }
            else if (inFigure1 || inFigure2 || onBorder)
            {
                Console.WriteLine("inside");
            }
            else
            {
                Console.WriteLine("border");
            }
        }
    }
}
