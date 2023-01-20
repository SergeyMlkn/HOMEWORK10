// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

//показывает в терминале все чв массиве
void PrintArray (int[] nums)
{
    Console.Write("Данные которые ввел пользователь: ");
    int size = nums.Length;
    for (int i = 0; i < size; i++)
    {
        Console.Write(nums[i] + " ");
    }
    Console.WriteLine();
}

//Рандом сл. чисел в массиве
void FillArray(int[] nums)
{
    int length = nums.Length;
    for (int i =0; i < length; i++)
    {
        Console.WriteLine($"Введите {i+1} число:");
        nums[i] = Convert.ToInt32(Console.ReadLine());
    }
}

void CounterPositiveNumber (int[] nums)
{
    int counter = 0;
    int length = nums.Length;
    for (int i = 0; i < length; i++)
    {
        if(nums[i] > 0)
        {
            counter++;
        }
    }
    Console.WriteLine($"Количество положительных (больше 0) чисел, которые ввел пользователь: {counter}");

}

// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

{
    Console.WriteLine("Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.");
    Console.WriteLine("Сколько чисел вы планируете ввести?");
    int sizeArray = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[sizeArray];
    FillArray(array);
    PrintArray(array);
    CounterPositiveNumber(array);
}