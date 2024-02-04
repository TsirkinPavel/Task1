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
Random rnd = new Random();
int size = 6;
int[] arr_int = new int[size];
int i = 0;
while (i < size)
{
    arr_int[i] = rnd.Next(1, 100);
    i++;
}

//определяем простое число или нет
bool IsPrime(int number)
{
    for (int i = 2; i < number; i++)
    {
        if (number % i == 0)
            return false;
    }
    return true;
}
    //Задание 2. Задайте массив из N случайных целых чисел (N вводится с
    //клавиатуры). Найдите количество чисел, которые оканчиваются на 1 и
    //делятся нацело на 7.
    /*
    System.Console.WriteLine("Введите количество элементов массива:");
    int N = int.Parse(Console.ReadLine());
    Random rnd = new Random();
    int size = N;
    int[] arr_int = new int[size];
    int i = 0;
    while (i < size)
    {
        arr_int[i] = rnd.Next(1, 100);
        i++;
    }
    */
    /*Задание 3. Заполните массив на N (вводится с консоли, не более 8)
    случайных целых чисел от 0 до 9.
    Сформируйте целое число, которое будет состоять из цифр из
    массива. Старший разряд числа находится на 0-м индексе,
    младший – на последнем.*/
    /*
    int []array = new int [8]
    for (int i = 0; i < 8; i++)
    {
        System.Console.WriteLine("Введите {i+1}-й элемент массива, любое число от 0 до 9:");
        int value = int.Parse(Console.ReadLine());
        int array[i] = value        
    }
string StrNum = Num.ToString(array);
for (int i = 0; i < StrNum.Length); i++)
{
    System.Console.Write($"{StrNum[i]}");
}
*/