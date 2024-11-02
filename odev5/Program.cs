using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main()
    {
        Console.Write("Bir sayı giriniz = ");
        string girilenSayi = Console.ReadLine();

        int basamakSayisi = BasamakSayisiniBul(girilenSayi);

        Console.WriteLine("Girilen sayı " + basamakSayisi + " basamaklıdır.");

    }


    static int BasamakSayisiniBul(string sayi)
    {
        if (sayi.StartsWith("-")) { sayi = sayi.Substring(1); }
        return sayi.Length;
    }
}