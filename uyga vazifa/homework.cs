using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> a = new List<int> { 12, -5, 123, 8, 21, 42, 7, 100, 3, 14 };
        List<int> b = new List<int> { 5, 20, 100, 2, 30, 10, 9, 40, 6, 1 };
        List<string> s = new List<string> { "$abc", "HELLO", "World", "$TEST", "JAVA" };

        // 1
        int count3digit = 0;
        foreach (int x in a)
            if (Math.Abs(x) >= 100 && Math.Abs(x) <= 999) count3digit++;
        Console.WriteLine(count3digit);

        // 2
        int evenCount = 0;
        foreach (int x in a)
            if (x % 2 == 0) evenCount++;
        Console.WriteLine(evenCount);

        // 3
        int oddSum = 0;
        foreach (int x in a)
            if (x % 2 != 0) oddSum += x;
        Console.WriteLine(oddSum);

        // 4
        int count3and7 = 0;
        foreach (int x in a)
            if (x % 3 == 0 && x % 7 == 0) count3and7++;
        Console.WriteLine(count3and7);

        // 5
        int count2digitOdd = 0, sum2digitOdd = 0;
        foreach (int x in a)
            if (Math.Abs(x) >= 10 && Math.Abs(x) <= 99 && x % 2 != 0)
            {
                count2digitOdd++;
                sum2digitOdd += x;
            }
        Console.WriteLine(count2digitOdd + " " + sum2digitOdd);

        // 6
        int temp = a[0];
        a[0] = a[a.Count - 1];
        a[a.Count - 1] = temp;
        Console.WriteLine(string.Join(" ", a));

        // 7
        Console.WriteLine(a[0] + a[1] + a[2]);

        // 8
        Console.WriteLine(a[a.Count - 1] + a[a.Count - 2] + a[a.Count - 3]);

        // 9
        int oddC = 0, evenC = 0;
        foreach (int x in a)
            if (x % 2 == 0) evenC++; else oddC++;
        Console.WriteLine(oddC > evenC);

        // 10
        for (int i = 0; i < a.Count; i++)
            if (a[i] % 2 == 0) a[i] *= 3;
        Console.WriteLine(string.Join(" ", a));

        // 11
        bool all5 = true;
        foreach (int x in a)
            if (x % 5 != 0) all5 = false;
        Console.WriteLine(all5);

        // 12
        bool first3twoDigit = true;
        for (int i = 0; i < 3; i++)
            if (!(Math.Abs(a[i]) >= 10 && Math.Abs(a[i]) <= 99)) first3twoDigit = false;
        Console.WriteLine(first3twoDigit);

        // 13
        bool cond13 = a[0] % 2 == 0 && a[1] % 2 == 0 && a[^1] % 2 != 0 && a[^2] % 2 != 0;
        Console.WriteLine(cond13);

        // 14
        int min = a[0];
        foreach (int x in a)
            if (x < min) min = x;
        Console.WriteLine(min);

        // 15
        int max = a[0];
        min = a[0];
        foreach (int x in a)
        {
            if (x > max) max = x;
            if (x < min) min = x;
        }
        Console.WriteLine(max + min);

        // 16
        for (int i = 0; i < a.Count; i++)
            if (Math.Abs(a[i]) >= 10 && Math.Abs(a[i]) <= 99) a[i] += 100;

        // 17
        int pos = 0, neg = 0;
        foreach (int x in a)
            if (x > 0) pos++; else if (x < 0) neg++;
        Console.WriteLine(pos + " " + neg);

        // 18
        int countLessFirst = 0;
        foreach (int x in a)
            if (x < a[0]) countLessFirst++;
        Console.WriteLine(countLessFirst);

        // 19
        int sumGreaterLast = 0;
        foreach (int x in a)
            if (x > a[^1]) sumGreaterLast += x;
        Console.WriteLine(sumGreaterLast);

        // 20
        bool all3or4 = true;
        foreach (int x in a)
            if (!(x % 3 == 0 || x % 4 == 0)) all3or4 = false;
        Console.WriteLine(all3or4 ? "hello" : "salom");

        // 21
        bool inc = true;
        for (int i = 1; i < a.Count; i++)
            if (a[i] <= a[i - 1]) inc = false;
        Console.WriteLine(inc);

        // 22
        bool dec = true;
        for (int i = 1; i < a.Count; i++)
            if (a[i] >= a[i - 1]) dec = false;
        Console.WriteLine(dec);

        // 23
        int minI = 0, maxI = 0;
        for (int i = 0; i < a.Count; i++)
        {
            if (a[i] < a[minI]) minI = i;
            if (a[i] > a[maxI]) maxI = i;
        }
        temp = a[minI];
        a[minI] = a[maxI];
        a[maxI] = temp;
        Console.WriteLine(string.Join(" ", a));

        // 24
        int sumAll = 0;
        foreach (int x in a) sumAll += x;
        Console.WriteLine(sumAll);

        // 25
        int maxPairSum = a[0] + a[1];
        for (int i = 1; i < a.Count - 1; i++)
            if (a[i] + a[i + 1] > maxPairSum)
                maxPairSum = a[i] + a[i + 1];
        Console.WriteLine(maxPairSum);

        // 26
        int cnt = 0;
        for (int i = 1; i < a.Count; i++)
            if (a[i] > a[i - 1]) cnt++;
        Console.WriteLine(cnt);

        // 27
        List<int> c = new List<int>();
        for (int i = 0; i < a.Count; i++)
            c.Add(a[i] * b[i]);
        Console.WriteLine(string.Join(" ", c));

        // 28
        int dollarCount = 0;
        foreach (string x in s)
            if (x.StartsWith("$")) dollarCount++;
        Console.WriteLine(dollarCount);

        // 29
        foreach (string x in s)
            if (x.ToUpper() == x) Console.WriteLine(x);

        // 30
        int firstEven = 0;
        foreach (int x in a)
            if (x % 2 == 0) { firstEven = x; break; }
        for (int i = 0; i < a.Count; i++)
            if (a[i] % 2 == 0) a[i] += firstEven;

        // 31
        int lastOdd = 0;
        for (int i = a.Count - 1; i >= 0; i--)
            if (a[i] % 2 != 0) { lastOdd = a[i]; break; }
        for (int i = 0; i < a.Count; i++)
            if (a[i] % 2 != 0) a[i] += lastOdd;

        // 32
        int minEvenIndex = a[0];
        for (int i = 0; i < a.Count; i += 2)
            if (a[i] < minEvenIndex) minEvenIndex = a[i];
        Console.WriteLine(minEvenIndex);

        // 33
        List<int> d = new List<int>();
        for (int i = 0; i < a.Count; i++)
            d.Add(Math.Max(a[i], b[i]));
        Console.WriteLine(string.Join(" ", d));

        // 34
        List<int> evenList = new List<int>();
        foreach (int x in a)
            if (x % 2 == 0) evenList.Add(x);
        Console.WriteLine(evenList.Count);
        Console.WriteLine(string.Join(" ", evenList));
    }
}
