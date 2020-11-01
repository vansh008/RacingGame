namespace RacingGame
{
    partial class ZoombieForm
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
            this.Better = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.JerryButton = new System.Windows.Forms.RadioButton();
            this.alButton = new System.Windows.Forms.RadioButton();
            this.TomButton = new System.Windows.Forms.RadioButton();
            this.txtMaxBet = new System.Windows.Forms.Label();
            this.numBetAmount = new System.Windows.Forms.NumericUpDown();
            this.numThingNumber = new System.Windows.Forms.NumericUpDown();
            this.btnBet = new System.Windows.Forms.Button();
            this.lblBetStatus1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblBetStatus2 = new System.Windows.Forms.Label();
            this.lblBetStatus3 = new System.Windows.Forms.Label();
            this.PB4 = new System.Windows.Forms.PictureBox();
            this.PB3 = new System.Windows.Forms.PictureBox();
            this.PB2 = new System.Windows.Forms.PictureBox();
            this.PB1 = new System.Windows.Forms.PictureBox();
            this.pbBackground = new System.Windows.Forms.PictureBox();
            this.btnRace = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numBetAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numThingNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // Better
            // 
            this.Better.AutoSize = true;
            this.Better.Location = new System.Drawing.Point(247, 384);
            this.Better.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Better.Name = "Better";
            this.Better.Size = new System.Drawing.Size(46, 17);
            this.Better.TabIndex = 0;
            this.Better.Text = "Better";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(247, 428);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "on ghost";
            // 
            // JerryButton
            // 
            this.JerryButton.AutoSize = true;
            this.JerryButton.Location = new System.Drawing.Point(43, 379);
            this.JerryButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.JerryButton.Name = "JerryButton";
            this.JerryButton.Size = new System.Drawing.Size(61, 21);
            this.JerryButton.TabIndex = 2;
            this.JerryButton.TabStop = true;
            this.JerryButton.Tag = "0";
            this.JerryButton.Text = "Jerry";
            this.JerryButton.UseVisualStyleBackColor = true;
            this.JerryButton.CheckedChanged += new System.EventHandler(this.allBetters_CheckedChanged);
            // 
            // alButton
            // 
            this.alButton.AutoSize = true;
            this.alButton.Location = new System.Drawing.Point(43, 406);
            this.alButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.alButton.Name = "alButton";
            this.alButton.Size = new System.Drawing.Size(41, 21);
            this.alButton.TabIndex = 3;
            this.alButton.TabStop = true;
            this.alButton.Tag = "1";
            this.alButton.Text = "Al";
            this.alButton.UseVisualStyleBackColor = true;
            this.alButton.CheckedChanged += new System.EventHandler(this.allBetters_CheckedChanged);
            // 
            // TomButton
            // 
            this.TomButton.AutoSize = true;
            this.TomButton.Location = new System.Drawing.Point(43, 436);
            this.TomButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TomButton.Name = "TomButton";
            this.TomButton.Size = new System.Drawing.Size(57, 21);
            this.TomButton.TabIndex = 4;
            this.TomButton.TabStop = true;
            this.TomButton.Tag = "2";
            this.TomButton.Text = "Tom";
            this.TomButton.UseVisualStyleBackColor = true;
            this.TomButton.CheckedChanged += new System.EventHandler(this.allBetters_CheckedChanged);
            // 
            // txtMaxBet
            // 
            this.txtMaxBet.AutoSize = true;
            this.txtMaxBet.Location = new System.Drawing.Point(108, 395);
            this.txtMaxBet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtMaxBet.Name = "txtMaxBet";
            this.txtMaxBet.Size = new System.Drawing.Size(58, 17);
            this.txtMaxBet.TabIndex = 5;
            this.txtMaxBet.Text = "Max Bet";
            // 
            // numBetAmount
            // 
            this.numBetAmount.Location = new System.Drawing.Point(400, 382);
            this.numBetAmount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numBetAmount.Name = "numBetAmount";
            this.numBetAmount.Size = new System.Drawing.Size(160, 22);
            this.numBetAmount.TabIndex = 6;
            // 
            // numThingNumber
            // 
            this.numThingNumber.Location = new System.Drawing.Point(400, 426);
            this.numThingNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numThingNumber.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numThingNumber.Name = "numThingNumber";
            this.numThingNumber.Size = new System.Drawing.Size(160, 22);
            this.numThingNumber.TabIndex = 7;
            // 
            // btnBet
            // 
            this.btnBet.Location = new System.Drawing.Point(595, 454);
            this.btnBet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBet.Name = "btnBet";
            this.btnBet.Size = new System.Drawing.Size(100, 28);
            this.btnBet.TabIndex = 10;
            this.btnBet.Text = "Bet";
            this.btnBet.UseVisualStyleBackColor = true;
            this.btnBet.Click += new System.EventHandler(this.btnBet_Click);
            // 
            // lblBetStatus1
            // 
            this.lblBetStatus1.AutoSize = true;
            this.lblBetStatus1.Location = new System.Drawing.Point(636, 366);
            this.lblBetStatus1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBetStatus1.Name = "lblBetStatus1";
            this.lblBetStatus1.Size = new System.Drawing.Size(115, 17);
            this.lblBetStatus1.TabIndex = 11;
            this.lblBetStatus1.Text = "Jerry has not bet";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(583, 428);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 12;
            // 
            // lblBetStatus2
            // 
            this.lblBetStatus2.AutoSize = true;
            this.lblBetStatus2.Location = new System.Drawing.Point(636, 395);
            this.lblBetStatus2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBetStatus2.Name = "lblBetStatus2";
            this.lblBetStatus2.Size = new System.Drawing.Size(95, 17);
            this.lblBetStatus2.TabIndex = 13;
            this.lblBetStatus2.Text = "Al has not bet";
            // 
            // lblBetStatus3
            // 
            this.lblBetStatus3.AutoSize = true;
            this.lblBetStatus3.Location = new System.Drawing.Point(636, 418);
            this.lblBetStatus3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBetStatus3.Name = "lblBetStatus3";
            this.lblBetStatus3.Size = new System.Drawing.Size(111, 17);
            this.lblBetStatus3.TabIndex = 14;
            this.lblBetStatus3.Text = "Tom has not bet";
            // 
            // PB4
            // 
            this.PB4.Image = global::RacingGame.Resource1.Yellow;
            this.PB4.Location = new System.Drawing.Point(32, 244);
            this.PB4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PB4.Name = "PB4";
            this.PB4.Size = new System.Drawing.Size(75, 62);
            this.PB4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB4.TabIndex = 20;
            this.PB4.TabStop = false;
            // 
            // PB3
            // 
            this.PB3.Image = global::RacingGame.Resource1.Red;
            this.PB3.Location = new System.Drawing.Point(31, 164);
            this.PB3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PB3.Name = "PB3";
            this.PB3.Size = new System.Drawing.Size(75, 62);
            this.PB3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB3.TabIndex = 19;
            this.PB3.TabStop = false;
            // 
            // PB2
            // 
            this.PB2.Image = global::RacingGame.Resource1.Pink;
            this.PB2.Location = new System.Drawing.Point(29, 84);
            this.PB2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PB2.Name = "PB2";
            this.PB2.Size = new System.Drawing.Size(76, 62);
            this.PB2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB2.TabIndex = 18;
            this.PB2.TabStop = false;
            // 
            // PB1
            // 
            this.PB1.Image = global::RacingGame.Resource1.Blue;
            this.PB1.Location = new System.Drawing.Point(29, 15);
            this.PB1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PB1.Name = "PB1";
            this.PB1.Size = new System.Drawing.Size(75, 62);
            this.PB1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB1.TabIndex = 17;
            this.PB1.TabStop = false;
            // 
            // pbBackground
            // 
            this.pbBackground.Image = global::RacingGame.Resource1.ZombieGraveyard;
            this.pbBackground.Location = new System.Drawing.Point(3, -1);
            this.pbBackground.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbBackground.Name = "pbBackground";
            this.pbBackground.Size = new System.Drawing.Size(1249, 359);
            this.pbBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBackground.TabIndex = 21;
            this.pbBackground.TabStop = false;
            // 
            // btnRace
            // 
            this.btnRace.Location = new System.Drawing.Point(765, 454);
            this.btnRace.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRace.Name = "btnRace";
            this.btnRace.Size = new System.Drawing.Size(100, 28);
            this.btnRace.TabIndex = 22;
            this.btnRace.Text = "Race";
            this.btnRace.UseVisualStyleBackColor = true;
            this.btnRace.Click += new System.EventHandler(this.btnRace_Click);
            // 
            // ZoombieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 497);
            this.Controls.Add(this.btnRace);
            this.Controls.Add(this.PB4);
            this.Controls.Add(this.PB3);
            this.Controls.Add(this.PB2);
            this.Controls.Add(this.PB1);
            this.Controls.Add(this.lblBetStatus3);
            this.Controls.Add(this.lblBetStatus2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblBetStatus1);
            this.Controls.Add(this.btnBet);
            this.Controls.Add(this.numThingNumber);
            this.Controls.Add(this.numBetAmount);
            this.Controls.Add(this.txtMaxBet);
            this.Controls.Add(this.TomButton);
            this.Controls.Add(this.alButton);
            this.Controls.Add(this.JerryButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Better);
            this.Controls.Add(this.pbBackground);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ZoombieForm";
            this.Text = "Zoobie World";
            ((System.ComponentModel.ISupportInitialize)(this.numBetAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numThingNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Better;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton JerryButton;
        private System.Windows.Forms.RadioButton alButton;
        private System.Windows.Forms.RadioButton TomButton;
        private System.Windows.Forms.Label txtMaxBet;
        private System.Windows.Forms.NumericUpDown numBetAmount;
        private System.Windows.Forms.NumericUpDown numThingNumber;
        private System.Windows.Forms.Button btnBet;
        private System.Windows.Forms.Label lblBetStatus1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblBetStatus2;
        private System.Windows.Forms.Label lblBetStatus3;
        private System.Windows.Forms.PictureBox PB1;
        private System.Windows.Forms.PictureBox PB2;
        private System.Windows.Forms.PictureBox PB3;
        private System.Windows.Forms.PictureBox PB4;
        private System.Windows.Forms.PictureBox pbBackground;
        private System.Windows.Forms.Button btnRace;
    }
}

