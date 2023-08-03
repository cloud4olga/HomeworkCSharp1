// Напишите программу, которая на вход приниимает число (N), а на выходе показывает все четные числа от 1 до N (5 -> 2,4; 8 -> 2,4,6,8)

Console.WriteLine("Введите число");
int number1 = Convert.ToInt32(Console.ReadLine());
int a = 2;
while (a <= number1)
{
    Console.Write(a + ",");
    a = a + 2;
}

