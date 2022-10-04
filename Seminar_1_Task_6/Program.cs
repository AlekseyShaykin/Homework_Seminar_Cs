// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет



bool isEven(double x)
{
    if (x % 2 == 0)
        return true;
    else
        return false;
}


double GetValue()
{
    Console.WriteLine("Input number:");
    double x = Convert.ToDouble(Console.ReadLine());
    return x;
}


double N = GetValue();

if (N % 2 == 0)
{
    Console.WriteLine("--> да, число четное");
}
else
{
    Console.WriteLine("--> нет, число нечетное");
 
}









