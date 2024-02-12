// // 1) все нат число от м до н 
// // 2)функ аккермана 
// //ЗАДАЧА №3 НЕ МОГУ РАЗОБРАТЬСЯ В ЧЁМ ПРОБЛЕМА( код не работает)
// int[] array = {1, 2, 5, 0, 10, 34};
// int size = array.Length;
// void ShowArray(int[] arr, int size)
// {
//     if (size == 0)
//     {
//         Console.Write(arr[size]);
//         return;
//     }
//     Console.Write(arr[size] + " ");
//     ShowArray(arr, size - 1);
// }
// ShowArray(array, size);

// ЗАДАЧА№2
// Напишите программу вычисления функции Аккермана с 
// помощью рекурсии. Даны два неотрицательных числа m и n
// Console.WriteLine("Введите число M");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число N");
// int n = Convert.ToInt32(Console.ReadLine());
// int AkkermanFuncion(int m, int n)
// {
//     if (m == 0)
//     {
//     return n + 1; 
//     }
//     else if (n == 0)
//     {
//     return AkkermanFuncion(m - 1, 1);
//     }
//     else
//     {
//     return AkkermanFuncion(m - 1, AkkermanFuncion(m, n - 1));
//     }
    
// }
// Console.Write($"Функция Аккермана равнa {AkkermanFuncion(m, n)} ");

// ЗАДАЧА №1
// Задайте значения M и N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.
Console.WriteLine("Введите число min");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число max");
int max = Convert.ToInt32(Console.ReadLine());
void ShowNumbersOfSegment(int min, int max)
{
    if (min == max)
    {
        Console.Write(min);
        return;
    }
    Console.Write(min + " ");
    ShowNumbersOfSegment(min + 1, max);
}
ShowNumbersOfSegment(min, max);