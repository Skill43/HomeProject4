const int Size = 8;
double[] arr = new double[Size];
Random rand = new Random();
double max = 0, min = 1000;
for (int i = 0; i < arr.Length; i++)
{
    arr[i] =Math.Round(rand.NextDouble()*1000,3);
{
    if (arr[i] > max) max = arr[i];
    if (arr[i] < min) min = arr[i];
}

}
Console.WriteLine(string.Join(" | ", arr));
Console.WriteLine("max:  " + max);
Console.WriteLine("min  " + min);
Console.WriteLine("Разница между максимальным и минимальным: " + (max - min));