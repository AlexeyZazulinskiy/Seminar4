//Задача 29: Напишите программу, которая задаёт массив из 8 элементов, которые вводит пользователь, и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

void input_array(int [] array)
{

    for (int i = 0; i < 8; i++){
        Console.WriteLine($"Введите {i+1} из 8 элементов массива: ");   
        array[i] = Convert.ToInt32(Console.ReadLine());
        Console.Clear();
    }
}

Console.Clear();
int[] array = new int[8];
input_array(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
