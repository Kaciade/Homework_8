// В двумерном массиве целых чисел.
// Удалить строку и столбец, на пересечении которых расположен наименьший элемент.

Console.WriteLine();
Console.Write("Введите количество строк массива: ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите количество столбцов массива: ");
int n = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите левую часть массива: ");
int min = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите правую часть массива: ");
int max = int.Parse(Console.ReadLine() ?? "0");
int [,] matrix = new int [m, n];
Random random = new Random();

Console.WriteLine($"\nВаш массив {m} x {n}:");
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = random.Next(min, max);
        Console.Write($"{matrix[i, j]}\t");
    }
    Console.WriteLine();
}

int [] position = new int [2];
int temp = matrix[0, 0];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (matrix[i, j] < temp)
        {
            position[0] = i;
            position[1] = j;
            temp = matrix[i, j];
        }
    }
}
Console.WriteLine($"\nMинимальный элемент: {temp}");

int[,] newMatrix = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
int k = 0;
int l = 0;
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (position[0] != i && position[1] != j)
        {
            newMatrix[k, l] = matrix[i, j];
            l++;
        }
    }
    l = 0;
    if (position[0] != i)
    {
        k++;
    }
}

Console.WriteLine($"\nНовый массив {m-1} x {n-1}:");
for (int i = 0; i < newMatrix.GetLength(0); i++)
{
    for (int j = 0; j < newMatrix.GetLength(1); j++)
    {
        Console.Write($"{newMatrix[i, j]}\t");
    }
    Console.WriteLine();
}
Console.WriteLine();