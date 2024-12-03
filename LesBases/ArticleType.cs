using System;

struct ArticleType
{
    public string Nom;
    public double Prix;
    public int Quantite;
    public TypeArticle Type; 

    // Constructeur
    public ArticleType(string nom, double prix, int quantite, TypeArticle type)
    {
        Nom = nom;
        Prix = prix;
        Quantite = quantite;
        Type = type;
    }

    // Méthode afficher
    public void Afficher()
    {
        Console.WriteLine($"Nom: {Nom}, Prix: {Prix}euro, Quantité: {Quantite}, TypeArticle: {Type}");
    }

    //Méthode modifier 
    public void ModifierQuantite(int nouvelleQuantite)
{
    int ancienneQuantite = Quantite;  
    Quantite = nouvelleQuantite;     

    Console.WriteLine($"L'ancienne quantité de l'article '{Nom}' était : {ancienneQuantite}. " +
                      $"La nouvelle quantité est : {Quantite}.");
}

}
