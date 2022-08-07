*/
// Получаем первую и третью цифру трехзначного числа
/*
 string inputNumber = Console.ReadLine(); //"456"
Console.WriteLine(inputNumber[0]+ inputNumber[2]);

// 2. int

int number = new Random().Next(100, 1000); // [0;999]
int result = ((number/100) * 10) + number % 10;//456 -> 4, 456 % 10 -> 6

Console.WriteLine($"Исходное число: {number}, результат: {result}");
*/
/*
int firstNumber = Convert.ToInt32(Console.ReadLine());   
int secondNumber = Convert.ToInt32(Console.ReadLine());  

if (firstNumber % secondNumber == 0) // остаток от деления = 0, числа кратные
{
    Console.WriteLine("кратно");
}
else Console.WriteLine($"Не кратно, остаток: {firstNumber % secondNumber}");
*/
/*
int number = Convert.ToInt32(Console.ReadLine());   
// && - "И"
// or - "||" 
if (number % 7 == 0 || number % 23 == 0) Console.WriteLine("Кратно 7 и 23");
else Console.WriteLine("Не кратно 7 и 23");
*/