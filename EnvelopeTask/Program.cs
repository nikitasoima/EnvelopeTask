using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnvelopeTask
{
    class Program
    {
        static void Main(string[] args)
        {
           double a,b,c,d;
          

             Console.WriteLine("Введите сторону a первого конверта: ");
              try {

                a = Convert.ToDouble(Console.ReadLine());
                   }
                   catch 
                  {
                      Console.WriteLine("Повторите попытку");
                a = Convert.ToDouble(Console.ReadLine());
                   }
                Console.WriteLine("Введите сторону b первого конверта: ");
            try
            {
                b = Convert.ToDouble(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Повторите попытку");
                b = Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine("Введите сторону c второго конверта: ");
            try
            {
                c = Convert.ToDouble(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Повторите попытку");
                c = Convert.ToDouble(Console.ReadLine());
            }

            Console.WriteLine("Введите сторону d второго конверта: ");
            try
            {
                d = Convert.ToDouble(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Повторите попытку");
                d = Convert.ToDouble(Console.ReadLine());
            }

            
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите сторону c второго конверта: ");
            c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите сторону d второго конверта: ");
            d = Convert.ToDouble(Console.ReadLine());

        }





    }
}
