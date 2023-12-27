 
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
// using System;

// class Answer {
//     static void CheckIfEven(int number)
//     {
//       // Введите свое решение ниже
// if(number %2 == 0) 
//    Console.WriteLine($"число {number} четное");
//        else Console.WriteLine($"число {number} нечётное");
//     }
  

//   // Не удаляйте и не меняйте метод Main! 
//     static public void Main(string[] args) {
//         int number;

//         if (args.Length >= 1) {
//             number = int.Parse(args[0]);
//         } else {
//            // Здесь вы можете поменять значения для отправки кода на Выполнение
//             number = 6;
//         }

//         // Не удаляйте строки ниже
//         CheckIfEven(number);
//     }
// }
using System;

public class Answer {
    static void PrintEvenNumbers(int number)
    {
      // Введите свое решение ниже
 Console.Write($"number = {number}");
      if(number < 2) return;
Console.Write(" ->");
for(var i=2;i<=number;i+=2) Console.Write($"\t{i}");


    }


  // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args) {
        int number;

        if (args.Length >= 1) {
            number = int.Parse(args[0]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            number = 6;
        }

        // Не удаляйте строки ниже
        PrintEvenNumbers(number);
    }
}