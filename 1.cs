using System;

class work_2_2
{
    static void Main()
    {
        int[] array = new int[100]; // Создайтём массив
        int number = 300; // изначальное число
        
        for(int i = 0; i < 100; i++)
        {
            array[i] = number; // добавляем число в n место массива
            number -= 3; // уменьшаем число на 3
        }
        var str = string.Join(" ", array); // превращаем масив в строку с разделителями 
        Console.WriteLine(str); // выводим строку
    }
}