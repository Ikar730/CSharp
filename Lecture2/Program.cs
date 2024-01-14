int[] arr = new int[5]; // создаем массив на 5 целых чисел
arr[0] = 5;
arr[1] = 7;
arr[2] = 3;
arr[3] = 8;
arr[4] = 1;

Console.Writeline(arr[0]);
Console.Writeline(arr[1]);
Console.Writeline(arr[2]);
Console.Writeline(arr[3]);
Console.Writeline(arr[4]);
//сознательная ошибка
//Console.Writeline(arr[5]); error //выход за границы массив


int[] arr2 = new int[5] { 1, 2, 3, 4, 5 };
int[] arr3 = { 1, 2, 3, 4, 5 };


//Задача 1. Создать массив и заполнить его целыми числами от 1 до N(N-натуральное произвольное число).
//Вывести элементы массива на экран.
int N = 10;

int[] arr = new int[N];
int i = 0;

while (i < n)
{
    arr[i] = i + 1;
    Console.Writeline($"{arr[i]} ");
    i = i + 1;
}

//Задача 2. Создать целочисленный массив на 10 элементов и заполнить его произвольными числами.
//Вывести на экран четные элементы массива.

int n = 10;
int[] arrey = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
int i = 0;

while (i < n)
{
    if (arrey[i] % 2 == 0)
    {
        Console.Write($"{arrey[i]} ");
    }
    i = i + 1;
}