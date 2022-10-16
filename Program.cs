using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Введите градусы, минуты и секунды");
            int g = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());
            int s = Convert.ToInt32(Console.ReadLine());
            Angle angle = new Angle(g, m, s);
            Console.WriteLine("Заданный угол в радианах: {0:0.0000}", angle.ToRadians());
           
            Console.ReadKey();
        }
    }
    class Angle
    {
        int gradus;
        int min;
        int sec;

        int Gradus
        {
            get { return gradus; }
            set
            {
                gradus = value % 360;
            }
        }
        int Min
        {
            get { return min; }
            set
            {
                Gradus += value / 60;
                min = value % 60;
            }
        }
        int Sec
        {
            get { return sec; }
            set
            {
                Min += value / 60;
                sec = value % 60;
            }
        }


        public Angle(int gradus, int min, int sec)
        {
            Gradus = gradus;
            Min = min;  
            Sec = sec;  
        }
        public double ToRadians()
        {
          
            return (gradus + (min + sec / 60.0) / 60.0) * ((Math.PI)/180);
        }
    }
}
