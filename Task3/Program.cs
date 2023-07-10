/* Задача 3: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 */

int ReadInt(string message)				// Запрашивает число у пользователя и переводит его в int
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}



int funAkerman(int arg1, int arg2)
{
  if (arg1 == 0) 
  {
    return arg2 + 1;
  }
  else if (arg2 == 0) 
  {
  return funAkerman(arg1 - 1, 1);
  }
  else 
  {
    return funAkerman(arg1 - 1, funAkerman(arg1, arg2 - 1));
  }
}

int number1 = ReadInt("Введите неотрицательное число 1 ---> ");
int number2 = ReadInt("Введите неотрицательное число 2 ---> ");
Console.Write($"Функция Аккермана = {funAkerman(number1, number2)} ");

