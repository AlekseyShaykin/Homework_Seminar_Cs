// Задача 13: Напишите метод, который выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

double GetValue()
{
    Console.Write("Введите любое число ");
    double x = Convert.ToDouble(Console.ReadLine());
    return x;
}


double Lenght(double y)
{

    double count = 1;
    while ((y /= 10) > 1)
        ++count;
    return count;
}

double ThirdNumber(double x)
{
    double p = 0;
    double thirdNumb = 0;
    double stepen = (Lenght(x) - 2);
    double stepen2 = Math.Pow(10, (Lenght(x) - 3));
    if (Lenght(x) > 2)
    {
        p = x % Math.Pow(10, stepen);
        thirdNumb = Math.Truncate(p / stepen2);
    }
    else
    {
        Console.WriteLine("во введенном числе третьей цифры нет");
    }
    return thirdNumb;
  }


double N = GetValue();
double result = ThirdNumber(N);

Console.WriteLine("Третья цифра числа составляет " + result);


