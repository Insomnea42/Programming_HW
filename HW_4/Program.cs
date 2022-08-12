// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Clear();

int N = 0, i = 2;
string str = " ";

Console.Write("Введите число N: ");
N = Convert.ToInt32(Console.ReadLine());

while (i <= N)
{
    str = str + ", " + i;
    i += 2;
}

Console.WriteLine(str.Replace(@" , ", string.Empty));

