using System;
using System.Windows.Forms;

namespace NaturalSelection
{
    public partial class Form2 : Form
    {
        public int LimitWithoutFoodPredatorr;
        public int SpeedPredator;
        public int ChanceReproductionPredator;
        public int ChanceToBecomeCannibal;
        public int LimitWithoutFoodHerbivore;
        public int SpeedHerbivore;
        public int ChanceReproductionHerbivore;
        public int ChanceToBecomeSick;
        public int InitialQuantityBerries;
        public int MaximumQuantityBerries;
        public int AppearanceTimeBerries;
        public int ChanceAppearanceBerries;
        public int RottingLimitTime;

        public Form2()
        {
            InitializeComponent();
        }

        private void button_Cancellation_Click(object sender, EventArgs e)
        {
            numLimitWithoutFoodPredator.Value = LimitWithoutFoodPredatorr;
            numSpeedPredator.Value = SpeedPredator;
            numChanceReproductionPredator.Value = ChanceReproductionPredator;
            numChanceToBecomeCannibal.Value = ChanceToBecomeCannibal;
            numLimitWithoutFoodHerbivore.Value = LimitWithoutFoodHerbivore;
            numSpeedHerbivore.Value = SpeedHerbivore;
            numChanceReproductionHerbivore.Value = ChanceReproductionHerbivore;
            numChanceToBecomeSick.Value = ChanceToBecomeSick;
            numInitialQuantityBerries.Value = InitialQuantityBerries;
            numMaximumQuantityBerries.Value = MaximumQuantityBerries;
            numAppearanceTimeBerries.Value = AppearanceTimeBerries;
            numChanceAppearanceBerries.Value = ChanceAppearanceBerries;
            numRottingLimitTime.Value = RottingLimitTime;

            this.Close();
        }

        private void button_Apply_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            numLimitWithoutFoodPredator.Value = 300;
            numSpeedPredator.Value = 5;
            numChanceReproductionPredator.Value = 10;
            numChanceToBecomeCannibal.Value = 10;
            numLimitWithoutFoodHerbivore.Value = 400;
            numSpeedHerbivore.Value = 5;
            numChanceReproductionHerbivore.Value = 100;
            numChanceToBecomeSick.Value = 5;
            numInitialQuantityBerries.Value = 25;
            numMaximumQuantityBerries.Value = 30;
            numAppearanceTimeBerries.Value = 20;
            numChanceAppearanceBerries.Value = 50;
            numRottingLimitTime.Value = 150;
        }
    }
}
