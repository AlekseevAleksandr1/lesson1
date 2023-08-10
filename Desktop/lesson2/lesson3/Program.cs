int[] num = number(10, 10, 100);
Console.WriteLine($"{String.Join(",", num)}");




int[] number(int size, int minvalue, int maxvalue){
    int[] massive = new int[size];
    for(int i = 0; i < size; i++){
        massive[i] = new Random().Next(minvalue, maxvalue);
    }
    return massive;
}
