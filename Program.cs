// Урок 9. Как не нужно писать код. Часть 3

// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// int n = 8;
// System.Console.WriteLine(Real(n));
// string Real(int num)
// {
//     if (num == 1)
//         return num.ToString();
//     return num.ToString()+Real(num - 1);
// }



// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// int m = 4;
// int num = 8;
// System.Console.WriteLine(Real(m, num));
// int Real(int m, int num)
// {
//     int a = -1;
//     if (m > num) a = 1;
//     if (num == m)
//         return num;
//     return Real(m, num + a) + num;
// }





// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


int m = 3;
int n = 2;
System.Console.WriteLine(A(n, m));

int A(int n, int m)
{
    if (n == 0)
        return m + 1;
    else
      if ((n != 0) && (m == 0))
        return A(n - 1, 1);
    else
        return A(n - 1, A(n, m - 1));
}
