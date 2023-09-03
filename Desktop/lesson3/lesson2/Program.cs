
/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/

int[,] number1 = number(2,2);
int[,] number2 = number(2,2);
PrintArray(number1);
Console.WriteLine();
PrintArray(number2);
Console.WriteLine();
num(number1, number2);




int[,] number(int m, int n){
    int[,] result = new int[m,n];
    for(int i = 0; i < result.GetLength(0); i++){
        for(int j = 0; j < result.GetLength(1); j++){
            result[i,j] = new Random().Next(1,5);
        }
    }
    return result;
}



void PrintArray(int[,] result){
    for(int i = 0; i < result.GetLength(0); i++){
        for(int j = 0; j < result.GetLength(1); j++){
            Console.Write($"{result[i, j]} ");
        }
        Console.WriteLine();
    }
}


void num(int[,] result1, int[,] result2){
    int[,] result3 = new int[result1.GetLength(0), result1.GetLength(1)];
    Console.WriteLine(result3[0,0] = result1[0,0] * result2[0,0] + result1[0,1] * result2[1,0]);
    Console.WriteLine(result3[0,1] = result1[0,0] * result2[0,1] + result1[0,1] * result2[1,1]);
    Console.WriteLine(result3[1,0] = result1[1,0] * result2[0,0] + result1[1,1] * result2[1,0]);
    Console.WriteLine(result3[1,1] = result1[1,0] * result2[0,1] + result1[1,1] * result2[1,1]);
}