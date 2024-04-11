namespace StarWars.Games.Core.UI.Models;

public class GrilleAfficheur
{
    #region Fields
    private List<Cellule> cells = new List<Cellule>();
    #endregion

    //#region Constructors
    //public GrilleAfficheur()
    //{   
    //}
    //#endregion

    #region Public methods
    public void Afficher(int nbRows, int nbCols, AfficherQuelquePart afficherQuelquePart)
    {
        this.cells.Clear();

        for (int i = 0; i < nbRows; i++)
        {
            for (int j = 0; j < nbCols; j++)
            {
                Cellule cellule = new Cellule(i, j, afficherQuelquePart);
                cellule.Afficher();

                this.cells.Add(cellule);
            }
        }
    }
    #endregion
}
