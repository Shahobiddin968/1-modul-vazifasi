using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> lst = new List<int> { 12, 5, 300, -15, 48, 7, 99, 100, -200, 3 };
        List<int> a = new List<int> { 1, 4, 7, 9 };
        List<int> b = new List<int> { 3, 2, 8, 1 };

        // 1. 3 xonali elementlar soni
        int count = 0;
        foreach (int x in lst)
            if (Math.Abs(x) >= 100 && Math.Abs(x) <= 999) count++;
        Console.WriteLine("1: " + count);

        // 2. Juft elementlar soni
        count = 0;
        foreach (int x in lst)
            if (x % 2 == 0) count++;
        Console.WriteLine("2: " + count);

        // 3. Toq elementlar yig'indisi
        int sum = 0;
        foreach (int x in lst)
            if (x % 2 != 0) sum += x;
        Console.WriteLine("3: " + sum);

        // 4. 3 va 7 ga karrali elementlar
        count = 0;
        foreach (int x in lst)
            if (x % 3 == 0 && x % 7 == 0) count++;
        Console.WriteLine("4: " + count);

        // 5. 2 xonali toq elementlar soni va yig'indisi
        count = 0; sum = 0;
        foreach (int x in lst)
            if (Math.Abs(x) >= 10 && Math.Abs(x) <= 99 && x % 2 != 0)
            { count++; sum += x; }
        Console.WriteLine($"5: soni={count}, yig'indi={sum}");

        // 6. 1-chi va oxirgi element joyini almashtirish
        int temp = lst[0];
        lst[0] = lst[lst.Count - 1];
        lst[lst.Count - 1] = temp;
        Console.WriteLine("6: " + string.Join(", ", lst));

        // 7. Dastlabki 3 ta yig'indisi
        Console.WriteLine("7: " + (lst[0] + lst[1] + lst[2]));

        // 8. Oxirgi 3 ta yig'indisi
        Console.WriteLine("8: " + (lst[^1] + lst[^2] + lst[^3]));

        // 9. Toq ko'pmi?
        int odd = 0, even = 0;
        foreach (int x in lst)
            if (x % 2 == 0) even++; else odd++;
        Console.WriteLine("9: " + (odd > even));

        // 10. Juftlarni 3 barobar oshirish
        for (int i = 0; i < lst.Count; i++)
            if (lst[i] % 2 == 0) lst[i] *= 3;
        Console.WriteLine("10: " + string.Join(", ", lst));

        // 11. Hammasi 5 ga karralimi?
        bool ok = true;
        foreach (int x in lst)
            if (x % 5 != 0) ok = false;
        Console.WriteLine("11: " + ok);

        // 12. Dastlabki 3 ta 2 xonali bo'lsin
        ok = true;
        for (int i = 0; i < 3; i++)
            if (!(Math.Abs(lst[i]) >= 10 && Math.Abs(lst[i]) <= 99)) ok = false;
        Console.WriteLine("12: " + ok);

        // 13. 1-2 juft, oxirgi 2 toqmi?
        ok = lst[0] % 2 == 0 && lst[1] % 2 == 0 && lst[^1] % 2 != 0 && lst[^2] % 2 != 0;
        Console.WriteLine("13: " + ok);

        // 14. Eng kichik element
        int mn = lst[0];
        foreach (int x in lst)
            if (x < mn) mn = x;
        Console.WriteLine("14: " + mn);

        // 15. Katta + kichik yig'indisi
        int mx = lst[0];
        foreach (int x in lst) { if (x > mx) mx = x; }
        Console.WriteLine("15: " + (mx + mn));

        // 16. 2 xonali elementlarga 100 qo'shish
        for (int i = 0; i < lst.Count; i++)
            if (Math.Abs(lst[i]) >= 10 && Math.Abs(lst[i]) <= 99) lst[i] += 100;
        Console.WriteLine("16: " + string.Join(", ", lst));

        // 17. Musbat va manfiy
        int pos = 0, neg = 0;
        foreach (int x in lst)
            if (x > 0) pos++; else if (x < 0) neg++;
        Console.WriteLine($"17: musbat={pos}, manfiy={neg}");

        // 18. 1-chi elementdan kichiklar
        count = 0;
        foreach (int x in lst)
            if (x < lst[0]) count++;
        Console.WriteLine("18: " + count);

        // 19. Oxirgisidan katta yig'indi
        sum = 0;
        foreach (int x in lst)
            if (x > lst[^1]) sum += x;
        Console.WriteLine("19: " + sum);

        // 20. Hammasi 3 yoki 4 ga karralimi
        ok = true;
        foreach (int x in lst)
            if (!(x % 3 == 0 || x % 4 == 0)) ok = false;
        Console.WriteLine("20: " + (ok ? "hello" : "salom"));

        // 21. O'suvchi tartibmi?
        ok = true;
        for (int i = 0; i < lst.Count - 1; i++)
            if (lst[i] > lst[i + 1]) ok = false;
        Console.WriteLine("21: " + ok);

        // 22. Kamayuvchi tartibmi?
        ok = true;
        for (int i = 0; i < lst.Count - 1; i++)
            if (lst[i] < lst[i + 1]) ok = false;
        Console.WriteLine("22: " + ok);

        // 23. Eng katta va eng kichikni almashtirish
        int minIdx = lst.IndexOf(mn);
        int maxIdx = lst.IndexOf(mx);
        (lst[minIdx], lst[maxIdx]) = (lst[maxIdx], lst[minIdx]);
        Console.WriteLine("23: " + string.Join(", ", lst));

        // 24. Elementlar yig'indisi
        sum = 0;
        foreach (int x in lst) sum += x;
        Console.WriteLine("24: " + sum);

        // 25. Eng katta qo'shni yig'indi
        int bestA = lst[0], bestB = lst[1];
        int bestSum = lst[0] + lst[1];
        for (int i = 0; i < lst.Count - 1; i++)
            if (lst[i] + lst[i + 1] > bestSum)
            {
                bestSum = lst[i] + lst[i + 1];
                bestA = lst[i];
                bestB = lst[i + 1];
            }
        Console.WriteLine($"25: {bestA}, {bestB}");

        // 26. Chap qo'shnisidan katta elementlar soni
        count = 0;
        for (int i = 1; i < lst.Count; i++)
            if (lst[i] > lst[i - 1]) count++;
        Console.WriteLine("26: " + count);

        // 27. a[i] * b[i] dan yangi list
        List<int> c = new List<int>();
        for (int i = 0; i < a.Count; i++)
            c.Add(a[i] * b[i]);
        Console.WriteLine("27: " + string.Join(", ", c));

        // 28. $ bilan boshlanadigan stringlar soni
        List<string> str = new List<string> { "$hi", "test", "$abc", "world" };
        count = 0;
        foreach (var s in str)
            if (s.StartsWith("$")) count++;
        Console.WriteLine("28: " + count);

        // 29. Faqat katta harfli stringlar
        List<string> str2 = new List<string> { "HELLO", "Hi", "WORLD", "TEST", "AbC" };
        Console.WriteLine("29:");
        foreach (var s in str2)
            if (s == s.ToUpper()) Console.WriteLine(s);

        // 30. Har bir juft sonni birinchi juft songa oshirish
        int? firstEven = null;
        foreach (int x in lst)
            if (x % 2 == 0) { firstEven = x; break; }
        if (firstEven != null)
            for (int i = 0; i < lst.Count; i++)
                if (lst[i] % 2 == 0) lst[i] += (int)firstEven;
        Console.WriteLine("30: " + string.Join(", ", lst));

        // 31. Har bir toq sonni oxirgi toq songa oshirish
        int? lastOdd = null;
        for (int i = lst.Count - 1; i >= 0; i--)
            if (lst[i] % 2 != 0) { lastOdd = lst[i]; break; }
        if (lastOdd != null)
            for (int i = 0; i < lst.Count; i++)
                if (lst[i] % 2 != 0) lst[i] += (int)lastOdd;
        Console.WriteLine("31: " + string.Join(", ", lst));

        // 32. Juft indeksli elementlar ichida minimal
        mn = lst[0];
        for (int i = 0; i < lst.Count; i += 2)
            if (lst[i] < mn) mn = lst[i];
        Console.WriteLine("32: " + mn);

        // 33. c[i] = max(a[i], b[i])
        c = new List<int>();
        for (int i = 0; i < a.Count; i++)
            c.Add(Math.Max(a[i], b[i]));
        Console.WriteLine("33: " + string.Join(", ", c));

        // 34. Juft elementlardan b list
        List<int> b_list = new List<int>();
        foreach (int x in lst)
            if (x % 2 == 0) b_list.Add(x);
        Console.WriteLine("34: soni=" + b_list.Count + ", list=" + string.Join(", ", b_list));
    }
}
