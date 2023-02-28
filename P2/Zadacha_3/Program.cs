// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Clear();
Console.WriteLine("Введи цифру, обозначающую день недели");
int num = Convert.ToInt32(Console.ReadLine());
if (num == 6 || num == 7) {
  Console.WriteLine("Да, это выходной");
  }
  else if (num == 0 || num > 7) {
    Console.WriteLine("Ошибка!!!! Это не день недели");
  }
  else {
    Console.WriteLine("Нет, это не выходной");
  }