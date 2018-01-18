using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacManChallenge.App
{
    class PacMan
    {
        public PacMan()
        {
            Lives = 3;
            Points = 5000;
            NewLifeCounter = Points;
            NewLivesGained = 0;
        }

        public int Lives { get; set; }
        public int Points { get; set; }
        public int NewLifeCounter { get; set; }
        public int NewLivesGained { get; set; }
        public int VulnerableGhostsEaten = 0;

        public void Eat(string item)
        {
            int value = 0;

            switch (item)
            {
                case "Dot":
                    value += (int) Food.Dot;
                    break;
                case "Cherry":
                    value += (int) Food.Cherry;
                    break;
                case "Strawberry":
                    value += (int) Food.Strawberry;
                    break;
                case "Orange":
                    value += (int) Food.Orange;
                    break;
                case "Apple":
                    value += (int) Food.Apple;
                    break;
                case "Melon":
                    value += (int) Food.Melon;
                    break;
                case "Galaxian":
                    value += (int) Food.Galaxian;
                    break;
                case "Bell":
                    value += (int) Food.Bell;
                    break;
                case "Key":
                    value += (int) Food.Key;
                    break;
                case "InvincibleGhost":
                    Lives--;
                    break;
                case "VulnerableGhost":
                    value += EatVulnerableGhost();
                    VulnerableGhostsEaten++;
                    break;
            }

            Points += value;
            NewLifeCounter += value;

            if (NewLifeCounter > 10000)
            {
                NewLifeCounter -= 10000;
                Lives++;
                NewLivesGained++;
            }
        }

        private int EatVulnerableGhost()
        {
            var ghostPointValue = (int) Food.Ghost;

            for (int i = 0; i < VulnerableGhostsEaten; i++)
            {
                ghostPointValue *= 2;
            }

            return ghostPointValue;
        }
    }
}
