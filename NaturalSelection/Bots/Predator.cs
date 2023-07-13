namespace NaturalSelection.Bots
{
    public class Predator : Bot
    {
        private double chanceToBecomeCannibal;

        public Predator(double posX, double posY, Form2 newForm)
        {
            this.posX = posX;
            this.posY = posY;
            this.speed = (int)newForm.numSpeedPredator.Value;
            this.limitWithoutFood = (int)newForm.numLimitWithoutFoodPredator.Value;
            this.reproductionChance = (double)newForm.numChanceReproductionPredator.Value / 100;
            this.chanceToBecomeCannibal = (double)newForm.numChanceToBecomeCannibal.Value/100;
        }

        public override void Move()
        {
            MoveRandomly();             
        }

        public double GetChanceToBecomeCannibal()
        {
            return chanceToBecomeCannibal;
        }
    }
}
