namespace StarWars.Games.Core.UI.Models;
public class Cellule
{
    #region Fields
    private AfficherQuelquePart afficherQuelquePart;
    #endregion

    #region Constructors
    public Cellule(int i, int j, AfficherQuelquePart afficherQuelquePart)
    {
        this.RowIndex = i;
        this.ColIndex = j;

        this.afficherQuelquePart = afficherQuelquePart;
    }

    /// <summary>
    /// On utilise ici le Console pour afficher par défaut
    /// </summary>
    /// <param name="i"></param>
    /// <param name="j"></param>
    public Cellule(int i, int j) : this(i, j, Console.Write) { }
    #endregion

    #region Public methods
    public void Afficher()
    {
        this.afficherQuelquePart("_");
    }
    #endregion

    #region Properties
    public int ColIndex { get; init; }
    public int RowIndex { get; init; }
    #endregion
}
