const int Size = 5;
const int LeftRange = 100;
const int RightRange = 999;
int[] array = new int[Size];
Random rand = new Random();
int res =0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(LeftRange, RightRange + 1);
    if (array[i] % 2 == 0) res++;
}
System.Console.WriteLine($"Количество четных чисел в массиве: \n| {(string.Join(" | ", array))} | = {res}");
