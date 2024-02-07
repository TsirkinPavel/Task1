// Знакомство с языками программирования (семинары)
//1. Урок 4. Двумерные Массивы. Строки. (Лекция)
//2. Урок 4. Функции Домашнее задание

//Функция Создание матрицы заполненной случайными числами
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

// Семинар. Работа со строками
// Задача3. Считать с консоли строку состоящую из лат.букв и цифр. Сформировать новую строку
// только из букв исходной строки.
string GetLettersFromStr(string s)
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