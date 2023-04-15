// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int number = 8; // задаем длинну массива
int[] array = new int[number];

FillArrayRandom(number);
PrintArray(array);
Console.WriteLine($"Сумма чисел на нечетных позициях = {OddIndexCalc(array)}");

int[] FillArrayRandom(int length) // Метод заполнения массива
{
    Random random = new Random();

    for (int i = 0; i < number; i++)
    {
        int randomValue = random.Next(-100, 100);
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

int OddIndexCalc(int[] array) // подсчет суммы чисел на нечетных позициях
{
    int summ = 0;
        for (int i = 0; i < number; i++)
    {
        if (i%2 != 0)
        {
            summ += array[i];
        }
    }
    return summ;
}