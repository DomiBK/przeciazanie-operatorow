using System;
using System.Collections.Generic;

public class Produkt
{
    public string Nazwa { get; set; }
    public decimal Cena { get; set; }
    public int Ilość { get; set; }

    public Produkt(string nazwa, decimal cena, int ilość)
    {
        Nazwa = nazwa;
        Cena = cena;
        Ilość = ilość;
    }

    public void WyswietlInformacje()
    {
        Console.WriteLine($"Nazwa: {Nazwa}, Cena: {Cena}, Ilość: {Ilość}");
    }

    public static bool operator ==(Produkt produkt1, Produkt produkt2)
    {
        return produkt1.Cena == produkt2.Cena;
    }

    public static bool operator !=(Produkt produkt1, Produkt produkt2)
    {
        return produkt1.Cena != produkt2.Cena;
    }

    public static bool operator <(Produkt produkt1, Produkt produkt2)
    {
        return produkt1.Cena < produkt2.Cena;
    }

    public static bool operator >(Produkt produkt1, Produkt produkt2)
    {
        return produkt1.Cena > produkt2.Cena;
    }

    public static Produkt operator ++(Produkt produkt)
    {
        produkt.Ilość++;
        return produkt;
    }

    public static Produkt operator --(Produkt produkt)
    {
        if (produkt.Ilość > 0)
            produkt.Ilość--;
        return produkt;
    }
}

public class Magazyn
{
    public string Nazwa { get; set; }
    public List<Produkt> Produkty { get; set; }

    public Magazyn(string nazwa)
    {
        Nazwa = nazwa;
        Produkty = new List<Produkt>();
    }

    public void DodajProdukt(Produkt produkt)
    {
        Produkty.Add(produkt);
    }

    public void WyswietlProdukty()
    {
        foreach (var produkt in Produkty)
        {
            produkt.WyswietlInformacje();
        }
    }

    public void SortujProdukty()
    {
        Produkty.Sort((x, y) => x.Cena.CompareTo(y.Cena));
    }
}

class Program
{
    static void Main(string[] args)
    {
        Produkt produkt1 = new Produkt("Laptop", 11500, 1);
        Produkt produkt2 = new Produkt("Smartfon", 1500, 10);

        Console.WriteLine("Czy cena produktów jest taka sama? " + (produkt1 == produkt2));
        Console.WriteLine("Czy cena produktów jest różna? " + (produkt1 != produkt2));
        Console.WriteLine("Czy cena produktu 1 jest niższa od ceny produktu 2? " + (produkt1 < produkt2));
        Console.WriteLine("Czy cena produktu 1 jest wyższa od ceny produktu 2? " + (produkt1 > produkt2));

        Console.WriteLine("Ilość produktu 1 przed inkrementacją: " + produkt1.Ilość);
        produkt1++;
        Console.WriteLine("Ilość produktu 1 po inkrementacji: " + produkt1.Ilość);
        produkt1--;
        Console.WriteLine("Ilość produktu 1 po dekrementacji: " + produkt1.Ilość);

        Magazyn magazyn = new Magazyn("Sklep");

        magazyn.DodajProdukt(produkt1);
        magazyn.DodajProdukt(produkt2);

        Console.WriteLine("Produkty przed sortowaniem:");
        magazyn.WyswietlProdukty();

        magazyn.SortujProdukty();

        Console.WriteLine("Produkty po sortowaniu:");
        magazyn.WyswietlProdukty();
    }
}

