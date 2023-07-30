//Задача 1
//Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.

// void ShowNumbers (int n)
// {

//     Console.Write(n + " ");
//     if (n>1) ShowNumbers(n - 1);
// }
// ShowNumbers(5);

//Задача 2
//Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.


// int SumDigits (int num)
// {
//     if (num< 0) num *= -1;
//     if (num > 0) return SumDigits(num / 10) + num %10;
//     else return 0;
// }

// Console.Clear();
// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int res = SumDigits(n);
// Console.Write(res);


//Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// N < M, N = M, M < N

// void ShowNumbersMN (int numM, int numN)
// {
//     //Math.Min(numM,numN)
//     Console.Write($"{Math.Min(numN, numM)} ");
//     if (Math.Min(numM,numN) != Math.Max(numM, numN)) ShowNumbersMN (Math.Min(numM,numN)+1, Math.Max(numM,numN));
// }
// ShowNumbersMN(1, 9);


//Задача 4
//Напишите программу, которая на вход принимает два числа A и B, 
//и возводит число А в целую степень B с помощью рекурсии.
//2^(-1) = 1/2     
//2^(-3) = 1/(2^3)   2^3 = 8
//-2^(-3) = -1/(2^3)   -2^3 = -8  -2^4 = 16
//2^0 = 1  18888^0 = 1


// double FindPower (int a, int b)
// {
//     if (b > 0) return FindPower(a, b - 1) *a;
//     if (b < 0) return FindPower(a, b + 1) /a;
//     return 1.0;
// }

// double resultFind = FindPower(-2,4);
// Console.Write(resultFind);