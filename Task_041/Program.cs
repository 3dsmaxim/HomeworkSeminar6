Console.Clear();

//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 4




int[] ArrayNums(string nums)
{
    string[] elemArr = nums.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[] array = new int[elemArr.Length];
    for (int i = 0; i < elemArr.Length; i++)
    {
        array[i] = int.Parse(elemArr[i]);
    }
    return array;
}

int CountPositive(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) count++;
    }
    return count;
}

Console.Write("Введите числа чтерез пробел: ");

string elements = Console.ReadLine();

int[] arrayTwo = ArrayNums(elements);

Console.WriteLine($"В массиве [{String.Join(", ", arrayTwo)}] колличество чисел больше 0 равно {CountPositive(arrayTwo)}");


// string[] nums = Console.ReadLine(string.Split(" ", StringSplitOptions.RemoveEmptyEntries));
