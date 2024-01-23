int[,] matrix = new int[3, 5];
Random rnd = new Random();
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)//запрашиваем количество чтолбцов в массиве?
    //строка i,столбец j
    {
        matrix[i, j] = rnd.Next(1, 11);
    }
}
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write($"{matrix[i, j]} ");
    }
    Console.WriteLine();
}

int[,] CreateMatrix(int rowCount,int columnCount)
{
 int[,] matrix = new int[rowCount,columnCount];
Random rnd = new Random();
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = rnd.Next(1, 11);
    }
}  
return matrix; 
}
void ShowMatrix(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write($"{matrix[i, j]} ");
    }
    Console.WriteLine();
}  
}
int[,] matrix=CreateMatrix(4,5);
ShowMatrix(matrix);
//непраывильно проверить!!!

// задача 2

int[,] CreateMatrix(int rowCount,int columnCount)//функция создания двумерного массива
{
 int[,] matrix = new int[rowCount,columnCount];
Random rnd = new Random();
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = rnd.Next(1, 1000);
    }
}  
return matrix; 
}
int [,]matrix =CreateMatrix(3,4);
foreach(int e in matrix)
{
    if(IsInteresting(e)==true)
    {
        ConsoleW.Write($"{e} ");
    }
}
bool IsInteresting(int value)
{
    sumOfDigits=GetSumOfDigits(value);
    if(sumofDigits %2==0)
    {
        return true;
    }
        return false;
    }
int GetSumOfDigits(int value)
{
    int sum=0;
    while(value>0)
    {
        sum+=value%10;
        value/=10;
    }
    return sum;
}