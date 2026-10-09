// int[] recordBooks = { 1042, 1058, 1071, 1093, 1105 };
// int target = 1098;
// bool found = false;
// foreach (int number in recordBooks)
// {
//     if (number == target)
//     {
//         found = true;
//         break;
//     }
// }
// Console.WriteLine(found ? "Студент найден" : "Студент не найден");


// int variant = 1;
// bool isPrime = true;
// if (variant <= 1)
// {
//     isPrime = false;
// }
// else
// {
//     for (int divisor = 2; divisor < variant; divisor++)
//     {
//         if (variant % divisor == 0)
//         {
//             isPrime = false;
//             break;
//         }
//     }
// }

// Console.WriteLine(isPrime ? "Номер варианта простой" : "Номер варианта составной");

// using System.ComponentModel.DataAnnotations;
// using System.Globalization;
// using System.Runtime.CompilerServices;

// int i = 0;
// int[] pointsPerLab = { 8, -1, 10, 9, -1, 7 };
// int sum = 0;
// foreach (int points in pointsPerLab)
// {
//     if (points < 0)
//     {
//         continue;
//         i++;
//     }
//     sum += points;
// }int b = pointsPerLab.Length - i;

// Console.WriteLine($"Сумма баллов за сданные работы: {sum} {b}");



// int[] groupIds = { 101, 104, 107, 104, 110 };
// bool hasDuplicates = false;
// for (int i = 0; i < groupIds.Length; i++)
// {
//     for (int j = i + 1; j < groupIds.Length; j++)
//     {
//         if (groupIds[i] == groupIds[j])
//         {
//             hasDuplicates = true;
//             Console.WriteLine($"Есть повторяющиеся номера");
//             return;
//         }
//     }
// }
// Console.WriteLine(hasDuplicates ? "Есть повторяющиеся номера" : "Все номера уникальны");



// int days = 5;
// int lessonsPerDay = 6;
// bool found = false;
// for (int day = 1; day <= days && !found; day++)
// {
//     for (int lesson = 1; lesson <= lessonsPerDay; lesson++)
//     {
//         bool isFree = (day == 3 && lesson == 4);
//         if (isFree)
//         {
//             Console.WriteLine($"Свободный слот: день {day}, урок {lesson}");
//             found = true;
//             break;
//         }
//     }
// }
// if (!found)
// {
//     Console.WriteLine("Свободных слотов нет");
// }



//Задание А
// int[] a = { 10, 23, 5, 42, 17, 8 };
// int b = 42;
// bool flag = false;
// int c = 0;
// for (int i = 0; i < a.Length; i++)
// {
//     if (a[i] == b)
//     {
//         c = i;
//         flag = true;
//         break;
//     }
// }
// if (flag)
// {
//     Console.WriteLine($"Число {b} найдено на индексе {c}");
// }
// else
// {
//     Console.WriteLine($"Число {b} не найдено в массиве");
// }




//Задача Б
int num = 17;
if (num < 2)
{
    Console.WriteLine($"{num} не является простым числом");
    return;
}
bool flag = true;
for (int i = 2; i <= num / 2; i++)
{
    if (num % i == 0)
    {
        flag = false;
        break;
    }
}
if (flag)
{
    Console.WriteLine($"{num} является простым числом");
}
else
{
    Console.WriteLine($"{num} не является простым числом");
}