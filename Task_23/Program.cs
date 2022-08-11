// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
   //  3 -> 1, 8, 27
    // 5 -> 1, 8, 27, 64, 125


    Console.WriteLine("Кубы чисел до N");

    Console.Write("Введите число N: ");
    int n = Convert.ToInt32(Console.ReadLine());
    for (int i = 1; i <= n; i++)
    {
      Console.WriteLine($"| {i} | {i * i * i} |");
    }