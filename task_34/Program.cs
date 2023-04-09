// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
//  Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int number = 8; // задаем длинну массива
int[] array = new int[number];

FillArrayRandom(number);
PrintArray(array);
Console.WriteLine($"Количество четных цифр в массиве = {EvenCalc(array)}");

int[] FillArrayRandom(int length) // Метод заполнения массива
{
    Random random = new Random();

    for (int i = 0; i < number; i++)
    {
        int randomValue = random.Next(100, 1000);
        array[i] = randomValue;
    }
    return array;
}

void PrintArray(int[] array) // вывод массива
{
    for (int i = 0; i < number; i++)
    {
        Console.Write($"элемент {i} - ");
        Console.WriteLine(array[i]);
    }
}

int EvenCalc(int[] array) // подсчет числа четных чисел
{
    int EvenNumbers = 0;
        for (int i = 0; i < number; i++)
    {
        if (array[i]%2 == 0)
        {
            EvenNumbers += 1;
        }
    }
    return EvenNumbers;
}