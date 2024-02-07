﻿// Урок 5. Двумерные Массивы. Содержание:
//1. Семинар. Урок 5. Двумерные Массивы
//2.Домашнее задание №5

//Задание 1.Задайте двумерный массив. Найдите элементы, у которых оба
//индекса чётные, и замените эти элементы на их квадраты.
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
int[,] matrix = CreateRndMatrix(4, 5);
ShowMatrix(matrix);

//Задание 2. Задайте двумерный массив. Найдите сумму элементов,
//находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

//Задание 3. Задайте двумерный массив из целых чисел. Сформируйте новый
//одномерный массив, состоящий из средних арифметических
//значений по строкам двумерного массива. 

//2.Домашнее задание№5
/*Задача 1: Напишите программу, которая на вход
принимает позиции элемента в двумерном массиве, и
возвращает значение этого элемента или же указание,
что такого элемента нет.*/

/*Задача 2: Задайте двумерный массив. Напишите
программу, которая поменяет местами первую и
последнюю строку массива.*/

/*Задача 3: Задайте прямоугольный двумерный массив.
Напишите программу, которая будет находить строку с
наименьшей суммой элементов.*/
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