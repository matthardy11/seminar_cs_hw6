// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

int FindPositive(int[] array)
{
  int result = 0;
  for(int i = 0; i < array.Length; i++)
  {
    if(array[i] > 0)
    {
      result++;
    }
  }
  return result;
}

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

int[] FillArray(int size)
{
  int[] array = new int[size];
  for(int i = 0; i < array.Length; i++)
  {
    array[i] = InputNumber("Введите число: ");
  }
  return array;
}

int size = InputNumber("Введите желаемый размер массива: ");
System.Console.WriteLine("");
System.Console.WriteLine("Колличество положительных чисел: " + FindPositive(FillArray(size)));

