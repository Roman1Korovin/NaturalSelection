using System;

namespace NaturalSelection.Bots
{
    public abstract class Bot
    {
        protected double posX;
        protected double posY;
        protected int speed;
        protected int sizeX = 20;
        protected int sizeY = 50;

        protected int sideDirection;
        protected int lengthDirectionCounter = 0;

        protected int timeWithoutFoodCounter;
        protected int limitWithoutFood;
        protected double reproductionChance;


        public int GetPosX()
        {
            return (int)Math.Floor(posX); ;
        }

        public int GetPosY()
        {
            return (int)Math.Floor(posY);
        }

        public int GetSizeX()
        {
            return sizeX;
        }

        public int GetSizeY()
        {
            return sizeY;
        }

        public int GetSpeed()
        {
            return speed;
        }

        public int GetLengthDirectionCounter()
        {
            return lengthDirectionCounter;
        }

        public int GetTimeWithoutFoodCounter()
        {
            return timeWithoutFoodCounter;
        }

        public int GetLimitWithoutFood()
        {
            return limitWithoutFood;
        }

        public double GetReproductionChance()
        {
            return reproductionChance;
        }

        public void AddTimeWithoutCounter()
        {
            timeWithoutFoodCounter++;
        }

        public void ResetToZeroTimeWithoutFoodCounter()
        {
            timeWithoutFoodCounter = 0;
        }  
        
        public void SetOppositeSpeed() 
        {
            speed = -speed;
        }

        public void SetRandomDirection(Random rand)
        {
           sideDirection = rand.Next(8);
        }

        public  void GetRandomLengthCounter(Random rand)
        {
            lengthDirectionCounter = rand.Next(100/speed, 300 / speed);
        }

        public void SubtractDirectionLengthCounter()
        {
            lengthDirectionCounter--;
        }

        public abstract void Move();


        protected void MoveRandomly()
        {
            switch (sideDirection)
            {
                case 0:
                    posY += speed;
                    break;
                case 1:
                    posX += speed;
                    break;
                case 2:
                    posY -= speed;
                    break;
                case 3:
                    posX -= speed;
                    break;
                case 4:
                    posX += speed / Math.Sqrt(2); ;
                    posY += speed / Math.Sqrt(2); ;
                    break;
                case 5:
                    posX -= speed / Math.Sqrt(2); ;
                    posY += speed / Math.Sqrt(2); ;
                    break;
                case 6:
                    posX -= speed / Math.Sqrt(2); ;
                    posY -= speed / Math.Sqrt(2); ;
                    break;
                case 7:
                    posX += speed / Math.Sqrt(2);
                    posY -= speed / Math.Sqrt(2);
                    break;
            }        
        }
    }
}

