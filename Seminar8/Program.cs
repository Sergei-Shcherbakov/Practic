
// int [,] Create2dArray (int rows, int collumns)
// {
//     int [,] createdArray = new int[rows, collumns];
//     for (int i = 0; i < rows; i++)
//         for (int j = 0; j < collumns; j++)
//             createdArray[i,j] = new Random().Next(0,10);
//     return createdArray;
// }

// void ShowArray (int [,] showedArray)
// {
//     for (int i = 0; i < showedArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < showedArray.GetLength(1); j++)
//         {
//             Console.Write (showedArray[i,j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// // Метод для перестановки любых строк
// void ChangeRows (int row1, int row2, int [,] arrayToChange)
// {
//     if (row1 >= 0
//      && row1 < arrayToChange.GetLength(0)
//      && row2 >= 0
//      && row2 < arrayToChange.GetLength(0))
//      {
//         for (int j = 0; j < arrayToChange.GetLength(1); j++)
//         {
//             int temp = arrayToChange[row1,j];
//             arrayToChange[row1,j] = arrayToChange[row2,j];
//             arrayToChange[row2,j] = temp;
//         }
//         ShowArray(arrayToChange);
//      }
//     else
//         Console.WriteLine("Error! Impossible value!");
// }

// Console.Write("Enter count of rows: ");
// int userRows = Convert.ToInt32(Console.ReadLine());

// Console.Write("Enter count of collumns: ");
// int userCollumns = Convert.ToInt32(Console.ReadLine());

// int [,] firstTaskArray = Create2dArray(userRows, userCollumns);
// ShowArray(firstTaskArray);

// Console.Write("Enter number of the first row to remove: ");
// int userRowFirst = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter number of the second row to remove: ");
// int userRowSecond = Convert.ToInt32(Console.ReadLine());

// ChangeRows(userRowFirst, userRowSecond, firstTaskArray);



// Задача 2.
// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.


// int [,] Create2dArray (int rows, int collumns)
// {
//     int [,] createdArray = new int[rows, collumns];
//     for (int i = 0; i < rows; i++)
//         for (int j = 0; j < collumns; j++)
//             createdArray[i,j] = new Random().Next(0,10);
//     return createdArray;
// }

// void ShowArray (int [,] showedArray)
// {
//     for (int i = 0; i < showedArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < showedArray.GetLength(1); j++)
//         {
//             Console.Write (showedArray[i,j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// void Removing(int[,] matrix)
// {
//     // if (rows >= 0
//     //   && rows < arrayToChange.GetLength(0)
//     //   && collumns >= 0
//     //   && collumns < arrayToChange.GetLength(1)
//     //   && rows == collumns)
    
//         for (int i = 0; i < matrix.GetLength(0); i++)
//         {
//             for (int j = i; j < matrix.GetLength(1); j++)
//             {
//                 int temp = matrix[i,j];
//                 matrix[i,j] = matrix[j,i];
//                 matrix[j,i] = temp;
//             }
    
            
//         }
    
//         ShowArray(matrix);
//     // else
//     //     Console.WriteLine("Error! Impossible value!");

// }

// Console.Write("Enter count of rows: ");
// int userRows = Convert.ToInt32(Console.ReadLine());

// Console.Write("Enter count of collumns: ");
// int userCollumns = Convert.ToInt32(Console.ReadLine());

// int [,] firstTaskArray = Create2dArray(userRows, userCollumns);
// ShowArray(firstTaskArray);

// Removing(firstTaskArray);



Задача 3.
Задайте двумерный массив из целых чисел. Напишите программу, которая обнулит строку и столбец, 
на пересечении которых расположен первый наименьший элемент массива.ffbgngngnn