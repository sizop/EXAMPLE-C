// Напишите программу, которая принимает на вход координаты точки (X и Y),
//  причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой
//   находится эта точка.
/*
Console.Write("Введите координату по оси оХ: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату по оси оY: ");
int y = Convert.ToInt32(Console.ReadLine());
if (x > 0 && y > 0) Console.WriteLine("I четверть");
else if (x < 0 && y > 0) Console.WriteLine("II четверть");
else if (x < 0 && y < 0) Console.WriteLine("III четверть");
else if (x > 0 && y < 0) Console.WriteLine("IV четверть");
else System.Console.WriteLine("eror 404, quarter not found");
*/
// Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).
/*
Console.Write("Введите номер четверти: ");
int quarter = Convert.ToInt32(Console.ReadLine());

if (quarter == 1) Console.WriteLine($"I четверть: x > 0; y > 0");
else if (quarter == 2) Console.WriteLine($"II четверть: x < 0; y > 0");
else if (quarter == 3) Console.WriteLine($"III четверть: x < 0; y < 0");
else if (quarter == 4) Console.WriteLine($"IV четверть: x > 0; y < 0");
else Console.WriteLine($"Error: на плоскости 4 четверти, возможно совершили ошибку в введенных данных");
*/

// Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21
/*
Console.Write("Введите координату ox первой точки: ");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату oy первой точки: ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату ox второй точки: ");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату oy второй точки: ");
int y2 = Convert.ToInt32(Console.ReadLine());

double result = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
Console.WriteLine($"result = {Math.Round(result, 2)}");
*/
// Напишите программу, которая принимает на вход число (N) и 
// выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4
/*
Console.Write("Введите число N: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 0) number = number * (-1);

int i = 1;
while (i <= number)
{
    double result = Math.Pow(i,2);
    Console.Write($" {result}");
    i++;
}
*/
/*
Console.Write("Координата х: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Координата y: ");
int y1 = Convert.ToInt32(Console.ReadLine());
// B
Console.Write("Координата х: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Координата y: ");
int y2 = Convert.ToInt32(Console.ReadLine());

double d = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));

Console.WriteLine($"Расстояние = {Math.Round(d,3)}");
Console.WriteLine($"Расстояние = {d:f3}");

// переменная:fсколько_знаков
*/
/*

int N = Convert.ToInt32(Console.ReadLine());
//int start = 1;
// while (start <= N)
// {
//     // Console.WriteLine(start*start); 
//     Console.WriteLine(Math.Pow(start,2));
//     start++;//start = start + 1;
// }
// (начало; условие; увеличение счетчика цикла)
for (int start = 1; start <= N; start++)
{
    Console.WriteLine(Math.Pow(start,2) + " ");
}
*/
/*
    Console.Write(Math.Pow(start, 2) + "\t"); // Литералы строк
    // "\t" - поставить Tab между элементами строчки 
    // то же самое, что и "     "
*/