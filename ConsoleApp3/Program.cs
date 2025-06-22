class Program
{
    static void Main()
    {

        // Kullanıcıya soru sor
        Console.Write("Kübra manavına hoşgeldiniz!");

        Console.Write("Hangi meyveyi satın almak istiyorsunuz? ");
        string meyve = Console.ReadLine().ToLower(); // Küçük harfe çevirerek karşılaştırma yapıyoruz

        int fiyat;

        switch (meyve)
        {
            case "elma":
                fiyat = 2;
                break;
            case "armut":
                fiyat = 3;
                break;
            case "çilek":
                fiyat = 2;
                break;
            case "muz":
                fiyat = 3;
                break;
            default:
                fiyat = 4; // Diğer bütün meyveler
                break;
        }

        // Sonucu ekrana yazdır
        Console.WriteLine($"{meyve} fiyatı: {fiyat} TL");

        // Program hemen kapanmasın diye bekletme
        Console.WriteLine("Çıkmak için bir tuşa basınız...");
        Console.ReadKey();
    }
}