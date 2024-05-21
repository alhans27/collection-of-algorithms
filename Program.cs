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
        Console.WriteLine("");
    }
}