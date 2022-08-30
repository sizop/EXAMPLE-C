// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет 
// местами первую и последнюю строку массива.
// Создание массива
/*

Console.WriteLine("Количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] GetArray(int m, int n)
{
int[,] matrix = new int[m, n];
for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
matrix[i, j] = new Random().Next(11);
}
}
return matrix;
}
*/

// Вывод массива
/*
void PrintArray(int[,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
Console.Write(matrix[i, j] + "\t");
}
Console.WriteLine();
}
}
*/
// Метод замены строк
/*
void ChangeRows(int[,] inputMatrix)
{
int indexLastRow = inputMatrix.GetLength(0) - 1; // size - 1
for (int i = 0; i < inputMatrix.GetLength(1); i++)
{
int temp = inputMatrix[0, i];
inputMatrix[0, i] = inputMatrix[indexLastRow, i];
inputMatrix[indexLastRow, i] = temp;
}
}

int[,] resultMatrix = GetArray(rows, columns);
PrintArray(resultMatrix);
Console.WriteLine("Result: ");
ChangeRows(resultMatrix);
PrintArray(resultMatrix);
*/

// Задача 55: Задайте двумерный массив. Напишите программу, которая 
// заменяет строки на столбцы. В случае, если это невозможно, программа 
// должна вывести сообщение для пользователя.


// Метод замены строк на столбцы
/*
int[,] resultMatrix = GetArray(rows, columns);
PrintArray(resultMatrix);
Console.WriteLine();

int[,] ChangeArray(int[,] inputMatrix)
{
    
    int[,] result = new int[inputMatrix.GetLength(0), inputMatrix.GetLength(1)];
    for (int i = 0; i < result.GetLength(0); i++)
    { 
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = inputMatrix[j, i];
        }
    }
    return result;
}
//ChangeArray(resultMatrix);
if (resultMatrix.GetLength(0) == resultMatrix.GetLength(1)) PrintArray(ChangeArray(resultMatrix));
else Console.WriteLine("Матрица не квадратная");
*/

// Задайте двумерный массив из целых чисел. Напишите программу, которая удалит
//  строку и столбец, на пересечении которых расположен наименьший элемент массива.

int rows = 3;
int columns = 3;

int[,] matrix = new int[rows, columns];
int minElement = int.MaxValue;
int indexMinRows = 0; // строчка
int indexMinColumns = 0; // столбец с мин элементом

for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
matrix[i, j] = new Random().Next(11); // [0;10]
Console.Write(matrix[i, j] + "\t");
if (minElement > matrix[i, j]) // 5 > 0, min = 0
{
indexMinColumns = j;
indexMinRows = i;
minElement = matrix[i,j];
}
}
Console.WriteLine();
}
System.Console.WriteLine("Result: ");
for (int i = 0; i < matrix.GetLength(0); i++)
{
if (indexMinRows != i)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
if (indexMinColumns != j)
{
Console.Write(matrix[i, j] + "\t");
}
}
Console.WriteLine();
}
}
*/