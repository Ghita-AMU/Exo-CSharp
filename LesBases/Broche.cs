public class Broche : LesBases.Livre
{
    public Broche(string designation, double prix, int quantite, string isbn, int nbPages)
        : base(designation,
            prix,
            quantite,
            isbn,
            nbPages)
    {
    }

    public new void Afficher()
    {
        base.Afficher();
        Console.WriteLine($"Type: Livre broché");
    }
}