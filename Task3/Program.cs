// Задайте массив. Напишите программу, которая определяет, 
// присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, -3] -> да

Console.Clear();
Console.WriteLine("Введите размерность массива: ");
int size = int.Parse(Console.ReadLine());
int [] array = new int [size];

Console.WriteLine("Введите число: ");
int number =int.Parse(Console.ReadLine());
bool A = false;


    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(-99,100);
        Console.Write(array[i]+" ");
        if (array[i]==number)
        A= true;
    }
    
    Console.WriteLine();
    if (A==true)
    Console.WriteLine("Да");
    else
    Console.WriteLine("Нет");
    
    