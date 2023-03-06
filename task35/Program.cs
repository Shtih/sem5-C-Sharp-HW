// Задача 35: Задайте одномерный массив 
//из N случайных чисел. 
// Найдите количество элементов массива, 
//значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. 
//В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int[] RandomArray (int lenght)
{
int[] arr = new int [lenght]; // выделяем память под длину массива
    Random rnd = new Random(); //
    for(int i = 0; i < arr.Length; i++) // заполняем массив
    { // индекс от 0, пока не кончится длина массива, добавляя по еденице
        arr[i] = rnd.Next(-100, 101); // рандомные числа от - 9 до 9
    }
    return arr;
}
Console.WriteLine("Введите длину массива: ");
int lenght = Convert.ToInt32(Console.ReadLine());
int[] array = RandomArray(lenght);
Console.WriteLine($"[ {string.Join(", ", array)} ]");
int count = 0;

for (int i = 0; i < array.Length; i++)
{
    if(array[i] >= 10 && array[i] <= 99)
    {
        count++;
    }
}
Console.WriteLine($"Числа от 10 до 99 встречаются в массиве {count} раз");