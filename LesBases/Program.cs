// // EXO 1 
using System;

// // class Program
// // {
// //     static void Main(string[] args)
// //     {
// //         Article article1 = new Article("A", 2.50, 12);
// //         Article article2 = new Article("B", 1.50, 11);

// //         article1.Afficher();
// //         article2.Afficher();


        
// //         article1.Ajouter(1);
// //         article1.Retirer(3);

// //         article2.Ajouter(2);
// //         article2.Retirer(1);

        
// //         // après modif
// //         article1.Afficher();
// //         article2.Afficher();

// //         // Demander à l'user 
// //         Console.WriteLine("\nSaisissez les informations pour un nouvel article :");
        
// //         // Saisie du nom
// //         Console.Write("Entrez le nom de l'article : ");
// //         string nom = Console.ReadLine();

// //         // Saisie du prix
// //         double prix = 0;
// //         bool prixValide = false;
// //         while (!prixValide)
// //         {
// //             Console.Write("Entrez le prix de l'article : ");
// //             string prixSaisie = Console.ReadLine();
// //             try
// //             {
// //                 // convertir le  prix
// //                 prix = Convert.ToDouble(prixSaisie); 
// //                 prixValide = true;
// //             }
// //             catch (FormatException)
// //             {
// //                 Console.WriteLine("Erreur : Veuillez entrer un prix valide.");
// //             }
// //         }

// //         // Saisir  la quantité
// //         int quantite = 0;
// //         bool quantiteValide = false;
// //         while (!quantiteValide)
// //         {
// //             Console.Write("Entrez la quantité de l'article : ");
// //             string quantiteSaisie = Console.ReadLine();
// //             try
// //             {
// //                 // Conversion de la quantité
// //                 quantite = Convert.ToInt32(quantiteSaisie); 
// //                 quantiteValide = true;
// //             }
// //             catch (FormatException)
// //             {
// //                 Console.WriteLine("Erreur : Veuillez entrer une quantité valide.");
// //             }
// //         }

// //         // Création du nouvel article
// //         Article nouvelArticle = new Article(nom, prix, quantite);

// //         // Affichage du nouvel article
// //         Console.WriteLine("\nNouvel article créé :");
// //         nouvelArticle.Afficher();
// //     }

// // }

// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         // Création de deux articles
//         ArticleType article1 = new ArticleType("Short", 1.50, 50, TypeArticle.Habillement);
//         ArticleType article2 = new ArticleType("Kiwi", 2.20, 30, TypeArticle.Alimentaire);

//         // infos initiales
//         Console.WriteLine("Articles avant la modification :");
//         article1.Afficher();
//         article2.Afficher();

//         // Modification des quantités
//         article1.ModifierQuantite(10);
//         article2.ModifierQuantite(50);

//         // infos après modification
//         Console.WriteLine("\nArticles après la modification :");
//         article1.Afficher();
//         article2.Afficher();

//         // Test 
//         Console.WriteLine("\nCréer un nouvel article :");
//         Console.Write("Entrez le nom : ");
//         string nom = Console.ReadLine();

//         Console.Write("Entrez le prix : ");
//         double prix = Convert.ToDouble(Console.ReadLine());

//         Console.Write("Entrez la quantité : ");
//         int quantite = Convert.ToInt32(Console.ReadLine());

//         Console.WriteLine("Entrez le type (Alimentaire, Droguerie, Habillement, Loisir) : ");
//         string typeString = Console.ReadLine();

//         // conversion de la saisie en énumération
//         TypeArticle type = (TypeArticle)Enum.Parse(typeof(TypeArticle), typeString);

//         // Création de l'article basé sur la saisie
//         ArticleType nouvelArticle = new ArticleType(nom, prix, quantite, type);

//         // Afficher l'article 
//         Console.WriteLine("\nNouvel article créé :");
//         nouvelArticle.Afficher();
//     }
// }




        // Exo dernier
        Console.WriteLine("\nGestion d'un tableau d'articles :");
        var tableau = new LesBases.ArticleTableau();
        tableau.AfficherTableau();