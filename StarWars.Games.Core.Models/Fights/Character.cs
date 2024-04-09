namespace StarWars.Games.Core.Models.Fights;

//public class Character
//{
//    #region Constructors
//    public Character(int id, string prenom)
//    {
//        this.Id = id;
//        this.Prenom = prenom;
//    }

//    #endregion

//    #region Properties
//    public int Id { get; }
//    public string Prenom { get; set; } = string.Empty;
//    #endregion
//}

public class Character(int id, string prenom) //dotnet 8 // C# 12
{
    #region Constructors
    public Character(int id, string prenom, int taille) : this(id, prenom)
    {

    }

    public Character() : this(0, "")
    {

    }
    #endregion

    #region Properties
    public int Id { get; } = id;
    public string Prenom { get; set; } = prenom;
    #endregion
}

