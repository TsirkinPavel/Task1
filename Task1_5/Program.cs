// Урок 5. Двумерные Массивы. Содержание:
//1. Семинар. Урок 5. Двумерные Массивы
//2.Домашнее задание №5

//Задание 1.Задайте двумерный массив. Найдите элементы, у которых оба
//индекса чётные, и замените эти элементы на их квадраты.
/*int[,] CreateRndMatrix(int rowsCount, int columnsCount)
{
    int[,] matrix = new int[rowsCount, columnsCount];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 10);
        }
    }
    return matrix;
}

//Функция Печать матрицы
void ShowMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}
int[,] matrix = CreateRndMatrix(4, 4);
ShowMatrix(matrix);
System.Console.WriteLine();

//Функция суммирования всех элементов массива
int Sum(int[,] array)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
    }

    return sum;
}


for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (i % 2 == 0 && j % 2 == 0 && i == j)
        {
            matrix[i, j] = matrix[i, j] * matrix[i, j];
        }
    }
}

ShowMatrix(matrix);
*/
/*
//Задание 2. Задайте двумерный массив. Найдите сумму элементов,
//находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
int[,] CreateRndMatrix(int rowsCount, int columnsCount)
{
    int[,] matrix = new int[rowsCount, columnsCount];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 10);
        }
    }
    return matrix;
}

//Функция Печать матрицы
void ShowMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}
int[,] matrix = CreateRndMatrix(4, 4);

int SumDiag(int[,] matrix)
{
    int sum = 0;
    int minLength = Math.Min(matrix.GetLength(0), matrix.GetLength(1));

    for (int i = 0; i < minLength; i++)
    {
        sum = sum + matrix[i, i];
    }
    return sum;
}
ShowMatrix(matrix);
int sum = SumDiag(matrix);
System.Console.WriteLine($"Сумма = {sum}");
//Задание 3. Задайте двумерный массив из целых чисел. Сформируйте новый
//одномерный массив, состоящий из средних арифметических
//значений по строкам двумерного массива.

int[,] GetArray(int rows, int cols, int minValue = 0, int maxValue = 10)
{
    int[,] table = new int[rows, cols];

    var rnd = new Random();
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            table[i, j] = rnd.Next(minValue, maxValue + 1);
        }
    }

    return table;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

double[] MeansRows(int[,] matrix)
{
    double[] means = new double[matrix.GetLength(0)];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            means[i] += matrix[i, j];
        }
        means[i] /= matrix.GetLength(1);
    }

    return means;
}

int[,] matrix = GetArray(3, 2);
PrintArray(matrix);

double[] means = MeansRows(matrix);
foreach (double item in means)
{
    Console.WriteLine(item);
}
/*
//2.Домашнее задание№5
/*Задача 1: Напишите программу, которая на вход
принимает позиции элемента в двумерном массиве, и
возвращает значение этого элемента или же указание,
что такого элемента нет.*/
/*int FindElementByPosition(int[,] array, int x, int y)
{
    return array[x - 1, y - 1];
}

bool ValidatePosition(int[,] array, int x, int y)
{
    if (x > array.GetLength(0) || y > array.GetLength(1))
    {
        return false;
    }
    else
    {
        return true;
    }
}

void PrintResult(int[,] numbers, int x, int y)
{
    System.Console.WriteLine(numbers[x - 1, y - 1]);
}

int[,] array = new int[,] {
    {1, 2, 3, 4},
    {5, 6, 7, 8},
    {9, 10, 11, 12}
};
int x = 3;
int y = 3;

if (ValidatePosition(array, x, y) == false)
{
    System.Console.WriteLine($"Позиция выходит за пределы массива");
}
else
{
        PrintResult(array, x, y);
}
*/

/*Задача 2: Задайте двумерный массив. Напишите
программу, которая поменяет местами первую и
последнюю строку массива.*/
/*void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}

int[,] numbers = new int[,] {
    {1, 2, 3, 4},
    {5, 6, 7, 8},
    {9, 10, 11, 12}
};
int[,] array = new int[,] {
    {1, 2, 3, 4},
    {5, 6, 7, 8},
    {9, 10, 11, 12}
};
PrintArray(array);
System.Console.WriteLine();
int[,] SwapFirstLastRows(int[,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        int temp = array[0, j];
        array[0, j] = array[array.GetLength(0) - 1, j];
        array[array.GetLength(0) - 1, j] = temp;
    }
    return array;
}
SwapFirstLastRows(array);
PrintArray(array);
*/

/*Задача 3: Задайте прямоугольный двумерный массив.
Напишите программу, которая будет находить строку с
наименьшей суммой элементов.*/

int[] SumRows(int[,] array)
{
    int[] sumRowsArray = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i, j];
        }
        sumRowsArray[i] = sum;

    }
    return sumRowsArray;
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
}
int MinIndex(int[] array)
{
   int min = array[0];
   int minind = 0;
   for (int i = 0; i < array.Length; i++)
    {        
        if (array[i] < min)
        {
            min = array[i];
            minind = i;
        }
    }
    return minind;
}
int[,] numbers = new int[,] {
    {1, 2, 3},
    {1, 1, 0},
    {7, 8, 2},
    {9, 10, 11}
};
int[] sumRowsArray = SumRows(numbers);
PrintArray(sumRowsArray);
int result = MinIndex(sumRowsArray);
System.Console.WriteLine($"Min = {result}");