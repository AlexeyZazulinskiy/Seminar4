//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

int LengthArray(int n){
    int count = 0;
    for (int i = 1; i < n; i = i*10)
         count ++;
    return count;
}

void InputArray(int [] array,int n) {

    for (int i = 0; i < array.Length ; i++){
        array[i] = n%10;
        n = n/10;
    }

}

int Summ (int [] array){
    int s =0;
    for (int i = 0; i < array.Length ; i++){
        s = s + array [i];
    }
    return s;
}

Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int [] array = new int[LengthArray(n)];
InputArray(array,n);
Console.WriteLine($"= {Summ(array)}");
