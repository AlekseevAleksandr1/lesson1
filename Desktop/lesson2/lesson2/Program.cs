Console.WriteLine("Введите число ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine(sum(number));




int sum(int number){
    int result = 0;
    while(number > 0){
        result += number % 10;
        number = number / 10;
    }
    return result;
}
