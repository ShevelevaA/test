using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using test_tdd;


namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodInitMatrix()
        {
            Game game;
            int[][] matr;

            game = new Game();
            game.initMatr();
            matr = game.getMatr();
            if (matr[0][0] != 0)
                Assert.Fail("Матрица инициализирована неверно.");
        }


        [TestMethod]
        public void TestMethodInitMatrix2()
        {
            Game game;
            int[][] matr;

            game = new Game();
            game.initMatr();
            matr = game.getMatr();
            if (matr[0][1] != 0)
                Assert.Fail("Матрица инициализирована неверно.");
        }      


    }
}
