// Задача 50. Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение этого элемента или же указание, 
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(1, 10);
            Console.Write($"{matrix[i,j]} \t");
        }
        Console.WriteLine();
    }
}

string ReleaseMatrix(int[,] matrix)
{
    int row = ReadInt("Введите индекс строки: ");
    int col = ReadInt("Введите индекс столбца: ");
    // int row = position[0], col = position[1];
    if (row < matrix.GetLength(0) && col < matrix.GetLength(1))
    {
        return $"Ваш элемент [{row};{col}] = {matrix[row, col]}";
    }
    else
    {
        return $"Такого элемента нет в массиве";
    }
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

Console.Clear();
Console.Write("Введите размер матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
Console.WriteLine();
InputMatrix(matrix);
Console.WriteLine();
Console.WriteLine(ReleaseMatrix(matrix));
