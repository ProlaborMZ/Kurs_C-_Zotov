// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
int[] numbers = InputUser("Введите размер массива и нажмите Enter");
RandomNumbers(numbers);
ConclusionArray(numbers);
int sum = SumNumber(numbers);
Console.WriteLine($"Сумма элементов на нечётных позициях = {sum}");

int[] InputUser(string text) {
    Console.Clear();
    Console.WriteLine(text);
    int size = Convert.ToInt32(Console.ReadLine());
    int[] numbers = new int[size];
    return numbers;
}

void RandomNumbers(int[] numbers) {
    for(int i = 0; i < numbers.Length; i++) {
        numbers[i] = new Random().Next(1,10);
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

int SumNumber(int[] numbers) {
    int sum = 0;
    for (int z = 0; z < numbers.Length; z+=2)
    sum = sum + numbers[z];
    return sum;
}
