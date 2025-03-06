using System;

public class Meyve
{
    public string Ad;
    public int Fiyat;
}

public class Araba
{
    public string Marka;
    public int Yil;
    public string Renk;
    public int Fiyat;
}

public class Users
{
    public string Name;
    public string LastName;
    public int Age;
}

public class OyuncakKutusu
{
    private string oyuncak; // Oyuncağı saklayan gizli yer

    public string Oyuncak
    {
        get { return oyuncak; }  // Oyuncağı göstermek için
        set { oyuncak = value; } // Oyuncağı değiştirmek için
    }
}

public class Ogrenci
{
    public string Ad;
    public string Soyad;        
    public int Yas;
}

public class Stok
{
    public int Miktar;
    public string UrunAdi;
    public int Fiyat;
    public string UrunKodu;
    public string UrunAciklamasi;
}

class Program
{
    static void Main()
    {
        // Oyuncak Kutusu Kullanımı
        OyuncakKutusu kutu = new OyuncakKutusu
        {
            Oyuncak = "Kitap"
        };
        Console.WriteLine(kutu.Oyuncak);

        // Stok Kullanımı
        Stok stok = new Stok
        {
            Miktar = 100,
            UrunAdi = "Bilgisayar",
            Fiyat = 1000,
            UrunKodu = "B001",
            UrunAciklamasi = "Gaming Bilgisayar"
        };

        Console.WriteLine(stok.Miktar);
        Console.WriteLine(stok.UrunAdi);
        Console.WriteLine(stok.Fiyat);
        Console.WriteLine(stok.UrunKodu);
        Console.WriteLine(stok.UrunAciklamasi);

        // Araba Kullanımı
        Araba araba = new Araba
        {
            Marka = "Ford",
            Yil = 2010,
            Renk = "Beyaz",
            Fiyat = 10000
        };

        Console.WriteLine(araba.Marka);
        Console.WriteLine(araba.Yil);
        Console.WriteLine(araba.Renk);
        Console.WriteLine(araba.Fiyat);

        // Ogrenci Kullanımı
        Ogrenci ogrenci = new Ogrenci
        {
            Ad = "Ali",
            Soyad = "Veli",
            Yas = 20
        };
        Console.WriteLine(ogrenci.Ad);
        Console.WriteLine(ogrenci.Soyad);
        Console.WriteLine(ogrenci.Yas);

        // Users Kullanımı
        Users user = new Users
        {
            Name = "Derya",
            LastName = "Bilmem", 
            Age = 20
        };
        Console.WriteLine(user.Name);
        Console.WriteLine(user.LastName);
        Console.WriteLine(user.Age);

        // Meyve Kullanımı
        Meyve meyve = new Meyve
        {
            Ad = "Kayısı",
            Fiyat = 5
        };
        Console.WriteLine(meyve.Ad);
        Console.WriteLine(meyve.Fiyat);
    }
}
