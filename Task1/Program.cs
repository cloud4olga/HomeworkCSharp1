// Напишите программу, которая на вход принимает 2 числа и выдает какое число больше, какое меньше

Console.WriteLine("Введите два числа");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2)
{
    Console.WriteLine("Первое число больше второго");
}
else
{
    Console.WriteLine("Первое число меньше второго");
}