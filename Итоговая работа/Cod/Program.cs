//Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
//длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
//либо задать на старте выполнения алгоритма. 
Console.Clear();
string[] array1 = new string[5] {"computer science", "23", ":-)", "world", "1"};
string[] array2 = new string[5];
PrintArray(array1, "Ваш заданный массив:");
Result(array1, array2);
PrintArray(array2, "Ваш новый массив:");

void Result(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}

void PrintArray(string[] array, string text)
{
    Console.WriteLine(text);
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.Write("]");
    Console.WriteLine();
}


