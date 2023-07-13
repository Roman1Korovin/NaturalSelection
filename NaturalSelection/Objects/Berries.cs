using System;

namespace NaturalSelection.Objects
{
    public class Berries :Item
    {

        private static int appearanceCounter;

        public Berries(Random rand) 
        {
            appearanceCounter = 0;
            this.posX = rand.Next(50, 958);
            this.posY = rand.Next(90, 650);
            this.sizeX = 38;
            this.sizeY = 19;
        }

        public Berries(int posX,int posY)
        {
            appearanceCounter = 0;
            this.posX=posX;
            this.posY=posY;
            this.sizeX = 38;
            this.sizeY = 19;
        }

        public Berries(Random rand, int flag)
        {
            appearanceCounter = 0;
            this.posX = rand.Next(25, 980);
            this.posY = rand.Next(25, 720);
            this.sizeX = 38;
            this.sizeY = 19;
        }

        public static int GetAppearanceCounter()
        {
            return appearanceCounter;
        }
        public static void AddAppearanceCounter()
        {
            appearanceCounter++;
        }
        public static void ResetAppearanceCounter()
        {
            appearanceCounter = 0;
        }
    }
}
