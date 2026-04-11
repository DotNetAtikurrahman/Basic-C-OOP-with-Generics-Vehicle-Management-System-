using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_c_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //a
            int age = 18;
            if (age>=18)
            {
                Console.WriteLine("you can vote");
                
            }
            else
            {
                Console.WriteLine("you cannot vote");
            }

            bool mode = true;
            switch (mode)
            {
                case true:
                    Console.WriteLine("darkmode on");
                    break;
                    case false:
                    Console.WriteLine("lightmode on");
                    break;
                default:
                    Console.WriteLine("system mode on");
                    break;
            }

            int x = 5;
            while (x<=10)
            {
                Console.WriteLine(x);
                x++;
                
            }

            int y = 5;
            do
            {
                Console.WriteLine(y);
                y++;
            }
            while (y<=10);

            for (int li = 0; li < 10; li++)
            {
                Console.WriteLine(li);
            }

            //b
            int userage = 18;
            bool member   = true;
            bool memberrelative = true;
            if (userage >= 18 && member)
            {
                Console.WriteLine("you can enter");
                
            }
            else
            {
                Console.WriteLine("you can not enter");
            }
            
            
            
            if (userage<18 || memberrelative)
            {
                Console.WriteLine("you also can enter");
            }
            else
            {
                Console.WriteLine("you can not enter");
            }
            //c
            string a = "atikur";
            char    b = 'a';
            int c = 155 + 544;
            short d = 4 * 5;
            long e= 545454L - 454545L;
            bool f = true;
            double g = 455.5 / 55.5;
            float h = 5454.555F % 5454.55F;
            decimal i = 545454.455M;

            int count = 1;
            count++;
            ++count;
            Console.WriteLine($"{a}{b}{c}{d}{e}{f}{g}{h}{i}{count}");

            //d
            amerinfo(name: "atikur", address: "pabna");

            //e
            checked
            {
                try
                {
                    int ry = int.MaxValue;
                    ry++;
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }


            }

            unchecked
            {
                int ty = int.MaxValue;
                ty++;
                Console.WriteLine(ty);
            }


            //f
            try
            {
                int m = 45;
                int n = 0;
                int o = m / n;


            }
            catch (DivideByZeroException de)
            {

                Console.WriteLine(de.Message);
            }

            finally
            {
                Console.WriteLine("yes i catch the exception");
            }








        }


        public static void amerinfo(string name , string address, string fname = "mojaharul",string mname="sufiya")
        {
            int age = 25;
            Console.WriteLine($"{name} {age} {address} {fname} {mname}");

        }
    }
}
