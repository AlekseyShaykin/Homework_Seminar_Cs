// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

double GetValue()
{
    Console.WriteLine("Input number N");
    double N = Convert.ToDouble(Console.ReadLine());
    return N;
}

double Method(double N)
{
    double x = 1;
    while (x < N)
    {
        if (x % 2 == 0)
            Console.WriteLine(x);
        x = x + 1;
    }
return x;
}


double N = GetValue();
Method(N);








