namespace Lab1_2;

public class Lab1_2
{
    public static void Main(string[] args)
    {
        Console.Write("Введите количество строк матрицы: ");
        int rows = int.Parse(Console.ReadLine());

        Console.Write("Введите количество столбцов матрицы: ");
        int columns = int.Parse(Console.ReadLine());

        int[,] matrix = new int[rows, columns];

        Random random = new Random();
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                matrix[i, j] = random.Next(-10, 10); // Генерируем случайные числа от -10 до 10
            }
        }
        
        PrintMatrix(matrix);

        int positiveCount = 0;
        int negativeCount = 0;
        int zeroCount = 0;

        string zeroCoordinates = "";

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                int currentElement = matrix[i, j];
                if (currentElement > 0)
                {
                    positiveCount++;
                }
                else if (currentElement < 0)
                {
                    negativeCount++;
                }
                else
                {
                    zeroCount++;
                    zeroCoordinates += $"({i}, {j}) ";
                }
            }
        }

        Console.WriteLine($"Количество положительных элементов: {positiveCount}");
        Console.WriteLine($"Количество отрицательных элементов: {negativeCount}");
        Console.WriteLine($"Количество нулевых элементов: {zeroCount}");
        if (zeroCount > 0)
        {
            Console.WriteLine($"Координаты нулевых элементов: {zeroCoordinates}");
        }
    }
    
    static void PrintMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int columns = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine(); 
        }
    }
}