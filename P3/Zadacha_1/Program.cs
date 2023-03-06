// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.Clear();
Console.WriteLine("Введите пятизначное число");
int num = Convert.ToInt32(Console.ReadLine());
string number = Convert.ToString(num);
int rev = 0;
int n = 0;
int count = num;
if (number.Length == 5) {
    while (count > 0) {
        n = count % 10;
        rev = rev*10+n;
        count = count/10;
    }
    if (num == rev) { 
       Console.WriteLine("Да!! Это палиндром"); 
    } else {Console.WriteLine("Нет!! Это не палиндром");} 
}
else {Console.WriteLine("Ошибка!!! Введите пятизначное число");}

