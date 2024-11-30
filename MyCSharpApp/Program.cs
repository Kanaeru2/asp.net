using System;
using MyCSharpApp.Components;

class Program
{
    static void Main(string[] args)
    {
        var kalkulator = new Kalkulator();
        bool running = true;

        while (running)
        {
            Console.Clear();
            Console.WriteLine("=== Mini Kalkulator Interaktif ===");
            Console.WriteLine("1. Penjumlahan");
            Console.WriteLine("2. Pengurangan");
            Console.WriteLine("3. Perkalian");
            Console.WriteLine("4. Pembagian");
            Console.WriteLine("5. Akar Kuadrat");
            Console.WriteLine("6. Pangkat");
            Console.WriteLine("7. Faktorial");
            Console.WriteLine("0. Keluar");
            Console.Write("Pilih operasi (0-7): ");
            string pilihan = Console.ReadLine() ?? string.Empty;

            try
            {
                switch (pilihan)
                {
                    case "1":
                        OperasiDuaAngka("Penjumlahan", kalkulator.Tambah);
                        break;
                    case "2":
                        OperasiDuaAngka("Pengurangan", kalkulator.Kurang);
                        break;
                    case "3":
                        OperasiDuaAngka("Perkalian", kalkulator.Kali);
                        break;
                    case "4":
                        OperasiDuaAngka("Pembagian", kalkulator.Bagi);
                        break;
                    case "5":
                        Console.Write("Masukkan angka: ");
                        double akarInput = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"Hasil: {kalkulator.AkarKuadrat(akarInput)}");
                        break;
                    case "6":
                        Console.Write("Masukkan basis: ");
                        double basis = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Masukkan pangkat: ");
                        double eksponen = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"Hasil: {kalkulator.Pangkat(basis, eksponen)}");
                        break;
                    case "7":
                        Console.Write("Masukkan angka: ");
                        int faktorialInput = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"Hasil: {kalkulator.Faktorial(faktorialInput)}");
                        break;
                    case "0":
                        running = false;
                        Console.WriteLine("Keluar dari program. Terima kasih!");
                        break;
                    default:
                        Console.WriteLine("Pilihan tidak valid. Coba lagi.");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            if (running)
            {
                Console.WriteLine("\nTekan Enter untuk melanjutkan...");
                Console.ReadLine();
            }
        }
    }

    static void OperasiDuaAngka(string operasi, Func<double, double, double> func)
    {
        Console.Write($"Masukkan angka pertama untuk {operasi}: ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.Write($"Masukkan angka kedua untuk {operasi}: ");
        double b = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"Hasil {operasi}: {func(a, b)}");
    }
}
