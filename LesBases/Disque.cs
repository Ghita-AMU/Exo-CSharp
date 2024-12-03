using System;

public class Disque : LesBases.Article
{
    protected string Label;

    public Disque(string designation, double prix, int quantite, string label)
        : base(designation, prix, quantite)
    {
        Label = label;
    }

    public void Ecouter(object Designation)
    {
        Console.WriteLine($"Vous écoutez le disque: {Designation} - {Label}");
    }

    public new void Afficher()
    {
        base.Afficher();
        Console.WriteLine($"Label: {Label}");
    }
}