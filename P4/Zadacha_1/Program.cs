// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.Clear();
int numA = GetNumUser("Введите число А: ", "Ошибка!!! Введите верное число");
int numB = GetNumUser("Введите число B: ", "Ошибка!!! Введите верное число");
int degreeOf = GetDegreeOf(numA, numB);
Console.WriteLine($"Число {numA} в натуральной степени {numB} -> {degreeOf}");


int GetNumUser(string text, string textError) {
    while(true) {
        Console.Write(text);
        bool flag = int.TryParse(Console.ReadLine(), out int number);
        if(flag)
            return number;
        Console.WriteLine(textError);
    }
}

int GetDegreeOf(int number_A, int number_B) {
    int result = 1;
    if (number_B < 0)
         number_B = -1 * number_B;
    for (int i = 1; i <= number_B; i++) {
        result = result * number_A;
    }
    numB = number_B;
    return result;
}