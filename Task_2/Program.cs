// Напишите программу, которая на вход принимает два числа 
// выдаёт, какое число большее, а какое меньшее.
 
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3
 
Console.Write("Введите число a:  ");
int num_1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b:  ");
int num_2 = Convert.ToInt32(Console.ReadLine());
if (num_1 > num_2) {
    int max = num_1;
    int min = num_2;
    Console.WriteLine($"Большее число: {num_1}");
    Console.WriteLine($"Меньшее число: {num_2}");
}
else {
    int max = num_1;
    int mmin = num_2;
    Console.WriteLine($"Большее число: {num_2}");
    Console.WriteLine($"Меньшее число: {num_1}");
}
 
