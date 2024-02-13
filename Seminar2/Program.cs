// Напишите программу, которая принимает на вход
// трёхзначное число и удаляет вторую цифру этого
// числа.
// Примеры
// a = 256 => 26
// a = 891 => 81

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// // "&&" - "И": апельсины И яблоки (и то, и другое)
// // "||" - "ИЛИ": апельсины ИЛИ яблоки (или то, или другое, или все вместе)
// if (number >= 100 && number <= 999)
// {
//     int firstDigit = number / 100; // 275 / 100 = 2
//     int thirdDigit = number % 10; // 275 % 10 = 5
//     int result = firstDigit * 10 + thirdDigit; // 2 * 10 + 5
//     // $"Текст {result} текст {firstDigit * 10 + thirdDigit}"
//     Console.WriteLine($"Число {number} => {result}");
// }
// else
// {
//     Console.WriteLine("Число не трехзначное!");
// }

// Напишите программу, которая принимает на вход трёхзначное
// число и возводит вторую цифру этого числа в степень, равную
// третьей цифре.
// Примеры
// 487 => 8^7 = 2 097 152
// 254 => 5^4 = 625
// 617 => 1

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number >= 100 && number <= 999)
// {
//     int secondDigit = number / 10 % 10; // 275 / 10 % 10 = 27 % 10 = 7
//     int thirdDigit = number % 10; // 275 % 10 = 5
//     // Math.Pow(5, 2) => 5 в 2 степени => 25
//     int result = (int)Math.Pow(secondDigit, thirdDigit);
//     Console.WriteLine($"Число {number} : {secondDigit}^{thirdDigit} = {result}");
// }
// else
// {
//     Console.WriteLine("Число не трехзначное!");
// }

// Получить 3 цифру числа с левой стороны (с начала)
// 12345679 -> 3
// 128 -> 8
// 23 - 3 цифры нет
// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int copyNumber = number;
// if (number < 100)
// {
//     Console.WriteLine("3 цифры нет, ЛИБО число отрц.");
// }
// else
// {
//     while (number > 999) // В числе > 3 цифр
//     {
//         number /= 10; // number = number / 10
//         // a = a * 50: a *= 50
//         // a = a - 750: a -= 750
//     }
//     Console.WriteLine($"Третья цифра от: {copyNumber} = {number % 10} ");
// }

// Напишите программу, которая выводит третью с конца
// цифру заданного числа или сообщает, что третьей цифры
// нет.
// 456 => 4
// 7812 => 8
// 91 => Третьей цифры нет

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number < 100)
// {
//     Console.WriteLine("3 цифры нет, ЛИБО число отрц.");
// }
// else
// {
//     int result = number / 100 % 10;
//     Console.WriteLine($"3 цифра от {number} = {result}");
// }
// // 123 / 100 % 10 = 1  %  10 => 1

//int a = 14;

//if (a % 7 == 0)
//{
//    Console.WriteLine($"Число {a} делится на 7 без остатка");
//}


//int FindFactorial(int n)
//{
//    // Базовый случай - случай остановки рекурсии
//    if (n == 1) return 1;
//    // Рекурсивный случай - вызов функции внутри функции 
//    return n * FindFactorial(n - 1);
//    //  FindFactorial(3)
//    // 3 * 2 * FindFactorial(1) = 3 * 2 * 1
//    // FindFactorial(2) = 2 * FindFactorial(1)
//    // FindFactorial(1) = 1
//}

//Console.WriteLine(FindFactorial(4));


//// // Напишите программу, которая будет принимать на вход число и
//// // возвращать сумму его цифр.
//// // Указание
//// // Использовать рекурсию.
//// // Пример
//// // 123 => 6
//// // 63 => 9 ( 6 + 3 )
//int SumOfDigits(int number)
//{
//    if (number == 0) return 0; // Базовый случай
//    int result = number % 10 + SumOfDigits(number / 10);
//    return result;
//    //  number = 63
//    //  res = 63 % 10 + SumOfDigits(63/10); 
//    //  res = 3 + 6 + 0 = 9
//    //  SumOfDigits(6) = 6 + SumOfDigits(0); 
//    //  SumOfDigits(0) = 0
//}
//Console.WriteLine(SumOfDigits(1006));


//// // Рекурсия - вызов метода внутри метода
//// // Факториал - про-е чисел от 1 до N включительно
//// // 3! = 3 * 2 * 1= 6: n! = 1 * 2 ... * n
//// n -> 1, 1 -> n?
//int FindFactorial(int start)
//{
//    int n = 4;
//    // Базовый случай - случай остановки рекурсии
//    if (start == n) return n; // 1 * 2  * 3 * 4
//                              // Рекурсивный случай - вызов функции внутри функции 
//    return start * FindFactorial(start + 1); // j--
//                                             // FindFactorial(4) 
//                                             // 4 * 3  * 2 * 1  =24
//                                             // FindFactorial(3)  = 3  * 2 * FindFactorial(1)
//                                             // FindFactorial(1) = 1
//}
//Console.WriteLine(FindFactorial(1));



//Урок 7. Рекурсия
//Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.

//Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

//Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.


//    int m =4;
//int n = 12;
//int m = start;
//int m = end;

//void ShowNumbers(int m,int n)
//{
//    if (m == n)
//    { 
//    Console.Write(m);
//        return;
//}
//    Console.Write(m+" ");
//    ShowNumbers(m + 1, n);
//}
//ShowNumbers(4, 12);

void ShowNumbers(int start, int end)
{
    if(start == end)
    {
        Console.Write(start);
        return;
    }
    Console.Write(start+ " ");
    ShowNumbers(start+1, end);
}
ShowNumbers(1, 10);