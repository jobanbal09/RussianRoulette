using System;
using System.Windows.Forms;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RussianRoulette;
namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        RouletteGame test = new RouletteGame();
        
        [TestMethod]
        public void TestMethod1()
        {
          test.startChamber = test.spinChamber();
          test.bulletChamber = test.spinChamber();
        }

        [TestMethod]
        public void FireMethodAsync()
        {
            test.startChamber = test.spinChamber();
            test.bulletChamber = test.spinChamber();
            int currentChamber = test.GunFire(test.numPlayers, test.startChamber, test.bulletChamber);

        }
    }
}
