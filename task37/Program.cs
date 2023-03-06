// Задача 37: Найдите произведение пар чисел 
//в одномерном массиве.
// Парой считаем первый и последний 
//элемент, второй и предпоследний и т.д. 
//Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

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

int newLenght = array.Length/2 + array.Length % 2;
int[] newArray = new int[newLenght];

for (int i = 0; i < array.Length/2; i++)
{
    newArray[i] = array[i] * array[array.Length - 1 - i];
}
if(array.Length % 2 > 0)
    {
        newArray[newArray.Length - 1] = array[array.Length/2];
    }

Console.WriteLine($"[ {string.Join(", ", newArray)} ]");