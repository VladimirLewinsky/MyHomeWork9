// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"



// Console.WriteLine("Введите число N");
// int n = Convert.ToInt32(Console.ReadLine());


// void Numbers(int n)
// {
//     if (n != 0)

//     {
//         Console.Write($"{n}, ");
//         Numbers(n - 1);

//     }

// }


// Console.Write($"N = {n} -> ");
// Numbers(n);



// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


// Console.WriteLine("Введите число M");
// int m = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число N");
// int n = Convert.ToInt32(Console.ReadLine());



// int Numbers(int m, int n)
// {
//     if (n == m) return n;

//     return Numbers(m,n-1) + n;

// }
// Console.WriteLine(Numbers(m,n));


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29



Console.WriteLine("Введите число M");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число N");
int n = Convert.ToInt32(Console.ReadLine());


int AkkermanNumbers(int m, int n)
{

    if (m == 0)
    {
        return n + 1;
    }
    else
    if (m > 0 && n == 0)
    {
        return AkkermanNumbers(m - 1, 1);
    }
    else
    if (m > 0 && n > 0)
    {
        return AkkermanNumbers(m - 1, AkkermanNumbers(m, n - 1));
    }
    else return AkkermanNumbers(m, n);


}

Console.WriteLine(AkkermanNumbers(m, n));