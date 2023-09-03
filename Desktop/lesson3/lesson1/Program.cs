/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/

int[,] number1 = number(4,4);
PrintArray(number1);
Console.WriteLine();
num(number1);




int[,] number(int m, int n){
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
            Console.Write($"{result[i, j]} ");
        }
        Console.WriteLine();
    }
}



void num(int[,] result){
    int sum = 0;
    int k = 0;
    int[] massive = new int[result.GetLength(1)];
    for(int i = 0; i < result.GetLength(0); i++){
            while(k < result.GetLength(1)){
                sum += result[i,k];
                k++;
            }
            massive[i] = sum;
            sum = 0;
            k = 0;
            Console.WriteLine(massive[i]);
            int index = 0;
            int min = massive[0];
            for(int d = 0; d < massive.Length; d++){
                if(min > massive[d]) {min = massive[d];
                    index = d;}
    }
                Console.WriteLine(index);
        }
        
}

void num1(int[] massive){
    int index = 0;
    int min = massive[0];
    for(int d = 0; d < massive.Length; d++){
        if(min > massive[d]) min = massive[d];
        index = d;
    }
    Console.WriteLine(index);
}