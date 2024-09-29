using Tyuiu.PuzinaDA.Sprint3.Task5.V8.Lib;
namespace Tyuiu.PuzinaDA.Sprint3.Task5.V8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнил: Пузина Д. А. | ИИПБ-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Вложенные циклы                                                   *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #8                                                              *");
            Console.WriteLine("* Выполнил: Пузина Дарья Алексеевна | ИИПБ-24-1                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Вычислить сумму ряда с помощью вложенных циклов.                        *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int startValue1 = 1, startValue2 = 1, stopValue1 = 3, stopValue2 = 12;
            
            Console.WriteLine("Старт шага №1 = " + startValue1);
            Console.WriteLine("Конец шага №1 = " + startValue2);
            Console.WriteLine("Старт шага №2 = " + stopValue1);
            Console.WriteLine("Конец шага №1 = " + stopValue2);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            double res = ds.GetSumSumSeries(startValue1, startValue2, stopValue1, stopValue2);
            Console.WriteLine("Сумма ряда = " + res);
        }
    }
}
