//Задайте массив заполненный случайными положительными трёхзначными числами.
 //Напишите программу, которая покажет количество чётных чисел в массиве.
void evCount() {
    int n = int.Parse(Console.ReadLine());
    int[]array = new int[n];
    string str = string.Empty;
    string num = "четных чисел";
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100,1000);
        if(array[i] % 2 == 0)
        count++;
        str += $"{array[i]}, ";
    }
    if (count > 1 && count <5)
    num = "четных числа";
    else if(count == 1)
    num = "четное число";
    Console.WriteLine($"В массиве [{str}] {count} {num}");
}
Console.WriteLine("Задайте длинну массива: ");
evCount();
