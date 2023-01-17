// Задача 29: Напишите программу, которая задаёт массив из 8 элементов 
//и выводит их на экран.

//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

//6, 1, 33 -> [6, 1, 33]

int[] getRandomArray(int length)
{
    int[] array = new int[length];
    for(int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(0, 101);
    }
    return array;
}

Console.WriteLine("Введите число элементов массива: ");
int length = int.Parse(Console.ReadLine()!);
int[] array = getRandomArray(length);

void showArray(int[] array)
{
    Console.Write($"[");
    for(int i = 0; i < array.Length; i++)
    {
        if(i != array.Length-1)
        {
            Console.Write($"{array[i]},");
        }
        else
        {
            Console.Write($"{array[i]}]");
        }
    }
}
 showArray(array);
