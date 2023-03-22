// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Console.Clear();
Console.WriteLine("введите количество строк");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов");
int m = Convert.ToInt32(Console.ReadLine());

int[,] numbers = new int[n, m];
RandomNumbers(numbers);

for (int j = 0; j < numbers.GetLength(1); j++) {
    double avarage = 0;
    for (int i = 0; i < numbers.GetLength(0); i++) {
        avarage = (avarage + numbers[i, j]);
    }
    avarage = avarage / n;
    Console.Write(avarage + "; ");
}
Console.WriteLine();
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
