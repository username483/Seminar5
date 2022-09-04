// Напишите программу замена элементов массива: 
// положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

Console.Clear();
Console.WriteLine("Введите размерность массива: ");
int size = int.Parse(Console.ReadLine());
int [] array = new int [size];
int [] array2 = new int [size];


    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(-99,100);
        Console.Write(array[i]+" ");
    }
    
    Console.WriteLine();
    
    for(int i = 0; i < size; i++)
    {
        array2[i] = array[i]*-1;
        Console.Write(array2[i]+" ");
    }


