// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

int number = 8; // задаем длинну массива
int[] array = new int[number];

FillArrayRandom(number);
PrintArray(array);
Console.WriteLine($"Максимальный элемент = {MaxArrayElement(array)}");
Console.WriteLine($"Минимальный элемент = {MinArrayElement(array)}");
Console.WriteLine($"Разница между максимальным и минимальным элементами = {MaxArrayElement(array) - MinArrayElement(array)}");

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

int MaxArrayElement(int[] array) // поиск максимального числа в массиве
{
    int max = array[0];
        for (int i = 0; i < number; i++)
    {
        if (max < array[i])
        {
            max = array[i];
        }
    }
    return max;
}

int MinArrayElement(int[] array) // поиск минимального числа в массиве
{
    int min = array[0];
        for (int i = 0; i < number; i++)
    {
        if (min > array[i])
        {
            min = array[i];
        }
    }
    return min;
}
