// Показать кубы чисел, заканчивающихся на четную цифру;

Console.Clear();
System.Console.WriteLine();

int N = new Random().Next(1, 30);
System.Console.WriteLine($"N = {N}");

System.Console.WriteLine("By Method 1:");

int[] GetEvenCubeArray(int N)
{
    int num = 1;
    int i = 0;
    int[] EvenCubs = new int[N];
    while (num <= N)
    {
        int cube = num * num * num;
        if (cube % 2 == 0)
        {
            EvenCubs[i] = cube;
            i++;
        }
        num++;
    }
    return EvenCubs;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write($"{arr[i]} ");
    }
    System.Console.WriteLine();
}

PrintArray(GetEvenCubeArray(N));
