﻿

int[,,] num = number(2,2,2);
PrintArray(num);






int[,,] number(int m, int n, int k){
    int number1 = new Random().Next(1,101);
    int[,,] result = new int[m,n,k];
    for(int i = 0; i < result.GetLength(0); i++){
        for(int j = 0; j < result.GetLength(1); j++){
            for(int d = 0; d < result.GetLength(2); d++){
                while(true){
                    int RandomValue = new Random().Next(1,99);
                    if(!value1(result, RandomValue)){
                        result[i,j,d] = RandomValue;
                        break;
                    }
                }
            }
        }
    }
    return result;
}

void PrintArray(int[,,] result){
    for(int i = 0; i < result.GetLength(0); i++){
        for(int j = 0; j < result.GetLength(1); j++){
            for(int d = 0; d < result.GetLength(2); d++){
                Console.Write($"{result[i,j,d]}({i}, {j},{d})");
            }
            Console.WriteLine();
        }
    }
}








bool value1(int[,,] result, int value){
    bool CheckValue = false;
    for(int i = 0; i < result.GetLength(0); i++){
        for(int j = 0; j < result.GetLength(1); j++){
            for(int d = 0; d < result.GetLength(2); d++){
                if(result[i,j,d] == value) 
                CheckValue = true;
                break;
            }
        }
    }
    return CheckValue;
}