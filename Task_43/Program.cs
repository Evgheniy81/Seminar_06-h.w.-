//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных 
//уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите k1: ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите k2: ");
int k2 = Convert.ToInt32(Console.ReadLine());
double x = (double) (b2 - b1) / (k1 - k2);
//double y = (double) k1 * x + b1; 
//double y2 = (double) k2 * x + b2;
Console.WriteLine($"Прямые пересекаются при значении X = {x} ");


//// Идеальный вариант. Разобраться бы как он работает
/*
const int COEFF = 0;
const int CONST = 1;
const int X_COORD = 0;
const int Y_COORD = 1;
const int LINE1 = 1;
const int LINE2 = 2;
double[] lineData1 = InputLineData(LINE1);
double[] lineData2 = InputLineData(LINE2);
if (ValidateLine(lineData1, lineData2))
{
    double[] coord = FindCoords(lineData1, lineData2);
    Console.Write($"Точка пересечения уравнений y = {lineData1[COEFF]} * x + {lineData1[CONST]} и y = {lineData2[COEFF]} * x + {lineData2[CONST]}");
    Console.WriteLine($"имеет координаты ({coord[X_COORD]}, {coord[Y_COORD]})");
}
//Ввод числа
double Prompt(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    double result = Convert.ToDouble(value);
    return result;
}
//Ввод данных по прямой
double[] InputLineData(int numberOfLine)
{
    double[] lineData = new double[2];
    lineData[COEFF] = Prompt($"Введите коэффициент для {numberOfLine} прямой > ");
    lineData[CONST] = Prompt($"Введите константу для {numberOfLine} прямой > ");
    return result;
}
//Поиск координат
double[] FindCoords(double[] lineData1, double[] lineData2)
{
    double[] coord = new double[2];
    coord[X_COORD] = (lineData1[CONST] - lineData2[CONST]) / (lineData2[COEFF] - lineData1[COEFF]);
    coord[Y_COORD] = lineData1[CONST] * coord[X_COORD] + lineData1[CONST];
    return coord;
}
bool ValidateLine(double[] lineData1, double[] lineData2)
{
    if (lineData1[COEFF] == lineData2[COEFF])
    {
        if (lineData1[CONST] == lineData2[CONST])
        {
            Consile.WriteLine("Прямые совпадают");
            return false;
        }
        else
        {
            Console.WriteLine("Прямые параллельны");
            return false;
        }
    }
    return true;
}
*/