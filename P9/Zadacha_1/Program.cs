// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
int n = InputNumber("Введите положительное число");
Console.WriteLine(NaturalNumber(n, 1));

int NaturalNumber(int n, int m) {
    if (n == m)
        return n;
    else
        Console.Write($"{NaturalNumber(n, m + 1)}, ");
    return m;
}

int InputNumber(string text) {
    Console.Clear();
    while(true) {
        Console.WriteLine(text);
        int num = int.Parse(Console.ReadLine());
        if(num > 0)
            return num;
        Console.WriteLine("Ввели не положительное число");
    }
}
