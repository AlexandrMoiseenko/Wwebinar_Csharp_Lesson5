// Задайте массив, заполненный случайными положительными трехзначными 
// числами. Напишите программу, которая покажет количество четных
// чисел в массиве.

int[] CreateArray (int legth)                   
{
    int[] numbers = new int [legth];
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(100, 1000);
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

int SumNumbers(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i]%2 == 0)
        {
            sum += 1;
        }
    }
    return sum;
}

int[] array = CreateArray (8);
PrintArray(array);

int Sum = SumNumbers(array);
Console.WriteLine();
Console.WriteLine($"Количество четных чисел в заданном массиве равно {Sum}");