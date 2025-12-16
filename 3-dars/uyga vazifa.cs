
                                                                //1.3.1 homework

  using System;                                     
class Program
{
    static void Main()
    {
        // 1
        for (int i = 1; i <= 20; i++)
            Console.Write(i + " ");
        Console.WriteLine("\n--------------------------------");

        // 2
        for (int i = 25; i <= 100; i++)
            Console.Write(i + " ");
        Console.WriteLine("\n--------------------------------");

        // 3
        for (int i = 12; i <= 200; i++)
            Console.Write(i + " ");
        Console.WriteLine("\n--------------------------------");

        // 4
        for (int i = 15; i >= 2; i--)
            Console.Write(i + " ");
        Console.WriteLine("\n--------------------------------");

        // 5
        for (int i = 120; i >= 23; i--)
            Console.Write(i + " ");
        Console.WriteLine("\n--------------------------------");

        // 6 – toq sonlar
        for (int i = 10; i <= 50; i++)
            if (i % 2 != 0) Console.Write(i + " ");
        Console.WriteLine("\n--------------------------------");

        // 7 – juft sonlar
        for (int i = 120; i <= 250; i++)
            if (i % 2 == 0) Console.Write(i + " ");
        Console.WriteLine("\n--------------------------------");

        // 8
        for (int i = 100; i >= 50; i--)
            if (i % 2 != 0) Console.Write(i + " ");
        Console.WriteLine("\n--------------------------------");

        // 9
        for (int i = 80; i >= 20; i--)
            if (i % 2 == 0) Console.Write(i + " ");
        Console.WriteLine("\n--------------------------------");

        // 10 – 5 ga karrali
        int a = 5, b = 60;
        for (int i = a; i <= b; i++)
            if (i % 5 == 0) Console.Write(i + " ");
        Console.WriteLine("\n--------------------------------");

        // 11 – 4 va 7 ga karrali => 28
        for (int i = a; i <= b; i++)
            if (i % 28 == 0) Console.Write(i + " ");
        Console.WriteLine("\n--------------------------------");

        // 12 – 8 ga karrali sonlar soni
        int count8 = 0;
        for (int i = a; i <= b; i++)
            if (i % 8 == 0) count8++;
        Console.WriteLine("8 ga karrali sonlar soni: " + count8);
        Console.WriteLine("--------------------------------");

        // 13 – 9 yoki 5 ga bo'linadiganlar
        for (int i = b; i >= a; i--)
            if (i % 9 == 0 || i % 5 == 0) Console.Write(i + " ");
        Console.WriteLine("\n--------------------------------");

        // 14 – 1..100 toq sonlar yig'indisi
        int sumOdd = 0;
        for (int i = 1; i <= 100; i++)
            if (i % 2 != 0) sumOdd += i;
        Console.WriteLine("Toq sonlar yig'indisi: " + sumOdd);
        Console.WriteLine("--------------------------------");

        // 15 – 3 xonali sonlar, raqamlar yig'indisi > 20
        for (int i = 100; i <= 999; i++)
        {
            int x = i, s = 0;
            while (x > 0) { s += x % 10; x /= 10; }
            if (s > 20) Console.Write(i + " ");
        }
        Console.WriteLine("\n--------------------------------");

        // 16 – 3 xonali palindromlar
        for (int i = 100; i <= 999; i++)
        {
            int t = i;
            int r = 0;
            int x = i;
            while (x > 0)
            {
                r = r * 10 + x % 10;
                x /= 10;
            }
            if (r == t) Console.Write(i + " ");
        }
        Console.WriteLine("\n--------------------------------");

        // 17 – 2 xonali, raqamlar ko'paytmasi > 12
        int cnt = 0, sum = 0;
        for (int i = 10; i <= 99; i++)
        {
            int d1 = i / 10, d2 = i % 10;
            if (d1 * d2 > 12)
            {
                cnt++;
                sum += i;
            }
        }
        Console.WriteLine("Miqdori: " + cnt);
        Console.WriteLine("Yig'indisi: " + sum);
        Console.WriteLine("--------------------------------");

        // 18 – o‘nlar xonasi 2 yoki 5 bo'lgan 3 xonali sonlar
        for (int i = 100; i <= 999; i++)
        {
            int tens = (i / 10) % 10;
            if (tens == 2 || tens == 5) Console.Write(i + " ");
        }
        Console.WriteLine("\n--------------------------------");

        // 19 – a soni a marta
        int aa = 7;
        for (int i = 0; i < aa; i++)
            Console.Write(aa + " ");
        Console.WriteLine("\n--------------------------------");

        // 20 – a sonini b marta
        for (int i = 0; i < b; i++)
            Console.Write(a + " ");
        Console.WriteLine("\n--------------------------------");

        // 21 – b sonini a marta
        for (int i = 0; i < a; i++)
            Console.Write(b + " ");
        Console.WriteLine("\n--------------------------------");

        // 22 – a bo‘luvchilari
        int A = 36;
        for (int i = 1; i <= A; i++)
            if (A % i == 0) Console.Write(i + " ");
        Console.WriteLine("\n--------------------------------");

        // 23 – bo‘luvchilar soni
        int cntDiv = 0;
        for (int i = 1; i <= A; i++)
            if (A % i == 0) cntDiv++;
        Console.WriteLine("Bo'luvchilar soni: " + cntDiv);
        Console.WriteLine("--------------------------------");

        // 24 – bo‘luvchilar yig'indisi
        int sumDiv = 0;
        for (int i = 1; i <= A; i++)
            if (A % i == 0) sumDiv += i;
        Console.WriteLine("Bo'luvchilar yig'indisi: " + sumDiv);
        Console.WriteLine("--------------------------------");

        // 25 – tub son tekshirish
        int T = 37;
        bool prime = true;
        for (int i = 2; i * i <= T; i++)
            if (T % i == 0)
            {
                prime = false;
                break;
            }
        Console.WriteLine("Tubmi? " + prime);
        Console.WriteLine("--------------------------------");

        // 26 – 2 ta son
        int x1 = 11, x2 = 13;
        bool p1 = true, p2 = true;
        for (int i = 2; i * i <= x1; i++) if (x1 % i == 0) p1 = false;
        for (int i = 2; i * i <= x2; i++) if (x2 % i == 0) p2 = false;

        if (p1 && p2) Console.WriteLine("Yig'indisi: " + (x1 + x2));
        else Console.WriteLine("Ko'paytma: " + (x1 * x2));
        Console.WriteLine("--------------------------------");

        // 27 – 3..60 kg shakar
        for (int i = 3; i <= 60; i++)
            Console.WriteLine($"{i} kg = {i * 7000} so'm");
        Console.WriteLine("--------------------------------");

        // 28 – 23 dan n gacha 3 ga bo'linmaydiganlar
        int n = 50;
        int c28 = 0;
        for (int i = 23; i <= n; i++)
            if (i % 3 != 0)
            {
                Console.Write(i + " ");
                c28++;
            }
        Console.WriteLine("\nSoni: " + c28);
        Console.WriteLine("--------------------------------");

        // 29 – qaysi sonning bo'luvchisi ko'proq
        int a29 = 24, b29 = 36;
        int da = 0, db = 0;
        for (int i = 1; i <= a29; i++) if (a29 % i == 0) da++;
        for (int i = 1; i <= b29; i++) if (b29 % i == 0) db++;

        Console.WriteLine($"{a29} bo'luvchilari: {da}");
        Console.WriteLine($"{b29} bo'luvchilari: {db}");
        Console.WriteLine(da > db ? "a ko'p" : db > da ? "b ko'p" : "teng");
        Console.WriteLine("--------------------------------");

        // 30 – a dan b gacha yig'indi (a va b kirmaydi)
        int A30 = 3, B30 = 10;
        int s30 = 0;
        for (int i = A30 + 1; i < B30; i++)
            s30 += i;
        Console.WriteLine("Yig'indi: " + s30);

    }
}
                                                                         //1.3.3 homework
using System;

class Program
{
    static void Main()
    {
        // 1
        for (int i = 14; i <= 20; i++)
            Console.Write(i + " ");
        Console.WriteLine("\n------------------------------");

        // 2
        for (int i = 11; i <= 99; i++)
            Console.Write(i + " ");
        Console.WriteLine("\n------------------------------");

        // 3
        for (int i = 12; i <= 200; i++)
            Console.Write(i + " ");
        Console.WriteLine("\n------------------------------");

        // 4
        for (int i = 25; i >= 10; i--)
            Console.Write(i + " ");
        Console.WriteLine("\n------------------------------");

        // 5
        for (int i = 500; i >= 80; i--)
            Console.Write(i + " ");
        Console.WriteLine("\n------------------------------");

        // 6
        for (int i = 11; i <= 88; i++)
            if (i % 2 != 0) Console.Write(i + " ");
        Console.WriteLine("\n------------------------------");

        // 7
        for (int i = 12; i <= 25; i++)
            if (i % 2 == 0) Console.Write(i + " ");
        Console.WriteLine("\n------------------------------");

        // 8
        for (int i = 15; i <= 88; i++)
            if (i % 2 != 0) Console.Write(i + " ");
        Console.WriteLine("\n------------------------------");

        // 9
        for (int i = 99; i >= 10; i--)
            if (i % 2 == 0) Console.Write(i + " ");
        Console.WriteLine("\n------------------------------");

        // 10
        int a = 5, b = 50;
        for (int i = a; i <= b; i++)
            if (i % 3 == 0) Console.Write(i + " ");
        Console.WriteLine("\n------------------------------");

        // 11
        for (int i = a; i <= b; i++)
            if (i % 5 == 0 && i % 6 == 0) Console.Write(i + " ");
        Console.WriteLine("\n------------------------------");

        // 12
        int count10 = 0;
        for (int i = a; i <= b; i++)
            if (i % 10 == 0) count10++;
        Console.WriteLine("10 ga karralilar soni: " + count10);
        Console.WriteLine("------------------------------");

        // 13
        for (int i = b; i >= a; i--)
            if (i % 7 == 0 || i % 8 == 0) Console.Write(i + " ");
        Console.WriteLine("\n------------------------------");

        // 14
        int sumEven = 0;
        for (int i = 1; i <= 100; i++)
            if (i % 2 == 0) sumEven += i;
        Console.WriteLine("Juft sonlar yig'indisi: " + sumEven);
        Console.WriteLine("------------------------------");

        // 15
        for (int i = 100; i <= 999; i++)
        {
            int x = i, s = 0;
            while (x > 0) { s += x % 10; x /= 10; }
            if (s > 18) Console.Write(i + " ");
        }
        Console.WriteLine("\n------------------------------");

        // 16 – palindrom
        for (int i = 100; i <= 999; i++)
        {
            int t = i, r = 0, x = i;
            while (x > 0)
            {
                r = r * 10 + x % 10;
                x /= 10;
            }
            if (r == t) Console.Write(i + " ");
        }
        Console.WriteLine("\n------------------------------");

        // 17
        int cnt = 0, sum = 0;
        for (int i = 10; i <= 99; i++)
        {
            int a1 = i / 10, a2 = i % 10;
            if (a1 * a2 > 15)
            {
                cnt++;
                sum += i;
            }
        }
        Console.WriteLine("Soni: " + cnt);
        Console.WriteLine("Yig'indisi: " + sum);
        Console.WriteLine("------------------------------");

        // 18
        for (int i = 100; i <= 999; i++)
        {
            int tens = (i / 10) % 10;
            if (tens == 4 || tens == 7) Console.Write(i + " ");
        }
        Console.WriteLine("\n------------------------------");

        // 19
        int A19 = 7;
        for (int i = 0; i < A19; i++)
            Console.Write(A19 + " ");
        Console.WriteLine("\n------------------------------");

        // 20
        for (int i = 0; i < b; i++)
            Console.Write(a + " ");
        Console.WriteLine("\n------------------------------");

        // 21
        for (int i = 0; i < a; i++)
            Console.Write(b + " ");
        Console.WriteLine("\n------------------------------");

        // 22
        int A22 = 48;
        for (int i = 1; i <= A22; i++)
            if (A22 % i == 0) Console.Write(i + " ");
        Console.WriteLine("\n------------------------------");

        // 23
        int countDiv = 0;
        for (int i = 1; i <= A22; i++)
            if (A22 % i == 0) countDiv++;
        Console.WriteLine("Bo'luvchilar soni: " + countDiv);
        Console.WriteLine("------------------------------");

        // 24
        int sumDiv = 0;
        for (int i = 1; i <= A22; i++)
            if (A22 % i == 0) sumDiv += i;
        Console.WriteLine("Bo'luvchilar yig'indisi: " + sumDiv);
        Console.WriteLine("------------------------------");

        // 25 – tub son
        int T = 37;
        bool prime = true;
        for (int i = 2; i * i <= T; i++)
            if (T % i == 0) prime = false;
        Console.WriteLine("Tubmi? " + prime);
        Console.WriteLine("------------------------------");

        // 26
        int x1 = 13, x2 = 17;
        bool p1 = true, p2 = true;
        for (int i = 2; i * i <= x1; i++) if (x1 % i == 0) p1 = false;
        for (int i = 2; i * i <= x2; i++) if (x2 % i == 0) p2 = false;

        if (p1 && p2) Console.WriteLine("Yig'indisi: " + (x1 + x2));
        else Console.WriteLine("Ko'paytma: " + (x1 * x2));
        Console.WriteLine("------------------------------");

        // 27 – shakar
        for (int i = 13; i <= 60; i++)
            Console.WriteLine($"{i} kg = {i * 4000} so'm");
        Console.WriteLine("------------------------------");

        // 28
        int n = 60;
        int count28 = 0;
        for (int i = 35; i <= n; i++)
            if (i % 3 != 0)
            {
                Console.Write(i + " ");
                count28++;
            }
        Console.WriteLine("\nSoni: " + count28);
        Console.WriteLine("------------------------------");

        // 29
        int a29 = 24, b29 = 36, da = 0, db = 0;
        for (int i = 1; i <= a29; i++) if (a29 % i == 0) da++;
        for (int i = 1; i <= b29; i++) if (b29 % i == 0) db++;
        Console.WriteLine(da > db ? "a ko'p bo'luvchiga ega" :
                         db > da ? "b ko'p bo'luvchiga ega" :
                         "Ikkisi teng");
        Console.WriteLine("------------------------------");

        // 30 — yig'indi
        int A30 = 5, B30 = 20, s30 = 0;
        for (int i = A30 + 1; i < B30; i++)
            s30 += i;
        Console.WriteLine("Yig'indi: " + s30);
        Console.WriteLine("------------------------------");

        // 31 — konfet narxi
        double price = 15000; 
        for (double i = 1.1; i <= 2; i += 0.1)
            Console.WriteLine($"{Math.Round(i,1)} kg = {Math.Round(i*price)} so'm");
        Console.WriteLine("------------------------------");

        // 32 — ildizlar
        int N = 20;
        for (int i = 0; i <= N; i++)
            Console.WriteLine($"{i} -> {Math.Sqrt(i)}");
        Console.WriteLine("------------------------------");

        // 33 — daraja
        int nn = 3, kk = 4, natija = 1;
        for (int i = 0; i < kk; i++)
            natija *= nn;
        Console.WriteLine($"{nn}^{kk} = {natija}");

    }
}
