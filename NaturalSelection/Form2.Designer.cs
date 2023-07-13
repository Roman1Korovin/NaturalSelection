namespace NaturalSelection
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.numChanceReproductionPredator = new System.Windows.Forms.NumericUpDown();
            this.numSpeedPredator = new System.Windows.Forms.NumericUpDown();
            this.numChanceToBecomeCannibal = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numLimitWithoutFoodPredator = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Cancellation = new System.Windows.Forms.Button();
            this.button_Apply = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numChanceReproductionHerbivore = new System.Windows.Forms.NumericUpDown();
            this.numSpeedHerbivore = new System.Windows.Forms.NumericUpDown();
            this.numChanceToBecomeSick = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.numLimitWithoutFoodHerbivore = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numInitialQuantityBerries = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.numAppearanceTimeBerries = new System.Windows.Forms.NumericUpDown();
            this.numMaximumQuantityBerries = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.numRottingLimitTime = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.numChanceAppearanceBerries = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.button_reset = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numChanceReproductionPredator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSpeedPredator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numChanceToBecomeCannibal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLimitWithoutFoodPredator)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numChanceReproductionHerbivore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSpeedHerbivore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numChanceToBecomeSick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLimitWithoutFoodHerbivore)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numInitialQuantityBerries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAppearanceTimeBerries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaximumQuantityBerries)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRottingLimitTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numChanceAppearanceBerries)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.numChanceReproductionPredator);
            this.groupBox3.Controls.Add(this.numSpeedPredator);
            this.groupBox3.Controls.Add(this.numChanceToBecomeCannibal);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.numLimitWithoutFoodPredator);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(244, 442);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Хищники";
            // 
            // numChanceReproductionPredator
            // 
            this.numChanceReproductionPredator.Location = new System.Drawing.Point(17, 243);
            this.numChanceReproductionPredator.Name = "numChanceReproductionPredator";
            this.numChanceReproductionPredator.Size = new System.Drawing.Size(120, 31);
            this.numChanceReproductionPredator.TabIndex = 17;
            this.numChanceReproductionPredator.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // numSpeedPredator
            // 
            this.numSpeedPredator.Location = new System.Drawing.Point(17, 168);
            this.numSpeedPredator.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numSpeedPredator.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numSpeedPredator.Name = "numSpeedPredator";
            this.numSpeedPredator.Size = new System.Drawing.Size(120, 31);
            this.numSpeedPredator.TabIndex = 13;
            this.numSpeedPredator.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // numChanceToBecomeCannibal
            // 
            this.numChanceToBecomeCannibal.Location = new System.Drawing.Point(17, 347);
            this.numChanceToBecomeCannibal.Name = "numChanceToBecomeCannibal";
            this.numChanceToBecomeCannibal.Size = new System.Drawing.Size(120, 31);
            this.numChanceToBecomeCannibal.TabIndex = 15;
            this.numChanceToBecomeCannibal.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(159)))), ((int)(((byte)(58)))));
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.Location = new System.Drawing.Point(13, 143);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(87, 22);
            this.label2.TabIndex = 12;
            this.label2.Text = "Скорость";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(159)))), ((int)(((byte)(58)))));
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label3.Location = new System.Drawing.Point(13, 218);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(188, 22);
            this.label3.TabIndex = 16;
            this.label3.Text = "Шанс репродукции(%)";
            // 
            // label4
            // 
            this.label4.AutoEllipsis = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(159)))), ((int)(((byte)(58)))));
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label4.Location = new System.Drawing.Point(13, 296);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(147, 48);
            this.label4.TabIndex = 14;
            this.label4.Text = "Шанс стань каннибалом(%)";
            // 
            // numLimitWithoutFoodPredator
            // 
            this.numLimitWithoutFoodPredator.Location = new System.Drawing.Point(17, 92);
            this.numLimitWithoutFoodPredator.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numLimitWithoutFoodPredator.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numLimitWithoutFoodPredator.Name = "numLimitWithoutFoodPredator";
            this.numLimitWithoutFoodPredator.Size = new System.Drawing.Size(120, 31);
            this.numLimitWithoutFoodPredator.TabIndex = 11;
            this.numLimitWithoutFoodPredator.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(159)))), ((int)(((byte)(58)))));
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(13, 41);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(147, 48);
            this.label1.TabIndex = 10;
            this.label1.Text = "Время жизни без еды(тиков)";
            // 
            // button_Cancellation
            // 
            this.button_Cancellation.BackColor = System.Drawing.Color.White;
            this.button_Cancellation.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button_Cancellation.Location = new System.Drawing.Point(12, 545);
            this.button_Cancellation.Name = "button_Cancellation";
            this.button_Cancellation.Size = new System.Drawing.Size(160, 56);
            this.button_Cancellation.TabIndex = 21;
            this.button_Cancellation.Text = "Отмена";
            this.button_Cancellation.UseVisualStyleBackColor = false;
            this.button_Cancellation.Click += new System.EventHandler(this.button_Cancellation_Click);
            // 
            // button_Apply
            // 
            this.button_Apply.BackColor = System.Drawing.Color.White;
            this.button_Apply.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button_Apply.Location = new System.Drawing.Point(958, 545);
            this.button_Apply.Name = "button_Apply";
            this.button_Apply.Size = new System.Drawing.Size(160, 56);
            this.button_Apply.TabIndex = 22;
            this.button_Apply.Text = "Применить";
            this.button_Apply.UseVisualStyleBackColor = false;
            this.button_Apply.Click += new System.EventHandler(this.button_Apply_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numChanceReproductionHerbivore);
            this.groupBox1.Controls.Add(this.numSpeedHerbivore);
            this.groupBox1.Controls.Add(this.numChanceToBecomeSick);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.numLimitWithoutFoodHerbivore);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(311, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(244, 442);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Травоядные";
            // 
            // numChanceReproductionHerbivore
            // 
            this.numChanceReproductionHerbivore.Location = new System.Drawing.Point(17, 243);
            this.numChanceReproductionHerbivore.Name = "numChanceReproductionHerbivore";
            this.numChanceReproductionHerbivore.Size = new System.Drawing.Size(120, 31);
            this.numChanceReproductionHerbivore.TabIndex = 17;
            this.numChanceReproductionHerbivore.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numSpeedHerbivore
            // 
            this.numSpeedHerbivore.Location = new System.Drawing.Point(17, 168);
            this.numSpeedHerbivore.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numSpeedHerbivore.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numSpeedHerbivore.Name = "numSpeedHerbivore";
            this.numSpeedHerbivore.Size = new System.Drawing.Size(120, 31);
            this.numSpeedHerbivore.TabIndex = 13;
            this.numSpeedHerbivore.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // numChanceToBecomeSick
            // 
            this.numChanceToBecomeSick.Location = new System.Drawing.Point(17, 347);
            this.numChanceToBecomeSick.Name = "numChanceToBecomeSick";
            this.numChanceToBecomeSick.Size = new System.Drawing.Size(120, 31);
            this.numChanceToBecomeSick.TabIndex = 15;
            this.numChanceToBecomeSick.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(159)))), ((int)(((byte)(58)))));
            this.label5.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label5.Location = new System.Drawing.Point(13, 143);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(87, 22);
            this.label5.TabIndex = 12;
            this.label5.Text = "Скорость";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(159)))), ((int)(((byte)(58)))));
            this.label6.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label6.Location = new System.Drawing.Point(13, 218);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(188, 22);
            this.label6.TabIndex = 16;
            this.label6.Text = "Шанс репродукции(%)";
            // 
            // label7
            // 
            this.label7.AutoEllipsis = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(159)))), ((int)(((byte)(58)))));
            this.label7.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label7.Location = new System.Drawing.Point(13, 296);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(228, 89);
            this.label7.TabIndex = 14;
            this.label7.Text = "Шанс возникновения слабого представителя(%)";
            // 
            // numLimitWithoutFoodHerbivore
            // 
            this.numLimitWithoutFoodHerbivore.Location = new System.Drawing.Point(17, 92);
            this.numLimitWithoutFoodHerbivore.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numLimitWithoutFoodHerbivore.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numLimitWithoutFoodHerbivore.Name = "numLimitWithoutFoodHerbivore";
            this.numLimitWithoutFoodHerbivore.Size = new System.Drawing.Size(120, 31);
            this.numLimitWithoutFoodHerbivore.TabIndex = 11;
            this.numLimitWithoutFoodHerbivore.Value = new decimal(new int[] {
            400,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoEllipsis = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(159)))), ((int)(((byte)(58)))));
            this.label8.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label8.Location = new System.Drawing.Point(13, 41);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label8.Size = new System.Drawing.Size(147, 48);
            this.label8.TabIndex = 10;
            this.label8.Text = "Время жизни без еды(тиков)";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numInitialQuantityBerries);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.numAppearanceTimeBerries);
            this.groupBox2.Controls.Add(this.numMaximumQuantityBerries);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox2.Location = new System.Drawing.Point(592, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(244, 442);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Кусты";
            // 
            // numInitialQuantityBerries
            // 
            this.numInitialQuantityBerries.Location = new System.Drawing.Point(10, 92);
            this.numInitialQuantityBerries.Name = "numInitialQuantityBerries";
            this.numInitialQuantityBerries.Size = new System.Drawing.Size(120, 31);
            this.numInitialQuantityBerries.TabIndex = 19;
            this.numInitialQuantityBerries.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(159)))), ((int)(((byte)(58)))));
            this.label11.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label11.Location = new System.Drawing.Point(6, 67);
            this.label11.Name = "label11";
            this.label11.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label11.Size = new System.Drawing.Size(193, 22);
            this.label11.TabIndex = 18;
            this.label11.Text = "Начальное количество";
            // 
            // numAppearanceTimeBerries
            // 
            this.numAppearanceTimeBerries.Location = new System.Drawing.Point(10, 244);
            this.numAppearanceTimeBerries.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numAppearanceTimeBerries.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numAppearanceTimeBerries.Name = "numAppearanceTimeBerries";
            this.numAppearanceTimeBerries.Size = new System.Drawing.Size(120, 31);
            this.numAppearanceTimeBerries.TabIndex = 17;
            this.numAppearanceTimeBerries.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // numMaximumQuantityBerries
            // 
            this.numMaximumQuantityBerries.Location = new System.Drawing.Point(10, 168);
            this.numMaximumQuantityBerries.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numMaximumQuantityBerries.Name = "numMaximumQuantityBerries";
            this.numMaximumQuantityBerries.Size = new System.Drawing.Size(120, 31);
            this.numMaximumQuantityBerries.TabIndex = 13;
            this.numMaximumQuantityBerries.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(159)))), ((int)(((byte)(58)))));
            this.label9.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label9.Location = new System.Drawing.Point(6, 143);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label9.Size = new System.Drawing.Size(227, 22);
            this.label9.TabIndex = 12;
            this.label9.Text = "Максимальное количество";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(159)))), ((int)(((byte)(58)))));
            this.label10.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label10.Location = new System.Drawing.Point(6, 219);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label10.Size = new System.Drawing.Size(211, 22);
            this.label10.TabIndex = 16;
            this.label10.Text = "Время появления(тиков)";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.numRottingLimitTime);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.numChanceAppearanceBerries);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox4.Location = new System.Drawing.Point(874, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(244, 442);
            this.groupBox4.TabIndex = 25;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Останки";
            // 
            // numRottingLimitTime
            // 
            this.numRottingLimitTime.Location = new System.Drawing.Point(10, 168);
            this.numRottingLimitTime.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numRottingLimitTime.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numRottingLimitTime.Name = "numRottingLimitTime";
            this.numRottingLimitTime.Size = new System.Drawing.Size(120, 31);
            this.numRottingLimitTime.TabIndex = 21;
            this.numRottingLimitTime.Value = new decimal(new int[] {
            150,
            0,
            0,
            0});
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(159)))), ((int)(((byte)(58)))));
            this.label13.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label13.Location = new System.Drawing.Point(6, 143);
            this.label13.Name = "label13";
            this.label13.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label13.Size = new System.Drawing.Size(230, 22);
            this.label13.TabIndex = 20;
            this.label13.Text = "Время переработки(тиков)";
            // 
            // numChanceAppearanceBerries
            // 
            this.numChanceAppearanceBerries.Location = new System.Drawing.Point(10, 92);
            this.numChanceAppearanceBerries.Name = "numChanceAppearanceBerries";
            this.numChanceAppearanceBerries.Size = new System.Drawing.Size(120, 31);
            this.numChanceAppearanceBerries.TabIndex = 19;
            this.numChanceAppearanceBerries.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(159)))), ((int)(((byte)(58)))));
            this.label12.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label12.Location = new System.Drawing.Point(6, 67);
            this.label12.Name = "label12";
            this.label12.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label12.Size = new System.Drawing.Size(223, 22);
            this.label12.TabIndex = 18;
            this.label12.Text = "Шанс появления куста(%)";
            // 
            // button_reset
            // 
            this.button_reset.BackColor = System.Drawing.Color.White;
            this.button_reset.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button_reset.Location = new System.Drawing.Point(207, 545);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(160, 56);
            this.button_reset.TabIndex = 26;
            this.button_reset.Text = "Сброс настроек";
            this.button_reset.UseVisualStyleBackColor = false;
            this.button_reset.Click += new System.EventHandler(this.button_reset_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(159)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(1134, 613);
            this.Controls.Add(this.button_reset);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_Apply);
            this.Controls.Add(this.button_Cancellation);
            this.Controls.Add(this.groupBox3);
            this.MaximumSize = new System.Drawing.Size(1150, 652);
            this.MinimumSize = new System.Drawing.Size(1150, 652);
            this.Name = "Form2";
            this.Text = "Natural  Selection";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numChanceReproductionPredator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSpeedPredator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numChanceToBecomeCannibal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLimitWithoutFoodPredator)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numChanceReproductionHerbivore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSpeedHerbivore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numChanceToBecomeSick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLimitWithoutFoodHerbivore)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numInitialQuantityBerries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAppearanceTimeBerries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaximumQuantityBerries)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRottingLimitTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numChanceAppearanceBerries)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Cancellation;
        private System.Windows.Forms.Button button_Apply;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.NumericUpDown numSpeedPredator;
        public System.Windows.Forms.NumericUpDown numChanceReproductionPredator;
        public System.Windows.Forms.NumericUpDown numChanceToBecomeCannibal;
        public System.Windows.Forms.NumericUpDown numChanceReproductionHerbivore;
        public System.Windows.Forms.NumericUpDown numSpeedHerbivore;
        public System.Windows.Forms.NumericUpDown numChanceToBecomeSick;
        public System.Windows.Forms.NumericUpDown numLimitWithoutFoodHerbivore;
        public System.Windows.Forms.NumericUpDown numAppearanceTimeBerries;
        public System.Windows.Forms.NumericUpDown numMaximumQuantityBerries;
        public System.Windows.Forms.NumericUpDown numInitialQuantityBerries;
        public System.Windows.Forms.NumericUpDown numChanceAppearanceBerries;
        public System.Windows.Forms.NumericUpDown numLimitWithoutFoodPredator;
        public System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_reset;
        public System.Windows.Forms.NumericUpDown numRottingLimitTime;
        private System.Windows.Forms.Label label13;
    }
}