namespace RussianRoulette
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ButtonBulletLoad = new System.Windows.Forms.Button();
            this.ButtonChamberSpin = new System.Windows.Forms.Button();
            this.btnPlayAgain = new System.Windows.Forms.Button();
            this.buttonFireGun = new System.Windows.Forms.Button();
            this.LabelTurnInfo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblWin = new System.Windows.Forms.Label();
            this.lblLose = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblDead = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblDeadInfo = new System.Windows.Forms.Label();
            this.LabelGameResult = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonBulletLoad
            // 
            this.ButtonBulletLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonBulletLoad.Image = ((System.Drawing.Image)(resources.GetObject("ButtonBulletLoad.Image")));
            this.ButtonBulletLoad.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonBulletLoad.Location = new System.Drawing.Point(591, 318);
            this.ButtonBulletLoad.Name = "ButtonBulletLoad";
            this.ButtonBulletLoad.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ButtonBulletLoad.Size = new System.Drawing.Size(221, 75);
            this.ButtonBulletLoad.TabIndex = 0;
            this.ButtonBulletLoad.Text = "Load Bullet";
            this.ButtonBulletLoad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonBulletLoad.UseVisualStyleBackColor = true;
            this.ButtonBulletLoad.Click += new System.EventHandler(this.ButtonBulletLoad_Click);
            // 
            // ButtonChamberSpin
            // 
            this.ButtonChamberSpin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonChamberSpin.Image = ((System.Drawing.Image)(resources.GetObject("ButtonChamberSpin.Image")));
            this.ButtonChamberSpin.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonChamberSpin.Location = new System.Drawing.Point(591, 412);
            this.ButtonChamberSpin.Name = "ButtonChamberSpin";
            this.ButtonChamberSpin.Size = new System.Drawing.Size(221, 89);
            this.ButtonChamberSpin.TabIndex = 1;
            this.ButtonChamberSpin.Text = "Spin Chamber";
            this.ButtonChamberSpin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonChamberSpin.UseVisualStyleBackColor = true;
            this.ButtonChamberSpin.Click += new System.EventHandler(this.ButtonChamberSpin_Click);
            // 
            // btnPlayAgain
            // 
            this.btnPlayAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayAgain.Image = ((System.Drawing.Image)(resources.GetObject("btnPlayAgain.Image")));
            this.btnPlayAgain.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPlayAgain.Location = new System.Drawing.Point(591, 518);
            this.btnPlayAgain.Name = "btnPlayAgain";
            this.btnPlayAgain.Size = new System.Drawing.Size(221, 86);
            this.btnPlayAgain.TabIndex = 2;
            this.btnPlayAgain.Text = "Play Again";
            this.btnPlayAgain.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlayAgain.UseVisualStyleBackColor = true;
            this.btnPlayAgain.Click += new System.EventHandler(this.btnPlayAgain_Click);
            // 
            // buttonFireGun
            // 
            this.buttonFireGun.BackColor = System.Drawing.Color.Red;
            this.buttonFireGun.Enabled = false;
            this.buttonFireGun.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFireGun.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonFireGun.Image = ((System.Drawing.Image)(resources.GetObject("buttonFireGun.Image")));
            this.buttonFireGun.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonFireGun.Location = new System.Drawing.Point(253, 518);
            this.buttonFireGun.Name = "buttonFireGun";
            this.buttonFireGun.Size = new System.Drawing.Size(133, 86);
            this.buttonFireGun.TabIndex = 3;
            this.buttonFireGun.Text = "Fire";
            this.buttonFireGun.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonFireGun.UseVisualStyleBackColor = false;
            this.buttonFireGun.Click += new System.EventHandler(this.buttonFireGun_ClickAsync);
            // 
            // LabelTurnInfo
            // 
            this.LabelTurnInfo.AutoSize = true;
            this.LabelTurnInfo.BackColor = System.Drawing.Color.Transparent;
            this.LabelTurnInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTurnInfo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.LabelTurnInfo.Location = new System.Drawing.Point(267, 267);
            this.LabelTurnInfo.Name = "LabelTurnInfo";
            this.LabelTurnInfo.Size = new System.Drawing.Size(0, 26);
            this.LabelTurnInfo.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(207, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Win :-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(692, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Lose :-";
            // 
            // lblWin
            // 
            this.lblWin.AutoSize = true;
            this.lblWin.BackColor = System.Drawing.Color.Transparent;
            this.lblWin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWin.ForeColor = System.Drawing.Color.Green;
            this.lblWin.Location = new System.Drawing.Point(268, 135);
            this.lblWin.Name = "lblWin";
            this.lblWin.Size = new System.Drawing.Size(19, 20);
            this.lblWin.TabIndex = 7;
            this.lblWin.Text = "0";
            // 
            // lblLose
            // 
            this.lblLose.AutoSize = true;
            this.lblLose.BackColor = System.Drawing.Color.Transparent;
            this.lblLose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLose.ForeColor = System.Drawing.Color.Red;
            this.lblLose.Location = new System.Drawing.Point(762, 135);
            this.lblLose.Name = "lblLose";
            this.lblLose.Size = new System.Drawing.Size(19, 20);
            this.lblLose.TabIndex = 8;
            this.lblLose.Text = "0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(211, 318);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(221, 192);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // lblDead
            // 
            this.lblDead.AutoSize = true;
            this.lblDead.BackColor = System.Drawing.Color.Black;
            this.lblDead.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDead.ForeColor = System.Drawing.Color.Red;
            this.lblDead.Location = new System.Drawing.Point(216, 412);
            this.lblDead.Name = "lblDead";
            this.lblDead.Size = new System.Drawing.Size(209, 26);
            this.lblDead.TabIndex = 10;
            this.lblDead.Text = "Player 2 is Dead!!!";
            this.lblDead.Visible = false;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.Color.Red;
            this.lblInfo.Location = new System.Drawing.Point(586, 267);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(178, 26);
            this.lblInfo.TabIndex = 11;
            this.lblInfo.Text = "Load The Bullet";
            // 
            // timer1
            // 
            this.timer1.Interval = 700;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblDeadInfo
            // 
            this.lblDeadInfo.AutoSize = true;
            this.lblDeadInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblDeadInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeadInfo.ForeColor = System.Drawing.Color.Red;
            this.lblDeadInfo.Location = new System.Drawing.Point(366, 188);
            this.lblDeadInfo.Name = "lblDeadInfo";
            this.lblDeadInfo.Size = new System.Drawing.Size(0, 31);
            this.lblDeadInfo.TabIndex = 12;
            this.lblDeadInfo.Visible = false;
            // 
            // LabelGameResult
            // 
            this.LabelGameResult.AutoSize = true;
            this.LabelGameResult.BackColor = System.Drawing.Color.Transparent;
            this.LabelGameResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelGameResult.ForeColor = System.Drawing.Color.Red;
            this.LabelGameResult.Location = new System.Drawing.Point(366, 219);
            this.LabelGameResult.Name = "LabelGameResult";
            this.LabelGameResult.Size = new System.Drawing.Size(0, 31);
            this.LabelGameResult.TabIndex = 13;
            this.LabelGameResult.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.label3.Location = new System.Drawing.Point(264, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(464, 46);
            this.label3.TabIndex = 14;
            this.label3.Text = "Russian Roulette Game";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExit.Location = new System.Drawing.Point(696, 627);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(114, 51);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LabelGameResult);
            this.Controls.Add(this.lblDeadInfo);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblDead);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblLose);
            this.Controls.Add(this.lblWin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LabelTurnInfo);
            this.Controls.Add(this.buttonFireGun);
            this.Controls.Add(this.btnPlayAgain);
            this.Controls.Add(this.ButtonChamberSpin);
            this.Controls.Add(this.ButtonBulletLoad);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonBulletLoad;
        private System.Windows.Forms.Button ButtonChamberSpin;
        private System.Windows.Forms.Button btnPlayAgain;
        private System.Windows.Forms.Button buttonFireGun;
        private System.Windows.Forms.Label LabelTurnInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblWin;
        private System.Windows.Forms.Label lblLose;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblDead;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblDeadInfo;
        private System.Windows.Forms.Label LabelGameResult;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnExit;
    }
}

