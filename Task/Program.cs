//Написать программу, которая из имеющегося массива строк 
//формирует новый массив из строк, длина которых меньше, 
//либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
//либо задать на старте выполнения алгоритма.
//При решении не рекомендуется пользоваться коллекциями, 
//лучше обойтись исключительно массивами. 


Console.WriteLine("Введите количество строк"); 
int numStr = Convert.ToInt32(Console.ReadLine()); 
string[] array = new string[numStr]; 
Console.WriteLine("Введите текст"); 
for(int i = 0; i < numStr; i++) 
{ 
array[i] = Console.ReadLine(); 
if (array[i].Length > 3) array[i] = ""; 
} 
Console.WriteLine("Новый текст"); 
for (int i = 0; i < numStr; i++) 
{ 
if (array[i] == "") ; 
else { Console.Write(array[i] + " "); } 
}
