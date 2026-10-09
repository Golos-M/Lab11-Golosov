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

using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

int i = 0;
int[] pointsPerLab = { 8, -1, 10, 9, -1, 7 };
int sum = 0;
foreach (int points in pointsPerLab)
{
    if (points < 0)
    {
        continue;
        i++;
    }
    sum += points;
}int b = pointsPerLab.Length - i;

Console.WriteLine($"Сумма баллов за сданные работы: {sum} {b}");


