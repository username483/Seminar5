// Задайте одномерный массив из 123 случайных чисел. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

Console.Clear();

int [] array = GetArray(123, -99,199);
int j = 0;
int [] GetArray(int size, int min, int max)
{
    int [] result = new int[size];
    
    for(int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(min,max+1);
        
    }
    return result;
}


int FindNumber(int [] array)
{for(int i = 0; i < array.Length; i++){

        if(10 <= array[i] && 99>= array[i])
        j++;
        }
        return j;
}

Console.WriteLine(String.Join(" ",array));
Console.WriteLine(FindNumber(array));