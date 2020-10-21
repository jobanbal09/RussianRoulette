namespace RussianRoulette
{
    partial class RouletteGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RouletteGame));
            this.btnLoadBullet = new System.Windows.Forms.Button();
            this.btnSpinChamber = new System.Windows.Forms.Button();
            this.btnPlayAgain = new System.Windows.Forms.Button();
            this.btnFire = new System.Windows.Forms.Button();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblWin = new System.Windows.Forms.Label();
            this.lblLose = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblDeadInfo = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.picCross = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCross)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoadBullet
            // 
            this.btnLoadBullet.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLoadBullet.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLoadBullet.BackgroundImage")));
            this.btnLoadBullet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadBullet.Image = ((System.Drawing.Image)(resources.GetObject("btnLoadBullet.Image")));
            this.btnLoadBullet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoadBullet.Location = new System.Drawing.Point(86, 152);
            this.btnLoadBullet.Name = "btnLoadBullet";
            this.btnLoadBullet.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnLoadBullet.Size = new System.Drawing.Size(230, 96);
            this.btnLoadBullet.TabIndex = 0;
            this.btnLoadBullet.Text = "Load Bullet";
            this.btnLoadBullet.UseVisualStyleBackColor = false;
            this.btnLoadBullet.Click += new System.EventHandler(this.btnLoadBullet_Click);
            // 
            // btnSpinChamber
            // 
            this.btnSpinChamber.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSpinChamber.BackgroundImage")));
            this.btnSpinChamber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpinChamber.Image = ((System.Drawing.Image)(resources.GetObject("btnSpinChamber.Image")));
            this.btnSpinChamber.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSpinChamber.Location = new System.Drawing.Point(339, 152);
            this.btnSpinChamber.Name = "btnSpinChamber";
            this.btnSpinChamber.Size = new System.Drawing.Size(230, 96);
            this.btnSpinChamber.TabIndex = 1;
            this.btnSpinChamber.Text = "Spin Chamber";
            this.btnSpinChamber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSpinChamber.UseVisualStyleBackColor = true;
            this.btnSpinChamber.Click += new System.EventHandler(this.btnSpinChamber_Click);
            // 
            // btnPlayAgain
            // 
            this.btnPlayAgain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPlayAgain.BackgroundImage")));
            this.btnPlayAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayAgain.Image = ((System.Drawing.Image)(resources.GetObject("btnPlayAgain.Image")));
            this.btnPlayAgain.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlayAgain.Location = new System.Drawing.Point(600, 152);
            this.btnPlayAgain.Name = "btnPlayAgain";
            this.btnPlayAgain.Size = new System.Drawing.Size(230, 96);
            this.btnPlayAgain.TabIndex = 2;
            this.btnPlayAgain.Text = "Play Again";
            this.btnPlayAgain.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPlayAgain.UseVisualStyleBackColor = true;
            this.btnPlayAgain.Click += new System.EventHandler(this.btnPlayAgain_Click);
            // 
            // btnFire
            // 
            this.btnFire.BackColor = System.Drawing.Color.Red;
            this.btnFire.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFire.BackgroundImage")));
            this.btnFire.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFire.Enabled = false;
            this.btnFire.Font = new System.Drawing.Font("Myanmar Text", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFire.ForeColor = System.Drawing.Color.White;
            this.btnFire.Location = new System.Drawing.Point(219, 518);
            this.btnFire.Name = "btnFire";
            this.btnFire.Size = new System.Drawing.Size(201, 86);
            this.btnFire.TabIndex = 3;
            this.btnFire.Text = "Fire Gun";
            this.btnFire.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnFire.UseVisualStyleBackColor = false;
            this.btnFire.Click += new System.EventHandler(this.btnFire_ClickAsync);
            // 
            // lblPlayer
            // 
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer.ForeColor = System.Drawing.Color.Teal;
            this.lblPlayer.Location = new System.Drawing.Point(257, 285);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(0, 26);
            this.lblPlayer.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(535, 611);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Win Game :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(526, 653);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Lose Game :";
            // 
            // lblWin
            // 
            this.lblWin.AutoSize = true;
            this.lblWin.BackColor = System.Drawing.Color.Transparent;
            this.lblWin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWin.ForeColor = System.Drawing.Color.Teal;
            this.lblWin.Location = new System.Drawing.Point(643, 611);
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
            this.lblLose.Location = new System.Drawing.Point(643, 653);
            this.lblLose.Name = "lblLose";
            this.lblLose.Size = new System.Drawing.Size(19, 20);
            this.lblLose.TabIndex = 8;
            this.lblLose.Text = "0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(187, 334);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(283, 178);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblDeadInfo
            // 
            this.lblDeadInfo.AutoSize = true;
            this.lblDeadInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblDeadInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeadInfo.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblDeadInfo.Location = new System.Drawing.Point(603, 318);
            this.lblDeadInfo.Name = "lblDeadInfo";
            this.lblDeadInfo.Size = new System.Drawing.Size(0, 31);
            this.lblDeadInfo.TabIndex = 12;
            this.lblDeadInfo.Visible = false;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.BackColor = System.Drawing.Color.Transparent;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblResult.Location = new System.Drawing.Point(603, 406);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 39);
            this.lblResult.TabIndex = 13;
            this.lblResult.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(244, 40);
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
            this.btnExit.Location = new System.Drawing.Point(860, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(136, 51);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "Exit Game";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // picCross
            // 
            this.picCross.BackColor = System.Drawing.Color.Black;
            this.picCross.Image = ((System.Drawing.Image)(resources.GetObject("picCross.Image")));
            this.picCross.Location = new System.Drawing.Point(324, 406);
            this.picCross.Name = "picCross";
            this.picCross.Size = new System.Drawing.Size(96, 96);
            this.picCross.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picCross.TabIndex = 16;
            this.picCross.TabStop = false;
            this.picCross.Visible = false;
            // 
            // RouletteGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.picCross);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblDeadInfo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblLose);
            this.Controls.Add(this.lblWin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPlayer);
            this.Controls.Add(this.btnFire);
            this.Controls.Add(this.btnPlayAgain);
            this.Controls.Add(this.btnSpinChamber);
            this.Controls.Add(this.btnLoadBullet);
            this.DoubleBuffered = true;
            this.Name = "RouletteGame";
            this.Text = "RouletteGame";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCross)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoadBullet;
        private System.Windows.Forms.Button btnSpinChamber;
        private System.Windows.Forms.Button btnPlayAgain;
        private System.Windows.Forms.Button btnFire;
        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblWin;
        private System.Windows.Forms.Label lblLose;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblDeadInfo;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox picCross;
    }
}

