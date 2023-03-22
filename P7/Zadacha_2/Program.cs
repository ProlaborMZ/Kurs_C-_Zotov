// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
Console.Clear();
Console.WriteLine("Введите номер строки");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца");
int column = Convert.ToInt32(Console.ReadLine());
int [,] numbers = new int [10,10];
RandomNumbers(numbers);

if (row > numbers.GetLength(0) || column > numbers.GetLength(1)) {
    Console.WriteLine("такого элемента нет");
}
else {
    Console.WriteLine($"значение элемента {row} строки и {column} столбца равно {numbers[row-1,column-1]}");
}

InputArray(numbers);

void RandomNumbers(int[,] array) {
    for (int i = 0; i < array.GetLength(0); i++) {
        for (int j = 0; j < array.GetLength(1); j++) {
            array [i,j] = new Random().Next(-100, 100)/10;
        }   
    }
}

void InputArray(int[,] array) {
    for (int i = 0; i < array.GetLength(0); i++) {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++) {
            Console.Write(array[i,j] + " ");
        }   
        Console.Write("]");
        Console.WriteLine(""); 
    }
}

