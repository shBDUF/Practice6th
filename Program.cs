Console.WriteLine("Введите цифры - ");
int[] array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i]>0)
    {
        count++;
    }
}
Console.WriteLine("Количество цифр больше нуля -> {0}", count);