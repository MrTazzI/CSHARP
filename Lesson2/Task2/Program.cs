﻿int n = 12;
int[] arr = new int[n];
int i = 0;

// while( i < arr.Length)
while (i < n)
{
    arr[i] = i + 1;
    // Console.Write(arr[i]);
    // Console.Write(' ');
    Console.Write($"{arr[i]} ");
    i = i + 1;
}