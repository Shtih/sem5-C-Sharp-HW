// Задача 32: Напишите программу замена элементов 
//массива: положительные элементы замените 
//на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]
int[] ChangeNumbersArray (int lenght)
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
int[] array = ChangeNumbersArray(lenght);
Console.WriteLine($"[ {string.Join(", ", array)} ]");

for(int i =0; i < array.Length; i++)
{
    array[i] = array[i] * -1;
}

Console.WriteLine($"[ {string.Join(", ", array)} ]");
