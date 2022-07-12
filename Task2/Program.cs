/* Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
 b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

Console.Clear();
double[,] value = new double[2, 2];
double[] crossPoint = new double[2];

void InputValue()
{
    for (int i = 0; i < value.GetLength(0); i++)
    {
        Console.Write($"Введите коэффициенты {i+1}-го уравнения (y = k * x + b):");
        System.Console.WriteLine();
        for (int j = 0; j < value.GetLength(1); j++)
        {
            if(j == 0) Console.Write($"Введите коэффициент k: ");
            else Console.Write($"Введите коэффициент b: ");
            value[i,j] = int.Parse(Console.ReadLine()!);
        }
    }
}

double[] Decision(double[,] value)
{
    crossPoint[0] = (value[1,1] - value[0,1]) / (value[0,0] - value[1,0]);
    crossPoint[1] = crossPoint[0] * value[0,0] + value[0,1];
    return crossPoint;
}

void ValueComparison(double[,] value)
{
    if (value[0,0] == value[1,0] && value[0,1] == value[1,1]) 
    {
        Console.Write($"\nПрямые совпадают");
    }
    else if (value[0,0] == value[1,0] && value[0,1] != value[1,1]) 
    {
        Console.Write($"\nПрямые параллельны");
    }
    else 
    {
        Decision(value);
        Console.Write($"Точка пересечения прямых: ({crossPoint[0]}, {crossPoint[1]})");
    }
}

InputValue();
ValueComparison(value);

/*
1. Вводим 4 числа
2. Присваиваем им значения
3. Запихиваем их в массив
4. Объявляем массив
5. Подставляем числа массива по индексам в уравнения
6. Сравниваем



Console.Write("Введите k1: ");
double k1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите b1: ");
double b1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите k2: ");
double k2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите b2: ");
double b2 = int.Parse(Console.ReadLine()!);
int[] arrayValue = new int[4] {k1, b1, k2, b2};
System.Console.Write(string.Join(", ", arrayValue));
double x;
x = 0;
*/