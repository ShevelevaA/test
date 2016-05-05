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

        [TestMethod]
        public void TestMethodGoodInitMatrix()
        {
            Game game;
            int[][] matr;

            game = new Game();
            game.initMatr();
            matr = game.getMatr();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                    if (matr[i][j] != 0)
                    {
                        Assert.Fail("Матрица инициализирована неверно.");
                    }
            }
        }


        [TestMethod]
        public void TestMethodWhoFirst()
        {
            Game game;
            game = new Game();

            if (game.getWhoFirst() != 2)
                Assert.Fail("Инициализация номера первого игрока производится неверно.");
        }

        [TestMethod]
        public void TestMethodWhoFirst2()
        {
            Game game;
            game = new Game();

            game.setWhoFirst(2);
            if (game.getWhoFirst() != 2)
                Assert.Fail("Метод setWhoFirst неверно устанавливает значение.");
        }

        [TestMethod]
        public void TestMethodWhoFirst3()
        {
            Game game;
            game = new Game();

            game.setWhoFirst(1);
            if (game.getWhoFirst() != 1)
                Assert.Fail("Метод setWhoFirst неверно устанавливает значение либо getWhoFirst неверно его возвращает.");
        }

        [TestMethod]
        public void TestMethodfirstHodComp()
        {
            Game game;
            int[][] matr;
            game = new Game();

            game.hodComp(1, 0);
            matr = game.getMatr();
            if (matr[1][0] != 1)
            {
                Assert.Fail("Метод hodComp неверно устанавливает значение.");
            }
        }

        [TestMethod]
        public void TestMethodifNull()
        {
            Game game;
            int[][] matr;
            game = new Game();

            game.initMatr();
            matr = game.getMatr();
            if (!game.ifNull(0, 1))
            {
                Assert.Fail("Метод ifNull возвращает неверное значение.");
            }
        }


    }
}
