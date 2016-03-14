using System.IO;
using System;

class Program
{
    //zwraca silnie liczby
    static double silnia (double n){
        if (n == 0) return 1;
        else return n*silnia(n-1);
    }
    //zwraca sume cyfr liczby
    static double zliczSume(double liczba){
        double sum = 0;
        while (liczba != 0) {
            sum = sum + liczba % 10;
            liczba /= 10;
        }
        sum.Convert.ToInt();
        if(sum==0){
            return 1111111111111111;
        }
        return sum;
    }
    static void Main()
    {
        Console.WriteLine("Podaj liczbe");
        double x = Convert.ToUInt64(Console.ReadLine());
        Console.Write(zliczSume(silnia(x)));
        Console.Write("\n");
    }
}