

using System;

public class Video : LesBases.Article
{
    protected int Duree;

    public object Designation { get; private set; }

    public Video(string designation, double prix, int quantite, int duree)
        : base(designation, prix, quantite)
    {
        Duree = duree;
    }

    public void AfficherVideo()
    {
        Console.WriteLine($"Vous regardez la vidéo: {Designation} ({Duree} minutes)");
    }

    public new void Afficher()
    {
        base.Afficher();
        Console.WriteLine($"Durée: {Duree} minutes");
    }
}
