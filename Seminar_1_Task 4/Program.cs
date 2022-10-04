// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите 3 числа");
double value1 = Convert.ToDouble(Console.ReadLine());

double value2 = Convert.ToDouble(Console.ReadLine());

double value3 = Convert.ToDouble(Console.ReadLine());

double max = value1;

if (value2 > max)
{
    max = value2;
}
if (value3 > max)
{
    max = value3;
}

Console.WriteLine("max -> " + max);


