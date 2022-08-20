﻿// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из 
// промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел 
// равна 29, сумма отрицательных равна -20.

/*
int[] array = new int[12]; // array = [0,0,0...0]

int resultPositive = 0; // Сумма положительных чисел
int resultNegative = 0; // Сумма отрицательных чисел
// for(int i = 0; i < array.Length; i++)
int i = 0; // i - index(int i = 0)
int arraySize = array.Length; // Длина массива - количество элементов
int[] array = new int[12]; // array = [0,0,0...0]
int resultPositive = 0; // Сумма положительных чисел
int resultNegative = 0; // Сумма отрицательных чисел
// for(int i = 0; i < array.Length; i++)
int i = 0; // i - index(int i = 0)
int arraySize = array.Length; // Длина массива - количество элементов

while (i < arraySize) // i < array.Length
{
    array[i] = new Random().Next(-9, 10); // [-9;9]
    // i++ - увеличение индекса
    i++;
}
Console.WriteLine($"Array: [ {String.Join("; ", array)} ]");
int[] array = new int[12]; // array = [0,0,0...0]
int resultPositive = 0; // Сумма положительных чисел
int resultNegative = 0; // Сумма отрицательных чисел
// for(int i = 0; i < array.Length; i++)
int i = 0; // i - index(int i = 0)
int arraySize = array.Length; // Длина массива - количество элементов
while (i < arraySize) // i < array.Length
{
    array[i] = new Random().Next(-9, 10); // [-9;9]
    // i++ - увеличение индекса
    i++;
}
Console.WriteLine($"Array: [ {String.Join("; ", array)} ]");
// j,k,m
for (int j = 0; j < arraySize; j++)
{
    // Число отрицательное
    if (array[j] < 0) resultNegative += array[j]; // resultNegative = resultNegative + array[i]
    // Положительные числа и 0
    else resultPositive += array[j]; // resultPositive = resultPositive + array[j] 
}

Console.WriteLine($"Сумма пол. = {resultPositive}, сумма отр. = {resultNegative} ");
*/

// Задача 32: Напишите программу замена элементов массива: положительные элементы замените 
// на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

/*
int[] array = new int[10];
for (int i = 0; i < array.Length; i++) array[i] = new Random().Next(-10, 11);
Console.WriteLine("[" + String.Join(", ", array) + "]");
for (int j = 0; j < array.Length; j++) array[j] *= -1;
Console.WriteLine("[" + String.Join(", ", array) + "]");
*/

// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли 
// заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

/*
int[] array = new int [10] {1,2,3,4,5,6,7,8,9,10};

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Boolean result = false;

for (int i = 0; i < array.Length; i++) 
{
    array[i] = new Random().Next(10);
    if (array[i] == number) result = true;
}
Console.WriteLine("[" + String.Join(", ", array) + "]");
if (result) Console.WriteLine("Число найдено");
else Console.WriteLine("Число не найдено");
*/

// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество 
// элементов массива, значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

/*
int[] array = new int[123];
int count = 0;
for (int i = 0; i < array.Length; i++) 
{
    array[i] = new Random().Next(200);
    //Console.Write(array[i] + "  ");  
    if (array[i] >= 10 && array[i] <=99) count++;
}
*/
