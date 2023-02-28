// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Второе число");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Третье число");
int c = Convert.ToInt32(Console.ReadLine());
int max = a;
if ( max < b) {
    max = b;
}
if ( max < c ) {
    max = c;
}
Console.WriteLine("Максимальное число: " + max);
