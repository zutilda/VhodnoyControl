using System;

namespace Vhodnoy // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static double zadacha1()
        {
            Console.WriteLine("Введите a");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите b");
            int b = Convert.ToInt32(Console.ReadLine());
            return Math.Pow(a, b);
        }
        public static void zadacha2()
        {
            Console.WriteLine("Введите точку начала гипотенузы по координате Х:");
            int x3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите точку начала гипотенузы по координате Y:");
            int y3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите точку конца гипотенузы по координате Х:");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите точку конца гипотенузы по координате Y:");
            int y2 = Convert.ToInt32(Console.ReadLine());
            int x1 = x3;
            int y1 = y2;
            int a = y3 - y1;
            int b = x2 - x1;
            double s = (a*b)/2;
            Console.WriteLine("Коррдинаты последней точки равны: ({0};{1}). Площадь равна {2}", x1, y1, s);
           
            double c = (int) Math.Sqrt(Math.Pow(a,2) + Math.Pow(b, 2));
            double p = a + b + c;
            Console.WriteLine("Длина стороны a = {0}, длина стороны b ={1}, длины стороны с = {2}. Периметр равен {3}",a,b,c,p);
        }
        public static void zadacha3()
        {
            Console.WriteLine("Введите a");
            int a = Convert.ToInt32(Console.ReadLine());            
            int c = a % 2;
            int d = a % 3;
            if (c==d)
            {
                Console.WriteLine("Остаток от деления {0} на 2 и 3 совпадает", a);  
            }
            else Console.WriteLine("Остаток от деления {0} на 2 и 3 не совпадает", a);
           
        }
        public static void zadacha4()
        {
            Console.WriteLine("Введите число n");
            int n = Convert.ToInt32(Console.ReadLine());           
            for (int i = 0; 0 < n; i++)
            {
                Console.WriteLine(n % 10);
                n /= 10;
            }
        }
       
        public static void zadacha5()
        {
            Console.WriteLine("Введите x");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите y");
            int y = Convert.ToInt32(Console.ReadLine());
            double z = (1+Math.Sin(Math.Sqrt(x+1)))/(Math.Cos(12*y-4));
            Console.WriteLine("Ответ: " + Math.Round(z, 5));
        }
        public static void zadacha6()
        {
            Console.WriteLine("Введите число:");
            int n = Convert.ToInt32(Console.ReadLine());
        }
       
            public static void zadacha7()
        {
                Console.WriteLine("Введите a:");
                int a = Convert.ToInt32(Console.ReadLine());
                double rezult = 0;
                double b = 1;
                for (int i = 0; i < a; i++)
                {
                    rezult = rezult + ((b / (1 + b)));
                    b++;
                Console.WriteLine(Math.Round(rezult, 3));
                }                            
        }       

        public static void zadacha8()
        {
            Console.WriteLine("Введите результат 1 пловца");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите результат 2 пловца");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите результат 3 пловца");
            double z = Convert.ToDouble(Console.ReadLine());
            if ((x < y)&&(x<z))
            {
                Console.WriteLine("Лучшее время показал 1 пловец с результатом {0}", x);
            }
            else if ((y < x) && (y < z))
            {
                Console.WriteLine("Лучшее время показал 2 пловец с результатом {0}", y);
            }
            else if ((z < x) && (x < y))
            {
                Console.WriteLine("Лучшее время показал 3 пловец с результатом {0}", z);
            }
        }
        static void Main(string[] args)
        {
           while(true)
            {
                
                Console.WriteLine("Введите номер задачи от 1 до 8. Чтобы завершить работу программы введите любое значение кроме указанных.");
                int i = Convert.ToInt32(Console.ReadLine());
                switch (i)
                {
                    case 1:
                        Console.WriteLine("Ответ: " + zadacha1()); 
                    break;
                    case 2:
                        zadacha2();
                        break;
                    case 3:
                        zadacha3();
                        break;
                    case 4:
                        zadacha4();
                        break;
                    case 5:
                        zadacha5();
                        break;
                    case 6:
                        zadacha6();
                        break;
                    case 7:
                        zadacha7();
                        break;
                    case 8:
                        zadacha8();
                        break;

                    default: Environment.Exit(0);
                        break;
                }

            }
        }
    }
}