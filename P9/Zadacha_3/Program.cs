// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
Console.Clear();
int m = InputNum("Введите положительное число M: ");
int n = InputNum("Введите положительное число N: ");
Console.WriteLine($"A({m}, {n}) = {Result(m, n)}");

int InputNum(string text) {
    Console.WriteLine(text);
    return int.Parse(Console.ReadLine());
}

int Result(int m, int n) {
    if (m == 0)
        return n + 1;
    if (m > 0 && n == 0)
        return Result(m - 1, 1);
    else
        return Result(m - 1, Result(m, n - 1));
}
