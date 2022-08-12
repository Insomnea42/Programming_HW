// Напишите программу, которая на вход принимает два числа и выдаёт максимальное.

Console.Clear();

int a = 0, b = 0;

Console.Write("Введите число а: ");
a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число b: ");
b = Convert.ToInt32(Console.ReadLine());

if (a == b)
{
    Console.WriteLine("Числа равны");
}
else
{

    if (a > b)
    {
        Console.WriteLine("max = " + a);
    }
    else
    {
        Console.WriteLine("max = " + b);

    }
}