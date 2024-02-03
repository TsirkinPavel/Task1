//Знакомство с языками программирования (семинары) домашнее задание №2

//Задача 1: Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
/*System.Console.WriteLine("Введите целое число:");
int num = int.Parse(Console.ReadLine());
if (num % 7 == 0 && num % 23 == 0)
{
   System.Console.WriteLine($"Число {num} кратно одновременно 7 и 23 "); 
}
else
{
  System.Console.WriteLine($"Число {num} не кратно одновременно 7 и 23 ");  
}*/

//Задача 2: Напишите программу, которая принимает на вход координаты точки (X и Y),
//причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка.

/*System.Console.WriteLine("Введите ненулевую координату X:");
int X = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите ненулевую координату Y:");
int Y = int.Parse(Console.ReadLine());
if (X > 0 && Y > 0)
{
  System.Console.WriteLine($"Число ({X},{Y}) находится в 1 плоскости системы координат "); 
}
else if (X < 0 && Y > 0)
{
  System.Console.WriteLine($"Число ({X},{Y}) находится в 2 плоскости системы координат "); 
}
else if (X < 0 && Y < 0)
{
  System.Console.WriteLine($"Число ({X},{Y}) находится в 3 плоскости системы координат "); 
}
else if (X > 0 && Y < 0)
{
  System.Console.WriteLine($"Число ({X},{Y}) находится в 4 плоскости системы координат "); 
}
else
{
   System.Console.WriteLine($"Вы ввели нулевую координату");
}
*/

//Задача 3: Напишите программу, которая принимает на вход целое число из отрезка [10, 99]
//и показывает наибольшую цифру числа.

/*System.Console.WriteLine("Введите двухзначное целое число:");
int number = int.Parse(Console.ReadLine());
int number1 = number % 10;
int number2 = number / 10;
if (number1 > number2)
{
   System.Console.WriteLine(number1); 
}
else
{
    System.Console.WriteLine(number2);
}
*/

//Задача 4: Напишите программу, которая на вход принимает натуральное число N, 
//а на выходе показывает его цифры через запятую.

System.Console.WriteLine("Введите натуральное число N:");
int Num = int.Parse(Console.ReadLine());
string StrNum = Num.ToString();
for (int i = 0; i < (StrNum.Length-1); i++)
{
    System.Console.Write($"{StrNum[i]}, ");
}
System.Console.WriteLine(StrNum[StrNum.Length-1]);
