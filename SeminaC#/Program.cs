// Напишите программу, которая на вход
// принимает число и выдает его квадрат
// (число умноженное
// на само себя).

// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());

// int result= num*num;
// Console.WriteLine(result);

// Задача №1. Напишите программу, которая на
// вход принимает два числа и проверяет,
// является ли первое число квадратом второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3 b = 9 -> нет

// Console.WriteLine("Введите число");
// int num1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число");
// int num2 = Convert.ToInt32(Console.ReadLine());

// if(num1 == num2*num2)
// {
// Console.WriteLine("Да");
// }
// else
// {
// Console.WriteLine("Нет");
// }

// Задача №3. Напишите программу, которая будет выдавать
// название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

// Console.WriteLine("Введите число");
// int num1 = Convert.ToInt32(Console.ReadLine());

// if(num1 == 1)
// {
// Console.WriteLine("Понедельник");
// }
// else if(num1 == 2)
// {
// Console.WriteLine("Вторник");
// }
// else if(num1 == 3)
// {
// Console.WriteLine("Среда");
// }
// else if(num1 == 4)
// {
// Console.WriteLine("Четверг");
// }
// else if(num1 == 5)
// {
// Console.WriteLine("Пятница");
// }
// else if(num1 == 6)
// {
// Console.WriteLine("Суббота");
// }
// else if(num1 == 7)
// {
// Console.WriteLine("Воскресенье");
// }
// else
// {
// Console.WriteLine("Такого дня нет");
// }

// Задача №5. Напишите программу, которая на
// вход принимает одно число (N), а на выходе
// показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> " -2, -1, 0, 1, 2"


// Console.WriteLine("Введите число");
// int num1 = Convert.ToInt32(Console.ReadLine());

// int negNum = num1 *-1;

// while(negNum<=num1)
// {
// Console.Write(negNum+ " ");
// negNum = negNum+1;
// }

// Задача №7. Напишите программу, которая
// принимает на вход трёхзначное число и на
// выходе показывает последнюю цифру этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8

// Console.WriteLine("Введите число");
// int num1 = Convert.ToInt32(Console.ReadLine());

// int result = num1 %10;

// Console.WriteLine(result);



// Дз по 1 семинару  Задача №1
// Сравнение чисел и вывод результата
    //   if (firstNumber > secondNumber)
    //   {
    //     Console.WriteLine("первое число больше");
    //   }
    //   else if (firstNumber < secondNumber)
    //   {
    //     Console.WriteLine("второе число больше");
    //   }
    //   else
    //     {
    //         Console.WriteLine("числа равны");
    //     } 


// Дз по 1 семинару  Задача №2 
// Console.WriteLine("Введите первое число");
// int a = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите второе число");
// int b = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите третье число");
// int c = Convert.ToInt32(Console.ReadLine());

// int result = a;

// if (b > result)
// {
//     result = b;
// }
// if (c > result)
// {
//     result = c;
// }
// Console.WriteLine(result);


// Дз по 1 семинару  Задача №3
//  Console.WriteLine("Введите число");
//  int number = Convert.ToInt32(Console.ReadLine());

// if (number % 2 == 0)
//       {
//             Console.WriteLine("четное");
//         }
//         else
//         {
//             Console.WriteLine("нечетное");
//         }


// Дз по 1 семинару  Задача №4

// Console.WriteLine("Введите число:");
//  int number = Convert.ToInt32(Console.ReadLine());

//  Console.WriteLine("Чётные числа от 1 до " + number + ":");

// Перебираем числа от 1 до number и выводим чётные числа
//  for (int i = 1; i <= number; i++)
//   {
//      if (i % 2 == 0)
//      {
//          Console.Write(i + " ");
//      }
//   }

//         Console.WriteLine();