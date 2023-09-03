/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/


int[,] result = num1(4,4);
PrintArray(result);
Console.WriteLine();
PrintArray(number(result));




int[,] num1(int m, int n){
    int[,] result = new int[m,n];
    for(int i = 0; i < result.GetLength(0); i++){
        for(int j = 0; j < result.GetLength(1); j++){
            result[i,j] = new Random().Next(1,9);
        }
    }
    return result;
}

void PrintArray(int[,] result){
    for(int i = 0; i < result.GetLength(0); i++){
        for(int j = 0; j < result.GetLength(1); j++){
            Console.Write($"{result[i,j]} ");
        }
        Console.WriteLine();
    }
}


int[,] number(int[,] result){
    for(int i = 0; i < result.GetLength(0); i++){
        for(int j = 0; j < result.GetLength(1); j++){
            for(int k = 0; k < result.GetLength(1) - 1; k++){
                if(result[i,k] < result[i, k+1]) {
                    (result[i,k], result[i, k+1]) = (result[i, k+1], result[i,k]);
                    }
            }
        }
    }
    return result;
}
