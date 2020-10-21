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
    public partial class RouletteGame : Form
    {
        public int WinGame = 0;
        public int LoseGame = 0;
        public bool LoadGun = false;
        public int numPlayers = 2;
        public int startChamber = 0;
        public int bulletChamber = 0;
        public int round = 1;
       
    private static Random generateNumber = new Random();

        public RouletteGame()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblResult.Text = "Load The Bullet";
            btnSpinChamber.Enabled = false;
            timer1.Start();
        }

        private void btnSpinChamber_Click(object sender, EventArgs e)
        {
            if (LoadGun == true)
            {
                startChamber = spinChamber(); //Set Chamber to start game
                bulletChamber = spinChamber(); //Bullet is which chamber
                lblPlayer.Text = "Your Turn";
                btnFire.Enabled = true;
                btnSpinChamber.Enabled = false;
                lblResult.Text = "Fire The Gun";
                lblResult.Visible = true;
                
            }
            else
            {
                MessageBox.Show("Please Load the gun firstly...");
            }
        }
        public int spinChamber()
        {

            return generateNumber.Next(1,7);
          
        }

        private void btnFire_ClickAsync(object sender, EventArgs e)
        {
            btnFire.Enabled = false;
            //Play the game on fire buuton click
            int currentChamber =GunFire(numPlayers, startChamber, bulletChamber);
            startChamber = currentChamber;
            
            if (currentChamber==-1)
            {
                //lblResult.Text = "Game End";
                lblPlayer.Text = "";
                btnFire.Enabled = false;
            }
            else
            {

                lblResult.Visible = false;
               
                lblPlayer.Text = "Your Turn";
                btnFire.Enabled = true;
                round++;
                lblResult.Text = "Round "+round+" Fire the gun";
                lblResult.Visible = true;
            }
            
        }
        public int GunFire(int numPlayers, int currentChamber, int bulletChamber)
        {
            for (int i = 1; i <= numPlayers; i++)
            {

                if (i == 1)
                {
                    lblPlayer.Text = "Your Turn";

                }
                else
                {
                    lblPlayer.Text = "Player " + i + " trun";


                }

                // chamber with bullet is fired

                if (currentChamber == bulletChamber)
                {
                    SoundPlayer simpleSound = new SoundPlayer(Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10)) + "\\FireSound\\fire.wav");
                    simpleSound.Play();
                    picCross.Visible = true;
                    if (i == 1)
                    {

                        lblDeadInfo.Text = "You Dead!!!";
                        lblResult.Text = "You LOSE The GAME";
                        lblDeadInfo.Visible = true;
                        lblResult.Visible = true;
                        LoseGame++;
                        lblLose.Text = LoseGame.ToString();
                    }
                    else
                    {

                        lblDeadInfo.Text = "Player " + i + " is dead...";
                        lblResult.Text = "You WIN The GAME";
                        lblDeadInfo.Visible = true;
                        lblResult.Visible = true;
                        WinGame++;
                        lblWin.Text = WinGame.ToString();
                    }


                    return -1;

                }
                else
                {
                    if (i == 1)
                    {
                        lblResult.Text = "You Are Lucky";
                    }
                    else
                    {
                        lblResult.Text = "Player " + i + " is Lucky";
                    }

                    lblResult.Visible = true;

                    lblResult.Visible = false;


                }
                if (currentChamber == 6)
                {

                    currentChamber = 1;

                }
                else
                {

                    currentChamber++;

                }


            }
            return currentChamber;


        }

        private void btnLoadBullet_Click(object sender, EventArgs e)
        {
            LoadGun = true;
            btnSpinChamber.Enabled = true;
            btnLoadBullet.Enabled = false;
            lblResult.Text = "Spin The Chamber";
            round = 1;
        }

        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            btnSpinChamber.Enabled = false;
            btnLoadBullet.Enabled = true;
            btnFire.Enabled = false;
            startChamber = 0;
            bulletChamber = 0;
            picCross.Visible = false;
            LoadGun = false;
            lblResult.Text = "Load The Bullet";
            lblDeadInfo.Visible = false;
            round = 1;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(lblResult.Visible==true)
            {
                lblResult.Visible = false;
            }
            else
            {
                lblResult.Visible = true;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
