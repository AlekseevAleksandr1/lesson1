

/*Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/

Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());
Console.WriteLine(number(num, 1));


string number(int n, int alpha){
    if(n == alpha) return alpha.ToString();
    return(n + ", " + number(n - 1, alpha));
}