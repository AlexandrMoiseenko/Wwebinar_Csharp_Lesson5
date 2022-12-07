// Задайте массив вещественных чисел. Найдите разницу между
// максимальным и минимальным элементов массива.
// [3, 7.4, 4, 5.6, 11] -> 76

double[] CreateArray (int length, int minRange, int maxRange)                   
{
    double[] numbers = new double[length];
    Random rand = new Random();
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = rand.Next( minRange, maxRange + 1) + rand.NextDouble();
    }
    return numbers;
}


void PrintArray (double[] array)                      
{
     for(int i = 0; i < array.Length; i++)
    {
        Console.Write("{0,6:F2}", array[i]);            
    }
}

double Raznica(double[] array)
{
    double min = array[0];
    double max = array[0];
   for (int i = 0; i < array.Length; i++)
   {
    if(array[i] > max)
    {
        max = array[i];
    }
   }
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] < min)
        {
            min = array[i];
        }
    }
    double raz = max - min;
    return raz;
}

double[] array = CreateArray(9, 4, 10);
PrintArray(array);
double Raz = Raznica(array);
Console.WriteLine();
Console.WriteLine("Разница между максимальным и минимальным элементами массива равна" + "{0,6:F2}", Raz);