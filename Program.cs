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
            Angle angle = new Angle(0, 0, 0);
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
