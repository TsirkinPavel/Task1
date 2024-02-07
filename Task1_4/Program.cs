// Знакомство с языками программирования (семинары)
//Урок 4. Функции Домашнее задание
int[,] matrix = new int[2, 4];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Random.rnd = new Random();
        matrix[i, j] = rnd.Next(1, 11);
    }
}
System.Console.WriteLine(matrix);
