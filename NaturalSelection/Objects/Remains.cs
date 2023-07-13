namespace NaturalSelection.Objects
{
    public class Remains : Item
    {

        private int rottingCounter = 0;

        public Remains(int posX, int posY)
        {
            this.posX = posX;
            this.posY = posY;
            this.sizeX = 19;
            this.sizeY = 50;
        }


        public int GetRottingCounter()
        {
            return rottingCounter;
        }

        public void AddRebirthTimer()
        {
            this.rottingCounter++;
        }
    }
}
