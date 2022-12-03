using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WindowsFormsApp1;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Ravnst_3_3_3()
        {
            int a = 3;
            int b = 3; 
            int c = 3;
            int Rvnst = 1;

            int expext_Ravn = 1;

            Program rvn = new Program();
            int actual_Ravn = rvn.Ravnst(a, b, c, Rvnst);

            Assert.AreEqual(expext_Ravn, actual_Ravn);
        }
        [TestMethod]
        public void Ravnobed_2_2_3()
        {
            int a = 2;
            int b = 2;
            int c = 3;
            int Rvnst = 1;

            int expext_Ravn = 1;

            Program rvnb = new Program();
            int actual_Ravn = rvnb.Ravnobed(a, b, c, Rvnst);

            Assert.AreEqual(expext_Ravn, actual_Ravn);
        }
        [TestMethod]
        public void Raznost_1_2_3()
        {
            int a = 1;
            int b = 2;
            int c = 3;
            int Rvnst = 1;

            int expext_Ravn = 1;

            Program razn = new Program();
            int actual_Ravn = razn.Raznost(a, b, c, Rvnst);

            Assert.AreEqual(expext_Ravn, actual_Ravn);
        }

        [TestMethod]
        public void Bad_Ravnst_2_3_3()
        {
            int a = 2;
            int b = 3;
            int c = 3;
            int Rvnst = 1;

            int expext_Ravn = 1;

            Program rvn = new Program();
            int actual_Ravn = rvn.Ravnst(a, b, c, Rvnst);

            Assert.AreEqual(expext_Ravn, actual_Ravn);
        }
        [TestMethod]
        public void Bad_Ravnobed_1_2_3()
        {
            int a = 1;
            int b = 2;
            int c = 3;
            int Rvnst = 1;

            int expext_Ravn = 1;

            Program rvnb = new Program();
            int actual_Ravn = rvnb.Ravnobed(a, b, c, Rvnst);

            Assert.AreEqual(expext_Ravn, actual_Ravn);
        }
        [TestMethod]
        public void Bad_Raznost_2_2_2()
        {
            int a = 2;
            int b = 2;
            int c = 2;
            int Rvnst = 1;

            int expext_Ravn = 1;

            Program razn = new Program();
            int actual_Ravn = razn.Raznost(a, b, c, Rvnst);

            Assert.AreEqual(expext_Ravn, actual_Ravn);
        }

    }
}
