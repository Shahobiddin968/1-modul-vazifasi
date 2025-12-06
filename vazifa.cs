using System;

class Program
{
    static void Main()
    {
        Console.Write("Satr kiriting: ");
        string input = Console.ReadLine();
        
        if (input.Length > 4)
        {
            int startIndex = 2;
            int length = input.Length - 4;
            string middleChars = input.Substring(startIndex, length);
            Console.WriteLine("O'rtadagi belgilar (boshidan 2ta, oxiridan 2ta olinmagan): " + middleChars);
        }
        else
        {
            Console.WriteLine("Satr kamida 5 ta belgidan iborat bo'lishi kerak!");
        }
    }
}