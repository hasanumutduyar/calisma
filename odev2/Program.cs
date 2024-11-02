Console.Write("Bir sayı giriniz = ");

int sayi = Convert.ToInt32(Console.ReadLine());
int faktoriyel = 1;

for (int i = sayi; i >= 2; i--)
{
    faktoriyel *= i; 
}

Console.WriteLine($"{sayi} sayısının faktöriyeli = {faktoriyel}");