// Задача 33: Задайте массив. Напишите программу, 
//которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 3, 19, 345, 3] -> да

int[] TestNumbers (int lenght)
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
int[] array = TestNumbers(lenght);
Console.WriteLine($"[ {string.Join(", ", array)} ]");

Console.WriteLine("Введите число поиска N: ");
int N = Convert.ToInt32(Console.ReadLine());

bool isOk(int[] array, int N)
{
for (int i = 0; i < array.Length; i++)
{
if (N == array[i])
{
return true;
}
}
return false;
}
if (isOk(array, N))
{
System.Console.WriteLine("Элемент найден");
}
else
{
System.Console.WriteLine("Элемент не найден");
}