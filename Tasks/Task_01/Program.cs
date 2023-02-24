// // Найти произведение двух матриц

Console.WriteLine("\nВведите размерность 1 матрицы");
Console.Write("Введите количество строк: ");
int m1 = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите количество столбцов: ");
int n1 = int.Parse(Console.ReadLine() ?? "0");
int [,] matrix1 = new int [m1, n1];

Console.WriteLine("\nВведите элементы 1 матрицы");
for (int i = 0; i < matrix1.GetLength(0); i++)
{
    for (int j = 0; j < matrix1.GetLength(1); j++)
    {
        Console.Write($"Элемент {i+1},{j+1}:");
        matrix1[i, j] = int.Parse(Console.ReadLine() ?? "0");
    }
}

Console.WriteLine("\nВведите размерность 2 матрицы");
Console.Write("Введите количество строк: ");
int m2 = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите количество столбцов: ");
int n2 = int.Parse(Console.ReadLine() ?? "0");
int [,] matrix2 = new int [m2, n2];

Console.WriteLine("\nВведите элементы 2 матрицы");
for (int i = 0; i < matrix2.GetLength(0); i++)
{
    for (int j = 0; j < matrix2.GetLength(1); j++)
    {
        Console.Write($"Элемент {i+1},{j+1}:");
        matrix2[i, j] = int.Parse(Console.ReadLine() ?? "0");
    }
}

Console.WriteLine("\n1 МАТРИЦА");
for (int i = 0; i < matrix1.GetLength(0); i++)
{
    for (int j = 0; j < matrix1.GetLength(1); j++)
    {
        Console.Write($"{matrix1[i, j]}\t");
    }
    Console.WriteLine();
}

Console.WriteLine("\n2 МАТРИЦА");
for (int i = 0; i < matrix2.GetLength(0); i++)
{
    for (int j = 0; j < matrix2.GetLength(1); j++)
    {
        Console.Write($"{matrix2[i, j]}\t");
    }
    Console.WriteLine();
}

if (n1 == m2)
{
    int[,] matrix3 = new int[m1,n2];
    for (int i = 0; i < matrix3.GetLength(0); i++)
    {
        for (int j = 0; j < matrix3.GetLength(1); j++)
        {
            matrix3[i, j] = 0;
            for (int n = 0; n < matrix1.GetLength(1); n++)
            {
                matrix3[i, j] += matrix1[i, n] * matrix2[n, j];
            }
        }
    }

    Console.WriteLine("\nРЕЗУЛЬТИРУЮЩАЯ МАТРИЦА");
    for (int i = 0; i < matrix3.GetLength(0); i++)
    {
        for (int j = 0; j < matrix3.GetLength(1); j++)
        {
            Console.Write($"{matrix3[i, j]}\t");
        }
        Console.WriteLine();
    }
}
else
{
    Console.WriteLine("\nПриведённые матрицы нельзя перемножить");
}

Console.WriteLine();