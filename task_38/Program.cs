// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

int number = 8; // задаем длинну массива
double[] array = new double[number];

FillArrayRandom(number);
PrintArray(array);
// Console.WriteLine($"Сумма чисел на нечетных позициях = {OddIndexCalc(array)}");

double[] FillArrayRandom(int length) // Метод заполнения массива
{
    Random random = new Random();

    for (int i = 0; i < number; i++)
    {
        double randomValue = random.Next(-100, 100);
        array[i] = randomValue;
    }
    return array;
}

void PrintArray(double[] array) // вывод массива
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


