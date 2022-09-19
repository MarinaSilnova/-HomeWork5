// Задайте массив дробных чисел. Найдите разницу между максимальным и минимальным элементов массива.

void InputArray(double[] array)
{
   Console.WriteLine(" Введите вещественные числа: ");
    for (int i = 0; i < array.Length; i++)
    array[i] = Convert.ToDouble(Console.ReadLine());
}
double MaxNumber(double[] array)
{
    double max = array[0];
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        max = array[i];
    }
    for (int i = 0; i < array.Length; i++)
       {
        if (array[i] < min)
        min = array[i]; 
       }
double dif = max - min;
return dif;
}

double[] array = new double[5];
InputArray(array);
Console.WriteLine("Исходный массив данных: [" + string.Join(", ", array) + "]");
Console.WriteLine(Math.Round (MaxNumber(array), 5));
