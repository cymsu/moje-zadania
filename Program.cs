using System;

namespace Nauka


    {
    class Program
    {
        static void Main(string[] args)
        {
            /*
            double a, b, pole;
            Console.WriteLine("Podaj długość boku a");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj długość boku b");
            b = double.Parse(Console.ReadLine());

            pole = a*b;

            Console.Write("Pole prostokąta o boku a = {0} i b = {1}", a, b);
            Console.WriteLine(" wynosi {0} ", pole);


            Console.ReadKey();
            */


            /*Console.WriteLine("Pi = {0:#.##}", Math.PI);
            Console.ReadKey();
            */

            /*Console.WriteLine("Sqrt(Pi) = {0:#.##}", Math.Sqrt(Math.PI));
            Console.ReadKey();
            */

            /*double r, objętość;
            Console.WriteLine("Podaj długość promienia");
            r = double.Parse(Console.ReadLine());
            objętość = 4.0 * Math.PI * r * r * r / 3;
            Console.WriteLine("Objętość kuli o promieniu r = {0:#.##} wynosi {1:#.##}", r, objętość);
            Console.ReadKey();
            */

            /*int a = 37; int b = 11;
            Console.WriteLine("Dzielimy liczbę a przez liczbę b");
            Console.WriteLine("Dla liczb a = " + a + " i b = " + b);
            Console.WriteLine(a + "/" + b + " = " + a / b );
            Console.ReadKey();
            */

            /*int a = 37; int b = 11;
            Console.WriteLine("Obliczamy resztę z dzielenia liczb a i b");
            Console.WriteLine("Dla liczb a = " + a + " i b = " + b );
            Console.WriteLine(a + "%" + b + " = " + a % b);
            Console.ReadKey();
             */

            /*double x, y, suma, różnica, iloczyn, iloraz;
            Console.WriteLine("Podaj x");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj y");
            y = double.Parse(Console.ReadLine());
            suma = x + y; różnica = x - y; iloczyn = x * y; iloraz = x / y;
            Console.WriteLine("Dla x = {0:#.##} i y = {1:#.##}", x, y);
            Console.WriteLine("suma = {0:#.##}", suma);
            Console.WriteLine("różnica = {0:#.##}", różnica);
            Console.WriteLine("iloczyn = {0:#.##}", iloczyn);
            Console.WriteLine("iloraz = {0:#.##}", iloraz);

            Console.ReadKey();
            */


            /*double a, b, pole;
            Console.Write("Podaj a ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Podaj b ");
            b = double.Parse(Console.ReadLine());

            pole = a * b;
            Console.WriteLine("Pole prostokąta o bokach a i b wynosi {0:##.##} ", pole);
            Console.ReadKey();
            */

            /*int a, b, c;
            Console.Write("Podaj a ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Podaj b ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Podaj c ");
            c = int.Parse(Console.ReadLine());

            if ((a * a + b * b) == c * c)
            {
                Console.Write("Liczby");
                Console.Write("a = " + a + ", ");
                Console.Write("b = " + b + ", ");
                Console.Write("c = " + c);
                Console.WriteLine("są trójką pitagorejską ");

            }
            else
            {
                Console.Write("Liczby ");
                Console.Write("a = " + a + ", ");
                Console.Write("b = " + b + ", ");
                Console.Write("c = " + c);
                Console.WriteLine(" nie są trójką pitagorejską ");
                
            }

                Console.ReadKey();
                */


            /*double a, b, c, delta, x1, x2;
            Console.Write("Podaj a ");
            a = double.Parse(Console.ReadLine());

            if (a == 0) 
            {
                Console.WriteLine("niedozwolona wartość współczynnika kierunkowego");

            }
            else
            {
                Console.Write("Podaj b ");
                b = double.Parse(Console.ReadLine());
                Console.Write("Podaj c ");
                c = double.Parse(Console.ReadLine());

                delta = b * b - 4 * a * c;

                if (delta < 0)
                {
                    Console.Write("Brak miejsc zerowych dla podanych liczb.");

                }
                else
                {
                    if (delta == 0)
                    {
                        x1 = -b / (2 * a);
                        Console.Write("Dla podanych liczb występuje jedno miejsce zerowe x1 = {0:##.##}.", x1);

                    }
                    else
                    {
                        x1 = (-b - Math.Sqrt(delta)) / (2 * a);
                        x2 = (-b + Math.Sqrt(delta)) / (2 * a);
                        Console.WriteLine("Dla podanych liczb występują 2 miejsca zerowe; x1 = {0:##.##} i x2 = {1:##.##}", x1, x1);

                    }
                    
                
                }
                Console.ReadKey();
            }
            */
            
               /* bool isMale = false;
                bool isTall = false;
                if (isMale && isTall)
                {
                    
                        Console.WriteLine("You are a tall Male");
                } 
                else if (isMale && !isTall)
                {
                Console.WriteLine("You are a short male");
                 }
                else if (!isMale && isTall)
                {
                Console.WriteLine("You are tall but you are not male");
            
                }
                else
                {
                Console.WriteLine("You are short and you are not male");
                }
            Console.ReadKey(); 
            */





        }
    }
}
