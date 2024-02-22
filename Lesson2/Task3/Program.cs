// int n = 10;
int[] array = { 1, 5, 4, 2, 9, 6, 1, 3, 9, 5 };
int i = 0;

// while (i < n) можно и так но тогда надо убрать массив 1 строка
while (i < array.Length)
{
    if(array[i] % 2 == 0)
    {
        Console.Write($"{array[i]} ");
    }
    i = i + 1; 
}