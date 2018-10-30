using System;
using TheTyrants;

namespace TheTyrants.Models.Teachers
{
    public class Maurice : Teacher
    {
       
        public string BeBipoloar()
        {
            
            int res = Dice.ThrowDice(1, 4);
            string toReturn = "";

            if (res == 1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                toReturn = this.Name + " se venge en donnant une interro surprise.";
                this.LoosePatience(2);
            }
            else if (res == 2)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                toReturn = this.Name + " se venge en notant le dernier td que personne n'a rendu.";
                this.LoosePatience(2);
            }
            else
            {
                toReturn = this.Name + " Comme il est bipolaire, il décide d'acheter des petits pains à tout le monde";
            }


            return toReturn;
        }

    }
}
