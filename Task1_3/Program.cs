// ДЗ №3 Знакомство с языками программирования (семинары)

// Задание 1. Задайте одномерный массив из 10 целых чисел от 1 до 100. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,90].
/*int[] numbers = { 1, 5, 10, 20, 30, 40, 99, 4, 90, 3 };
int minRange = 10;
int maxRange = 90;
int count = 0;
foreach (int element in numbers)
{
    if (element >= minRange && element <= maxRange)
    {
        count++;
    }
}
//return count;
System.Console.WriteLine(count);
*/
// Задание 2. Задайте массив на 10 целых чисел.
//Напишите программу, которая определяет количество чётных чисел в массиве.
/*int[] numbers = { 2, 5, 2, 3, 6, 3, 7, 8, 2, 4 };

int count = 0;
foreach (int element in numbers)
{
    if (element % 2 ==0)
    {
        count++;
    }
}
//return count;
System.Console.WriteLine(count);
*/
//Задание 3. Задайте массив из вещественных чисел с ненулевой дробной частью.
//Найдите разницу между максимальным и минимальным элементов массива.

/*double[] numbers = { 0.25, 5.4, 1.3, 2.1, 3.8, 5.2, 3.01 };
double FindMin(double[] numbers)
{
    double Min = numbers[0];
    foreach (double e in numbers)
    {
        if (e < Min)
        {
            Min = e;
        }
    }
    return Min;
}
double Min = FindMin(numbers);
Console.WriteLine(Min);

double FindMax(double[] numbers)
{
    double Max = numbers[0];
    foreach (double e in numbers)
    {
        if (e > Max)
        {
            Max = e;
        }
    }
    return Max;
}
double Max = FindMax(numbers);
Console.WriteLine(Max);
Console.WriteLine(Max - Min);
*/

//ЗАПОЛНЕНИЕ МАССИВА СЛУЧАЙНЫМИ ЧИСЛАМИ
/*Random rnd  = new Random();
int size = 6;
int[] arr_int = new int[size];
int i = 0;
while(i < size)
{
	arr_int[i] = rnd.Next(1, 1000);
	i++;
}

i = 0;
while(i < size)
{
	Console.Write($"{arr_int[i]} ");
	i++;
}
*/
//Семинар 4 
//Задание 1. Задайте одномерный массив, заполненный случайными
//числами. Определите количество простых чисел в этом массиве.
bool IsPrime(int number)
{
    for (int i = 2; i < number; i++)
    {
        if (number % i == 0)
            return false;
    }
    return true;
}

int[] GetRandomArray(int size, int minValue = 1, int maxValue = 99)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(minValue, maxValue + 1);

    }
    return array;
}

int[] GetArrayFromConsole()
{
    Console.Write("Size: ");
    int size = int.Parse(Console.ReadLine()!);
    int[] array = new int[size];

    Console.WriteLine($"Enter {size} elements:");
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = int.Parse(Console.ReadLine()!);
    }
    return array;

}

void PrintArray(int[] array)
{
    Console.Write("[");
    foreach (int number in array)
    {
        Console.Write(number + " ");
    }
    Console.WriteLine("]");
}

int CountPrimeNumbers(int[] array)
{
    int count = 0;
    foreach (var elem in array)
    {
        if (IsPrime(elem))
        {
            count++;
        }
    }
    return count;
}
/*

int[] array = GetRandomArray(6);
PrintArray(array);

int[] array2 = GetArrayFromConsole();
PrintArray(array2);

System.Console.WriteLine($"результат: {CountPrimeNumbers(array)}");
System.Console.WriteLine($"результат: {CountPrimeNumbers(array2)}");
*/

/*Задание 3. Заполните массив на N (вводится с консоли, не более 8)
случайных целых чисел от 0 до 9.
Сформируйте целое число, которое будет состоять из цифр из
массива. Старший разряд числа находится на 0-м индексе,
младший – на последнем.*/
int[] GetArrayFrCons()
{
    Console.Write("Enter Size < 9: ");
    int size = int.Parse(Console.ReadLine()!);
    int[] array = new int[size];

    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(0, 10);

    }
    return array;
}

int ConvertDigToInt(int[] array)
{
    int res = 0;
    for (int i = 0; i < array.Length; i++)
    {
        int tmpResult = array[i] * (int)Math.Pow(10, array.Length - i - 1);
        System.Console.Write($"{tmpResult} ");   
        res += tmpResult;   
    }
    return res;
}

int[] array = GetArrayFrCons();
PrintArray(array);
System.Console.WriteLine($"результат {ConvertDigToInt(array)}");
