using System;

class Program
{
    static int AREA(int höjd, int bredd)
    {
        return höjd * bredd;
    }
    static void Main()
    {
        Console.Write("Skriv höjden för din rektangen " );
        int Höjd = int.Parse(Console.ReadLine());
        Console.Write("Skriv bredden för rektangen  " );
        int bredd = int.Parse(Console.ReadLine());

        int area = AREA(Höjd, bredd);
        Console.WriteLine("Arean på rektanglen är " + area);
    }
}