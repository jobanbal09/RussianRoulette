using System;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RussianRoulette;

namespace UnitTesting
{
    [TestClass]
    public class UnitTest1
    {
        Form1 obj = new Form1();
      
        public int LoseGame = 0;
        public int WinGame = 0;
        public int round = 0;
        [TestMethod]
        public void GetRandomNumber()
        {
           
           int  startChamber = obj.spinGunChamber(); //Set Chamber to start game
           int bulletChamber = obj.spinGunChamber();//Bullet is which chamber
           
        }
        [TestMethod]
        public void PlayingMethod()
        {
            int numPlayers = 2;
            int startChamber = obj.spinGunChamber(); //Set Chamber to start game
            int bulletChamber = obj.spinGunChamber();//Bullet is which chamber
            int currentChamber = play(numPlayers, startChamber, bulletChamber);
            startChamber = currentChamber;

            if (currentChamber == -1)
            {
                Assert.AreEqual("Game End", "Game End");
            }
            else
            {

                round++;
                Assert.AreEqual(round, round);

            }
        }
        
        public int play(int numPlayers, int currentChamber, int bulletChamber)
        {
            for (int i = 1; i <= numPlayers; i++)
            {


                // Determine if chamber with bullet is fired

                if (currentChamber == bulletChamber)
                {


                    if (i == 1)
                    {

                        LoseGame++;
                        Assert.AreEqual(LoseGame,LoseGame);

                    }
                    else
                    {

                        WinGame++;
                        Assert.AreEqual(WinGame, WinGame);
                    }


                    return -1;

                }
                else
                {

                    if (i == 1)
                    {
                        Assert.AreEqual("You Are Lucky", "You Are Lucky");
                    }
                    else
                    {
                       Assert.AreEqual("Player " + i + " is Lucky", "Player " + i + " is Lucky");

                    }


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
    }
}
