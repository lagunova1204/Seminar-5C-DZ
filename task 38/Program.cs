 //Задайте массив вещественных чисел.
 //Найдите разницу между максимальным и минимальным элементов массива
int[] PrintArray(int number)
 {
    Random rnd = new Random();
    int[] array = new int[number];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(number);
        System.Console.Write($"{array[i]}, ");
    }
    return array;
 }
 void Result (int[] array)
 {
 int minValue = array[0];
 for (int i = 1; i < array.Length; i++)
 {
    if (array[i] < minValue)
    {
        minValue = array[i];
    }
    
 }
  int maxValue = array[0];
 for (int i = 1; i < array.Length; i++)
 {
    if (array[i] > maxValue)
    {
        maxValue = array[i];
    }

  }
   int result = maxValue - minValue;
  System.Console.WriteLine();
  System.Console.Write($"Разница между максимальным и минимальным элементов массива : {result}");
 }
 Console.WriteLine("Введите число элементов массива: ");
 int number = Convert.ToInt32(Console.ReadLine());
 int[]array = PrintArray(number);
 Result (array);