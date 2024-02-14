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

//ДРУГОЕ из семинара
//string input = Console.ReadLine()!;
string input = "1, 3, 5";

// int[] numbers = input.Split(", ").Select(x => int.Parse(x)).ToArray();
int[] numbers = input.Split(", ").Select(int.Parse).ToArray();

Console.WriteLine(string.Join(", ", numbers));
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

/* Задание 2. Задайте значение N. Напишите программу, которая выведет
все натуральные числа в промежутке от 1 до N.
Указание Использовать рекурсию. Не использовать цикл.*/

/* Задание 3. Считать строку с консоли, содержащую латинские буквы.
Вывести на экран согласные буквы этой строки.
Указание Использовать рекурсию. Не использовать цикл./*
