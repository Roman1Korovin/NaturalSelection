namespace NaturalSelection.Objects
{
    public abstract class Item
    {

        protected int posX;
        protected int posY;
        protected int sizeX;
        protected int sizeY;

        public  int GetPosX()
        {
            return posX;
        }

        public int GetPosY()
        {
            return posY;
        }

        public int GetSizeX()
        {
            return sizeX;
        }
        public int GetSizeY() 
        { 
            return sizeY;
        }
    }
}
