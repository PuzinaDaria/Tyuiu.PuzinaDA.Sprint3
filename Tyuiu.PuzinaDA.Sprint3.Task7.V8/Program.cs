using Tyuiu.PuzinaDA.Sprint3.Task7.V8.Lib;
namespace Tyuiu.PuzinaDA.Sprint3.Task7.V8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнил: Пузина Д. А. | ИИПБ-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #8                                                              *");
            Console.WriteLine("* Выполнил: Пузина Дарья Алексеевна | ИИПБ-24-1                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая выводит таблицу значений функции на         *");
            Console.WriteLine("* заданном отрезке [-5; 5] c шагом 1.                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int startValue = -5, stopValue = 5;

            Console.WriteLine("Отрезок: [{0}; {1}]", startValue, stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            double[] res = new double[11];
            res = ds.GetMassFunction(startValue, stopValue);
            Console.WriteLine("+---------+----------+");
            Console.WriteLine("|    x    |    F(x)  |");
            Console.WriteLine("+---------+----------+");
            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine("|{0, 5:d}    |  {1, 5:f2}   |", startValue, res[i]);
                startValue++;
            }
            Console.WriteLine("+---------+----------+");
        }
    }
}
