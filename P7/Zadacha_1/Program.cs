// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
Console.Clear();
Console.WriteLine("Введите количество строк");
int countRows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int countColumns = Convert.ToInt32(Console.ReadLine());
double[,] numbers = new double[countRows, countColumns];
RandomNumbers(numbers);
Console.WriteLine("Ваш массив");
InputArray(numbers);

void RandomNumbers(double[,] array) { 
    for (int i = 0; i < array.GetLength(0); i++) { 
        for (int j = 0; j < array.GetLength(1); j++) {
            array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
    }
}

void InputArray(double[,] array) {
    for (int i = 0; i < array.GetLength(0); i++) {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++) {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}
