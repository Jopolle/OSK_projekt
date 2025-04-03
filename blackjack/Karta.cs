using System;

public class Karta
{
    public string Kolor { get; set; } // Kier, Pik, Trefl, Karo
    public string Wartosc { get; set; } // As, 2, 3, ..., Król
    public int Punkty { get; set; } // 2-10, 10 dla figur, 1 lub 11 dla Asa

    public Karta(string kolor, string wartosc, int punkty)
    {
        Kolor = kolor;
        Wartosc = wartosc;
        Punkty = punkty;
    }

    public override string ToString()
    {
        return $"{Wartosc} of {Kolor}";
    }

    public string ToStringName()
    {
        return $"{Wartosc}_of_{Kolor}.png";
    }
}