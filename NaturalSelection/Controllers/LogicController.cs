using NaturalSelection.Bots;
using NaturalSelection.Objects;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;


namespace NaturalSelection.Controllers
{
    public static class LogicController
    {

        public static void BordersCheck(int Width, int Height, Dictionary<Type, List<Bot>> bots)
        {      
            foreach (List<Bot> botList in bots.Values)
                foreach (Bot bot in botList)
                {
                    if (bot.GetPosX() <= 20 || bot.GetPosX() >= Width - 40 || bot.GetPosY() <= 20 || bot.GetPosY() >= Height - 70)
                    {
                        bot.SetOppositeSpeed();
                        bot.Move();
                    }
                }
        }

        public static void CheckCollisionToEatDino(List<Bot> predatorList, List<Bot> preyList, List<Item> remainsList, Random rand,Form2 newForm)
        {
            for (int i = 0; i < predatorList.Count; i++)
                for (int j = 0; j < preyList.Count; j++)
                {
                    Bot bot1 = predatorList[i];
                    Bot bot2 = preyList[j];

                    Rectangle rectBot1 = new Rectangle(bot1.GetPosX(), bot1.GetPosY(), bot1.GetSizeX(), bot1.GetSizeY());
                    Rectangle rectBot2 = new Rectangle(bot2.GetPosX(), bot2.GetPosY(), bot2.GetSizeX(), bot2.GetSizeY());

                    if (rectBot1.IntersectsWith(rectBot2))
                    {
                        bot1.ResetToZeroTimeWithoutFoodCounter();
                        remainsList.Add(new Remains(bot2.GetPosX(), bot2.GetPosY()));
                        preyList.Remove(bot2);

                        if (rand.NextDouble() <= bot1.GetReproductionChance())
                        {
                            predatorList.Add(new Predator(bot1.GetPosX(), bot1.GetPosY(),newForm));
                        }
                    }
                }
        }

        public static void CheckCollisionToEatAll(Dictionary<Type, List<Bot>> bots, List<Item> remainsList)
        {
            List<Bot> cannibalList = bots.ElementAt(2).Value;

            for (int i = 0; i < cannibalList.Count; i++)
            {
                Bot bot1 = cannibalList[i];
                for (int j = 0; j < bots.Count; j++)
                {
                    for (int g = 0; g < bots.ElementAt(j).Value.Count; g++)
                    {
                        Bot bot2 = bots.ElementAt(j).Value[g];
                        Rectangle rectBot1 = new Rectangle(bot1.GetPosX(), bot1.GetPosY(), bot1.GetSizeX(), bot1.GetSizeY());
                        Rectangle rectBot2 = new Rectangle(bot2.GetPosX(), bot2.GetPosY(), bot2.GetSizeX(), bot2.GetSizeY());

                        if (rectBot1.IntersectsWith(rectBot2) && bot1 != bot2)
                        {
                            bot1.ResetToZeroTimeWithoutFoodCounter();
                            bots.ElementAt(j).Value.Remove(bot2);

                            remainsList.Add(new Remains(bot2.GetPosX(), bot2.GetPosY()));
                        }
                    }
                }
            }
        }

        public static void CheckColissionToEatBerry(List<Bot> botList, List<Item> berryList, Random rand,Form2 newForm)
        {
            for (int i = 0; i < botList.Count; i++)
            {
                Herbivore bot = botList[i] as Herbivore;
                for (int j = 0; j < berryList.Count; j++)
                {
                    Item item = berryList[j];

                    Rectangle rectBot = new Rectangle(bot.GetPosX(), bot.GetPosY(), bot.GetSizeX(), bot.GetSizeY());
                    Rectangle rectItem = new Rectangle(item.GetPosX(), item.GetPosY(), item.GetSizeX(), item.GetSizeY());

                    if (rectBot.IntersectsWith(rectItem))
                    {
                        bot.ResetToZeroTimeWithoutFoodCounter();
                        berryList.Remove(item);

                        if (rand.NextDouble() <= bot.GetReproductionChance())
                        {
                            if (bot is HerbivoreWeak)
                                botList.Add(new HerbivoreWeak(bot.GetPosX(), bot.GetPosY(),newForm));
                            else
                                botList.Add(new Herbivore(bot.GetPosX(), bot.GetPosY(),newForm));
                        }
                    }
                }
            }
        }

        public static void CheckColissionToInfection(List<Bot> herbivoreWeakList, List<Bot> herbivoreList,Random rand,Form2 newForm)
        {
            for (int i = 0; i < herbivoreWeakList.Count; i++)
            {
                Herbivore herbivoreWeak = (HerbivoreWeak)herbivoreWeakList[i];

                for (int j = 0; j < herbivoreList.Count; j++)
                {
                    Herbivore herbivore = herbivoreList[j] as Herbivore;

                    Rectangle rectBot1 = new Rectangle(herbivoreWeak.GetPosX(), herbivoreWeak.GetPosY(), herbivoreWeak.GetSizeX(), herbivoreWeak.GetSizeY());
                    Rectangle rectBot2 = new Rectangle(herbivore.GetPosX(), herbivore.GetPosY(), herbivore.GetSizeX(), herbivore.GetSizeY());

                    if (rectBot1.IntersectsWith(rectBot2) && rand.NextDouble()< 0.25)
                    {
                        herbivoreWeakList.Add(new HerbivoreWeak( herbivore.GetPosX(), herbivore.GetPosY(),newForm));
                        herbivoreList.Remove(herbivore);
                    }
                }
            }
        }
    }
}
