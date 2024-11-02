class Program
{
    static void Main()
    {
        Console.Write("Bir kelime girin: ");
        string kelime = Console.ReadLine();

        string tersKelime = TerstenYaz(kelime);

        Console.WriteLine("Ters yazılmış kelime: " + tersKelime);
    }

    static string TerstenYaz(string kelime)
    {
        char[] karakterler = kelime.ToCharArray();
        Array.Reverse(karakterler);
        return new string(karakterler);
    }
}