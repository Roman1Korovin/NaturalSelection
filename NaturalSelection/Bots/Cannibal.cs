using System;

namespace NaturalSelection.Bots
{
    public class Cannibal : Bot
    {
        public Cannibal(double posX, double posY, Form2 newForm)
        {
            this.posX = posX;
            this.posY = posY;
            this.speed = (int)newForm.numSpeedPredator.Value;
            this.limitWithoutFood = (int)Math.Floor((double)newForm.numLimitWithoutFoodPredator.Value * 0.67); ;
            this.reproductionChance = 0;
        }

        public override void Move()
        {
            MoveRandomly();
        }
    }
}
