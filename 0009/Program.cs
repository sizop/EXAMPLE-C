// Двумерные массивы

// Задача 39: Напишите программу, которая перевернёт одномерный массив 
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

// Через вспомогательный массив
/*
int size = 5;
int[] array = new int[size];  // array = [0,0,0,0,0]

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(11); // 0-10
}

Console.WriteLine($" Array: [{String.Join("; ", array)}]");

// 1. Создать массив, в который мы скопируем текущий

int[] resultArray = new int[size];
int lastIndex = size - 1;
for (int i = 0; i < size; i++) //size = array.Length
{
    resultArray[i] = array[lastIndex - i];
}
Console.WriteLine($" Reverse array: [{String.Join("; ", resultArray)}]");
*/
// Половинка массива
/*
int[] array = GetArray(10, 0, 10);
Console.WriteLine(String.Join(" ", array));

int[] reversArray=CopyArray(array);
Console.WriteLine(String.Join(" ", reversArray));

ReversArray(array);
Console.WriteLine(String.Join(" ", array));


int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

void ReversArray(int[] inArray)
{
    for (int i = 0; i < inArray.Length / 2; i++)
    {
        int temp = inArray[i];
        inArray[i] = inArray[inArray.Length - i - 1];
        inArray[inArray.Length - i - 1] = temp;
    }
}

int[] CopyArray(int[] inArray)
{
    int[] result = new int[inArray.Length];
    for (int i = 0; i < inArray.Length; i++)
    {
        result[i] = inArray[inArray.Length - 1 - i];

    }
    return result;
}

*/

// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника 
// меньше суммы двух других сторон.
/*
Console.WriteLine("Ведите первое число");
int firstNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ведите второе число");
int secondNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ведите третье число");
int thirdNum = Convert.ToInt32(Console.ReadLine());
if( firstNum < secondNum + thirdNum && secondNum < firstNum + thirdNum && 
thirdNum < firstNum + secondNum ) Console.WriteLine("Треугольник со сторонами указаного размера существует");
else Console.WriteLine("Треугольник со сторонами указаного размера не существует");
*/

// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. 
// Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

/*
Console.WriteLine("Ведите желаемое количество чисел фибоначи");
int number = Convert.ToInt32(Console.ReadLine());
int firstNum = 0;
int secondNum = 1;
Console.Write(" Последовательность фибоначи искомой длинны: 0 1 ");
for (int i = 0; i < number; i++)
{
    int fibonachi = firstNum + secondNum;
    firstNum = secondNum;
    secondNum = fibonachi;
    Console.Write(fibonachi + " ");
}
*/
/*
int N = 10;

int firstElement = 0; // Первое число по определению равно 0

int secondElement = 1; // Второе число равно 1

Console.WriteLine(firstElement);  // 1 число
Console.WriteLine(secondElement); // 2 число

for (int i = 3; i <= N; i++)
{
    int nextElement = firstElement + secondElement;
    Console.WriteLine(nextElement);
    firstElement = secondElement;
    secondElement = nextElement;
}
*/

// Задача 45: Напишите программу, которая будет создавать копию заданного 
// массива с помощью поэлементного копирования.

/*
int[] array = new int[5];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(11);
}
Console.WriteLine($" Array: [ {string.Join("; ", array)} ]");
Console.WriteLine($" CopiedArray: [ {string.Join("; ", CopyArray(array))} ]");

int[] CopyArray(int[] inArray)
{
    int[] result = new int[inArray.Length];
    for (int i = 0; i < i                                                            nArray.Length; i++)
    {
        result[i] = inArray[i];

    }
    return result;
}
*/

// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

