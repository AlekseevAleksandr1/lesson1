Console.WriteLine("Введите числа");
string number = Console.ReadLine();
Console.WriteLine(str(number));


int str(string number){
    int cou = 0;
    string[] str1 = number.Split(',');
    foreach (var num in str1){
        if(Convert.ToInt32(num) > 0) {
            cou = cou + 1;
        }
        
    }
    return cou;
}
