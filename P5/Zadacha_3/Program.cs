// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
double[] numbers = InputUser("Введите размер массива и нажмите Enter");
RandomNumbers(numbers);
ConclusionArray(numbers);
double min = Int32.MaxValue;
double max = Int32.MinValue;
for (int z = 0; z < numbers.Length; z++) {
    if (numbers[z] > max) {
        max = numbers[z];
    }
    if (numbers[z] < min) {
        min = numbers[z];
    }
}
Console.WriteLine($"Max = {max}");
Console.WriteLine($"Min = {min}");
Console.WriteLine($"Разница = {max - min}");

double[] InputUser(string text) {
    Console.Clear();
    Console.WriteLine(text);
    int size = Convert.ToInt32(Console.ReadLine());
    double[] numbers = new double[size];
    return numbers;
}

void RandomNumbers(double[] numbers) {
    for(int i = 0; i < numbers.Length; i++) {
        numbers[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
    }
}

void ConclusionArray(double[] numbers) {
    Console.Write("Массив: ");
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++) {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}
