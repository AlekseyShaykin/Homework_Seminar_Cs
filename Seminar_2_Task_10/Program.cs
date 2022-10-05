// Задача 10: Напишите метод, который принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

double GetValue(string text)
{
    Console.WriteLine(text + ", введите трехзначное число");
    double x = Convert.ToDouble(Console.ReadLine());
    return x;
}



double SecondIndex(double N)
{
double a1 = (N % 100);
double a2 = (N % 10);
double a3 = (a1 - a2) / 10;
return a3;
}

double N = GetValue("привет-омлет");
SecondIndex(N);

Console.WriteLine("Вторая цифра этого числа " + SecondIndex(N));













