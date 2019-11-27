namespace BullRace
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.racetrack = new System.Windows.Forms.PictureBox();
            this.Bull1 = new System.Windows.Forms.PictureBox();
            this.Bull2 = new System.Windows.Forms.PictureBox();
            this.Bull3 = new System.Windows.Forms.PictureBox();
            this.Bull4 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SachinBet = new System.Windows.Forms.Label();
            this.KumarBet = new System.Windows.Forms.Label();
            this.PranshuBet = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.race = new System.Windows.Forms.Button();
            this.BullNumber = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.BettingAmount = new System.Windows.Forms.NumericUpDown();
            this.Bets = new System.Windows.Forms.Button();
            this.SachinButton = new System.Windows.Forms.RadioButton();
            this.KumarButton = new System.Windows.Forms.RadioButton();
            this.PranshuButton = new System.Windows.Forms.RadioButton();
            this.MaximumBet = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.racetrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bull1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bull2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bull3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bull4)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BullNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BettingAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // racetrack
            // 
            this.racetrack.BackColor = System.Drawing.SystemColors.Control;
            this.racetrack.Image = ((System.Drawing.Image)(resources.GetObject("racetrack.Image")));
            this.racetrack.Location = new System.Drawing.Point(-1, -79);
            this.racetrack.Margin = new System.Windows.Forms.Padding(4);
            this.racetrack.Name = "racetrack";
            this.racetrack.Size = new System.Drawing.Size(1069, 527);
            this.racetrack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.racetrack.TabIndex = 0;
            this.racetrack.TabStop = false;
            // 
            // Bull1
            // 
            this.Bull1.Image = ((System.Drawing.Image)(resources.GetObject("Bull1.Image")));
            this.Bull1.Location = new System.Drawing.Point(18, 2);
            this.Bull1.Margin = new System.Windows.Forms.Padding(4);
            this.Bull1.Name = "Bull1";
            this.Bull1.Size = new System.Drawing.Size(154, 79);
            this.Bull1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Bull1.TabIndex = 1;
            this.Bull1.TabStop = false;
            // 
            // Bull2
            // 
            this.Bull2.Image = ((System.Drawing.Image)(resources.GetObject("Bull2.Image")));
            this.Bull2.Location = new System.Drawing.Point(18, 116);
            this.Bull2.Margin = new System.Windows.Forms.Padding(4);
            this.Bull2.Name = "Bull2";
            this.Bull2.Size = new System.Drawing.Size(154, 79);
            this.Bull2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Bull2.TabIndex = 2;
            this.Bull2.TabStop = false;
            // 
            // Bull3
            // 
            this.Bull3.Image = ((System.Drawing.Image)(resources.GetObject("Bull3.Image")));
            this.Bull3.Location = new System.Drawing.Point(18, 224);
            this.Bull3.Margin = new System.Windows.Forms.Padding(4);
            this.Bull3.Name = "Bull3";
            this.Bull3.Size = new System.Drawing.Size(154, 79);
            this.Bull3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Bull3.TabIndex = 3;
            this.Bull3.TabStop = false;
            // 
            // Bull4
            // 
            this.Bull4.Image = ((System.Drawing.Image)(resources.GetObject("Bull4.Image")));
            this.Bull4.Location = new System.Drawing.Point(18, 339);
            this.Bull4.Margin = new System.Windows.Forms.Padding(4);
            this.Bull4.Name = "Bull4";
            this.Bull4.Size = new System.Drawing.Size(154, 79);
            this.Bull4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Bull4.TabIndex = 4;
            this.Bull4.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.SachinBet);
            this.groupBox1.Controls.Add(this.KumarBet);
            this.groupBox1.Controls.Add(this.PranshuBet);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.race);
            this.groupBox1.Controls.Add(this.BullNumber);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.BettingAmount);
            this.groupBox1.Controls.Add(this.Bets);
            this.groupBox1.Controls.Add(this.SachinButton);
            this.groupBox1.Controls.Add(this.KumarButton);
            this.groupBox1.Controls.Add(this.PranshuButton);
            this.groupBox1.Controls.Add(this.MaximumBet);
            this.groupBox1.Location = new System.Drawing.Point(-1, 455);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1069, 207);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Place Bet Here";
            // 
            // SachinBet
            // 
            this.SachinBet.BackColor = System.Drawing.SystemColors.Info;
            this.SachinBet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SachinBet.Location = new System.Drawing.Point(649, 110);
            this.SachinBet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SachinBet.Name = "SachinBet";
            this.SachinBet.Size = new System.Drawing.Size(386, 20);
            this.SachinBet.TabIndex = 13;
            this.SachinBet.Text = "label6";
            // 
            // KumarBet
            // 
            this.KumarBet.BackColor = System.Drawing.SystemColors.Info;
            this.KumarBet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.KumarBet.Location = new System.Drawing.Point(649, 80);
            this.KumarBet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.KumarBet.Name = "KumarBet";
            this.KumarBet.Size = new System.Drawing.Size(386, 20);
            this.KumarBet.TabIndex = 12;
            this.KumarBet.Text = "label5";
            // 
            // PranshuBet
            // 
            this.PranshuBet.BackColor = System.Drawing.SystemColors.Info;
            this.PranshuBet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PranshuBet.Location = new System.Drawing.Point(649, 50);
            this.PranshuBet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PranshuBet.Name = "PranshuBet";
            this.PranshuBet.Size = new System.Drawing.Size(386, 20);
            this.PranshuBet.TabIndex = 11;
            this.PranshuBet.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(645, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Bets";
            // 
            // race
            // 
            this.race.BackColor = System.Drawing.Color.Tan;
            this.race.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.race.FlatAppearance.BorderSize = 5;
            this.race.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.race.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.race.Location = new System.Drawing.Point(380, 156);
            this.race.Margin = new System.Windows.Forms.Padding(4);
            this.race.Name = "race";
            this.race.Size = new System.Drawing.Size(180, 37);
            this.race.TabIndex = 9;
            this.race.Text = "START RACE";
            this.race.UseVisualStyleBackColor = false;
            this.race.Click += new System.EventHandler(this.race_Click);
            // 
            // BullNumber
            // 
            this.BullNumber.Location = new System.Drawing.Point(502, 106);
            this.BullNumber.Margin = new System.Windows.Forms.Padding(4);
            this.BullNumber.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.BullNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.BullNumber.Name = "BullNumber";
            this.BullNumber.Size = new System.Drawing.Size(85, 22);
            this.BullNumber.TabIndex = 8;
            this.BullNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(352, 111);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Bull number";
            // 
            // BettingAmount
            // 
            this.BettingAmount.Location = new System.Drawing.Point(504, 47);
            this.BettingAmount.Margin = new System.Windows.Forms.Padding(4);
            this.BettingAmount.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.BettingAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.BettingAmount.Name = "BettingAmount";
            this.BettingAmount.Size = new System.Drawing.Size(84, 22);
            this.BettingAmount.TabIndex = 6;
            this.BettingAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Bets
            // 
            this.Bets.BackColor = System.Drawing.Color.Tan;
            this.Bets.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Bets.FlatAppearance.BorderSize = 5;
            this.Bets.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Bets.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bets.Location = new System.Drawing.Point(285, 37);
            this.Bets.Margin = new System.Windows.Forms.Padding(4);
            this.Bets.Name = "Bets";
            this.Bets.Size = new System.Drawing.Size(164, 44);
            this.Bets.TabIndex = 5;
            this.Bets.Text = "Place Bet";
            this.Bets.UseVisualStyleBackColor = false;
            this.Bets.Click += new System.EventHandler(this.Bets_Click);
            // 
            // SachinButton
            // 
            this.SachinButton.AutoSize = true;
            this.SachinButton.Checked = true;
            this.SachinButton.Location = new System.Drawing.Point(19, 119);
            this.SachinButton.Margin = new System.Windows.Forms.Padding(4);
            this.SachinButton.Name = "SachinButton";
            this.SachinButton.Size = new System.Drawing.Size(72, 21);
            this.SachinButton.TabIndex = 3;
            this.SachinButton.TabStop = true;
            this.SachinButton.Text = "Sachin";
            this.SachinButton.UseVisualStyleBackColor = true;
            this.SachinButton.CheckedChanged += new System.EventHandler(this.SachineButton_CheckedChanged);
            // 
            // KumarButton
            // 
            this.KumarButton.AutoSize = true;
            this.KumarButton.Location = new System.Drawing.Point(19, 90);
            this.KumarButton.Margin = new System.Windows.Forms.Padding(4);
            this.KumarButton.Name = "KumarButton";
            this.KumarButton.Size = new System.Drawing.Size(70, 21);
            this.KumarButton.TabIndex = 2;
            this.KumarButton.Text = "Kumar";
            this.KumarButton.UseVisualStyleBackColor = true;
            this.KumarButton.CheckedChanged += new System.EventHandler(this.KumarButton_CheckedChanged);
            // 
            // PranshuButton
            // 
            this.PranshuButton.AutoSize = true;
            this.PranshuButton.Location = new System.Drawing.Point(19, 60);
            this.PranshuButton.Margin = new System.Windows.Forms.Padding(4);
            this.PranshuButton.Name = "PranshuButton";
            this.PranshuButton.Size = new System.Drawing.Size(82, 21);
            this.PranshuButton.TabIndex = 1;
            this.PranshuButton.Text = "Pranshu";
            this.PranshuButton.UseVisualStyleBackColor = true;
            this.PranshuButton.CheckedChanged += new System.EventHandler(this.PranshuButton_CheckedChanged);
            // 
            // MaximumBet
            // 
            this.MaximumBet.AutoSize = true;
            this.MaximumBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximumBet.Location = new System.Drawing.Point(15, 30);
            this.MaximumBet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MaximumBet.Name = "MaximumBet";
            this.MaximumBet.Size = new System.Drawing.Size(120, 20);
            this.MaximumBet.TabIndex = 0;
            this.MaximumBet.Text = "Maximum bet";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 661);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Bull4);
            this.Controls.Add(this.Bull3);
            this.Controls.Add(this.Bull2);
            this.Controls.Add(this.Bull1);
            this.Controls.Add(this.racetrack);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bull Race";
            ((System.ComponentModel.ISupportInitialize)(this.racetrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bull1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bull2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bull3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bull4)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BullNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BettingAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox racetrack;
        private System.Windows.Forms.PictureBox Bull1;
        private System.Windows.Forms.PictureBox Bull2;
        private System.Windows.Forms.PictureBox Bull3;
        private System.Windows.Forms.PictureBox Bull4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton SachinButton;
        private System.Windows.Forms.RadioButton KumarButton;
        private System.Windows.Forms.RadioButton PranshuButton;
        private System.Windows.Forms.Label MaximumBet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown BettingAmount;
        private System.Windows.Forms.Button Bets;
        private System.Windows.Forms.NumericUpDown BullNumber;
        private System.Windows.Forms.Button race;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label PranshuBet;
        private System.Windows.Forms.Label SachinBet;
        private System.Windows.Forms.Label KumarBet;
    }
}
