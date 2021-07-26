using System;

public class PezGlobo: Peces
{
    public string Piel { get; set; }

    public void Incharse()
    {
        Console.WriteLine("Incharse como globo");
    }

    public void Venenosa()
    {
        SonVenenosa();
    }

    private void SonVenenosa()
    {
        Console.WriteLine("Son Venenosas con tocar una de sus puas ");
    }
}