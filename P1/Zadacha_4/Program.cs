// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
int evenNumber = 2;
if(a > 1) {
    Console.WriteLine("Четные числа: ");
    while(evenNumber <= a) {
        Console.WriteLine(evenNumber + " ");
        evenNumber = evenNumber + 2;
    }
}
