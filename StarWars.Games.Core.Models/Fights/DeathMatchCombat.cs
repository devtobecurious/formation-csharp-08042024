namespace StarWars.Games.Core.Models.Fights
{
    public class DeathMatchCombat : ICombat
    {
        public void Lancer(IAttaquant attaquant, IAttaquant attaquant2)
        {
            while (attaquant.EstEnVie && attaquant2.EstEnVie)
            {
                attaquant.Attaquer(attaquant2);
                if (attaquant2.EstEnVie)
                {
                    attaquant2.Attaquer(attaquant);
                }
            }
        }
    }
}
