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


