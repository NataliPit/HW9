/* Задача 1: Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
M = 1; N = 5 -> "2, 4"
M = 4; N = 8 -> "4, 6, 8" */

int ReadInt(string message)				// Запрашивает число у пользователя и переводит его в int
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void power(int arg1, int arg2)
{
    if (arg1 > arg2)
    {
        return;
    }
    if (arg1 % 2 == 0)
    {
        System.Console.WriteLine(arg1);
    }
    power(arg1 + 1, arg2);
}

int number1 = ReadInt("Введите число 1 ---> ");
int number2 = ReadInt("Введите число 2 ---> ");
power(number1, number2);