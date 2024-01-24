// Задайте двумерный массив. Найдите элементы, у которых оба
// индекса чётные, и замените эти элементы на их квадраты.

int[,] FillMatrix(int rows, int cols)
{
    int[,] matrix = new int[rows, cols]; // Матрица размером rows стр и col столбцов
    Random rnd = new Random();
    for (int i = 0; i < rows; i++)  // matrix.GetLength(0) = rows, цикл по строчкам
    {
        // j, m, k
        for (int j = 0; j < cols; j++)   // matrix.GetLength(1) = cols, цикл по столбцам 
        {
            matrix[i, j] = rnd.Next(11);// [0; 10]
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]}\t"); // \t = 4 пробела
        }
        Console.WriteLine();
    }
}

// void SquareElements(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if (i % 2 == 0 && j % 2 == 0)
//             {
//                 matrix[i,j] *= matrix[i,j];
//                 // matrix[i,j] = matrix[i,j] * matrix[i,j] 
//             }
//         }
//     }
// }

// int GetMainDiagonalSum(int[,] matr)
// {
//     int sum = 0;
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             if (i == j) // Номер стр = номер стлб
//             {
//                 sum += matr[i, j]; // sum = sum + matr[i,j];
//             } 
//         }
//     }
//     return sum;
// }

double[] GetArrayWithMeans(int[,] matrix)
{
    double[] means = new double[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        double currentSum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            currentSum += matrix[i, j];
        }
        double currentMean = Math.Round(currentSum / matrix.GetLength(1), 2);
        means[i] = currentMean;
    }
    return means;
}


Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] res = FillMatrix(rows, columns);
PrintMatrix(res); // Матрица ДО
double[] resMeans = GetArrayWithMeans(res);
Console.WriteLine($"[ {string.Join("; ", resMeans)} ]");

// Console.WriteLine($"Результат: {GetMainDiagonalSum(res)}");

// SquareElements(res); // Эту же матрицу и меняем
// Console.WriteLine("Результат: ");
// PrintMatrix(res); 
