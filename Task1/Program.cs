// Задача 1: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да

int ReadInt(string message)
{
    Console.Write(message);                             // Ввод приглашения
    int number = Convert.ToInt32(Console.ReadLine());   // Чтение строки и преобразование в число
    return number;                                      // Возврат целого числа
}

bool Validate3sign(int number)
{
    if (number < 10000 || number >= 100000)
    {
        Console.WriteLine("Вы ввели не 5-х значное число");
        return false;
    } 
    return true;
}

int digit = ReadInt("Введите 5-х значное число > ");
if (Validate3sign(digit))
{
    int a1 = digit % 10;
    int a2 = digit / 10 % 10;
    int a3 = digit / 100 % 10;
    int a4 = digit / 1000 % 10;
    int a5 = digit / 10000;
    int num = a1 * 10000 + a2 * 1000 + a3 * 100 + a4 * 10 + a5;

    // System.Console.WriteLine(digit);
    // System.Console.WriteLine(num);

    if (num == digit)
    {
        Console.WriteLine($"Число {digit} - полиндром");
    }
    else
    {
        Console.WriteLine($"Число {digit} - не полиндром");
    }


}
