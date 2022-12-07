// Задайте одномерный массив, заполненный случайными
// числами. Найдите сумму элементов, стоящих на
// нечетных позициях.

int[] CreateArray (int legth, int minRange, int maxRange)                   
{
    int[] numbers = new int [legth];
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(minRange, maxRange + 1);
    }
    return numbers;
}

void PrintArray (int[] array)                      
{
     for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}\t");            
    }
} 

int SumElementsArray(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(i%2 == 0)                        
        {
            sum += array[i];
        }
    }
    return sum;
}

int[] array = CreateArray (10, 1, 14);
PrintArray(array);
int Sum = SumElementsArray(array);
Console.WriteLine();
Console.WriteLine($"Сумма элементов массива, стоящих на нечетных позициях, равна {Sum}");