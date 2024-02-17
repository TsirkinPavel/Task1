// Знакомство с языками программирования. Урок 6. Содержание
//1.Урок 6. Семинар.Массивы и строки
//2.Урок 6. Лекция.Рекурсия
//3.Урок 7. Семинар. Рекурсия
//4. Д3 №6
//5. Д3 №7

// Считать с консоли строку состоящую из лат.букв и цифр. Сформировать новую строку
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

/*Задание 1. Задайте массив символов (тип char []). Создайте строку из
символов этого массива.
Указание: Конструктор строки вида string(char []) не использовать.*/

/*char[] chars = { 'a', 'b', 'c', 'd' };

string PrString(char[] chars)
{
    string sim = "";
    foreach (char e in chars)
    {
        sim = sim + e;
    }    
    return sim;
    
}
string sim = PrString(chars);
System.Console.WriteLine(sim);
*/
/*Задание 2. На основе символов строки (тип string) сформировать массив
символов (тип char[]). Вывести массив на экран.
Указание: Метод строки ToCharArray() не использовать.*/
/*string str = "Hello";
char[] MakeCharsArray(string str)
{
    int size = str.Length;
    char[] word = new char[size];
    for (int i = 0; i < str.Length; i++)
    {
        word[i] = str[i];
    }
    return word;
}
char[] word = MakeCharsArray(str);
foreach (char e in word)
{
    System.Console.Write($"{e} ");
}
*/

/*Задание 3. Считать строку с консоли, состоящую из латинских
букв в нижнем регистре. Выяснить, сколько среди
введённых букв гласных(vowels).
bool IsVowels(char chr)
{
    return chr == 'a' || chr == 'e' ||
           chr == 'i' || chr == 'o' ||
           chr == 'u' || chr == 'y';
}

int CountVowels(string str)
{
    int vowels = 0;
    foreach (char e in str)
    {
        if (IsVowels(e))
        {
            vowels++;
        }
    }
    return vowels;
}
System.Console.WriteLine("введите произвольную строку");
string str2 = Console.ReadLine()!;
int res = CountVowels(str2);
System.Console.WriteLine($"Количество гласных:{res}");
*/

//ДРУГОЕ из семинара: вводятся числа через запятую, преобразовываются в численный массив
/*
//string input = Console.ReadLine()!;
string input = "1, 3, 5";

// int[] numbers = input.Split(", ").Select(x => int.Parse(x)).ToArray();
int[] numbers = input.Split(", ").Select(int.Parse).ToArray();
//а теперь обратно собираются в строку, разделенную буквой Ы
Console.WriteLine(string.Join(" Ы ", numbers));
*/

/*2.Урок 6. Лекция Рекурсия
факториал обычный(предпочтительный):
int Fact(int n)
{
    int f = 1;
    for (int i = 2; i <= n; i++)
    {
        f = f * i;
        //f *= i;
    }
return f;
}
*/

/*
//факториал при помощи рекурсии:
int Fact(int n)
{    
    if (n == 1 || n == 0)
    {        
        return 1;        
    }  
    Console.WriteLine($"{n}");
    return n * Fact(n - 1);    
}
//Console.WriteLine($"введите число");
//int n = Convert.ToInt32(Console.ReadLine());
int n = 10;
System.Console.WriteLine(Fact(n));
*/

//3.Урок 7. Семинар. Рекурсия
/* Задание 1. Напишите программу, которая будет принимать на вход число и
возвращать сумму его цифр. Указание Использовать рекурсию.*/
/*int SumDigit(int value)
{
    value = Math.Abs(value);
    if (value == 0)
    {
        return 0;
    }
    int sum = value % 10 + SumDigit(value / 10);
    return sum;
}
Console.WriteLine($"введите число");
int n = Convert.ToInt32(Console.ReadLine()!);
System.Console.WriteLine(SumDigit(n));
*/
/* Задание 2. Задайте значение N. Напишите программу, которая выведет
все натуральные числа в промежутке от 1 до N.
Указание Использовать рекурсию. Не использовать цикл.*/
/*void PrintDigit(int min, int max)
{
    if (min > max)
    {
        System.Console.WriteLine();
        return;
    }
    System.Console.Write(min + " ");
    PrintDigit(min + 1, max);
}

PrintDigit(5, 10);
*/


/* Задание 3. Считать строку с консоли, содержащую латинские буквы.
Вывести на экран согласные буквы этой строки.
Указание Использовать рекурсию. Не использовать цикл.*/

//4.Домашнее задание Урок 6. Массивы и строки
/*Задача 1: Задайте двумерный массив символов (тип char [,]). Создать строку из символов
этого массива.*/
/*string ArrayToString(char[,] array)
{
    string str = "";
    foreach (char e in array)
    {
        str = str + " "+ e;
    }
    return str;
}
char[,] array = {
    { 'a', 'b', 'c' },
{'d', 'e', 'f'}
};
System.Console.WriteLine(ArrayToString(array));
*/
/*Задача 2: Задайте строку, содержащую латинские буквы в обоих регистрах. Сформируйте строку,
в которой все заглавные буквы заменены на строчные.*/

/*Console.InputEncoding = System.Text.Encoding.GetEncoding("utf-16");

char HighToLow(string str)
{
    //string result = str.ToLower();
    int size = str.Length;
    char[] word = new char[size];
    for (int i = 0; i < size; i++)
    {
        word[i] = str[i];
        if ('A' <= word[i] && word[i] <= 'Z')

        {
            word[i] = word[i] + 'a' - 'A';
        }
    }

    return word[size];
}
System.Console.WriteLine("введите произвольную строку");
string str2 = Console.ReadLine()!;

System.Console.WriteLine($"Result:{HighToLow(str2)}");
*/

//Задача 3: Задайте произвольную строку. Выясните, является ли она палиндромом.
// Метод для проверки, является ли строка палиндромом
/* 
bool IsPalindrome(string str)
{
// Нормализация строки путем удаления не буквенно-цифровыхсимволов и приведения к нижнему регистру
string normalized = new
string(str.Where(char.IsLetterOrDigit).ToArray()).ToLower();
//либо более простой вариант:
string FormatString(string str)
{
    string format_string = str.ToLower().Replace(" ", "");
    //Console.WriteLine(format_string);
    return format_string;
}

// Сравнение строки с ее перевернутым вариантом
return normalized.SequenceEqual(normalized.Reverse());
}
*/
//второй вариант решения:
/*Console.InputEncoding = System.Text.Encoding.GetEncoding("utf-16");

bool IsPolindrom(string str)
{
    bool polindrom = true;
    int size = str.Length;
    for (int i = 0; i < size / 2; i++)
    {
        if (str[i] != str[size - 1 - i])
        {
            polindrom = false;
            break;
        }       
    }
    return polindrom;
}

void PrintAnswer(string input)
{
    if (IsPolindrom(input))
    {
        System.Console.WriteLine("Полиндром");
    }
    else
    {
        System.Console.WriteLine("Не полиндром");
    }
}
System.Console.Write("Введите текст: ");
string input = Console.ReadLine()!;
PrintAnswer(input);
*/
/*Задача 4*(не обязательная): Задайте строку, состоящую из слов, разделенных пробелами. 
Сформировать строку, в которой слова расположены в обратном порядке. В полученной строке 
слова должны быть также разделены пробелами.*/
// Метод для обращения порядка слов в строке
/*
string ReverseWords(string str)
{
// Разделение строки на слова
string[] words = str.Split(' ');
// Обращение порядка слов
Array.Reverse(words);
// Соединение слов обратно в строку с пробелами
return string.Join(" ", words);
}
*/
//Второй вариант решения:
/*Console.InputEncoding = System.Text.Encoding.GetEncoding("utf-16");
string ReverseStrings(string input)
{
    string[] words = input.Split(' ');
    string tmp;
    for (int i = 0; i < words.Length / 2; i++)
    {
        tmp = words[i];
        words[i] = words[words.Length - 1 - i];
        words[words.Length - 1 - i] = tmp;
    }
    string revers_text = string.Join( ' ', words);
    return revers_text;
}

System.Console.Write("Text: ");
string input = Console.ReadLine()!;
string revers_text = ReverseStrings(input);
Console.WriteLine($"{revers_text}");
*/