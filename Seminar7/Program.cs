char[] charArray = new char[10];
Random rnd = new Random();
for (int i = 0; i < charArray.Length; i++)
{
    // "A" = 65, "Z" = 90
    charArray[i] = (char)rnd.Next('a','z' + 1);
}
Console.WriteLine($"Array: [{string.Join("; ", charArray)}]");

// Рекурсия - вызов метода внутри метода
// Факториал - про-е чисел от 1 до N включительно
// 3! = 3 * 2 * 1= 6: n! = 1 * 2 ... * n

int FindFactorial (int n)
{
    // Базовый случай - случай остановки рекурсии
    if (n == 1) return 1; 
    // Рекурсивный случай - вызов функции внутри функции 
    return n * FindFactorial(n - 1);
    //  FindFactorial(3)
    // 3 * 2 * FindFactorial(1) = 3 * 2 * 1
    // FindFactorial(2) = 2 * FindFactorial(1)
    // FindFactorial(1) = 1
}

Console.WriteLine(FindFactorial(4));


// Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// Указание
// Использовать рекурсию.
// Пример
// 123 => 6
// 63 => 9 ( 6 + 3 )

int SumOfDigits(int number)
{
    if (number == 0) return 0; // Базовый случай
    int result = number % 10 + SumOfDigits(number / 10);
    return result;
    //  number = 63
    //  res = 63 % 10 + SumOfDigits(63/10); 
    //  res = 3 + 6 + 0 = 9
    //  SumOfDigits(6) = 6 + SumOfDigits(0); 
    //  SumOfDigits(0) = 0
}
Console.WriteLine(SumOfDigits(1006));


// // Рекурсия - вызов метода внутри метода
// // Факториал - про-е чисел от 1 до N включительно
// // 3! = 3 * 2 * 1= 6: n! = 1 * 2 ... * n
// n -> 1, 1 -> n?
int FindFactorial(int start)
{
    int n = 4;
    // Базовый случай - случай остановки рекурсии
    if (start == n) return n; // 1 * 2  * 3 * 4
    // Рекурсивный случай - вызов функции внутри функции 
    return start * FindFactorial(start + 1); // j--
    // FindFactorial(4) 
    // 4 * 3  * 2 * 1  =24
    // FindFactorial(3)  = 3  * 2 * FindFactorial(1)
    // FindFactorial(1) = 1
}
Console.WriteLine(FindFactorial(1));


// Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от 1 до N.
// Указание
// Использовать рекурсию. Не использовать цикл.
// Пример
// N = 5 => 1 2 3 4 5

void ShowNumbers(int start, int end)
{
    if (start == end) // 1 2 3 4 5 , start = 1, end = 5
    {
        Console.Write(start);
        return;
    }
    Console.Write(start + "  "); // 1
    ShowNumbers(start + 1, end);  // 2
}
ShowNumbers(1, 10);