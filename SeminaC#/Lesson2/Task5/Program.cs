// Напишите программу, котора принимает на 
// вход два числа и проверяет, является ли 
// одно число квадратом другого.

// 5, 25 ->  да 
// -4, 16 ->  да 
// 26, 55 -> да 
// 9, 9 -> нет

Console.WriteLine("Ввидите число");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ввидите число");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1 == num2*num2 || num2 == num1*num1)
{
    System.Console.WriteLine("Да");
}
else 
{
    System.Console.WriteLine("Нет");
}
