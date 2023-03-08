// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.Clear();
int num = GetInputNum("Введите число: ", "Ошибка!!! Повторите ввод числа");
int result = SumNumber(num);
Console.WriteLine("Сумма цифр в числе: " + result);


int GetInputNum(string text, string textError) {
     while(true) {
        Console.Write(text);
        bool flag = int.TryParse(Console.ReadLine(), out int number);
        if(flag)
            return number;
        Console.WriteLine(textError);
    }
}

int SumNumber(int num) {
    int counter = Convert.ToString(num).Length;
    int advance = 0;
    int result = 0;

    for (int i = 0; i < counter; i++){
      advance = num - num % 10;
      result = result + (num - advance);
      num = num / 10;
    }
   return result;
}
