// Задача 15: Напишите метод, который принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

double GetValue()
{
Console.WriteLine("Введите цифру, соответствующую дню недели ");

double x = Convert.ToDouble(Console.ReadLine());
return x;
}


double Method(double y)
{
if ( (y / 5) > 1)
{Console.WriteLine("--> да");
}
else
{
Console.WriteLine("--> нет"); 
}
 return y;
}


double c = GetValue();
double x = Method(c);
