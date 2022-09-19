// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(2, 15);
}
int EvenPosition(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 0)
        sum += array[i];
    }
    return sum;
}
int[] array = new int[5];
InputArray(array);
Console.WriteLine("Исходный массив данных: [" + string.Join(", ", array) + "]");
Console.WriteLine(EvenPosition(array));
