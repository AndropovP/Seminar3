// Задача 3: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27. 
// 5 -> 1, 8, 27, 64, 125

int Prompt(string message)
{
    System.Console.Write($"{message} ");
    return int.Parse(Console.ReadLine());
}

int number = Prompt("Введите число > ");
for (int num = 1; num <= number; num++)
{
    // System.Console.WriteLine($"Куб числа {num} - {num * num * num}");
    System.Console.WriteLine($"Куб числа {num} - {Math.Pow(num,3)}");
}
