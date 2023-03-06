// Задача 34: Задайте массив 
//заполненный случайными положительными 
//трёхзначными числами. 
//Напишите программу, которая 
//покажет количество чётных чисел 
//в массиве.
// [345, 897, 568, 234] -> 2

int[] PositiveNumbers(int lenght)
{
int[] arr = new int [lenght]; // выделяем память под длину массива
    Random rnd = new Random(); //
    for(int i = 0; i < arr.Length; i++) // заполняем массив
    { // индекс от 0, пока не кончится длина массива, добавляя по еденице
        arr[i] = rnd.Next(100, 1000); // рандомные числа от - 9 до 9
    }
    return arr;
}
Console.WriteLine("Введите длину массива: ");
int lenght = Convert.ToInt32(Console.ReadLine());
int[] array = PositiveNumbers(lenght);
Console.WriteLine($"[ {string.Join(", ", array)} ]");
int count = 0;

for (int i = 0; i < array.Length; i++)
{
    if(array[i] %2 == 0)
    {
        count++;
    }
}
Console.WriteLine($"Положительных чисел в массиве: {count} ");