// Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 3D пространстве.
Console.Clear();
string point1 = "A";
string point2 = "B";

int x1 = InputNum("x", point1);
int y1 = InputNum("y", point1);
int z1 = InputNum("z", point1);
int x2 = InputNum("x", point2);
int y2 = InputNum("y", point2);
int z2 = InputNum("z", point2);

static int InputNum(string coor, string point) {
    try {
        Console.WriteLine("Введите координату " + coor + " точки " + point + " и нажми Enter ");
        return (int.Parse(Console.ReadLine() ?? ""));
    } catch (Exception exc) {
        Console.Write($"Ошибка ввода данных!!! {exc.Message}");
        return 0;
    }
}

static double Rezult(int x1, int y1, int z1, int x2, int y2, int z2) {
    return Math.Sqrt(Math.Pow((x2-x1), 2) + Math.Pow((y2-y1), 2) + Math.Pow((z2-z1), 2));
}

Console.WriteLine($"Расстояние между точкой {point1}({x1};{y1};{z1}) и {point2}({x2};{y2};{z2}) = {Rezult(x1, y1, z1, x2, y2, z2)}");