// Задача 2: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между 
// ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int Prompt(string message)
{
    System.Console.Write($"{message}  ");
    return int.Parse(Console.ReadLine());
}

int x1 = Prompt("Введите координату x1 => ");
int y1 = Prompt("Введите координату y1 => ");
int z1 = Prompt("Введите координату z1 => ");
int x2 = Prompt("Введите координату x2 => ");
int y2 = Prompt("Введите координату y2 => ");
int z2 = Prompt("Введите координату z2 => ");

double distancex = x2 - x1;
double distancey = y2 - y1;
double distancez = z2 - z1;

double distance = Math.Sqrt(distancex * distancex + distancey * distancey + distancez * distancez);
System.Console.WriteLine($"Расстояние между точками {distance:f3}");