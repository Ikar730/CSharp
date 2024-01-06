 
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

//  Решение задая 1 семинар (проверить,дополнить)!
// using System;

// public class Answer {
//     static void PrintEvenNumbers(int number)
//     {
//       // Введите свое решение ниже
//  Console.Write($"number = {number}");
//       if(number < 2) return;
// Console.Write(" ->");
// for(var i=2;i<=number;i+=2) Console.Write($"\t{i}");


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
//         PrintEvenNumbers(number);
//     }
// }

//  Решение задач 2 семинар
// проверяем кратность, введенного с клавиатуры числа
// int a=7;
// int b=23;

//  Console.Write("Введите число : ");  //вывод текста на экран
// var line = Console.ReadLine();  //читаем строку с клавиатуры
// int number = Convert.ToInt32(line); //преобразование строки в число

// if(number % a == 0 && number % b ==0)
//     Console.WriteLine(S"число {number} кратно {a} и {b}");
// else Console.WriteLine(S"число {number} некратно {a} и {b}");


// в какой четверти системы координат (x,y), находится точка(если это не x=0 и y=0)
// int a = x,y
// int b = ?;
// int c = ?;
// int d = ?;
// может через  int result
// Console.Write("\nВведите число x : " );
// var lineX = Console.ReadLine(); 
// int x = Convert.ToInt32(lineX);
// Console.Write("\nВведите число y : " );
// var lineY = Console.ReadLine(); 
// int y = Convert.ToInt32(lineY);

// if(x > 0 && y > 0)
// {
// Console.WriteLine($"точка ({x},{y}) находится в 1 четверти ");
// }
// if(x > 0 && y < 0)
// {
// Console.WriteLine($"точка ({x},{y}) находится в 4 четверти ");
// }
// if(x < 0 && y > 0)
// {
// Console.WriteLine($"точка ({x},{y}) находится в 2 четверти ");
// }
// if(x < 0 && y < 0)
// {
// Console.WriteLine($"точка ({x},{y}) находится в 3 четверти ");
// }


// Console.Write("Введите число : ");  
// var line = Console.ReadLine();  
// int number = Convert.ToInt32(line); 

// if (number < 10 || number > 99)
// {Console.WriteLine($"число {number} не подходит");
// return;}
// int x = number / 10;
// int y = number % 10;

// if(x >= y)
// Console.WriteLine($"цифра {x} числа {number} является наибольшей ");
// else
// Console.WriteLine($"цифра {y} числа {number} является наибольшей ");


// Console.Write("Введите число : ");  
// var line = Console.ReadLine();  
// int n = Convert.ToInt32(line);

// string stringNumber = n.ToString();
//  for(var i = 0;i < number.Length; i++) 
// {
//  Console.Write(stringNumber[i]);
//  if (i < number.Length -1)
//  Console.WriteLine (",");
// }
 

//  Задача 4: Вывод цифр числа через запятую
using System;
class Program
{
//Методы
//  пример 1
static int Sum(int a, int b) // метод принимает на вход А и Б
{
    return a + b; //  и возвращает их сумму
}

//  пример 2, метод, возвращающий строку
static string GetString()
{
    return "эта строка будет возвращена";
}

// пример 3, принимающий число и строку, ничего не возвращающий

static void PrintToConsole(int a, string message)
{
    Console.WriteLine (message + a);
}
static void Main()
 {
   Console.WriteLine(GetString()); 
PrintToConsole(0,"test");
// Console.Write("Введите натуральное число N: ");
// int N = Convert.ToInt32(Console.ReadLine());
// if (N < 10)
// {
// Console.WriteLine(N);
// }
// else
// {
// while (N > 0)
// {
// int currentDigit = N % 10;
// N /= 10;
// if (N > 0)
// {
// Console.Write(currentDigit + ",");
// }
// else
// {
// Console.WriteLine(currentDigit);
// }
// }
// }
// }
 }

 

//  Класс (ссылочный тип)
class CarClass
{
 int Weels{get;set;} //свойство, отличающееся от поля встроенными методами  get и set
 int Wheight{get;set;}
 int Doors{get;set;}
 int Lights{get;set;}
  int currentSpeed=0; //поле-обычная переменная внутри класса
 public int GetSpeed() //метод, возвращающий текущую скорость
 {
    return currentSpeed;
 }
}
}