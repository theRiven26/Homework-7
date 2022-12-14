/* Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

using static Common.Helper;
int nRow = UserInputint("Enter row");
int nColumn = UserInputint("Enter column");
int[,] array2D = new int[nRow, nColumn];


FillRandom2DArray(array2D, -10, 10);
Print2DArray(array2D);
Console.WriteLine();
double[] aritMean = GetMeanArithmeticColumnArray2D(array2D);
PrintArray(aritMean);

double[] GetMeanArithmeticColumnArray2D(int[,] array2D)
{

	int lengthRow = array2D.GetLength(0);
	int lengthColumn = array2D.GetLength(1);
	double[] aritMean = new double[lengthColumn];
	for (int c = 0; c <= lengthColumn - 1; c++)
	{
		for (int r = 0; r <= lengthRow - 1; r++)
		{
			aritMean[c] = aritMean[c] + array2D[r, c];
		}
		Console.WriteLine(aritMean[c]);
		aritMean[c] = Math.Round(aritMean[c]/lengthRow,1);
	}

	return aritMean;
}
