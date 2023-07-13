using NaturalSelection.Bots;
using NaturalSelection.Controllers;
using NaturalSelection.Objects;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;


namespace NaturalSelection
{
    public partial class Form1 : Form
    {
        
        private List<Bot> predatorList;
        private List<Bot> herbivoreList;
        private List<Bot> cannibalList;
        private List<Bot> herbivoreWeakList;
        private Dictionary<Type, List<Bot>> bots;

        private List<Item> berriesList;
        private List<Item> remainsList;


        private Random rand = new Random();
        private bool isGameStarted = false;
        private bool isFirstStart = true;

        Form2 newForm = new Form2();

        public uint CurrentGeneration { get; private set; }


        public Form1()
        {
            InitializeComponent();
        }

        private void button_Start_Click(object sender, EventArgs e)
        {
            button_Start.Enabled = false;
            button1_Pause.Enabled = true;
            button_Reset.Enabled = true;
            button_settings.Enabled =false;
            
            StartGame();
        }

        private void button1_Pause_Click(object sender, EventArgs e)
        {
            PauseGame();
        }

        private void button_Finish_Click(object sender, EventArgs e)
        {
            button_Start.Enabled = true;
            button1_Pause.Enabled = false;
            button_Reset.Enabled = false;
            button_settings.Enabled = true;
            label_generation.Visible = false;
            numHerbivore.Enabled = true;
            numPredators.Enabled = true;
            
            FinishGame();
        }

        private void button1_Settings(object sender, EventArgs e)
        {
            newForm.LimitWithoutFoodPredatorr = (int)newForm.numLimitWithoutFoodPredator.Value;
            newForm.SpeedPredator = (int)newForm.numSpeedPredator.Value;
            newForm.ChanceReproductionPredator = (int)newForm.numChanceReproductionPredator.Value;
            newForm.ChanceToBecomeCannibal = (int)newForm.numChanceToBecomeCannibal.Value;
            newForm.LimitWithoutFoodHerbivore = (int)newForm.numLimitWithoutFoodHerbivore.Value;
            newForm.SpeedHerbivore = (int)newForm.numSpeedHerbivore.Value;
            newForm.ChanceReproductionHerbivore = (int)newForm.numChanceReproductionHerbivore.Value;
            newForm.ChanceToBecomeSick = (int)newForm.numChanceToBecomeSick.Value;
            newForm.InitialQuantityBerries = (int)newForm.numInitialQuantityBerries.Value;
            newForm.MaximumQuantityBerries = (int)newForm.numMaximumQuantityBerries.Value;
            newForm.AppearanceTimeBerries = (int)newForm.numAppearanceTimeBerries.Value;
            newForm.ChanceAppearanceBerries = (int)newForm.numChanceAppearanceBerries.Value;
            newForm.RottingLimitTime = (int)newForm.numRottingLimitTime.Value;

            newForm.ShowDialog();
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label_Track.Text = trackBar1.Value.ToString();
        }

        private void Init()
        {
            Renderer.Init();

            bots = new Dictionary<Type, List<Bot>>();
            predatorList = new List<Bot>();
            herbivoreList = new List<Bot>();
            cannibalList = new List<Bot>();
            herbivoreWeakList = new List<Bot>();

            berriesList = new List<Item>();
            remainsList = new List<Item>();


            for (int i = 0; i < newForm.numInitialQuantityBerries.Value; i++)
            {
                berriesList.Add(new Berries(rand));
            }

            int offset = pictureBox1.Width / ((int)numHerbivore.Value + 1) - 10;

            for (int i = 0; i < (int)numHerbivore.Value; i++)
            {             
                herbivoreList.Add(new Herbivore(offset, 30,newForm));
                offset += pictureBox1.Width / ((int)numHerbivore.Value + 1) ;
            }

            offset = pictureBox1.Width / (int)(numPredators.Value + 1) - 10;

            for (int i = 0; i < (int)numPredators.Value; i++)
            {
                predatorList.Add(new Predator(offset, 677,newForm));
                offset += pictureBox1.Width / ((int)numPredators.Value + 1);
            }

            bots.Add(typeof(Predator), predatorList);
            bots.Add(typeof(Herbivore), herbivoreList);
            bots.Add(typeof(Cannibal), cannibalList);
            bots.Add(typeof(HerbivoreWeak), herbivoreWeakList);

            CurrentGeneration = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Центрирование формы по оси X
            int x = (Screen.PrimaryScreen.Bounds.Width - this.Width) / 2;
            // Центрирование формы по оси Y
            int y = (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2;
            // Установка новых координат формы
            this.Location = new Point(x, y);
            label_Track.Text = trackBar1.Value.ToString();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            MapController.Init();
            Graphics g = e.Graphics;
            MapController.DrawMap(g);

            if (isGameStarted)
            {
                foreach (Item item in berriesList)
                {
                    Renderer.RenderObject(item, g);
                }

                foreach (Item item in remainsList)
                {
                    Renderer.RenderObject(item,g);
                }

                foreach (List<Bot> botList in bots.Values)
                {
                    foreach (Bot bot in botList)
                    {
                            Renderer.RenderBot(bot, g);    
                    }
                }
            }
        }

        private void StartGame()
        {
            Init();
            isGameStarted = true;

            numPredators.Enabled = false;
            numHerbivore.Enabled = false;
            pictureBox_logo.Visible = false;

            CurrentGeneration++;
            label_generation.Visible = true;
            label_generation.Text = $"Generation {CurrentGeneration}";
            pictureBox1.Refresh();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = trackBar1.Value;

            MovementInDirection();
            TurnRemainsToBerries();
            СheckHunger();
            BerriesAppearance();
        }

        private void MovementInDirection()
        {
            LogicController.BordersCheck(pictureBox1.Width, pictureBox1.Height, bots);
            LogicController.CheckCollisionToEatDino(predatorList,herbivoreList,remainsList,rand,newForm);
            LogicController.CheckCollisionToEatDino(predatorList, herbivoreWeakList, remainsList, rand, newForm);
            LogicController.CheckColissionToEatBerry(herbivoreList, berriesList,rand, newForm);
            LogicController.CheckColissionToEatBerry(herbivoreWeakList, berriesList, rand, newForm);
            LogicController.CheckCollisionToEatAll(bots, remainsList);
            LogicController.CheckColissionToInfection(herbivoreWeakList,herbivoreList,rand,newForm);

            foreach (List<Bot> botList in bots.Values)
                foreach (Bot bot in botList)
                {
                    if (bot.GetLengthDirectionCounter() == 0)
                    {
                        if (!isFirstStart && bot.GetSpeed() < 0)
                        {
                                bot.SetOppositeSpeed();
                        }

                        bot.SetRandomDirection(rand);
                        bot.GetRandomLengthCounter(rand);
                    }
                    else
                    {
                        bot.SubtractDirectionLengthCounter();
                    }
                }
   
            DrawNextGeneration();

            isFirstStart = false;
        }

        private void TurnRemainsToBerries()
        {
            List<Remains> remainsToRemove = new List<Remains>();

            foreach (Remains remains in remainsList)
            {
                if (remains.GetRottingCounter() == newForm.numRottingLimitTime.Value)
                {
                    if (rand.NextDouble() <=(double)newForm.numChanceAppearanceBerries.Value/100)
                    {                   
                        berriesList.Add(new Berries(remains.GetPosX(), remains.GetPosY()));
                    }
                        remainsToRemove.Add(remains);
                }
                else
                {
                    remains.AddRebirthTimer();
                }
            }
            foreach (Remains remains in remainsToRemove)
            {
                remainsList.Remove(remains);
            }
        }

        private void СheckHunger()
        {
            List<Predator> predatorsToRemove = new List<Predator>();

            foreach (Predator predator in predatorList)
            {
                if (predator.GetTimeWithoutFoodCounter() == predator.GetLimitWithoutFood() * 0.5 && rand.NextDouble() < predator.GetChanceToBecomeCannibal())
                {
                        cannibalList.Add(new Cannibal(predator.GetPosX(), predator.GetPosY(),newForm));
                        predatorsToRemove.Add(predator);

                }
            }
            foreach (Predator predator in predatorsToRemove)
            {
                predatorList.Remove(predator);
            }


            List<Herbivore> herbivoreToRemove = new List<Herbivore>();

            foreach (Herbivore herbivore in herbivoreList)
            {
                if (herbivore.GetTimeWithoutFoodCounter() == (herbivore.GetLimitWithoutFood() * 0.5) && herbivoreList.Count > 25 && rand.NextDouble() < herbivore.GetChanceToBecomeSick())
                {
                        herbivoreWeakList.Add(new HerbivoreWeak(herbivore.GetPosX(), herbivore.GetPosY(),newForm));
                        herbivoreToRemove.Add(herbivore);
                }
            }
            foreach (Herbivore herbivore in herbivoreToRemove)
            {
                herbivoreList.Remove(herbivore);
            }


            List<Remains> remainsToAdd = new List<Remains>();

            foreach (List<Bot> botList in bots.Values)
            {
                List<Bot> botsToRemove = new List<Bot>();
                foreach (Bot bot in botList)
                {
                    if (bot.GetTimeWithoutFoodCounter() >= bot.GetLimitWithoutFood())
                    {
                        Remains remains = new Remains(bot.GetPosX(), bot.GetPosY());
                        botsToRemove.Add(bot);
                        remainsToAdd.Add(remains);
                    }
                    else
                    {
                        bot.AddTimeWithoutCounter();
                    }
                }
                foreach (Bot bot in botsToRemove)
                {
                    botList.Remove(bot);
                }
            }
            foreach (Remains remains in remainsToAdd)
            {
                remainsList.Add(remains);
            }
        }

        private void BerriesAppearance()
        {
            if (Berries.GetAppearanceCounter() >= newForm.numAppearanceTimeBerries.Value && berriesList.Count<newForm.numMaximumQuantityBerries.Value)
            {
                berriesList.Add(new Berries(rand, 1));
                Berries.ResetAppearanceCounter();
            }
            else
            {
                Berries.AddAppearanceCounter();
            }
        }

        private void DrawNextGeneration()
        {
            CurrentGeneration++;
            label_generation.Text = $"Generation {CurrentGeneration}";

            foreach (List<Bot> botList in bots.Values)
                foreach (Bot bot in botList)
                {
                bot.Move();
                }
            pictureBox1.Refresh();
        }

        private void PauseGame()
        {
            if (timer1.Enabled)
            {
                timer1.Stop();
            }
            else
            {
                timer1.Start();
            }
        }

        private void FinishGame()
        {
            isGameStarted = false;
            timer1.Stop();
            Init();
            pictureBox1.Refresh();
            Berries.ResetAppearanceCounter() ;
            pictureBox_logo.Visible = true;
        }
    }
}
