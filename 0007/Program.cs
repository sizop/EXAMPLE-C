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
/*
Console.Write($"Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = 0;
for (int i = number; i>0; i/=10)
{
	result = result + number % 10;
}
Console.WriteLine($"Сумма цифр составляет: {result}");
*/

//ЛЕКЦИЯ

// Таблица умножения 
  /*
 for (int i = 2; i < 10; i++) 
 { 
     for (int j = 2; j < 10; j++) 
     { 
         Console.WriteLine($"{i} * {j} = {i*j}"); 
     } 
     Console.WriteLine(); 
 }
 */

 // Замена в тексте все пробелы на "-", к на К, С на с. 
  /*
 string Replace (string text, char oldValue, char newValue) 
 { 
     string result = string.Empty; 
     int Length = text.Length; 
     for (int i = 0; i < Length; i++) 
     { 
         if (text[i] == oldValue) result = result + newValue; 
         else result = result + text[i]; 
     } 
     return result; 
 } 
  
 string text = "Я к вам пишу — чего же боле?" +  
                 "Что я могу еще сказать?" + 
                 "Теперь, я знаю, в вашей воле" + 
                 "Меня презреньем наказать."+ 
                 "Но вы, к моей несчастной доле"+ 
                 "Хоть каплю жалости храня,"+ 
                 "Вы не оставите меня."+ 
                 "Сначала я молчать хотела;"+ 
                 "Поверьте: моего стыда"+ 
                 "Вы не узнали б никогда,"+ 
                 "Когда б надежду я имела"+ 
                 "Хоть редко, хоть в неделю раз"+ 
                 "В деревне нашей видеть вас,"+ 
                 "Чтоб только слышать ваши речи,"+ 
                 "Вам слово молвить, и потом"+ 
                 "Все думать, думать об одном"+ 
                 "И день и ночь до новой встречи."; 
  
 // string newText = Replace(text, " ", "|"); 
 // Console.WriteLine(newText); 
  
 string newText = Replace(text, ' ', '|'); 
 Console.WriteLine(newText); 
 Console.WriteLine(); 
 newText = Replace(newText, 'к', 'К'); 
 Console.WriteLine(newText); 
 Console.WriteLine(); 
 newText = Replace(newText, 'C', 'c'); 
 Console.WriteLine(newText);
 */

 // Сортировка массива 
  /*
 int[] arr = { 1, 5, 3, 6, 1, 1, 5 }; 
  
 void printArr(int[] array) 
 { 
     int count = array.Length; 
     for (int i = 0; i < count; i++) 
     { 
         Console.Write($"{array[i]} "); 
     } 
     Console.WriteLine(); 
 } 
  
 void selectionSort (int[] array) 
 { 
  for (int i = 0; i < array.Length-1; i++) 
     { 
        int minPos = i; 
        for (int j = i+1; j < array.Length; j++) 
        { 
            if(array[j]< array[minPos]) minPos = j; 
        } 
        int temporary = array[i]; 
        array[i] = array [minPos]; 
        array [minPos] = temporary; 
     }    
 } 
 printArr(arr); 
 selectionSort (arr); 
 printArr(arr);
 */