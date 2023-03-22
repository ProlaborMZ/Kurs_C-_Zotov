// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Console.Clear();
int size = InputInt("Размерность матриц: ");
int[,] matrix_1 = new int[size, size];
int[,] matrix_2 = new int[size, size];
RandomNumbers(matrix_1);
RandomNumbers(matrix_2);
int[,] matrix_3 = new int[size, size];

for (int i = 0; i < size; i++) {
    for (int j = 0; j < size; j++) {
        for (int k = 0; k < size; k++) { 
            matrix_3[i, j] = matrix_3[i, j] + (matrix_1[i, k] * matrix_2[k, j]);
        }
    }
}
Console.WriteLine("Матрица - 1");
InputArray(matrix_1);
Console.WriteLine();
Console.WriteLine("Матрица - 2");
InputArray(matrix_2);
Console.WriteLine();
Console.WriteLine("Произведение матриц");
InputArray(matrix_3);

int InputInt(string output) {
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}
void RandomNumbers(int[,] array) {
    for (int i = 0; i < array.GetLength(0); i++) {
        for (int j = 0; j < array.GetLength(1); j++) {
            array[i, j] = new Random().Next(1, 5);
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
