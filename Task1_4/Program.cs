// Знакомство с языками программирования (семинары).Содержание:
//1. Урок 4. Двумерные Массивы. Строки. (Лекция)
//2. Урок 4. Функции Домашнее задание

//1.Функция Создание матрицы заполненной случайными числами
/*int[,] CreateRndMatrix(int rowsCount, int columnsCount)
{
    int[,] matrix = new int[rowsCount, columnsCount];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 1000);
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
            System.Console.Write($"{matrix[i, j]}\t"); //интерполяция строк
        }
        System.Console.WriteLine();
    }
}
int[,] matrix = CreateRndMatrix(4, 5);
ShowMatrix(matrix);
*/
//Вычисление суммы цифр в элементах массива и, если сумма четная, выведение их в консоль

/*
int SumDigits(int value)
{
    int sum = 0;
    while (value > 0)
    {
        sum = sum + value % 10;
        value = value / 10;
    }
    return sum;
}

bool IsIntresting(int value)
{
    int sum = SumDigits(value);
    if (sum % 2 == 0)
    {
        return true;
    }
    else
    {
        return false;
    }
}

foreach (int e in matrix)
{
    if (IsIntresting(e) == true)
    {
        System.Console.Write($"{e} ");
    }
}*/

// Лекция. Работа со строками
// Задача3. Считать с консоли строку состоящую из лат.букв и цифр. Сформировать новую строку
// только из букв исходной строки.
/*string GetLettersFromStr(string s)
{
    string letters = "";
    foreach (char e in s)
    {
        if (char.IsAsciiLetter(e) == true)
        {
            letters = letters + e;
        }        
    }
    return letters;
}
string str = Console.ReadLine()!;
string result = GetLettersFromStr(str);
System.Console.WriteLine(result);
*/

//2. Урок 4. Функции Домашнее задание
/*Задача 1: Напишите программу, которая бесконечно
 запрашивает целые числа с консоли. Программа завершается 
 при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.*/

/*int sumNumbers(int number)
{
    int sum = 0;
    while (number > 0)
    {
        sum = sum + number % 10;
        number = number / 10;
    }
    return sum;
}
bool GetEven(int sum)
{
    if (sum % 2 == 0)
    {
        return true;
    }
    else return false;
}

while (true)
{
    System.Console.WriteLine($"введите число или q для выхода:");

    string input = Console.ReadLine()!;
    if (input == "q")
    {
        break;
    }
    int numb;
    if (int.TryParse(input, out numb)) // Проверка, является ли ввод числом

    {
        int number = int.Parse(input);
        int sum = sumNumbers(number);
        if (GetEven(sum) == true)
        {
            System.Console.WriteLine($"четное - EXIT");
            break;
        }
        System.Console.WriteLine($"нечетное, хочу еще");

    }
    else // Если ввод не является числом и не 'q', повторить запрос
    {
        Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое число или 'q'.");
    }

}
*/

/*Задача 2: Задайте массив заполненный случайными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.*/

int[] GetRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(minValue, maxValue + 1);

    }
    return array;
}

void PrintArray(int[] array)
{
    foreach (int e in array)
    {
        System.Console.Write($"{e} ");
    }
    System.Console.WriteLine();
}

/*bool GetEven(int elem)
{
    if (elem % 2 == 0)
    {
        return true;
    }
    else return false;
}

int[] newArray = GetRandomArray (5, 0, 999);
int sumEven = 0;
foreach (int e in newArray)
{
   if (GetEven(e) == true)
   {
    sumEven++;
   } 
}
PrintArray(newArray);
System.Console.WriteLine($"в массиве {sumEven} четных элементов");
*/

/*Задача 3: Напишите программу, которая перевернёт одномерный массив (первый
элемент станет последним, второй – предпоследним и т.д.)*/

int size = 5;
int[] newArray = GetRandomArray(size, 0, 999);
PrintArray(newArray);
int[] ReversArray = new int[size];
for (int i = 0; i < size; i++)
{
    ReversArray[size-1-i] = newArray[i];
}
PrintArray(ReversArray);  
