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

//Задача 3. Дано N гирь с разным весом  в случайном порядке. Определить вес самой тяжелой гири.

int size = 5;
int[] arrey = { 1, 2, 3, 4, 5 };
int i = 0;

while (i < size)
{
    arrey[i] = 0;
    Console.Writeline(arrey[i]);
    i = i + 1;
}
Console.Writeline(max);


// Цикл FOR
for (int i = 0; i < 10; i = i + 1;)  //1. инициализация 2. условие 3. модификация
{
    //...                                                   тело цикла
}

//Рекомендации к применению-проход по элементам массива в задачах, где число итераций фиксировано

int[] arr = { 1, 2, 3, 4, 5 };
for (int i = 1; i < arr.Length; i = i + 1)
{
    Console.Write($"{arrey[i]} ");
}


int N = 100;
int sum = 0;
for (int i = 1; i < N; i = i + 1)
{
    sum = sum + 1;
}
Console.Writeline(sum);


//Цикл WHILE. Рекомендации к применению-задачи, где верхняя граница итераций неизвестна.Пример-посимвольное чтение файла.


//Цикл FOREACH.

int[] arrey = { 1, 2, 3, 4, 5 };

foreach (int e in arrey)  //1.переменная цикла 2.массив. Т.е. для всех элементов в массиве.
{                             //тело ц.
    Console.Writeline(e);  //тело цикла
}                           //тело ц.

//Пример с FOREACH

max = arrey[0];
for (int i = 0; i < N; i++)
{
    if (arrey[i] > max)
    {
        max = arrey[i];
    }
}
Console.Writeline(max);

max = arrey[0];
foreach (int e in arrey)
{
    if (e > max)
    {
        max = e;
    }
}
Console.Writeline(max);