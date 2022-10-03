using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1_task1_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double ss = 0;
            int ii = 1, n=5;
            while(ii<= n)
            {
                ss += 1.0 / ii;
                ii++;
            }
            Console.WriteLine("s = " + ss);



            int timec;
            Console.WriteLine("1 задание");
            string a = Console.ReadLine();
            if (a.ToCharArray().Length == 4)
            {
                char[] num = a.ToCharArray();

                Console.WriteLine(num[3] + "" + num[2] + "" + num[1] + "" + num[0] + "");
            }
            else
            {
                Console.WriteLine("число не четырехзначное");
            }

            Console.WriteLine("2 задание");
            timec = Convert.ToInt32(Console.ReadLine());
            int tt = 8 - (timec / 3600);
            if (tt < 0)
            {
                Console.WriteLine("вы переработали ");
            }
            else
            {
                Console.WriteLine(tt);
            }

            Console.WriteLine("3 задание");
            int[] mass = new int[7];
            int s = 0;
            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("максимальное значение " + mass.Max());
            Console.WriteLine("5 задание");
            int volume = 800; //объем топлива бака
            Console.WriteLine("введите вес ");
            int weight = Convert.ToInt32(Console.ReadLine()); // вес
            Console.WriteLine(" введите расстояние от а до б ");
            int distance1 = Convert.ToInt32(Console.ReadLine());//расстаяние от а до б
            Console.WriteLine("введите расстояние от б до с");
            int distance2 = Convert.ToInt32(Console.ReadLine());   //расстояиние от б до с
            int distance12 = distance1 + distance2;// общее расстояние
            int k = 0;// необхоимое топливо
            int l = 0; //необходимое топливо для заправки 

            if (weight <= 500)
            {
                k = distance12 * 2;
                l = k - 800;
                if (l > 800)
                {
                    Console.WriteLine("Too long distance!");
                }
                else { Console.WriteLine("необходимо дохаправить " + l); }

            }
            else if (weight > 500 && weight <= 1000)
            {
                k = distance12 * 4;
                l = k - 800;
                if (l > 800)
                {
                    Console.WriteLine("Too long distance!");
                }
                else { Console.WriteLine("необходимо дохаправить " + l); }

            }
        }
    }
}
