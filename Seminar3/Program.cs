// Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

// Console.Clear();
// Console.Write("x = ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.Write("y = ");
// int y = Convert.ToInt32(Console.ReadLine());

// if (x > 0 && y > 0)
//     Console.Write("I");
// else if (x < 0 && y > 0)
//     Console.Write("II");
// else if (x < 0 && y < 0)
//     Console.Write("III");
// else if (x > 0 && y < 0)
//     Console.Write("IV");

// Напишите программу, которая по заданному номеру четверти,
//  показывает диапазон возможных координат точек в этой четверти (x и y).

// Console.Clear();
// Console.Write("Введите номер четверти ");
// int a = Convert.ToInt32(Console.ReadLine());
// while (a>4 || a<1)
// {
//     Console.Write("Введите номер четверти ");
//     a = Convert.ToInt32(Console.ReadLine());
// }
// if (a==1)
//     Console.Write("x>0, y>0");
// else if (a==2)
//     Console.Write("x<0, y>0");
// else if (a==3)
//     Console.Write("x<0, y<0");
// else if (a==4)
//     Console.Write("x>0, y<0");
// // else if (a>4)
//      Console.Write("Неверный номер четверти");
// else if (a<1)
//      Console.Write("Неверный номер четверти");



// Напишите программу, которая принимает на вход координаты двух точек и находит
//  расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

// Console.Clear();
//  Console.Write(" x1 = ");
// int x1 = Convert.ToInt32(Console.ReadLine());
//  Console.Write(" y1 = ");
// int y1 = Convert.ToInt32(Console.ReadLine());
//  Console.Write(" x2 = ");
// int x2 = Convert.ToInt32(Console.ReadLine());
//  Console.Write(" y2 = ");
// int y2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(Math.Round(Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2)), 3));


// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел 
// от 1 до N.

// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

//  Console.Clear();
//  Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
//  for(int i = 1; i<=n; i++)



// Console.WriteLine(Math.Pow (i, 2));

//  Console.Clear();
//  Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// //  for(int i = 1; i<=n; i++)
// int i = 1; 
// while (i<=n)
// {

//     Console.WriteLine(Math.Pow (i, 2));
//     i++;
// }