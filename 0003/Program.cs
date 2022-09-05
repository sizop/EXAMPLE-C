/*
int number = Convert.ToInt32(Console.ReadLine());
int square = number * number;
// int result = Convert.ToInt32(Math.Pow(number, 2));
Console.WriteLine("Квадрат от числа " + number + " = " + square);
*/

/*
Console.Write("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
if (Math.Pow(firstNumber,2) == secondNumber)
{ Console.WriteLine(firstNumber + " является квадратом " + secondNumber); }
else Console.WriteLine(firstNumber + " НЕ является квадратом " + secondNumber);
*/

/* /Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа
 в промежутке от -N до N.
4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
2 -> " -2, -1, 0, 1, 2"
*/

int number = Convert.ToInt32(Console.ReadLine());
int negativNumber=number*(-1);

while (negativNumber<=number)
{
	Console.WriteLine(negativNumber);
	negativNumber++;
}