/* #1
Console.WriteLine("Введите первое число: ");
int number_1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number_2 = Convert.ToInt32(Console.ReadLine());
if (number_1 > number_2)
{	Console.WriteLine("Число " + number_1 + " больше числа " + number_2);}
else Console.WriteLine("Число " + number_2 + " больше числа " + number_1);
*/

/* #2
Console.WriteLine("Введите первое число: ");
int number_1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number_2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int number_3 = Convert.ToInt32(Console.ReadLine());
int max = number_1;
if (number_2 > max)
{ max = number_2; }
if (number_3 > max)
{ max = number_3; }
Console.WriteLine("Максимальное трех чисел " + max);
*/

/* #3
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number%2==0)
{	Console.WriteLine("Число четное");}
else
{	Console.WriteLine("Число нечетное");}
*/

/* #4
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
while (number>1)
{
	if (number%2==0)
	{Console.WriteLine(number);}
	number--;
}
