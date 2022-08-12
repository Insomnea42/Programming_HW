// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Clear();

int a = 0, b = 0, c = 0;
int max = 0;

Console.Write("Введите число а: ");
a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число b: ");
b = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число c: ");
c = Convert.ToInt32(Console.ReadLine());

max = a;

if (max < b)
{
    max = b;
}
if (max < c)
{
    max = c;
}


Console.WriteLine("max = " + max);