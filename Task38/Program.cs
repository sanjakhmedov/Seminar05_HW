// // Задача 38: Задайте массив вещественных чисел. 
// // Найдите разницу между максимальным и минимальным элементами массива.

// // [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

// // Random random = new Random();
// // double n = random.NextDouble()*100;
// // Console.WriteLine(Math.Round(n, 2));

double[] CreateDoubleArray(int size, int max, int roundTo)
{
    Random random = new Random();
    double[] arr = new double[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = Math.Round(random.NextDouble()*max, roundTo);
    }
    return arr;
}

double[] MinMax(double[] arr)
{
    double[] res = new double[2];
    
    res[1] = arr[0]; // max
    for (int i = 0; i < arr.Length; i++)
    {
        if(res[1] > arr[i]) continue;
        else res[1] = arr[i];
    }
    res[0] = arr[0]; // min
    for (int i = 0; i < arr.Length; i++)
    {
        if(res[0] < arr[i]) continue;
        else res[0] = arr[i];
    }
    return res;
}

void PrintArray(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.Write(arr[arr.Length - 1]);
    Console.Write("]");
}

double[] array = CreateDoubleArray(10, 100, 2);
PrintArray(array);
double[] minMax = MinMax(array);
Console.WriteLine();
PrintArray(minMax);
double maxMinDiff = Math.Round(minMax[1] - minMax[0], 2);
Console.Write(" -> " + maxMinDiff);