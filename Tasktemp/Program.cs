// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные 
// числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.
void PrintDigit(int min, int max)
{
    if (min >= max)
    {
        System.Console.Write(max);
        System.Console.WriteLine();
        return;
    }
    System.Console.Write(min + ", ");
    PrintDigit(min + 1, max);
}
System.Console.WriteLine("Задача1:");
PrintDigit(3, 15);
// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два 
// неотрицательных числа m и n.
int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0)
    {
        return Akkerman(m - 1, 1);
    }
    else
    {
        return Akkerman(m - 1, Akkerman(m, n - 1));
    }
}
System.Console.WriteLine("Задача2:");
System.Console.WriteLine($"Akkerman Function Result = {Akkerman(2, 3)}");

// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать 
// рекурсию, не использовать циклы.

System.Console.WriteLine("Задача3:");

void PrintReversArray(int[] array, int size)
{
    System.Console.Write($"{array[size - 1]} ");
    if (size > 1)
    {
        PrintReversArray(array, size - 1);
    }
}

int[] array = { 7, 23564, 36, 546, 64, 13 };
PrintReversArray(array, array.Length);
