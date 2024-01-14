//Задача 1
// Вычислить значение формулы a*b/(c+d), где a,b,c,d целые числа.Решение оформить в виде функци

double CalculateFormula(int a, int b, int c, int d)
{
    double numenator = a * b;
    int denomenator = c + d;
    double result = numenator / denomenator;
    return result;
}
double result = CalculateFormula(1, 2, 3, 4); //если чисел нет, то ставим пустые скобки ().
Console.WriteLine(result);

// Задача 2.
//Вывод на эктан квадратов чисел от 1 до N

int n = 5;
int i = 1;
while (i <= n)
{
    Console.WriteLine($"{i * i} ")
    i = i + 1;
}
// Аналогичные вычисления происходят и с 10, и с 15, меняется только число.
//Как мы можем улучшить ситуацию с помощью метода(функции):


void PrintSquares(int limit)
{
    int i = 1;
    while (i <= limit)
    {
        Console.Write($"{i * i} ");
        i++;
    }
}
PrintSquares(5);
PrintSquares(10);
PrintSquares(15);

// Задача 3.
//
void ZeroEvenElements(int[] arr)
{
    for(i=0;i<arr.Length;i++)
    {
        if(arr[i]%2==0)
        {
            arr[i]=0;
        }
    }
}

void PrintArrey(int[] arr)
{
    foreach(int e in arr)
    {
        Console.Write($"{e} ");
    }
}

int arrey={1,2,3,4,5};
ZeroEvenElements(arrey);
PrintArrey(arrey);
