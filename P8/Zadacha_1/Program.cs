﻿// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Console.Clear();
Console.WriteLine("Введите количество строк");
int countRow = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int countColumns = Convert.ToInt32(Console.ReadLine());
int[,] numbers = new int[countRow, countColumns];
RandomNumbers(numbers);
Console.WriteLine();
Console.WriteLine("Ваш массив");
InputArray(numbers);

for (int i = 0; i < numbers.GetLength(0); i++) {
    for (int j = 0; j < numbers.GetLength(1) - 1; j++) {
        for (int z = 0; z < numbers.GetLength(1) - 1; z++) {
            if (numbers[i, z] < numbers[i, z + 1]) {
                int temp = 0;
                temp = numbers[i, z];
                numbers[i, z] = numbers[i, z + 1];
                numbers[i, z + 1] = temp;
            }
        }
    }
}
Console.WriteLine();
Console.WriteLine("Массив с упорядоченными значениями");
InputArray(numbers);

void RandomNumbers(int[,] array) {
    for (int i = 0; i < array.GetLength(0); i++) {
        for (int j = 0; j < array.GetLength(1); j++) {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void InputArray(int[,] array) {
    for (int i = 0; i < array.GetLength(0); i++) {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++) {
            Console.Write(array[i, j] + " ");
        } 
        Console.Write("]");
        Console.WriteLine("");
    }
}