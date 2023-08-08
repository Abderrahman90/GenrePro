using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //cette technique n'est pas top car on prédéfinit le champ genre
            //le mieux que je veux sur la cosnole c'est de laisser l'utilisateur interagir: IHM (interface homme machine)
            //je retire donc ce choix par défaut string genre = "autre";
            Console.WriteLine(" dites nous c'est quoi le genre que vous êtes homme, femme ou R");
            string genre = Console.ReadLine();
            string result = Conjugaison(genre);
            Console.WriteLine("Pour le genre " + genre + " la conjugaison est : " + result);
          
        }
    
    static string Conjugaison(string genre)
    {
        //Vérifier si l'argument est null ou vide
        if (string.IsNullOrEmpty(genre))
        {
            throw new ArgumentException("Le genre ne peut pas être null ou vide", nameof(genre));
        }
        //utilisation d'un switch pour traiter plusieurs cas d'entrée possible
        switch (genre.ToLower())
        {
            case "homme":
                return "é";
            case "femme":
                return "ée";
            default:
                return "ni homme ni femme";
        }
    
}
    }
    }
