﻿ 
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
      // Введите свое решение ниже

int max=a;
if (b > max)
{
    max = b;
 }   
if (c > max)
{
    max = c;
 }   
 return max;
  }

  // Не удаляйте и не меняйте метод Main! 
  static public void Main(string[] args) {
        int a, b, c;

        if (args.Length >= 3) {
           a = int.Parse(args[0]);
           b = int.Parse(args[1]);
           c = int.Parse(args[2]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
           a = 5;
           b = 6;
           c = 7;
        }

        // Не удаляйте строки ниже
        int result = FindMax(a, b, c);
        System.Console.WriteLine($"{result}");
    }
}