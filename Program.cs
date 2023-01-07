// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки 
// двумерного массива.
// int [,] Create2DArray (int rows, int cols, int min, int max){
//     int[,] array = new int [rows, cols];
//     for (int i=0; i<rows; i++){
//         for (int j=0; j<cols; j++){
//             array[i,j] = new Random().Next(min, max+1);
//         }
//     }
//     return array;
// }
// void ShowArray (int [,] array){
//     for (int i=0; i<array.GetLength(0); i++){
//         for (int j=0; j<array.GetLength(1); j++){
//             Console.Write($"{array[i,j]} ");
//         }
//         Console.WriteLine();
//     }
// }
// int [,] SortArray (int [,] array){
//     for(int i=0; i<array.GetLength(0); i++){
//         for (int j=0; j<array.GetLength(1); j++){
//             for (int k = 0; k < array.GetLength(1) - 1; k++){
//                 if (array[i, k] < array[i, k + 1]){
//                     int temp = array[i, k + 1];
//                     array[i, k + 1] = array[i, k];
//                     array[i, k] = temp;
//                 }
//             }
//         }
//     }
//     return array;
// }
// Console.Write("Введите кол-во строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите кол-во столбцов: ");
// int cols = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите минимальное значение элемента: ");
// int min = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите максимальное значение элемента: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int [,] array = Create2DArray(rows, cols, min, max);
// ShowArray(array);
// Console.WriteLine("Упорядоченный массив: ");
// int [,] arr = SortArray (array);
// ShowArray(arr);


// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить 
// строку с наименьшей суммой элементов.
// int [,] Create2DArray (int rows, int cols, int min, int max){
//     int[,] array = new int [rows, cols];
//         for (int i=0; i<rows; i++){
//             for (int j=0; j<cols; j++){
//                 array[i,j] = new Random().Next(min, max+1);
//             }
//         }
//         return array;
//     }
    

// void ShowArray (int [,] array){
//     for (int i=0; i<array.GetLength(0); i++){
//         for (int j=0; j<array.GetLength(1); j++){
//             Console.Write($"{array[i,j]} ");
//         }
//         Console.WriteLine();
//     }
// }
// void NumberRowMinSumEl(int[,] array)
// {
//     int minRow = 0;
//     int minSumRow = 0;
//     int sumRow = 0;
//     for (int i = 0; i < array.GetLength(1); i++)
//     {
//         minRow += array[0, i];
//     }
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++) sumRow += array[i, j];
//         if (sumRow < minRow)
//         {
//             minRow = sumRow;
//             minSumRow = i;
//         }
//         sumRow = 0;
//     }
//     Console.Write($"{minSumRow + 1} строка");
// }

// Console.Write("Введите кол-во строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите кол-во столбцов: ");
// int cols = Convert.ToInt32(Console.ReadLine());
// if (cols == rows){
// Console.WriteLine("Массив не прямоугольный. Начните сначала");
// return;
// }
// Console.Write("Введите минимальное значение элемента: ");
// int min = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите максимальное значение элемента: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int [,] array = Create2DArray(rows, cols, min, max);
// ShowArray(array);
// NumberRowMinSumEl(array);



// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

// int [,] Create2DArray (int rows, int cols, int min, int max){
//     int[,] array = new int [rows, cols];
//     for (int i=0; i<rows; i++){
//         for (int j=0; j<cols; j++){
//             array[i,j] = new Random().Next(min, max+1);
//         }
//     }
//     return array;
// }
// void ShowArray (int [,] array){
//     for (int i=0; i<array.GetLength(0); i++){
//         for (int j=0; j<array.GetLength(1); j++){
//             Console.Write($"{array[i,j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// int [,] GetMultiplicationMatrix(int[,] arrayA, int[,] arrayB){
//     int[,] arrayC = new int[arrayy.GetLength(0), arrayy.GetLength(1)];
//     for (int i = 0; i < arrayy.GetLength(0); i++){
//         for (int j = 0; j < arrayy.GetLength(1); j++){
//             for (int k = 0; k < arrayy.GetLength(1); k++){
//                 arrayC[i, j] += arrayA[i, k] * arrayB[k, j];
//             }
//         }
//       }
//     return arrayC;
// }

// Console.Write("Введите количество строк 1 массива: ");
// int rowsA = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите количество столбцов 1 массива: ");
// int colsA = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите количество строк 2 массива: ");
// int rowsB = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите количество столбцов 2 массива: ");
// int colsB = Convert.ToInt32(Console.ReadLine());

// if (colsA != rowsB){
//     Console.WriteLine("Такие матрицы не умножаются.Повтоорите ввод.");
//     return;
// }
// Console.Write("Введите минимальное значение элемента: ");
// int min = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите максимальное значение элемента: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[,] A = Create2DArray(rowsA, colsA, min, max);
// int[,] B = Create2DArray(rowsB, colsB, min, max);
// ShowArray(A);
// Console.WriteLine();
// ShowArray(B);
// Console.WriteLine();
// ShowArray(GetMultiplicationMatrix(A,B));

// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// int[,,] Create3dArray(int field, int rows, int columns) { 
//     int[,,] newArray = new int[field, rows, columns]; 
//     newArray[0,0,0] = 10;
//     int count = 0;
//     for(int i = 0; i < field; i++){ 
//         for(int j = 0; j < rows; j++){ 
//             for(int k = 0; k < columns; k++){
//                 if(newArray [i,j,k] < 99){
//                     newArray[i,j,k] = newArray[0,0,0]+count;
//                     count++; 
//                 }
//                 else{ 
//                 Console.WriteLine("Введите меньший размер массива");
//                 } 
//             }
//         }
//     }        
//     return newArray; 
// } 
// void ShowArray(int[,,] array){
//     for (int i = 0; i < array.GetLength(0); i++){
//         for(int j = 0; j < array.GetLength(1); j++){
//             for(int k = 0; k < array.GetLength(2); k++){
//                 Console.Write(array[i, j, k] + "(" + i + "," + j +"," + k +")" + " ");
//             }
//             Console.WriteLine();
//         } Console.WriteLine();
//     } 
//     Console.WriteLine();
// } 
// Console.Write("Введите кол-во полей: ");
// int n = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите длину строки: ");
// int m = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите кол-во столбцов: "); 
// int l = Convert.ToInt32(Console.ReadLine());

// int[,,] array = Create3dArray(m, n, l);
// ShowArray(array);


// Напишите программу, которая заполнит спирально массив 4 на 4.

// void SpiralArray(int[,] array, int n)
// {
//     int i = 0, j = 0;
//     int value = 1;
//     for (int e = 0; e < n * n; e++)
//     {
//         int k = 0;
//         do { array[i, j++] = value++; } while (++k < n - 1);
//         for (k = 0; k < n - 1; k++) array[i++, j] = value++;
//         for (k = 0; k < n - 1; k++) array[i, j--] = value++;
//         for (k = 0; k < n - 1; k++) array[i--, j] = value++;
//         ++i; ++j;
//         n = n < 2 ? 0 : n - 2;
//     }
// }

// //  Функция вывода двумерного массива в терминал
// void ShowArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (array[i, j] < 10)
//             {
//                 Console.Write("0" + array[i, j]);
//                 Console.Write(" ");
//             }
//             else Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }
// int size = 4;
// int[,] array = new int[size, size];
// SpiralArray(array, size);
// ShowArray(array);