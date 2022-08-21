// Дан массив из 1000 элементов, заполненный случайными целыми значениями 
// в диапазоне от -10000 до 10000. Сохранить в файл построчно данные 
// массива в формате:

// Подключаем библиотеку System.IO, создаем массив на 1000 элементов и 
// инициализируем экземпляр класса Random. Далее, в безопасной конструкции 
// try/catch инициализируем экземпляр класса StreamWriter с параметрами в 
// конструкторе «имя файла», false – формат перезаписи файла, кодировка UTF8. 
// Организуем цикл для перебора элементов массива, где в теле, будем 
// генерировать текущему элементу случайное значение методом Next(), и следующей 
// строкой оператором WriteLine запишем 
// в файл нужные данные. После цикла не забудем закрыть открытый файл методом Close().

using System;
using System.IO;
namespace Serg40in {
	 class Program {
  static void Main() {
    const int SIZE = 1000;
    int[] array = new int[SIZE];
    Random rnd = new Random();
    try {
       StreamWriter file = new StreamWriter("C:\\File.txt", false, System.Text.Encoding.UTF8);
       for(int i = 0; i < array.Length; i++) {
          array[i] = rnd.Next(-10000, 10001);
          file.WriteLine($"{i}|{array[i]}|");
       }
       file.Close();
       Console.WriteLine("ОК. Записать файл получилось.");
    } catch {
       Console.WriteLine("Ошибка доступа к файлу. Записать файл не получилось.");
    }
    Console.ReadKey();
  }
  }
}