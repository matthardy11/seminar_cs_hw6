// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

int InputNumber(string str)
{
  int number;
  string text;
  while(true)
  {
    Console.WriteLine(str);
    text = Console.ReadLine();
    if(int.TryParse(text, out number))
    {
      break;
    }
    System.Console.WriteLine("Введено не корректное число, попробуйте ещё раз.");
  }
  return number;
}

double b1 = InputNumber("Введите значение b1: ");
double k1 = InputNumber("Введите значение k1: ");
double b2 = InputNumber("Введите значение b2: ");
double k2 = InputNumber("Введите значение k2: ");

double x = (b2-b1)/(k1-k2);
double y = k1 * x + b1;


System.Console.WriteLine("Точка пересечения: (" + Math.Round(x, 3) + "; " + Math.Round(y, 3) + ")");