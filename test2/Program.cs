const int Size = 9;
const int LeftRange = -9;
const int RightRange = 9;

int[] array = new int[Size];
Random rand = new Random();
int res =0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(LeftRange, RightRange + 1);
    if (i % 2 != 0) res += array[i];
}
System.Console.WriteLine($"Сумма элементов массива, стоящих на нечётных позициях: \n| {(string.Join(" | ", array))} | = {res}");
