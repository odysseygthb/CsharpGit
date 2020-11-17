using System;

namespace Pythagoras_table
{
    class Program
    {
        static void Main(string[] args)
        {
            // Пифагор

            // Объявление

            Console.WriteLine("Таблица Пифагора");
            Console.WriteLine();
            Console.WriteLine("--------------------------------------");
            Console.WriteLine();

            // Объявление конец

            // Переменные 

            Console.WriteLine("Ввод чисел:");
            Console.WriteLine();

            Console.WriteLine("Первое горизонтальное число:");
            int gorisontalFirstNum = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Последнее горизонтальное число:");
            int gorisontalSecondNum = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Первое вертикальное число:");
            int verticalFirstNum = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Последнее вертикальное число:");
            int verticalSecondNum = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("--------------------------------------");
            Console.WriteLine();


            int maxValue = (gorisontalSecondNum * verticalSecondNum);
            string maxValueString = maxValue.ToString();
            int maxValueLength = maxValueString.Length;
            string verticalSecondString = verticalSecondNum.ToString();
            int lastVerticalLength = verticalSecondString.Length;
            string space = " ";
            string hyphen = "-";


            // Переменные конец

            // Резервные переменные 

            int xGorisontalFirstNum = gorisontalFirstNum;
            int xVerticalFirstNum = verticalFirstNum;
            string xSpace = space;
            string xHyphen = hyphen;
            int xMaxValueLength = maxValueLength;
            int xLastVerticalLength = lastVerticalLength;


            // Резерные переменные конец 

            // Количество пробелов в первом стоблике

            while (xLastVerticalLength > 0)
            {
                xSpace = space + xSpace;
                xHyphen = hyphen + xHyphen;
                xLastVerticalLength--;
            }
            xLastVerticalLength = lastVerticalLength;
            Console.Write(xSpace + " |");
            xSpace = space;

            // Количество пробелов в первом стоблике | конец 

            // Числа, которые ввел пользователь

            while (gorisontalSecondNum >= xGorisontalFirstNum)
            {
                string gorisontalFirstString = xGorisontalFirstNum.ToString();
                int gorisontalFirstLength = gorisontalFirstString.Length;
                while (gorisontalFirstLength < maxValueLength)
                {
                    xSpace = xSpace + space;
                    gorisontalFirstLength++;
                }
                Console.Write(xSpace + xGorisontalFirstNum);
                xGorisontalFirstNum++;
                xSpace = space;
            }
            Console.WriteLine();
            xGorisontalFirstNum = gorisontalFirstNum;


            // Числа, которые ввел пользователь | конец

            // Горизонтальная линия 

            Console.Write(xHyphen + hyphen);
            Console.Write("+");
            xHyphen = hyphen;
            while (xMaxValueLength > 0)
            {
                xHyphen = hyphen + xHyphen;
                xMaxValueLength--;
            }
            while (gorisontalSecondNum >= xGorisontalFirstNum)
            {
                Console.Write(xHyphen);
                xGorisontalFirstNum++;
            }
            Console.WriteLine();
            xGorisontalFirstNum = gorisontalFirstNum;
            xSpace = space;

            // Горизонтальная линия | конец

            // Таблица Пифагора 

            while (xVerticalFirstNum <= verticalSecondNum)
            {
                string xVerticalFirstNumString = xVerticalFirstNum.ToString();
                int xVerticalFirstNumLength = xVerticalFirstNumString.Length;

                while (xVerticalFirstNumLength < lastVerticalLength)
                {
                    xSpace = xSpace + space;
                    xVerticalFirstNumLength++;
                }
                Console.Write(xSpace + xVerticalFirstNum + " |");
                xSpace = space;
                while (xGorisontalFirstNum <= gorisontalSecondNum)
                {
                    int result = xGorisontalFirstNum * xVerticalFirstNum;
                    string resultString = result.ToString();
                    int resultLength = resultString.Length;

                    while (resultLength < maxValueLength)
                    {
                        xSpace = xSpace + space;
                        resultLength++;
                    }
                    Console.Write(xSpace + result);
                    xGorisontalFirstNum++;
                    xSpace = space;
                }
                Console.WriteLine();
                xGorisontalFirstNum = gorisontalFirstNum;
                xVerticalFirstNum++;
                xSpace = space;
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Excellent");
            Console.WriteLine();

            // Таблица Пифагора | конец

            // Пифагор конец
        }
    }
}
