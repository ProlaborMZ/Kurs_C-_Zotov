// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в 
// промежутке от M до N.
Console.Clear();
int m = InputNum("Введите значение M:");
int n = InputNum("Введите значение N:");
if (m < n) {
    Console.WriteLine($"Сумма элементов от {m} до {n} = {NaturalSum(m, n)}");
} else {
    Console.WriteLine("Ошибка!!! Число M не должно быть меньше N");
}

int InputNum(string text) {
    Console.WriteLine(text);
    return int.Parse(Console.ReadLine());
}

int NaturalSum(int m, int n) {
    if (m == n)
        return n;
    return n + NaturalSum(m, n - 1);
}

