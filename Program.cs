int size = int.Parse(Console.ReadLine());

Random r = new();
int[] array = new int[size];
int tmp;
for (int i = 0; i < array.Length; i++)
{
    array[i] = r.Next(1, 50);
    Console.Write(array[i] + "\t");
}
Console.WriteLine();

Console.WriteLine("Array after sort");

for (int j = 1; j <= array.Length - 1; j++)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        if (array[i] > array[i + 1])
        {
            Swap(ref array[i], ref array[i + 1]);

        }   
    }
}

Print(array);

static void Swap(ref int x, ref int y)
{
    int tmp = x;
    x = y;
    y = tmp;
}

static void Print (Array a)
{
    foreach(int i in a)
    {
        Console.Write(i + "\t");
    }
}

