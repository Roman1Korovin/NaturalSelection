namespace NaturalSelection.Bots
{
    public class Herbivore : Bot
    {
        private double chanceToBecomeSick;

        public Herbivore(double posX, double posY,Form2 newForm)
        {
            this.posX = posX;
            this.posY = posY;
            this.speed = (int)newForm.numSpeedHerbivore.Value;
            this.limitWithoutFood = (int)newForm.numLimitWithoutFoodHerbivore.Value;
            this.reproductionChance = (double)newForm.numChanceReproductionHerbivore.Value/100;
            this.chanceToBecomeSick = (double)newForm.numChanceToBecomeSick.Value / 100;
        }

        public override void Move()
        {
            MoveRandomly();
        }

        public double GetChanceToBecomeSick()
        {
            return chanceToBecomeSick;
        }
    }
}
