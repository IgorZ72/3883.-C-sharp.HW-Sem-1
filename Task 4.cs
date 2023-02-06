// написать программу, которая на вход принимает три числа 
// и выдаёт максимальное.
Console.Clear();
Console.Write("введите число a:");
int a = int.Parse(Console.ReadLine());
Console.Write("введите число b:");
int b = int.Parse(Console.ReadLine());
Console.Write("введите число c:");
int c = int.Parse(Console.ReadLine());
if ((a > b) && (a > c))
{
    Console.Write("максимальное число a");
}
if ((b > a) && (b > c))
{
    Console.Write("максимальное число b");
}
if ((c > a) && (c > b))
{
    Console.Write("максимальное число c");
}











