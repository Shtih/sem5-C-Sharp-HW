// Я запуталась с double, создавала его вот так, но в этом случа он ругается на return arr
int[] RandomArray (int lenght)
{
double[] arr = new double [lenght]; // выделяем память под длину массива
    Random rnd = new Random(); //
    for(int i = 0; i < arr.Length; i++) // заполняем массив
    { // индекс от 0, пока не кончится длина массива, добавляя по еденице
        arr[i] = rnd.NextDouble(); // рандомные числа
    }
    return arr;
}
Console.WriteLine("Введите длину массива: ");
int lenght = Convert.ToInt32(Console.ReadLine());
int[] array = RandomArray(lenght);
Console.WriteLine($"[ {string.Join(", ", array)} ]");

// обьясните пожалуйста как сделать, может дело в том что метод NextDouble возвращает 
//вещественные числа от одного до еденицы