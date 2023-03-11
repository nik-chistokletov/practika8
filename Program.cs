//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//7 4 2 1
//9 5 3 2
//8 4 4 2

//int[,] table = new int[3, 4];
//FillArrayRandom(table);
//PrintArray(table);
//SortToLower(table);
//Console.WriteLine();
//PrintArray(table);



//void FillArrayRandom(int[,] array)
//{
  //  for (int i = 0; i < array.GetLength(0); i++)
  //  {
    //    for (int j = 0; j < array.GetLength(1); j++)
    //    {
    //        array[i, j] = new Random().Next(1, 10);
    //    }
   // }
//}


//void SortToLower(int[,] array)
//{
  //  for (int i = 0; i < array.GetLength(0); i++)
  //  {
    //    for (int j = 0; j < array.GetLength(1); j++)
    //    {
    //        for (int k = 0; k < array.GetLength(1) - 1; k++)
    //        {
    //            if (array[i, k] < array[i, k + 1])
    //            {
    //                int temp = array[i, k + 1];
    //                array[i, k + 1] = array[i, k];
    //                array[i, k] = temp;
    //            }
    //        }
    //    }
   // }
//}


//void PrintArray(int[,] array)
//{
//    for (int i = 0; i < array.GetLength(0); i++)
//    {
//        for (int j = 0; j < array.GetLength(1); j++)
//        {
//            Console.Write($"{array[i, j]} ");
//        }
//        Console.WriteLine();
//    }
//}


//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

//int[,] table = new int[4, 4];

//void FillArrayRandom(int[,] array)
//{
  //  for (int i = 0; i < array.GetLength(0); i++)
  //  {
    //    for (int j = 0; j < array.GetLength(1); j++)
      //  {
       //     array[i, j] = new Random().Next(1, 10);
       // }
   // }
//}
//FillArrayRandom(table);
//PrintArray(table);
 
//void PrintArray(int[,] array)
//{
  //  for (int i = 0; i < array.GetLength(0); i++)
  //  {
  //      for (int j = 0; j < array.GetLength(1); j++)
  //      {
  //          Console.Write($"{array[i, j]} ");
  //      }
  //      Console.WriteLine();
  //  }
//}
//Console.WriteLine();
//void NumberRowMinSumElement(int[,] array)
//{
  //  int min1 = 0;
  //  int min2 = 0;
  //  int min3 = 0;
  //  for (int i = 0; i < table.GetLength(1); i++)
  //  {
  //      min1 += table[0, i];
  //  }
  //  for (int i = 0; i < table.GetLength(0); i++)
  //  {
  //      for (int j = 0; j < table.GetLength(1); j++)
  //       min3 += table[i, j];
  //      if (min3 < min1)
  //      {
  //          min1 = min3;
  //          min2 = i;
  //      }
  //      min3 = 0;
  //  }
  //  Console.Write($"{min2 + 1} строка");
//}
//NumberRowMinSumElement(table);

//Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
//Массив размером 2 x 2 x 2/
//66(0,0,0) 25(0,1,0)
//34(1,0,0) 41(1,1,0)
//27(0,0,1) 90(0,1,1)
//26(1,0,1) 55(1,1,1)


//int[,,] array = new int[2, 2, 2];
//FillArray(array);
//PrintIndex(array);


//void PrintIndex(int[,,] arr)
//{
  //  for (int i = 0; i < array.GetLength(0); i++)
  //  {
  //      for (int j = 0; j < array.GetLength(1); j++)
  //      {
  //          Console.WriteLine();
  //         for (int k = 0; k < array.GetLength(2); k++)
  //          {
  //              Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
  //          }
  //      }
  //  }
//}

//Console.ReadKey();

//void FillArray(int[,,] arr)
//{
//    for (int i = 0; i < arr.GetLength(0); i++)
//    {
//        for (int j = 0; j < arr.GetLength(1); j++)
//        {
//            for (int k = 0; k < arr.GetLength(2); k++)
//            {
                
 //               array[i, j,k] = new Random().Next(10, 99);
 //           }
 //       }
 //   }
//}