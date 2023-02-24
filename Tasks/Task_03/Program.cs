// Сформировать трехмерный массив не повторяющимися двузначными числами
// показать его построчно на экран выводя индексы соответствующего элемента.

Console.WriteLine();
Console.WriteLine("Размерность массива трёхмерного массива");
Console.Write("Введите X: ");
int x = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите Y: ");
int y = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите Z: ");
int z = int.Parse(Console.ReadLine() ?? "0");
int [,,] matrix = new int [x, y, z];
int f = 10;

// Заполнение массива неповторяющимися числами
for(int z1 = 0; z1 < matrix.GetLength(2); z1++)
{
    for(int x1 = 0; x1 < matrix.GetLength(0); x1++)
    {
        for(int y1 = 0; y1 < matrix.GetLength(1); y1++)
        {
            matrix[x1, y1, z1] = f;
            f++;
        }
    }

}

// Вывод массива в терминал
Console.WriteLine($"\nВаш массив {x} x {y} x {z}:");
for(int z1 = 0; z1 < matrix.GetLength(2); z1++)
{
    for(int x1 = 0; x1 < matrix.GetLength(0); x1++)
    {
        for(int y1 = 0; y1 < matrix.GetLength(1); y1++)
        {
            Console.Write($"{matrix[x1, y1, z1]} ({x1},{y1},{z1})\t");
        }
        Console.WriteLine();
    }

}

Console.WriteLine();

// Есть момент, когда начинают появляться трёхзначные числа.
// Задание невозможно полноценно выполнить при заданных условиях.