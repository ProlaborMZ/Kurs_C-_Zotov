// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Console.Clear();
Console.WriteLine("Введите размер квадратного массива");
int mass = Convert.ToInt32(Console.ReadLine());
int[,] numbers = new int[mass, mass];
RandomNumbers(numbers);
InputArray(numbers);
int minSum = Int32.MaxValue;
int indexLine = 0;

for (int i = 0; i < numbers.GetLength(0); i++) {
    int sum = 0;
    for (int j = 0; j < numbers.GetLength(1); j++) {
        sum = sum + numbers[i, j];        
    }
    if (sum < minSum) {
        minSum = sum;
        indexLine++;
    }
}

Console.WriteLine("Строка с наименьшей суммой элементов под номером: " + (indexLine) + ", с суммой элементов равной: " + (minSum));

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
