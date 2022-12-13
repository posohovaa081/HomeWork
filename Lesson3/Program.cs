// Задача 23  Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.Clear();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

int[] arr = CubeTable(number);

int[] CubeTable(int n)
{
    int[] arr = new int[n];

    for (int i = 1; i <= n; i++)
    {
        arr[i - 1] = i * i * i;
    }

    return arr;
}

System.Console.WriteLine(String.Join(",", arr));

