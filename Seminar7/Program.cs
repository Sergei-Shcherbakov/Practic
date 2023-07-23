// Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.

// void InputArray(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(0, 1000);
//             Console.Write($"{matrix[i, j]} \t");
//         }
//         Console.WriteLine();
//     }
        
// }


// Console.Clear();
// Console.Write("Введите размеры матрицы: "); // 5 4    2 1
// int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
// int[,] matrix = new int[size[0], size[1]];
// InputArray(matrix);
// // 1 2 3 
// // 4 5 6



// Задача 48: Задайте двумерный массив размера m на n,
//  каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.

// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5


// void InputArray(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = i + j;
//             Console.Write($"{matrix[i, j]} \t");
//         }
//         Console.WriteLine();
//     }
        
// }
// Console.Clear();
// Console.Write("Введите размеры матрицы: "); 
// int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
// int[,] matrix = new int[size[0], size[1]];
// InputArray(matrix);



// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.


// void InputArray(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(0, 100);
//             Console.Write($"{matrix[i, j]} \t");
//         }
//         Console.WriteLine();
//     }
// }

// void ReleaseArray(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//           if( i%2 == 0 && j%2 == 0 && i +j != 0)
//             matrix[i, j] *=  matrix[i, j];
//          Console.Write($"{matrix[i, j]} \t");
//         }
//         Console.WriteLine();
//     }

//      Console.WriteLine(matrix);
// }

// Console.Clear();
// Console.Write("Введите размеры матрицы: "); 
// int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
// int[,] matrix = new int[size[0], size[1]];
// InputArray(matrix);
// Console.Write("\n"); 
// ReleaseArray(matrix);


// Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12




void InputArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

void ReleaseArray(int[,] matrix)
{   int sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
          if( i == j)
           sum +=  matrix[i, j];
        
        }
        
    }

     Console.WriteLine($" Сумма главной диоганали: {sum}");
}

Console.Clear();
Console.Write("Введите размеры матрицы: "); 
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputArray(matrix);
Console.Write("\n"); 
ReleaseArray(matrix);
