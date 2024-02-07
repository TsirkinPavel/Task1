//int N = 5, i = 1;
//while (i <= N)
//{
//    Console.WriteLine(i);
//    i++;
//}
//ЗАДАНИЕ1 нахождение большего из 2 чисел
//int firstNumber = 5;
//int secondNumber = 6;
//if (firstNumber > secondNumber)
//{
//Console.WriteLine($"первое число больше");
//}
//else if (firstNumber < secondNumber)
//{
//Console.WriteLine($"второе число больше");
//}
//else
//{
//Console.WriteLine($"числа равны");
//}

//ЗАДАНИЕ2 максимальное из 3 чисел
//int a = 5; 
//int b = 6;
//int c = 7;
//int result = a;
//if (b > result)
//{
//result = b;
//}
//if (c > result)
//{
//result = c;
//}
//System.Console.WriteLine($"{result}");

//ЗАДАНИЕ3 Проверка на четность
//int number = 11;
//if (number % 2 == 0)
//{
    //Console.WriteLine($"четное");
//}
//else
//{
    //Console.WriteLine($"Число {number} - нечетное");
//}

//ЗАДАНИЕ 4 Вывести четные числа
int number = 157;
for (int i = 2; i <= number; i+=2)
{
   Console.Write($"{i} "); 
}
