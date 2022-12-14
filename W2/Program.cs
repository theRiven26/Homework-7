/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет */

using static Common.Helper;
int nRow = UserInputint("Enter row");
int nColumn = UserInputint("Enter column");
int[,] array2D = new int[3, 4];

if (nRow > array2D.GetLength(0) || nColumn > array2D.GetLength(1))
{
	Console.WriteLine("no element at given coordinates");
	return;
}
FillRandom2DArray(array2D, -10, 10);
Print2DArray(array2D);
Console.WriteLine();
Console.WriteLine(GetElemetsOfCoordinatesArray2D(array2D, nRow, nColumn));

int GetElemetsOfCoordinatesArray2D(int[,] array2D, int nRow, int nColumn)
{
	return array2D[nRow - 1, nColumn - 1];
}