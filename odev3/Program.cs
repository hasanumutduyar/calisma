class Program
{
    static void Main()
    {
        Console.WriteLine("1 ile 100 arasındaki asal sayılar:");

        for (int sayi = 2; sayi <= 100; sayi++)
        {
            bool kontrol = true;

            // 2'den 'sayi - 1' kadar olan sayılarla bölünebilirliğini kontrol et
            for (int i = 2; i < sayi; i++)
            {
                if (sayi % i == 0)
                {
                    kontrol = false;
                    break; // Eğer bir bölen bulursa döngüyü kır
                }
            }

            // Eğer asal ise yazdır
            if (kontrol)
            {
                Console.WriteLine(sayi);
            }
        }
    }
}