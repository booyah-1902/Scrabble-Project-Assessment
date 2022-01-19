namespace Scrabble_Project_Assessment
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
            this.txtUserInput = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblPoints = new System.Windows.Forms.Label();
            this.lblPower = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblScrabble = new System.Windows.Forms.Label();
            this.btnRandom = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lbl6 = new System.Windows.Forms.Label();
            this.lbl7 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.pnlStart = new System.Windows.Forms.Panel();
            this.pnlGame = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlOption = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.btnSurvival = new System.Windows.Forms.Button();
            this.btnBullet = new System.Windows.Forms.Button();
            this.btnRapid = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pnlStart.SuspendLayout();
            this.pnlGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnlOption.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUserInput
            // 
            this.txtUserInput.Location = new System.Drawing.Point(108, 56);
            this.txtUserInput.Name = "txtUserInput";
            this.txtUserInput.Size = new System.Drawing.Size(233, 20);
            this.txtUserInput.TabIndex = 0;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(180, 81);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(83, 23);
            this.btnSubmit.TabIndex = 1;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(81, 94);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(83, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // lblPoints
            // 
            this.lblPoints.AutoSize = true;
            this.lblPoints.Location = new System.Drawing.Point(454, 10);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(36, 13);
            this.lblPoints.TabIndex = 4;
            this.lblPoints.Text = "Points";
            // 
            // lblPower
            // 
            this.lblPower.AutoSize = true;
            this.lblPower.Location = new System.Drawing.Point(3, 10);
            this.lblPower.Name = "lblPower";
            this.lblPower.Size = new System.Drawing.Size(56, 13);
            this.lblPower.TabIndex = 11;
            this.lblPower.Text = "PowerUps";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(81, 63);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(83, 25);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Play";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.Button4_Click);
            // 
            // lblScrabble
            // 
            this.lblScrabble.AutoSize = true;
            this.lblScrabble.Font = new System.Drawing.Font("Zamenhof Plain", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScrabble.Location = new System.Drawing.Point(20, 10);
            this.lblScrabble.Name = "lblScrabble";
            this.lblScrabble.Size = new System.Drawing.Size(206, 38);
            this.lblScrabble.TabIndex = 12;
            this.lblScrabble.Text = "Scrabble.";
            this.lblScrabble.Click += new System.EventHandler(this.lblScrabble_Click);
            // 
            // btnRandom
            // 
            this.btnRandom.Location = new System.Drawing.Point(264, 81);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(87, 23);
            this.btnRandom.TabIndex = 13;
            this.btnRandom.Text = "Shuffle";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(20, 164);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(35, 13);
            this.lbl1.TabIndex = 14;
            this.lbl1.Text = "label1";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(149, 164);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(35, 13);
            this.lbl3.TabIndex = 15;
            this.lbl3.Text = "label3";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(215, 164);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(35, 13);
            this.lbl4.TabIndex = 16;
            this.lbl4.Text = "label4";
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Location = new System.Drawing.Point(288, 164);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(35, 13);
            this.lbl5.TabIndex = 17;
            this.lbl5.Text = "label5";
            // 
            // lbl6
            // 
            this.lbl6.AutoSize = true;
            this.lbl6.Location = new System.Drawing.Point(356, 164);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(35, 13);
            this.lbl6.TabIndex = 18;
            this.lbl6.Text = "label6";
            // 
            // lbl7
            // 
            this.lbl7.AutoSize = true;
            this.lbl7.Location = new System.Drawing.Point(431, 164);
            this.lbl7.Name = "lbl7";
            this.lbl7.Size = new System.Drawing.Size(35, 13);
            this.lbl7.TabIndex = 19;
            this.lbl7.Text = "label7";
            this.lbl7.Click += new System.EventHandler(this.lbl7_Click);
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(83, 164);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(35, 13);
            this.lbl2.TabIndex = 29;
            this.lbl2.Text = "label2";
            // 
            // pnlStart
            // 
            this.pnlStart.Controls.Add(this.lblScrabble);
            this.pnlStart.Controls.Add(this.btnExit);
            this.pnlStart.Controls.Add(this.btnStart);
            this.pnlStart.Location = new System.Drawing.Point(2, 3);
            this.pnlStart.Name = "pnlStart";
            this.pnlStart.Size = new System.Drawing.Size(246, 126);
            this.pnlStart.TabIndex = 30;
            this.pnlStart.Visible = false;
            // 
            // pnlGame
            // 
            this.pnlGame.Controls.Add(this.pictureBox3);
            this.pnlGame.Controls.Add(this.pictureBox1);
            this.pnlGame.Controls.Add(this.pictureBox2);
            this.pnlGame.Controls.Add(this.button4);
            this.pnlGame.Controls.Add(this.label5);
            this.pnlGame.Controls.Add(this.lblPower);
            this.pnlGame.Controls.Add(this.lbl2);
            this.pnlGame.Controls.Add(this.btnSubmit);
            this.pnlGame.Controls.Add(this.lbl7);
            this.pnlGame.Controls.Add(this.txtUserInput);
            this.pnlGame.Controls.Add(this.lbl6);
            this.pnlGame.Controls.Add(this.lblPoints);
            this.pnlGame.Controls.Add(this.lbl5);
            this.pnlGame.Controls.Add(this.btnRandom);
            this.pnlGame.Controls.Add(this.lbl4);
            this.pnlGame.Controls.Add(this.lbl1);
            this.pnlGame.Controls.Add(this.lbl3);
            this.pnlGame.Location = new System.Drawing.Point(2, 135);
            this.pnlGame.Name = "pnlGame";
            this.pnlGame.Size = new System.Drawing.Size(493, 186);
            this.pnlGame.TabIndex = 31;
            this.pnlGame.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(247, 10);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(23, 25);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 38;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(180, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(215, 10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(23, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 36;
            this.pictureBox2.TabStop = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(96, 81);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(83, 23);
            this.button4.TabIndex = 34;
            this.button4.Text = "Tiles Left";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(412, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "Timer";
            // 
            // pnlOption
            // 
            this.pnlOption.Controls.Add(this.pictureBox6);
            this.pnlOption.Controls.Add(this.pictureBox5);
            this.pnlOption.Controls.Add(this.pictureBox4);
            this.pnlOption.Controls.Add(this.btnSurvival);
            this.pnlOption.Controls.Add(this.btnBullet);
            this.pnlOption.Controls.Add(this.btnRapid);
            this.pnlOption.Location = new System.Drawing.Point(249, 3);
            this.pnlOption.Name = "pnlOption";
            this.pnlOption.Size = new System.Drawing.Size(246, 126);
            this.pnlOption.TabIndex = 31;
            this.pnlOption.Visible = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(45, 73);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(36, 38);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 39;
            this.pictureBox5.TabStop = false;
            // 
            // btnSurvival
            // 
            this.btnSurvival.Location = new System.Drawing.Point(81, 80);
            this.btnSurvival.Name = "btnSurvival";
            this.btnSurvival.Size = new System.Drawing.Size(83, 25);
            this.btnSurvival.TabIndex = 5;
            this.btnSurvival.Text = "Survival";
            this.btnSurvival.UseVisualStyleBackColor = true;
            this.btnSurvival.Click += new System.EventHandler(this.btnSurvival_Click);
            // 
            // btnBullet
            // 
            this.btnBullet.Location = new System.Drawing.Point(81, 20);
            this.btnBullet.Name = "btnBullet";
            this.btnBullet.Size = new System.Drawing.Size(83, 25);
            this.btnBullet.TabIndex = 4;
            this.btnBullet.Text = "3min";
            this.btnBullet.UseVisualStyleBackColor = true;
            this.btnBullet.Click += new System.EventHandler(this.btnBullet_Click);
            // 
            // btnRapid
            // 
            this.btnRapid.Location = new System.Drawing.Point(81, 51);
            this.btnRapid.Name = "btnRapid";
            this.btnRapid.Size = new System.Drawing.Size(83, 25);
            this.btnRapid.TabIndex = 0;
            this.btnRapid.Text = "5min";
            this.btnRapid.UseVisualStyleBackColor = true;
            this.btnRapid.Click += new System.EventHandler(this.btnRapid_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(51, 17);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(30, 31);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 38;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(46, 49);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(36, 28);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 40;
            this.pictureBox6.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(498, 326);
            this.Controls.Add(this.pnlOption);
            this.Controls.Add(this.pnlStart);
            this.Controls.Add(this.pnlGame);
            this.Name = "Form1";
            this.Text = "Scrabble";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlStart.ResumeLayout(false);
            this.pnlStart.PerformLayout();
            this.pnlGame.ResumeLayout(false);
            this.pnlGame.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnlOption.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtUserInput;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblPoints;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblPower;
        private System.Windows.Forms.Label lblScrabble;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lbl6;
        private System.Windows.Forms.Label lbl7;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Panel pnlStart;
        private System.Windows.Forms.Panel pnlGame;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnlOption;
        private System.Windows.Forms.Button btnSurvival;
        private System.Windows.Forms.Button btnBullet;
        private System.Windows.Forms.Button btnRapid;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox6;
    }
}

