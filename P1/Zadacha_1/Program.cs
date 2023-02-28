// Задача 2: Напишите программу, которая на вход принимает два числа и 
// выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Второе число");
int b = Convert.ToInt32(Console.ReadLine());
int max;
int min;
if (a > b) { 
    max = a;
    min = b;
} else {
    max = b;
    min = a;
}
Console.WriteLine("Максимальное значение: " + max);
Console.WriteLine("Минимально значение: " + min);


