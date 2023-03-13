// Задайте массив заполненный случайными положительными 
// трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
int[] numbers = InputUser("Введите размер массива и нажмите Enter");
RandomNumbers(numbers);
ConclusionArray(numbers);
int count = SearchNumber(numbers);
Console.WriteLine($"В массиве {count} чётные числа");

int[] InputUser(string text) {
    Console.Clear();
    Console.WriteLine(text);
    int size = Convert.ToInt32(Console.ReadLine());
    int[] numbers = new int[size];
    return numbers;
}

void RandomNumbers(int[] numbers) {
    for(int i = 0; i < numbers.Length; i++) {
        numbers[i] = new Random().Next(100,1000);
    }
}

void ConclusionArray(int[] numbers) {
    Console.Write("Массив: ");
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++) {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}

int SearchNumber(int[] numbers) {
    int count = 0; 
    for (int z = 0; z < numbers.Length; z++)
    if (numbers[z] % 2 == 0)
    count++;
    return count;
}