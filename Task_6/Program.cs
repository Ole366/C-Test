// Напишите программу, которая на вход принимает число 
// и выдаёт, является ли число чётным (делится ли оно на два без остатка).
//    4 -> да
//    -3 -> нет
//    7 -> нет
//   
    Console.WriteLine("Проверка четности числа");
    Console.Write("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    if (Convert.ToBoolean(number % 2))
    {
      Console.WriteLine("Нет, не является четным");
      return;
    }
    Console.WriteLine("Да, является четным");
