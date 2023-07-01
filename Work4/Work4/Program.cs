namespace Work4
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Введіть розмірність масиву (N):");
			int N = int.Parse(Console.ReadLine());

			int[] array = new int[N];
			Random random = new Random();
			// Заповнення масиву випадковими числами від 1 до 26
			for (int i = 0; i < N; i++)
			{
				array[i] = random.Next(1, 27);
			}

			int[] evenArray = new int[N];
			int[] oddArray = new int[N];
			int evenCount = 0;
			int oddCount = 0;

			// Розділення чисел на парні та непарні масиви
			for (int i = 0; i < N; i++)
			{
				if (array[i] % 2 == 0)
				{
					evenArray[evenCount] = array[i];
					evenCount++;
				}
				else
				{
					oddArray[oddCount] = array[i];
					oddCount++;
				}
			}

			// Виведення результатів
			Console.WriteLine("Масив з випадковими числами:");
			PrintArray(array);

			Console.WriteLine("Масив з парними числами:");
			PrintArray(evenArray, evenCount);

			Console.WriteLine("Масив з непарними числами:");
			PrintArray(oddArray, oddCount);
		}
		static void PrintArray(int[] array, int count = -1)
		{
			if (count == -1)
				count = array.Length;

			for (int i = 0; i < count; i++)
			{
				Console.Write(array[i] + " ");
			}
			
		}

	}
}