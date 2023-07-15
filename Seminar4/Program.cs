// Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

//  Console.Clear();
//  Console.Write("Введите число: ");

//  double f(double n)
// {
//     return (1+n)/ 2 * n;
// }

//  double n = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine(f(n));

// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

// int f(int n)
// {
//     int count = 0;
//     while (n > 0)
//     {
//         n /= 10; // n = n / 10
//         count ++;
//     }
//     return count;
// }

// Console.Clear();
// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(f(n));


// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

// (n−2)⋅ (n−1)⋅n

// void f(int n)
// {
//     int result = 1;
//     for (int i = 2; i <= n; i ++)
//         result *= i; // result = result * i
//     Console.WriteLine(result);
    
// }

// Console.Clear();
// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// f(n);

// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

// Console.Clear();
// int[] array = new int[8];
// for (int i = 0; i < array.Length; i ++)
//     array[i] = new Random().Next(0, 2); // [0;1]
// Console.WriteLine($"[{string.Join(", ", array)}]");