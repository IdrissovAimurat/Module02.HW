using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //task1();
            //task2();
            //task3();
            //task4();
            //task5();
            //task6();
            //task7();
            //task8();
            //task9();
            //task10();
            //task11();
            //task12();
            //task13();
            //task14(); повтор
            //task15(); повтор
            //task16(); повтор
            //task17();
            //task18();
            //task19();
            //task20();
            //task21();
            //task22();
            //task28();

        }

        /// <summary>
        /// 1.	Составить программу вывода на экран в
        /// одну строку трех любых чисел с
        /// двумя пробелами между ними.
        /// </summary>
        static void task1()
        {
            int a, b, c;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(a + "  " + b + "  " + c);

        }

        /// <summary>
        /// 2.	Вывести на экран числа 5, 10 и 21 одно под другим.
        /// </summary>
        static void task2()
        {
            int a = 5, b = 10, c = 21;

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }

        /// <summary>
        /// 3.	Дано расстояние в сантиметрах. Найти число полных метров в нем.
        /// </summary>
        static void task3()
        {
            Console.WriteLine("Write your number in santimetr: ");
            double santimetr = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Write your number in metr: ");
            Console.WriteLine(santimetr / 100);
        }

        /// <summary>
        /// 4.	С некоторого момента прошло 234 дня. 
        /// Сколько полных недель прошло за этот период?
        /// </summary>
        static void task4()
        {
            int days = 234 / 7;
            Console.WriteLine("полных недель прошло: " + days);
        }

        /// <summary>
        /// 5.	Дано двузначное число. Найти:
        /// a.число десятков в нем;
        /// b.число единиц в нем;
        /// c.сумму его цифр;
        /// d.произведение его цифр
        /// </summary>
        static void task5()
        {
            Console.WriteLine("Write your двухзначное number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("a: ");
            Console.WriteLine(number / 10);

            Console.WriteLine("b: ");
            Console.WriteLine(number % 10);

            Console.WriteLine("c: ");
            int c = (number / 10) + (number % 10);
            Console.WriteLine(c);

            Console.WriteLine("d: ");
            int d = (number / 10) * (number % 10);
            Console.WriteLine(d);
        }

        /// <summary>
        /// 6.	
        /// Вычислить значение логического выражения при следующих значениях
        /// логических величин А, В и С: 
        /// А = Истина, В = Ложь, С = Ложь:
        /// a.	А или В; 
        /// b.  А и В; 
        /// c.  В или С.
        /// </summary>        
        static void task6()
        {
            bool A = true;
            bool B = false;
            bool C = false;

            Console.WriteLine(A || B);
            Console.WriteLine(A || B);
            Console.WriteLine(B || C);
        }

        /// <summary>
        /// 7.	Даны радиус круга и сторона квадрата.
        /// У какой фигуры площадь больше?
        /// </summary>

        static void task7()
        {
            Console.Write("Write the radius of circle: ");
            int r = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your radius of circle: " + r + "\n");

            Console.Write("Write the side of the square: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your side of square: " + a + "\n");

            double S1 = 3.14 * r * r;
            double S2 = a * a;
            Console.WriteLine("the area of the radius of the circle: " + S1);
            Console.WriteLine("the area of the radius of the circle: " + S2 + "\n");

            if (S1 > S2)
            {
                Console.WriteLine("Площадь радиуса круга больше \n");
            }
            else if (S2 < S1)
            {

                Console.WriteLine("Площадь стороны квадрата больше \n");
            }
            else Console.WriteLine("Они равны \n");
        }

        /// <summary>
        /// 8.	Даны объемы и массы двух тел из разных материалов. Материал какого из тел имеет большую плотность?
        /// </summary
        static void task8()
        {
            Console.Write("Введите объем (V1) первого тела: ");
            double V1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите массу (m1) первого тела: ");
            double m1 = Convert.ToInt32(Console.ReadLine());

            double p1 = m1 / V1;

            Console.WriteLine("Плотность первого тела: m1/V1: " + p1 + "\n");

            Console.Write("Введите объем (V2) первого тела: ");
            double V2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите массу (m2) первого тела: ");
            double m2 = Convert.ToInt32(Console.ReadLine());

            double p2 = m2 / V2;

            Console.WriteLine("Плотность первого тела: m2/V2: " + p2 + "\n");

            if (p1 > p2)
            {
                Console.WriteLine("Плотность первого тела (р1) больше, чем второго (р2)");
            }
            else if (p1 < p2)
            {
                Console.WriteLine("Плотность второго тела (р2) больше, чем первого (р1)");
            }
            else Console.WriteLine("Они равны");
        }

        /// <summary>
        /// 9.	 Известны сопротивления двух несоединенных друг с другом 
        /// участков электрической цепи и напряжение на каждом из них. 
        /// По какому участку протекает меньший ток?
        /// </summary>
        static void task9()
        {
            Console.Write("Введите сопротивление (R1) в первом участке цепи: ");
            double R1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("\nВведите сопротивление (R2) в первом участке цепи: ");
            double R2 = Convert.ToDouble(Console.ReadLine());


            //В задачах по физике, обычно, если не известны измерения для решения той или иной задачи,
            //то берутся стандарты (в частотах 50Гц, скорость света - 3 * 10^8,
            //в этом случае Напряжение (U) возьмем каждую по 1 величине)).

            //"I = U/R"

            int U = 1;
            double I1 = U / R1;
            double I2 = U / R2;

            if (I1 > I2)
            {
                Console.WriteLine("\nВо втором участке протекает меньший ток (I1 > I2).\n");
            }
            else if (I1 < I2)
            {
                Console.WriteLine("\nВ первом участке протекает меньший ток (I2 > I1).\n");
            }
            else Console.WriteLine("\nНи в одном из участков не протекает меньший ток (они равны).\n");
        }

        /// <summary>
        /// Напечатать "столбиком": 
        /// a.все целые числа от 20 до 35;
        /// b.квадраты всех целых чисел от 10 до b(значение b вводится с клавиатуры; b > 10);
        /// c.третьи степени всех целых чисел от a до 50 (значение a вводится с клавиатуры; a< 50);
        /// d.все целые числа от a до b(значения a и b вводятся с клавиатуры; b > a).
        /// </summary>
        static void task10()
        {
            //a

            Console.WriteLine("a.все целые числа от 20 до 35: ");

            for (int i = 20; i <= 35; i++)
            {
                Console.WriteLine(i);
            }


            //b

            Console.WriteLine("\nb.квадраты всех целых чисел от 10 до b(значение b вводится с клавиатуры; b > 10): ");

            Console.WriteLine("Введите число больше 10 (b > 10): \n");
            int b = Convert.ToInt32(Console.ReadLine());

            if (b > 10)
            {
                for (int i = 1; i <= b; i++)
                {
                    Console.WriteLine(i * i);
                }
            }
            else if (b <= 10)
            {
                Console.WriteLine("Введенное число меньше или больше 10 (b <= 10)");
            }


            //c

            Console.WriteLine("\nc.третьи степени всех целых чисел от a до 50 (значение a вводится с клавиатуры; a < 50): ");

            Console.Write("Введите число не больше 50 (a < 50): ");
            int a = Convert.ToInt32(Console.ReadLine());

            if (a < 50)
            {
                for (int i = a; i <= 50; i++)
                {
                    Console.WriteLine(i * i * i);
                }
            }
            else if (a <= 50)
            {
                Console.WriteLine("Введенное число больше 50 (a < 50)");
            }


            //d

            Console.WriteLine("\nd. все целые числа от a до b (значения a и b вводятся с клавиатуры; b > a).: ");

            Console.Write("\nВведите число b, при условии, что число 'b' будет больше следующего числа 'a' (b > a): ");
            int c = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nВведите число a, при условии, что оно будет меньше числа 'b' (a < b): ");
            int d = Convert.ToInt32(Console.ReadLine());

            // c = b; d = a

            if (c > d)
            {
                for (int i = d; i <= c; i++)
                {
                    Console.WriteLine(i);
                }
            }
            else if (c <= d)
            {
                Console.WriteLine("Введенное число 'b' меньше или равно числа'a' (a => b)");
            }
        }

        /// <summary>
        /// вычисления значения функции y=7x^2-3x+4  при любом значении x;
        /// </summary>
        static void task11()
        {
            Console.Write("Введите число х: ");
            double x = Convert.ToDouble(Console.ReadLine());

            double y = 7 * x * x - 3 * x + 4;
            Console.WriteLine("у = " + y);
        }

        /// <summary>
        /// 12.	Дан радиус окружности. Найти длину окружности и площадь круга.
        /// </summary>
        static void task12()
        {
            Console.WriteLine("Введите радиус окружности 'r': ");
            int r = Convert.ToInt32(Console.ReadLine());

            double l = 2 * 3.14 * r;
            double S = 3.14 * r;

            Console.WriteLine("Длина окружности l = " + l + ". \nПлощадь круга S = " + S);
        }

        /// <summary>
        /// 13.	Дано расстояние в сантиметрах. Найти число полных метров в нем.
        /// </summary>
        static void task13()
        {
            Console.Write("Введите ваше расстояние S в сантиметрах: ");

            double S = Convert.ToDouble(Console.ReadLine());
            S = S / 100;

            Console.WriteLine("\nВаше расстояние S в метрах = " + S + "м\n");
        }

        /// <summary>
        /// 17.	В трехзначном числе x зачеркнули его вторую цифру. 
        /// Когда к образованному при этом двузначному числу справа 
        /// приписали вторую цифру числа x, то получилось число 456. 
        /// Найти число x.
        /// </summary>
        static void task17()
        {
            Console.WriteLine("У нас дано число '456'. То самое число х будет - 45_. : ");


            int x1 = 456 / 100; //убираем число справа, которое приписали к числу х
            int x2 = 456 / 10 % 10; //находим ту самую нашумевшую вторую цифру
            int x3 = 456 % 10; //выделяю от числа х число 6



            Console.WriteLine(x1 + "" + x3 + "" + x2);
        }

        /// <summary>
        /// 18.	Вычислить значение логического выражения при всех возможных значениях логических величин X и Y:
        /// a. не X и не Y;
        /// b. X или(не X и Y);
        /// c. (не X и Y) или Y.

        /// </summary>
        static void task18()
        {
            bool X = true, Y = true;
            bool X1 = true, Y1 = false;
            bool X2 = false, Y2 = true;
            bool X3 = false, Y3 = false;


            Console.WriteLine("a: не X и не Y");


            Console.WriteLine(!X && !Y);
            Console.WriteLine(!X1 && !Y1);
            Console.WriteLine(!X2 && !Y2);
            Console.WriteLine(!X3 && !Y3);


            Console.WriteLine("\n b: X или(не X и Y)");


            Console.WriteLine(X || (!X && Y));
            Console.WriteLine(X1 || (!X1 && Y1));
            Console.WriteLine(X2 || (!X2 && Y2));
            Console.WriteLine(X3 || (!X3 && Y3));


            Console.WriteLine("\nc: (не X и Y) или Y");


            Console.WriteLine((!X && Y) || Y);
            Console.WriteLine((!X1 && Y1) || Y1);
            Console.WriteLine((!X2 && Y2) || Y2);
            Console.WriteLine((!X3 && Y3) || Y3);
        }

        /// <summary>
        /// 19.	Напишите функцию swap(int* a, int* b), 
        /// которая изменяет значения параметров a и b так, 
        /// что новое значение a рав- но старому значению b и наоборот.
        /// </summary>

        static void task19()
        {
            Console.Write("Введите число a: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите число b: ");
            int b = Convert.ToInt32(Console.ReadLine());

            swap(a, b);
        }

        static void swap(int a, int b)
        {
            Console.WriteLine($"До: x = {a}, y = {b}");

            //t - "temp"
            int t = a;
                a = b;
                b = t;

            Console.WriteLine($"После: x = {a}, y = {b}");
        }

        /// <summary>
        /// 20.	Напишите функцию swap(int& a, int& b), 
        /// которая изменяет значения параметров a и b так, 
        /// что новое значение a равно старому значению b и наоборот.
        /// </summary>
       
                        // в C# нет int& ссылки, юзают ключевое слово ref или как выше вообще без, хачу абъяснений, я примат

        static void task20()
        {
            Console.Write("Введите число a: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите число b: ");
            int b = Convert.ToInt32(Console.ReadLine());

            swap2(ref a, ref b);
        }

        static void swap2(ref int a, ref int b)
        {
            Console.WriteLine($"До: a = {a}, b = {b}");

            //t - "temp"
            int t = a;
            a = b;
            b = t;

            Console.WriteLine($"После: a = {a}, b = {b}");
        }

        /// <summary>
        /// 21.	Напишите функцию int f(int& a, int& b, int x, int y), 
        /// которая присваивает объекту a значение, 
        /// равное x*y, а объекту b значение x/y. Если значение y 
        /// </summary>
        
        //Я так и не понял эту задачу адекватно - "Если значение у"(??). И решил вставить этот вопрос в чат GPT, чтобы он его дополнил.
        //
        //Он мне вывел:

        //Попробую предположить, что могло быть намерено в задаче. Возможно, задача должна была выглядеть следующим образом:
        //"... Если значение y равно нулю, функция должна вернуть специальное значение, например, -1, чтобы указать на ошибку или невозможность выполнения операции деления на ноль."
        static void task21()
        {
            Console.WriteLine("Введите число а: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите число b: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите число x: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите число y: ");
            int y = Convert.ToInt32(Console.ReadLine());

            //string error = "error";

            int result = f(ref a, ref b, x, y);

            if (result == -1)
            {
                Console.WriteLine("ERROR (деление на ноль!)");
            }
            else
            {
                Console.WriteLine($"a = {a}, b = {b}");
            }
        }

        static int f(ref int a, ref int b, int x, int y)
        {
            if (y == 0)
            {
                return -1;
                
                //Console.WriteLine("error");
            }
            else
            {
                a = x * y;
                b = x / y;
            }
            return 0;
        }

        /// <summary>
        /// 22.	Напишите функцию int f(int x, int y), 
        ///     которая возвращает 0, если значения x и y оба равны нулю, 
        ///     12/x, если y равен 0, 
        ///     12/y, если x равен 0, 
        ///     иначе 144/(x*y).
        /// </summary>
        static void task22()
        {
            Console.WriteLine("x: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("y: ");
            int y = Convert.ToInt32(Console.ReadLine());

            int result = f(x, y);

            if (result == -1)
            {
                Console.WriteLine("ERROR (деление на ноль!)");
            }
            else
            {
                Console.WriteLine("Result = " + result);
            }
        }

        static int f(int x, int y)
        {
            if (x == 0 && y == 0)
            {
                return 0;
            }
            else if (y == 0)
            {
                // Деление на ноль при y == 0
                return 0;
            }
            else if (x == 0)
            {
                // Деление на ноль при x == 0
                return 0;
            }
            else
            {
                return 144 / (x * y);
            }
        }



        /// <summary>
        /// 28.	Напишите программу, 
        /// которая находит наименьшее число из заданного набора 
        /// трех целых чисел. 
        /// Используйте условный оператор if.
        /// </summary>
        static void task28()
        {
            Console.Write("Введите числа а: \n");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите числа b: \n");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите числа c: \n");
            int c = Convert.ToInt32(Console.ReadLine());

            int small = a;

            if (b < small)
            {
                small = b;
            }

            else if (c < small)
            {
                small = c;
            }

            Console.WriteLine("Наименьшее число: " + small);
        }
    }
}