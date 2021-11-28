using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Tack10._1
{
    public class Corner

    {
        public int gradus;
        public int min;
        public int sec;
        public Corner(int g, int m, int s)
        {
            gradus = g;
            min = m;
            sec = s;
        }
        public void ToRadians(out double radians)
        {
            radians = (gradus + min / 60 + sec / 3600) * (Math.PI / 180);
        }
    }
    internal class Program
    {
        static void Main()
        {
            double radians =0;
            string tempNum = "";

            int gr = 0;
            int minutes = 0;
            int seconds = 0;

            Console.WriteLine("Введите градусы: ");
            tempNum =Console.ReadLine();
            while(!int.TryParse(tempNum, out gr))
            {
                Console.WriteLine("This is not valid input. Try agin");
                tempNum = Console.ReadLine();
            }
            Console.WriteLine("Введите минуты: ");
            tempNum = Console.ReadLine();
            while (!int.TryParse(tempNum, out minutes))
            {
                Console.WriteLine("This is not valid input. Try agin");
                tempNum = Console.ReadLine();
            }
            Console.WriteLine("Введите секунды: ");
            tempNum = Console.ReadLine();
            while (!int.TryParse(tempNum, out seconds))
            {
                Console.WriteLine("This is not valid input. Try agin");
                tempNum = Console.ReadLine();
            }
            Corner corner = new Corner(gr, minutes, seconds);
            corner.ToRadians(out radians);
            Console.WriteLine($"Радианы:{radians}");
            Console.ReadKey();
        }
    }
}
