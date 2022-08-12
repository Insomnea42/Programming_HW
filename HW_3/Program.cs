// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.Clear();

bool chet = false;
int a = 0, b = 0;

Console.Write("Введите число а: ");
a = Convert.ToInt32(Console.ReadLine());

if (a == 0) { Console.WriteLine("Просьба ввести отличное от 0 значение"); }
else
{
    b = a % 2;
    if (b == 0) { chet = true; }


    Console.WriteLine(chet);
}

