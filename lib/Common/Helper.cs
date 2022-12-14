namespace Common;
public static class Helper
{
	public static double UserInputDouble(string textConsole)
	{
		Console.WriteLine(textConsole);
		double number = double.Parse(Console.ReadLine());
		return number;
	}

	public static int UserInputint(string textConsole)
	{
		Console.WriteLine(textConsole);
		int number = int.Parse(Console.ReadLine());
		return number;
	}

	public static void PrintArray(int[] array)
	{
		for (int i = 0; i < array.Length; i++)
		{
			Console.Write($"{array[i]}; ");
		}
	}

		public static void PrintArray(double[] array)
	{
		for (int i = 0; i < array.Length; i++)
		{
			Console.Write($"{array[i]}; ");
		}
	}

	public static void Print2DArray(int[,] array)
	{
		for (int i = 0; i < array.GetLength(0); i++)
		{
			for (int j = 0; j < array.GetLength(1); j++)
			{
				Console.Write($"{array[i, j]}; ");
			}
			Console.WriteLine();
		}
	}

	public static void Print2DArray(double[,] array)
	{
		for (int i = 0; i < array.GetLength(0); i++)
		{
			for (int j = 0; j < array.GetLength(1); j++)
			{
				Console.Write($"{array[i, j]}; ");
			}
			Console.WriteLine();
		}
	}


	public static void FillRandom2DArray(int[,] array, int minRandom, int maxRandom)
	{
		Random random = new Random();
		for (int i = 0; i < array.GetLength(0); i++)
		{
			for (int j = 0; j < array.GetLength(1); j++)
			{
				array[i, j] = random.Next(minRandom, maxRandom);
			}
		}
	}

	public static void FillRandom2DArray(double[,] array, int minRandom, int maxRandom)
	{
		Random random = new Random();
		for (int i = 0; i < array.GetLength(0); i++)
		{
			for (int j = 0; j < array.GetLength(1); j++)
			{
				array[i, j] = Math.Round(random.NextDouble() + random.Next(minRandom, maxRandom), 1);
			}
		}
	}


}
