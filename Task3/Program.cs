// Напмшите программу, которая на вход принимает число и выдает, является ли число четным (делится ли оно на 2 без остатка)

Console.WriteLine("Введите число");
int number1 = Convert.ToInt32(Console.ReadLine());

if (number1 % 2 == 0)
{
    Console.WriteLine("Четное число");
}
else
{
    Console.WriteLine("Нечетное число");
}