using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RussianRoulette
{
    public partial class Form1 : Form
    {
        int numPlayers = 2;
        int startChamber = 0;
        int bulletChamber = 0;
        int WinGame = 0;
        int LoseGame = 0;
        bool GunReady = false;
        int gameRound = 1;
        // Create a single shared Random number randomNumber
    private static Random randomNumber = new Random();

       
        private void ButtonBulletLoad_Click(object sender, EventArgs e)
        {

            GunReady = true;
            ButtonChamberSpin.Enabled = true;
            ButtonBulletLoad.Enabled = false;
            lblInfo.Text = "Spin The Chamber";
            gameRound = 1;
        }

        private void ButtonChamberSpin_Click(object sender, EventArgs e)
        {
            if (GunReady == true)
            {

                SoundPlayer simpleSound = new SoundPlayer(Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10)) + "\\sound\\gun-cocking-01.wav");
                simpleSound.Play();
                startChamber = spinGunChamber(); //Set Chamber to start game
                bulletChamber = spinGunChamber(); //Bullet is which chamber
                LabelTurnInfo.Text = "Your Turn (Please Fire the gun)";
                buttonFireGun.Enabled = true;
                ButtonChamberSpin.Enabled = false;
                lblInfo.Text = "Fire The Gun";
                LabelGameResult.Text = "Game Round 1";
                LabelGameResult.Visible = true;

            }
            else
            {
                MessageBox.Show("Please Load the gun firstly...");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       

       
        

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(lblInfo.Visible==true)
            {
                lblInfo.Visible = false;
            }
            else
            {
                lblInfo.Visible = true;
            }
        }




        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            ButtonChamberSpin.Enabled = false;
            ButtonBulletLoad.Enabled = true;
            buttonFireGun.Enabled = false;
            startChamber = 0;
            bulletChamber = 0;
            lblDead.Visible = false;
            GunReady = false;
            lblInfo.Text = "Load The Bullet";
            lblDeadInfo.Visible = false;
            LabelGameResult.Visible = false;
            gameRound = 1;
        }

        public async Task<int> playAsync(int totalPlayers, int Chamber, int ChamberWithBullet)
        {
            for (int i = 1; i <= totalPlayers; i++)
            {

                if (i == 1)
                {
                    LabelTurnInfo.Text = "Your Turn (Please Fire the gun)";

                }
                else
                {
                    LabelTurnInfo.Text = "Player " + i + " trun";


                }

                // Determine if chamber with bullet is fired

                if (Chamber == ChamberWithBullet)
                {
                    SoundPlayer GunFireSound = new SoundPlayer(Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10)) + "\\sound\\gun-gunshot-01.wav");
                    GunFireSound.Play();
                    lblDead.Visible = true;
                    if (i == 1)
                    {
                        lblDead.Text = "You Dead!!!";
                        // MessageBox.Show("You dead!, Lose the game...");
                        lblDeadInfo.Text = "You Dead...";
                        LabelGameResult.Text = "LOSE GAME!!!";
                        lblDeadInfo.Visible = true;
                        LabelGameResult.Visible = true;
                        LoseGame++;
                        lblLose.Text = LoseGame.ToString();
                    }
                    else
                    {
                        lblDead.Text = "Player " + i + " is Dead!!!";
                        // MessageBox.Show("Player " + i + " is dead!");
                        // MessageBox.Show("You Win the game...");
                        lblDeadInfo.Text = "Player " + i + " is dead...";
                        LabelGameResult.Text = "WIN GAME!!!";
                        lblDeadInfo.Visible = true;
                        LabelGameResult.Visible = true;
                        WinGame++;
                        lblWin.Text = WinGame.ToString();
                    }


                    return -1;

                }
                else
                {
                    SoundPlayer simpleSound = new SoundPlayer(Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10)) + "\\sound\\empty-bullet-shell-fall-01.wav");
                    simpleSound.Play();
                    //MessageBox.Show("Lucky");
                    if (i == 1)
                    {
                        LabelGameResult.Text = "You Are Lucky";
                    }
                    else
                    {
                        LabelGameResult.Text = "Player " + i + " is Lucky";
                    }

                    LabelGameResult.Visible = true;
                    await Task.Delay(1000);
                    LabelGameResult.Visible = false;


                }
                if (Chamber == 6)
                {

                    Chamber = 1;

                }
                else
                {

                    Chamber++;

                }


            }
            return Chamber;


        }
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ButtonChamberSpin.Enabled = false;
            timer1.Start();
        }
        public int spinGunChamber()
        {

            return randomNumber.Next(1, 7);

        }

        private async void buttonFireGun_ClickAsync(object sender, EventArgs e)
        {
            buttonFireGun.Enabled = false;
            //Play the game on fire buuton click
            int currentChamberPostion = await playAsync(numPlayers, startChamber, bulletChamber);
            startChamber = currentChamberPostion;

            if (currentChamberPostion == -1)
            {

                lblInfo.Text = "Game End";
                LabelTurnInfo.Text = "";
                buttonFireGun.Enabled = false;
            }
            else
            {

                LabelGameResult.Visible = false;

                LabelTurnInfo.Text = "Your Turn (Please Fire the gun)";
                buttonFireGun.Enabled = true;
                gameRound++;
                LabelGameResult.Text = "Game Round " + gameRound;
                LabelGameResult.Visible = true;
            }
        }
    }
}
