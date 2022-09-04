// Задайте массив. Напишите программу, которая определяет, 
// присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, -3] -> да

// вариант с применением for
// Console.Clear();
// Console.WriteLine("Введите размерность массива: ");
// int size = int.Parse(Console.ReadLine());
// int [] array = new int [size];

// Console.WriteLine("Введите число: ");
// int number =int.Parse(Console.ReadLine());
// bool A = false;


//     for(int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(-99,100);
//         Console.Write(array[i]+" ");
//         if (array[i]==number)
//         A= true;
//     }
    
//     Console.WriteLine();
//     if (A==true)
//     Console.WriteLine("Да");
//     else
//     Console.WriteLine("Нет");
    
//вариант с применением функции    

    Console.Clear();
Console.WriteLine("Введите размерность массива: ");
int size = int.Parse(Console.ReadLine());
int [] array = GetArray(size,-9,9);
Console.WriteLine(String.Join(" ",array));

Console.WriteLine("Введите число: ");
int number =int.Parse(Console.ReadLine());

Console.WriteLine(array.FirstOrDefault(p=>p == number) != 0 ? "Да" : "Нет");


    int [] GetArray(int size, int min, int max)
{
    int [] result = new int[size];
    for(int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(min,max+1);
    }
    return result;
}
    
    