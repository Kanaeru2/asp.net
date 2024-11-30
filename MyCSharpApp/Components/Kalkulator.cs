using System;

namespace MyCSharpApp.Components
{
    public class Kalkulator
    {
        public double Tambah(double a, double b) => a + b;
        public double Kurang(double a, double b) => a - b;
        public double Kali(double a, double b) => a * b;

        public double Bagi(double a, double b)
        {
            if (b == 0)
                throw new DivideByZeroException("Tidak bisa membagi dengan nol.");
            return a / b;
        }

        public double AkarKuadrat(double a)
        {
            if (a < 0)
                throw new ArgumentException("Akar kuadrat dari bilangan negatif tidak valid.");
            return Math.Sqrt(a);
        }

        public double Pangkat(double a, double b) => Math.Pow(a, b);

        public long Faktorial(int n)
        {
            if (n < 0)
                throw new ArgumentException("Faktorial dari bilangan negatif tidak valid.");
            return n == 0 ? 1 : n * Faktorial(n - 1);
        }
    }
}
