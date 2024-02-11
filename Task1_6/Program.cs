// Знакомство с языками программирования. Урок 6. Содержание
//1.Урок 6. Семинар.Массивы и строки

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

/*Задание 2. На основе символов строки (тип string) сформировать массив
символов (тип char[]). Вывести массив на экран.
Указание: Метод строки ToCharArray() не использовать.*/

/*Задание 3. Считать строку с консоли, состоящую из латинских
букв в нижнем регистре. Выяснить, сколько среди
введённых букв гласных(vowels).*/
for (i = 0; i < len; i++)
{
    if (inputstring[i] == 'a' || inputstring[i] == 'e' ||
        inputstring[i] == 'i' || inputstring[i] == 'o' ||
        inputstring[i] == 'u')
    {
        vowels++;
    }
}
