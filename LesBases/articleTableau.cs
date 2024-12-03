using System;
namespace LesBases {
public class ArticleTableau
{
    private Article[] Articles;

    public ArticleTableau()
    {
        Articles = new Article[]
        {
            new Livre("Livre", 12.99, 5, "123-456", 200),
            new Disque("Disque ", 9.99, 3, "Label "),
            new Video("Vidéo ", 19.99, 2, 120)
        };
    }

    public void AfficherTableau()
    {
        Console.WriteLine("Les articles sont :");
        foreach (var article in Articles)
        {
            article.Afficher();
            Console.WriteLine();
        }
    }
}
}