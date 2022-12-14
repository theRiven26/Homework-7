/* Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.

0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9 */

using static Common.Helper;
int m = UserInputint("Enter m");
int n = UserInputint("Enter n");
double[,] array2D = new double[m, n];

FillRandom2DArray(array2D, -10, 10);
Print2DArray(array2D);