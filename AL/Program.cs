using System.Runtime.ExceptionServices;
Console.WriteLine("Выберите какую операцию вы хотите выполнить: 1. Сложить 2 числа 2. Вычесть первое из второго 3. Перемножить два числа 4. Разделить первое на второе 5. Возвести в степень N первое число 6. Найти квадратный корень из числа 7. Найти 1 процент от числа 8. Найти факториал из числа 9. Выйти из программы");
double firs = Convert.ToDouble(Console.ReadLine());
do
{
    Console.WriteLine("Введите первое число:");
    double first = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите второе число:");
    double second = Convert.ToDouble(Console.ReadLine());

    if (firs == 1)
    {
        Console.WriteLine(first + second);
    }
    else if (firs == 2)
    {
        Console.WriteLine(first - second);
    }
    if (firs == 3)
    {
        Console.WriteLine(first * second);
    }
    else if (firs == 4)
    {
        Console.WriteLine(first / second);
    }

    if (firs == 5)
    {
        Console.WriteLine(Math.Pow(first, second));
    }


    else if (firs == 6)
    {

        Console.WriteLine(Math.Sqrt(first));
        Console.WriteLine(Math.Sqrt(second));
    }

    if (firs == 7)
    {
        double f1 = Convert.ToDouble(first);
        double f2 = Convert.ToDouble(second);
        Console.WriteLine(f1 / 100);
        Console.WriteLine(f2 / 100);
    }

    else if (firs == 8)
    {
        double f1 = 1;
        for (double i = 1; first >= i; i++)
        {
            f1 = f1 * i;
        }
        double f2 = 1;
        for (double i = 1; second >= i; i++)
        {
            f2 = f2 * i;
        }
        Console.WriteLine(f1);
        Console.WriteLine(f2);
    }

    Console.WriteLine("Введите номер операции которую необходимо выполнить:");
    firs = Convert.ToDouble(Console.ReadLine());

} while (firs != 9);
