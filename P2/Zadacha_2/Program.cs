// Задача 13: Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.

Console.Clear();
Console.Write("Введи число: ");
int num = Convert.ToInt32(Console.ReadLine());
string stringNumber = Convert.ToString(num);
int count = stringNumber.Count();
if (count > 2) {
    Console.WriteLine("Третья цифра числа " + num + " -> " + stringNumber[2]);
} else {
    Console.WriteLine("Ошибка!!!! В числе " + num + " нет третьей цифры");
}
