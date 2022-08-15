// #1
/*
Console.Write($"Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());

Console.Write($"Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());
int result = 1;
for (int i = 1; i <= B; i++)
{
    result *= A;
}
Console.WriteLine(result);
*/

// #2

Console.Write($"Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = 0;
for (int i = number; i>0; i/=10)
{
	result = result + number % 10;
}
Console.WriteLine($"Сумма цифр составляет: {result}");