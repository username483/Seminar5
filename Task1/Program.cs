// задайте массив из 12 элементов, заполненный случайными числами
//из промежутка [-9,9]. найдите сумму отрицательныхи положительных
// элементов массива

Console.Clear();
Console.WriteLine("Введите размерность массива: ");
int size = int.Parse(Console.ReadLine());
int [] array = GetArray(size, -9,9);

//PrintArray(array);
Console.WriteLine(String.Join(" ",array));//Join это функция, которая выводит массив с разделителем знаков

int sumPositive = 0;
int sumNegative = 0;

foreach(int element in array)
{
    sumPositive += element > 0 ? element : 0;
    sumNegative += element < 0 ? element : 0;
}
Console.WriteLine($"sum positive = {sumPositive} sum negative = {sumNegative}");
int [] GetArray(int size, int min, int max)
{
    int [] result = new int[size];
    for(int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(min,max+1);
    }
    // foreach(int index in result)
    // {
    //   result[index] = new Random().Next(min,max+1);
    // }
    return result;
}

// void PrintArray(int [] array) // задаем функцию вывода массива - то же самое что и Join, но длиннее
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i]+ " ");
//     }
// }