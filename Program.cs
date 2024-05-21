using System.Xml.XPath;

class Program
{
    public static void Main(string[] args)
    {
        // Task Number 1
        Console.WriteLine("Soal Nomor 1");
        Console.Write("Masukkan Nilai n: ");
        string? input1 = Console.ReadLine();
        if(Int32.TryParse(input1, out int n))
        {
            Console.Write("Result: ");
            OkYesNumber(n);
        } else 
        {
            Console.WriteLine("input is not a number");
        }

        // Task Number 2
        Console.WriteLine("Soal Nomor 2");
        Console.Write("Masukkan Nilai n: ");
        string? input2 = Console.ReadLine();
        if(Int32.TryParse(input2, out int n2))
        {
            Console.Write("Result: ");
            PyramidNumA(n2);
            Console.WriteLine("--------------------------------");
            PyramidNumB(n2);
            Console.WriteLine("--------------------------------");
            PyramidNumC(n2);
            Console.WriteLine("--------------------------------");
            PyramidNumD(n2);
        } else 
        {
            Console.WriteLine("input is not a number");
        }

        // Task Number 3
        Console.WriteLine("Soal Nomor 3");
        int[] x = {12, 9, 13, 6, 10, 4, 7, 2};
        MultipleOfThreeRemover(x);

    }

    // Algoritma Angka 1 sd n dengan ketentuan kelipatan 3 diganti "OK", kelipatan 4 diganti "YES", kelipatan 3 & 4 diganti "OKEYES"
    private static void OkYesNumber(int n)
    {
        for(int i = 1; i <= n; i++)
        {
            if (i % 3 == 0 && i % 4 == 0)
            {
                Console.Write("OKYES");
            } 
            else if (i % 3 == 0)
            {
                Console.Write("OK");
            } 
            else if (i % 4 == 0)
            {
                Console.Write("YES");
            }
            else
            {
                Console.Write(i);
            }
            Console.Write(" ");
        }
        Console.WriteLine();
    }

    // Algoritma Piramida Angka
    // Piramida Angka tipe A
    private static void PyramidNumA(int n)
    {
        Console.WriteLine("Pyramid Type A");
        for(int i = 1; i <= n; i++)
        {
            for(int j = 0; j < i; j++)
            {
                Console.Write($"{i}");
            }
            Console.WriteLine();
        }
    }

    // Piramida Angka tipe B
    private static void PyramidNumB(int n)
    {
        Console.WriteLine("Pyramid Type B");
        for(int i = 1; i <= n; i++)
        {
            for(int j = i; j >= 1; j--)
            {
                Console.Write($"{j}");
            }
            Console.WriteLine();
        }
    }

    // Piramida Angka tipe C
    private static void PyramidNumC(int n)
    {
        Console.WriteLine("Pyramid Type C");
        bool isReverse = false;
        int count = 1;
        for(int i = 1; i <= n; i++)
        {
            for(int j = 1; j <= i; j++)
            {
                if(count == n)
                {
                    isReverse = true;
                }
                if(count == 1)
                {
                    isReverse = false;
                }
                Console.Write(count);
                if(isReverse)
                {
                    count--;
                }else{
                    count++;
                }
            }
            Console.WriteLine();
        }
    }

    // Piramida Angka tipe D
    private static void PyramidNumD(int n)
    {
        Console.WriteLine("Pyramid Type D");
        int count;
        for(int i = 0; i < n;i++)
        {
            count = i;
            for(int j = 1;j <= n; j++)
            {
                if(j == 1)
                {
                    count = i+1;
                } else {
                    if(j % 2 == 0)
                    {
                        count = j * n;
                        count -= i;
                    } else {
                        count += 2*i+1;
                    }
                }
                Console.Write(count);
                Console.Write(" ");
            }
            Console.WriteLine();
        }
    }

    // Algoritma untuk membuang nilai kelipatan 3 dari Array dan mengurutkan hasilnya secara Ascending
    public static void MultipleOfThreeRemover(int[] nArray)
    {
        var list = new List<int>();
        foreach(int n in nArray)
        {
            if(n % 3 != 0)
            {
                list.Add(n);
            }
        }
        var numbers = list.ToArray();
        Array.Sort(numbers);
        Console.Write("n = [ ");
        foreach(var num in numbers)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine("]");
    }
}