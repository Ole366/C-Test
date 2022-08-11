// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
   //  3, 5 -> 243 (3⁵)
   // 2, 4 -> 16

    Console.WriteLine("Число A в степени B");

    Console.Write("Введите число A: ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите степень B: ");
    int b = Convert.ToInt32(Console.ReadLine());
    int result = a;

    for (int i = 0; i < b - 1; i++)
    {
      result *= a;
    }

    Console.WriteLine(result);