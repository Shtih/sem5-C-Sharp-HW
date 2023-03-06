// Задача 38: Задайте массив вещественных
//  чисел. Найдите разницу между 
//  максимальным и минимальным 
//  элементов массива.
// [3 7 22 2 78] -> 76

int[] RandomArray (int lenght)
{
int[] arr = new int [lenght]; // выделяем память под длину массива
    Random rnd = new Random(); //
    for(int i = 0; i < arr.Length; i++) // заполняем массив
    { // индекс от 0, пока не кончится длина массива, добавляя по еденице
        arr[i] = rnd.Next(-100, 100); // рандомные числа от - 9 до 9
    }
    return arr;
}
Console.WriteLine("Введите длину массива: ");
int lenght = Convert.ToInt32(Console.ReadLine());
int[] array = RandomArray(lenght);
Console.WriteLine($"[ {string.Join(", ", array)} ]");

int max = 0;
for(int i = 0; i < array.Length; i++)
{
    if(max < array[i])
    {
        max = array[i];
    }
}
Console.WriteLine($"Максимальное число в массиве: {max}");

int min = array[0];
for(int i = 1; i < array.Length; i++)
{
    if(min > array[i])
    {
        min = array[i];
    }
}
Console.WriteLine($"Минимальное число в массиве: {min}");

int result = max - min;
Console.WriteLine($"Разница между максимальным и минимальным числом массива: {result}");


