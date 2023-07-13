namespace NaturalSelection.Bots
{
    public class HerbivoreWeak : Herbivore 
    {
        public HerbivoreWeak(double posX, double posY,Form2 newForm) : base (posX,posY, newForm)
        {
            this.limitWithoutFood = limitWithoutFood / 2;
            this.reproductionChance = 0;
        }
    }
}