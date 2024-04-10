using StarWars.Games.Core.Models.Fights;

ICombat combat = new DeathMatchCombat();

Character droide = new Character() { PointsDeVie = 50 };
droide.ArmeParDefaut = new Arbalete("ERR1221");

Character jedi = new Character();
jedi.ArmeParDefaut = new LaserArbalete("ZZEEEE");
jedi.PointsDeVie = 50;

jedi = new Character();

combat.Lancer(jedi, droide);