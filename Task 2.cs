// написать программу которая на вход принимает два числа 
// и выдаёт большее число.
Console.Clear();
Console.Write("введите число a:");
int a = int.Parse(Console.ReadLine());
Console.Write("введите число b:");
int b = int.Parse(Console.ReadLine());
if (a > b)
{
    Console.Write("большее число a");
}
else 
{
    Console.Write("большее число b");
}
