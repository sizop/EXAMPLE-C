// Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

/*
Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] GetArray(int m, int n)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)//строчки
    {
        for (int j = 0; j < matrix.GetLength(1); j++)// столбцы
        {
            matrix[i, j] = new Random().Next(11); 
        }
    }
    return matrix;
}
int[,] resultMatrix = GetArray(rows, columns); 
PrintArray(resultMatrix);
void PrintArray(int[,] inputMatrix)
{
    for (int i = 0; i < inputMatrix.GetLength(0); i++) // строчки
    {
        for (int m = 0; m < inputMatrix.GetLength(1); m++) // столбцы
        {
            Console.Write(inputMatrix[i, m] + "\t"); //"\t" - Tab
        }
        Console.WriteLine();
    }
}

*/

// Задача 48: Задайте двумерный массив размера m на n, каждый элемент 
//в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5
/*
Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] GetArray(int m, int n)
{
	int[,] matrix = new int[m, n];
	for (int i = 0; i < matrix.GetLength(0); i++)//строчки
	{
		for (int j = 0; j < matrix.GetLength(1); j++)// столбцы
		{
			matrix[i, j] = (i + j);
		}
	}
	return matrix;
}
int[,] resultMatrix = GetArray(rows, columns);
PrintArray(resultMatrix);
void PrintArray(int[,] inputMatrix)
{
	for (int i = 0; i < inputMatrix.GetLength(0); i++) // строчки
	{
		for (int m = 0; m < inputMatrix.GetLength(1); m++) // столбцы
		{
			Console.Write(inputMatrix[i, m] + "\t"); //"\t" - Tab
		}
		Console.WriteLine();
	}
}
*/

// Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные,
//  и замените эти элементы на их квадраты.

/*
Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] GetArray(int m, int n)
{
	int[,] matrix = new int[m, n];
	for (int i = 0; i < matrix.GetLength(0); i++)//строчки
	{
		for (int j = 0; j < matrix.GetLength(1); j++)// столбцы
		{
			matrix[i, j] = 1; //new Random().Next(11);
			if (i % 2 == 0 && j%2==0)  {matrix[i, j] = (i + j);}
		}
	}
	return matrix;
}
int[,] resultMatrix = GetArray(rows, columns);
PrintArray(resultMatrix);
void PrintArray(int[,] inputMatrix)
{
	for (int i = 0; i < inputMatrix.GetLength(0); i++) // строчки
	{
		for (int m = 0; m < inputMatrix.GetLength(1); m++) // столбцы
		{
			Console.Write(inputMatrix[i, m] + "\t"); //"\t" - Tab
		}
		Console.WriteLine();
	}
}
*/

// Задача 51. Найти сумму элементов главной диагонали.
// апример, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

/*
int[,] matrix = new int[3, 4];
int summa = 0;
for (int i = 0; i < matrix.GetLength(0); i++)//строчки
{
	for (int j = 0; j < matrix.GetLength(1); j++)// столбцы
	{
		matrix[i, j] = new Random().Next(11);
		if (i == j) { summa += matrix[i, j]; }
	}
}
for (int i = 0; i < matrix.GetLength(0); i++) // строчки
{
	for (int m = 0; m < matrix.GetLength(1); m++) // столбцы
	{
		Console.Write(matrix[i, m] + "\t"); //"\t" - Tab
	}
	Console.WriteLine();
}
Console.WriteLine($"Сумма по диагонали =  {summa}");
*/