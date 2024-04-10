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

public class Character(int id, string prenom) : IAttaquant //dotnet 8 // C# 12
{
    #region Constructors
    public Character(int id, string prenom, int taille) : this(id, prenom)
    {

    }

    public Character() : this(0, "")
    {

    }
    #endregion

    #region Public methods
    /// <summary>
    /// 
    /// </summary>
    /// <param name="autre"></param>
    /// <exception cref="Exception">Si autre est soi-même, ça plante</exception>
    public void Attaquer(IAvecPointsDeVie autre)
    {
        if (autre == this) // même référence
        {
            throw new Exception("On ne peut s'attaquer soi-même");
        }

        autre.PointsDeVie -= this.ArmeParDefaut.ValeurCout;
    }
    #endregion

    #region Properties
    public int Id { get; } = id;
    public string Prenom { get; set; } = prenom;

    public int PointsDeVie { get; set; }

    //    public bool EstEnVie => this.PointsDeVie > 0;
    public bool EstEnVie { get { return this.PointsDeVie > 0; } }

    public IArme ArmeParDefaut { get; set; }
    #endregion
}

