//  Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.

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
 void SumIndex (int[] array)
 {
    int sum = 0;
    for (int i = 1; i < array.Length; i+= 2)
  
    {
        sum = (sum + array[i]);
    }
    System.Console.WriteLine();
    System.Console.WriteLine($"Сумма сумму элементов, стоящих на нечётных позициях: {sum} ");

 }
 Console.WriteLine("Введите число элементов массива: ");
 int number = Convert.ToInt32(Console.ReadLine());
 int[]array = PrintArray(number);
 SumIndex(array);
