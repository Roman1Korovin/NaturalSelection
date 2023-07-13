namespace NaturalSelection
{
    partial class Form1
{
    /// <summary>
    /// Обязательная переменная конструктора.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Освободить все используемые ресурсы.
    /// </summary>
    /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Код, автоматически созданный конструктором форм Windows

    /// <summary>
    /// Требуемый метод для поддержки конструктора — не изменяйте 
    /// содержимое этого метода с помощью редактора кода.
    /// </summary>
    private void InitializeComponent()
    {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.SplitContainer splitContainer1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox_logo = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_Exit = new System.Windows.Forms.Button();
            this.button_settings = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numPredators = new System.Windows.Forms.NumericUpDown();
            this.label_Resolution = new System.Windows.Forms.Label();
            this.numHerbivore = new System.Windows.Forms.NumericUpDown();
            this.label_Density = new System.Windows.Forms.Label();
            this.button1_Pause = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_Track = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label_generation = new System.Windows.Forms.Label();
            this.button_Reset = new System.Windows.Forms.Button();
            this.button_Start = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(splitContainer1)).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPredators)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHerbivore)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(159)))), ((int)(((byte)(58)))));
            splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer1.IsSplitterFixed = true;
            splitContainer1.Location = new System.Drawing.Point(0, 0);
            splitContainer1.MaximumSize = new System.Drawing.Size(1484, 761);
            splitContainer1.MinimumSize = new System.Drawing.Size(1484, 761);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(this.pictureBox_logo);
            splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.AutoScroll = true;
            splitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(159)))), ((int)(((byte)(58)))));
            splitContainer1.Panel2.Controls.Add(this.button_Exit);
            splitContainer1.Panel2.Controls.Add(this.button_settings);
            splitContainer1.Panel2.Controls.Add(this.groupBox2);
            splitContainer1.Panel2.Controls.Add(this.button1_Pause);
            splitContainer1.Panel2.Controls.Add(this.groupBox1);
            splitContainer1.Panel2.Controls.Add(this.label_generation);
            splitContainer1.Panel2.Controls.Add(this.button_Reset);
            splitContainer1.Panel2.Controls.Add(this.button_Start);
            splitContainer1.Size = new System.Drawing.Size(1484, 761);
            splitContainer1.SplitterDistance = 1040;
            splitContainer1.TabIndex = 0;
            splitContainer1.TabStop = false;
            // 
            // pictureBox_logo
            // 
            this.pictureBox_logo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(186)))), ((int)(((byte)(149)))));
            this.pictureBox_logo.BackgroundImage = global::NaturalSelection.Properties.Resources.Logo;
            this.pictureBox_logo.Location = new System.Drawing.Point(186, 248);
            this.pictureBox_logo.Name = "pictureBox_logo";
            this.pictureBox_logo.Size = new System.Drawing.Size(635, 185);
            this.pictureBox_logo.TabIndex = 1;
            this.pictureBox_logo.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(173)))), ((int)(((byte)(173)))));
            this.pictureBox1.Location = new System.Drawing.Point(11, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1040, 758);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // button_Exit
            // 
            this.button_Exit.BackColor = System.Drawing.Color.White;
            this.button_Exit.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_Exit.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button_Exit.Location = new System.Drawing.Point(127, 420);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(160, 56);
            this.button_Exit.TabIndex = 21;
            this.button_Exit.Text = "Выход";
            this.button_Exit.UseVisualStyleBackColor = false;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // button_settings
            // 
            this.button_settings.BackColor = System.Drawing.Color.White;
            this.button_settings.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_settings.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button_settings.Location = new System.Drawing.Point(127, 234);
            this.button_settings.Name = "button_settings";
            this.button_settings.Size = new System.Drawing.Size(160, 56);
            this.button_settings.TabIndex = 20;
            this.button_settings.Text = "Настройки";
            this.button_settings.UseVisualStyleBackColor = false;
            this.button_settings.Click += new System.EventHandler(this.button1_Settings);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numPredators);
            this.groupBox2.Controls.Add(this.label_Resolution);
            this.groupBox2.Controls.Add(this.numHerbivore);
            this.groupBox2.Controls.Add(this.label_Density);
            this.groupBox2.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(13, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(415, 108);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Количество";
            // 
            // numPredators
            // 
            this.numPredators.Location = new System.Drawing.Point(32, 59);
            this.numPredators.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numPredators.Name = "numPredators";
            this.numPredators.Size = new System.Drawing.Size(120, 31);
            this.numPredators.TabIndex = 11;
            this.numPredators.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            // 
            // label_Resolution
            // 
            this.label_Resolution.AutoSize = true;
            this.label_Resolution.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(159)))), ((int)(((byte)(58)))));
            this.label_Resolution.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Resolution.Location = new System.Drawing.Point(28, 34);
            this.label_Resolution.Name = "label_Resolution";
            this.label_Resolution.Size = new System.Drawing.Size(91, 22);
            this.label_Resolution.TabIndex = 10;
            this.label_Resolution.Text = "Хищников";
            // 
            // numHerbivore
            // 
            this.numHerbivore.Location = new System.Drawing.Point(256, 59);
            this.numHerbivore.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numHerbivore.Name = "numHerbivore";
            this.numHerbivore.Size = new System.Drawing.Size(120, 31);
            this.numHerbivore.TabIndex = 13;
            this.numHerbivore.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label_Density
            // 
            this.label_Density.AutoSize = true;
            this.label_Density.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Density.Location = new System.Drawing.Point(252, 34);
            this.label_Density.Name = "label_Density";
            this.label_Density.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label_Density.Size = new System.Drawing.Size(116, 22);
            this.label_Density.TabIndex = 12;
            this.label_Density.Text = "Травоядных";
            // 
            // button1_Pause
            // 
            this.button1_Pause.BackColor = System.Drawing.Color.White;
            this.button1_Pause.Enabled = false;
            this.button1_Pause.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1_Pause.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button1_Pause.Location = new System.Drawing.Point(127, 296);
            this.button1_Pause.Name = "button1_Pause";
            this.button1_Pause.Size = new System.Drawing.Size(160, 56);
            this.button1_Pause.TabIndex = 18;
            this.button1_Pause.Text = "Пауза";
            this.button1_Pause.UseVisualStyleBackColor = false;
            this.button1_Pause.Click += new System.EventHandler(this.button1_Pause_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(159)))), ((int)(((byte)(58)))));
            this.groupBox1.Controls.Add(this.label_Track);
            this.groupBox1.Controls.Add(this.trackBar1);
            this.groupBox1.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(127, 500);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(160, 120);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Скорость симуляции";
            // 
            // label_Track
            // 
            this.label_Track.AutoSize = true;
            this.label_Track.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(159)))), ((int)(((byte)(58)))));
            this.label_Track.Font = new System.Drawing.Font("Modern No. 20", 14.25F);
            this.label_Track.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_Track.Location = new System.Drawing.Point(60, 72);
            this.label_Track.Name = "label_Track";
            this.label_Track.Size = new System.Drawing.Size(37, 21);
            this.label_Track.TabIndex = 7;
            this.label_Track.Text = "100";
            // 
            // trackBar1
            // 
            this.trackBar1.LargeChange = 1;
            this.trackBar1.Location = new System.Drawing.Point(21, 24);
            this.trackBar1.Maximum = 300;
            this.trackBar1.Minimum = 20;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.trackBar1.Size = new System.Drawing.Size(120, 45);
            this.trackBar1.TabIndex = 1;
            this.trackBar1.TickFrequency = 100;
            this.trackBar1.Value = 50;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label_generation
            // 
            this.label_generation.AutoSize = true;
            this.label_generation.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_generation.Location = new System.Drawing.Point(144, 643);
            this.label_generation.Name = "label_generation";
            this.label_generation.Size = new System.Drawing.Size(110, 21);
            this.label_generation.TabIndex = 16;
            this.label_generation.Text = "Generation 0";
            this.label_generation.Visible = false;
            // 
            // button_Reset
            // 
            this.button_Reset.BackColor = System.Drawing.Color.White;
            this.button_Reset.Enabled = false;
            this.button_Reset.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_Reset.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button_Reset.Location = new System.Drawing.Point(127, 358);
            this.button_Reset.Name = "button_Reset";
            this.button_Reset.Size = new System.Drawing.Size(160, 56);
            this.button_Reset.TabIndex = 15;
            this.button_Reset.Text = "Сброс";
            this.button_Reset.UseVisualStyleBackColor = false;
            this.button_Reset.Click += new System.EventHandler(this.button_Finish_Click);
            // 
            // button_Start
            // 
            this.button_Start.BackColor = System.Drawing.Color.White;
            this.button_Start.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button_Start.Location = new System.Drawing.Point(127, 172);
            this.button_Start.Name = "button_Start";
            this.button_Start.Size = new System.Drawing.Size(160, 56);
            this.button_Start.TabIndex = 14;
            this.button_Start.Text = "Начать";
            this.button_Start.UseVisualStyleBackColor = false;
            this.button_Start.Click += new System.EventHandler(this.button_Start_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 756);
            this.Controls.Add(splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MaximumSize = new System.Drawing.Size(1500, 795);
            this.MinimumSize = new System.Drawing.Size(1500, 795);
            this.Name = "Form1";
            this.Text = "Natural  Selection";
            this.Load += new System.EventHandler(this.Form1_Load);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(splitContainer1)).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPredators)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHerbivore)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);

    }

    #endregion
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Label label_Track;
    private System.Windows.Forms.TrackBar trackBar1;
    private System.Windows.Forms.Label label_generation;
    private System.Windows.Forms.Button button_Reset;
    private System.Windows.Forms.NumericUpDown numHerbivore;
    private System.Windows.Forms.Label label_Density;
    private System.Windows.Forms.NumericUpDown numPredators;
    private System.Windows.Forms.Label label_Resolution;
    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.Timer timer1;
    private System.Windows.Forms.Button button1_Pause;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.Button button_settings;
    private System.Windows.Forms.Button button_Start;
    private System.Windows.Forms.Button button_Exit;
    private System.Windows.Forms.PictureBox pictureBox_logo;
}
}

