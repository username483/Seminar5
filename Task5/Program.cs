// Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

// Console.Clear();
// Console.WriteLine("Введите размерность массива: ");
// int size = int.Parse(Console.ReadLine());
// int [] array = GetArray(size, 1,10);
int [] GetArray(int size, int min, int max)
{
    int [] result = new int[size];
    for(int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(min,max+1);
    }
    return result;
}

int ReadNumber()
{
    int number = 0;
    while(true)
    {
        Console.WriteLine("Введите размерность");
        if (!int.TryParse(Console.ReadLine(), out number))
        {
            Console.WriteLine("Некорректный ввод");
        }
        else break;
    }
    return number;
}

Console.Clear();

int size = ReadNumber();
int [] array = GetArray(size, 0,10);
int [] newArray = new int [size%2 == 0 ?(size/2): (size/2 +1)];
for (int i = 0; i < newArray.Length; i++ )
{
    newArray[i] = array[i] * array[array.Length -1 -i];
}
if (newArray.Length % 2 !=0)
{
    newArray[newArray.Length -1]= array[array.Length/2];
}
Console.WriteLine(String.Join(" ",array));
Console.WriteLine(String.Join(" ",newArray));