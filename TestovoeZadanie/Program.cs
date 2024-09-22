using System;
using System.Collections.Generic;
using System.Linq;
using TestovoeZadanie;

class Program
{
    static void Main(string[] args)
    {
        // Задача 1
        Console.WriteLine("Задача 1:");
        Console.WriteLine(Task1.SumDigits(16));  // Ожидается: 7
        Console.WriteLine(Task1.SumDigits(942)); // Ожидается: 6

        // Задача 2
        Console.WriteLine("\nЗадача 2:");
        var change1 = Task2.GetCoinChange(56);
        Console.WriteLine(string.Join(", ", change1.Select(kv => $"{kv.Key}: {kv.Value}")));  // Ожидается: Nickels: 1, Pennies: 1, Dimes: 0, Quarters: 2

        var change2 = Task2.GetCoinChange(-435);
        Console.WriteLine(string.Join(", ", change2.Select(kv => $"{kv.Key}: {kv.Value}")));  // Ожидается: Nickels: 0, Pennies: 0, Dimes: 0, Quarters: 0

        var change3 = Task2.GetCoinChange(4.935);
        Console.WriteLine(string.Join(", ", change3.Select(kv => $"{kv.Key}: {kv.Value}")));  // Ожидается: Nickels: 0, Pennies: 4, Dimes: 0, Quarters: 0

        // Задача 3
        Console.WriteLine("\nЗадача 3:");
        Console.WriteLine(Task3.ReorderDigitsDescending(42145));  // Ожидается: 54421

        // Задача 4
        Console.WriteLine("\nЗадача 4:");
        Console.WriteLine(Task4.RowSum(2));  // Ожидается: 8
        Console.WriteLine(Task4.RowSum(3));  // Ожидается: 27

        // Задача 5
        Console.WriteLine("\nЗадача 5:");
        Console.WriteLine(Task5.AlwaysFive_1());  // Ожидается: 5
        Console.WriteLine(Task5.AlwaysFive_2());  // Ожидается: 5
        Console.WriteLine(Task5.AlwaysFive_3());  // Ожидается: 5
    }
}
