using NaturalSelection.Objects;
using System;
using System.Drawing;
using System.IO;


namespace NaturalSelection.Bots
{
    public static class Renderer
    {

        private static Image predatorSprite;
        private static Image herbivoreSprite;
        private static Image herbivoreWeakSprite;
        private static Image cannibalSprite;
        private static Image berriesSprite;
        private static Image remainsSprite;
     

        public static void Init()
        {
            predatorSprite = LoadSprite("Sprites\\Predator.png");
            herbivoreSprite = LoadSprite("Sprites\\Herbivore.png");
            herbivoreWeakSprite = LoadSprite("Sprites\\HerbivoreWeak.png");
            cannibalSprite = LoadSprite("Sprites\\Cannibal.png");
            berriesSprite = LoadSprite("Sprites\\Berries.png");
            remainsSprite = LoadSprite("Sprites\\Remains.png");
        }

        public static void RenderBot(Bot bot, Graphics graphics)
        {
            Image sprite;

            if (bot is Predator)
                sprite = predatorSprite;
            else if (bot is HerbivoreWeak)
                sprite = herbivoreWeakSprite;
            else if (bot is Herbivore)
                sprite = herbivoreSprite;       
            else if (bot is Cannibal)
                sprite = cannibalSprite;
            else
                throw new ArgumentException("Unsupported bot type.");

            graphics.DrawImage(sprite, bot.GetPosX(), bot.GetPosY(),bot.GetSizeX(),bot.GetSizeY());
        }
        public static void RenderObject(Item item, Graphics graphics)
        {
            Image sprite;

            if (item is Berries)
                sprite = berriesSprite;
            else if (item is Remains)
                sprite = remainsSprite;
            else throw new ArgumentException("Unsupported bot type.");

            graphics.DrawImage(sprite, item.GetPosX(), item.GetPosY(),item.GetSizeX(),item.GetSizeY());
        }

        private static Image LoadSprite(string spritePath)
        {
            return new Bitmap(Path.Combine(new DirectoryInfo(Directory.GetCurrentDirectory()).Parent.Parent.FullName.ToString(), spritePath));
        }
    }
}
