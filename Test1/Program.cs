 
// using System;

// public class Answer {
//     static void CompareNumbers(int firstNumber, int secondNumber)
//     {
 
 

 
//  if (firstNumber > secondNumber)
//  {
//     Console.WriteLine($"Первое число `{firstNumber}` больше чем второе число `{secondNumber}`");
//  }
// if(secondNumber > firstNumber)
// {
//     Console.WriteLine($"Первое число `{firstNumber}` меньше чем второе число `{secondNumber}`");
// }
// if (secondNumber==firstNumber)
// {
//     Console.WriteLine($"Введенные числа равны `{firstNumber}` ");
// }
 
//     }
using System;

public class Answer {
    
  static int FindMax(int a, int b, int c)
    {
int a = max;
if (b > a)
    max = b;
if (c > max)
    max = c;
int result = FindMax(a, b, c);
        System.Console.WriteLine($"{result}");
//  System.Console.WriteLine($"Число `{max}` является максимальным");
    }
}


//  Не удаляйте и не меняйте метод Main! 
     static public void Main(string[] args) {
         int firstNumber, secondNumber;

         if (args.Length >= 2) {
             firstNumber = int.Parse(args[0]);
             secondNumber = int.Parse(args[1]);
         } else {
            // Здесь вы можете поменять значения для отправки кода на Выполнение
             firstNumber = 5;
             secondNumber = 5;
        }

        // Не удаляйте строки ниже
        CompareNumbers(firstNumber, secondNumber);
     }
 }             