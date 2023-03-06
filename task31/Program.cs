// Задача 31: Задайте массив из N элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, 
//сумма отрицательных равна -20.


int[] FillArrayWithRandomNumbers(int lenght) // метод заполнения рандомными числами
{
    int[] arr = new int [lenght]; // выделяем память под длину массива
    Random rnd = new Random(); //
    for(int i = 0; i < arr.Length; i++) // заполняем массив
    { // индекс от 0, пока не кончится длина массива, добавляя по еденице
        arr[i] = rnd.Next(-9, 10); // рандомные числа от - 9 до 9
    }
    return arr; // возвращаем наш массив
}

Console.WriteLine("Введите длину массива: ");
int lenght = Convert.ToInt32(Console.ReadLine()); // длина массива
int[] array = FillArrayWithRandomNumbers(lenght);
int sumPositive = 0;
int sumNegative = 0;
Console.WriteLine($"[ {string.Join(", ", array)} ]");
for(int i =0; i < array.Length; i++)
{
    if(array[i] > 0)
    {
        sumPositive += array[i];
    }
    else
    {
        sumNegative += array[i];
    }
}
Console.WriteLine($"Сумма положительныхт чисел составила {sumPositive}, сумма отрицательных чисел составила {sumNegative}");