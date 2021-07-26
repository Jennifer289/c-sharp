using System;

public class Loro: Aves
{
    public string Orden { get; set; }
    public string Familia { get; set; }

    public void Hablan()
    {
        Console.WriteLine("se comunican con los demás e imitando todos los sonidos que escucha");
    }

    public void Pico()
    {
        DescribirPico();
    }

    private void DescribirPico()
    {
        Console.WriteLine("Posee una curvatura y es duro, Las aves no tienen dientes tragan su alimento entero");

    }

 }