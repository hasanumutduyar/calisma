Console.Write("1. sayıyı girin = ");
int sayi1 = Convert.ToInt32(Console.ReadLine());

Console.Write("2. sayıyı girin = ");
int sayi2 = Convert.ToInt32(Console.ReadLine());

int kare = (sayi1 * sayi1 + sayi2 * sayi2);

Console.WriteLine($"İki sayının kareleri toplamı = {kare}");