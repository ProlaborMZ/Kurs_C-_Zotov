// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и 
// на выходе показывает вторую цифру этого числа.
Console.Clear();
Console.Write("Введи трёхзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
string stringNumber = Convert.ToString(num);
int count = stringNumber.Count();
if (count == 3) {
    Console.WriteLine("Вторая цифра числа " + num + " -> " + stringNumber[1]);
} else {
    Console.WriteLine("Ошибка!!!! Число " + num + " состоит из " + count + " цифр");
}
