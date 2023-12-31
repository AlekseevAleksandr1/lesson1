
string[] test = {"s", "dfsaa", "fdsfds", "fda"};

string[] aa = array(test);
Console.WriteLine($"{String.Join(",", aa)}");
//метод
string[] array(string[] massive){
    int count = 0;
    int number = 0;



    for(int k = 0; k < massive.Length; k++){
        if(massive[k].Length <= 3){
            number++;
        }
    }
    string[] result = new string[number];
    for(int i = 0; i < massive.Length; i++){
        if(massive[i].Length <= 3){
            result[count] = massive[i];
            count++;
        }
    }
    return result;
}

