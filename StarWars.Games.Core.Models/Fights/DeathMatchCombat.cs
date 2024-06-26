﻿namespace StarWars.Games.Core.Models.Fights
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
                    try
                    {
                        attaquant2.Attaquer(attaquant);
                    }
                    catch (Exception)
                    {
                        // Je traite l'erreur
                        throw; // je balance l'erreur, je la laisse se propager
                    }

                }
            }
        }
    }
}
