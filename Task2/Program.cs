// Напишите программу, которая принимает на вход три числа и выдает макстмальное из этих чисел


Console.WriteLine("Введите три числа");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
int number3 = Convert.ToInt32(Console.ReadLine());
int max = 0;

if (number1 > number2 && number1 > number3)
    {
        max = number1;
    }
else if (number2 > number1 && number2 > number3)
    {
        max = number2;
    }
else if (number3 > number2 && number3 > number1)
    {
        max = number3;
    }
Console.WriteLine(max);