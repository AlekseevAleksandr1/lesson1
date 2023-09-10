

/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/


Console.WriteLine("Введите число" );
int num = int.Parse(Console.ReadLine());
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine(number(num, num1));



int number(int alpha, int num){
    if(alpha == num) return num;
    return(alpha + number(alpha + 1, num));
}