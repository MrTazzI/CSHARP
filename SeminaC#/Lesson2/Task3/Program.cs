// Напишите программу, которая будет принимат
// на входе два числа и выводить, является ли 
// второе число кратным первом. Если число
// 2 не кратно числу 1, то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно 

Console.WriteLine("Ввидите число");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ввидите число");
int num2 = int.Parse(Console.ReadLine());

if (num1%num2 == 0 )
{
    Console.WriteLine("Кратно");
}
else
{
    // Console.WriteLine("Не кратно, ост." + num1%num2);  // Конкатенация
    Console.WriteLine($"Не кратно {num1%num2}");  // Интерполяция
}