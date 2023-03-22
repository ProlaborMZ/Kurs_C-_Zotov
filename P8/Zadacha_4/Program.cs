// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Console.Clear();
int count_1 = InputInt("Введите размерность 1: ");
int count_2 = InputInt("Введите размерность 2: ");
int count_3 = InputInt("Введите размерность 3: ");
int count = 89;

int[,,] result = CreateMassive(count_1, count_2, count_3);

for (int i = 0; i < result.GetLength(0); i++) {
    for (int j = 0; j < result.GetLength(1); j++) {
        for (int k = 0; k < result.GetLength(2); k++) {
            Console.WriteLine($"[{i},{j},{k}] - {result[i, j, k]}");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,,] CreateMassive(int size_1, int size_2, int size_3) {
    int[,,] array = new int[size_1, size_2, size_3];
    int[] values = new int[count];
    int num = 10;
    for (int i = 0; i < values.Length; i++)
        values[i] = num
        ++;

    for (int i = 0; i < values.Length; i++) {
        int randomInd = new Random().Next(0, values.Length);
        int temp = values[i];
        values[i] = values[randomInd];
        values[randomInd] = temp;
    }

    int valueIndex = 0;

    for (int i = 0; i < array.GetLength(0); i++) {
        for (int j = 0; j < array.GetLength(1); j++) {
            for (int k = 0; k < array.GetLength(2); k++) {
                array[i, j, k] = values[valueIndex++];
            }
        }
    }
    return array;
}

int InputInt(string output) {
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}
