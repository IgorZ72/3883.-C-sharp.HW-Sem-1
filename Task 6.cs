// написать программу,котоорая на вход принимает число, а
// на выходе выдаёт является ли число чётным.
Console.Clear();
Console.Write("введите число: ");
int number = int.Parse(Console.ReadLine());
if (number % 2 == 0)
{
    Console.Write("введённое число чётное");
}
else
{
    Console.Write("введённое число не чётное");
}

