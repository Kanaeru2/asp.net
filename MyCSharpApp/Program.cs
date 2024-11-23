using System;

class Program
{
    static void Main(string[] args)
    {
        // Menampilkan pesan ke konsol
        Console.WriteLine("Hello, World!");
        // Menampilkan pesan personalisasi
        Console.WriteLine("Halo, Kobo!");

        int umur = 15;
        string hasil = CheckUmur(umur);
        Console.WriteLine(hasil);
        
        if (hasil == "Masih Muda")
        {
        Person person = new Person();
        person.name = "Daffa";
        person.age = 15;

        person.Greet();
        }
        else if (hasil == "imut")
        {
            Console.WriteLine("Main YUK sama Adek aku");
        }
        else
        {
            Console.WriteLine("Yang penting Imut");
        }

       
    }

    // Mengubah tipe return menjadi string
    static string CheckUmur(int umur)
    {
        if (umur < 6)
        {
            return "Imut";  // Perbaikan: menggunakan return dengan titik koma
        } 
        else if (umur <= 15)
        {
            return "Masih Muda";  // Perbaikan: menggunakan return dengan titik koma
        }
        else 
        {
            return "Yang penting Imut";  // Perbaikan: menambahkan return
        }
    }
}
class Person
{
  public string name { get; set;}
  public int age { get; set;}

  public void Greet()
  {
           Console.WriteLine("Halo, nama saya " + name + " dan saya berusia " + age + " tahun.");
  }
  

}