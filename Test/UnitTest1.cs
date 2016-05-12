using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Drawing;

using test_tdd;

//using System.Windows.Forms;




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

        [TestMethod]
        public void TestMethodfirstHodUser()
        {
            Game game;
            int[][] matr;
            game = new Game();

            game.hodUser(1, 0);
            matr = game.getMatr();
            if (matr[1][0] != 2)
            {
                Assert.Fail("Метод hodUser неверно устанавливает значение.");
            }
        }

       // Проверка выигрышных комбинаций пользователя
        [TestMethod]
        public void TestMethoduserWin()
        {
            Game game;

            int[][] matr;
            game = new Game();

            matr = game.getMatr();

            matr[0][0] = 2;
            matr[2][0] = 2; // cherta = 1, cell = 2

            if (!game.winUser2())
            {
                Assert.Fail("Метод userWin неверно определяет выигрышную комбинацию на поле.");
            }
        }

        [TestMethod] 
        public void TestMethoduserWin2()
        {
            Game game;
                       
            int[][] matr;
            game = new Game();
            
            matr = game.getMatr();
           
            matr[0][0] = 2;
            matr[0][1] = 2; // cherta = 4, cell = 7

            if (!game.winUser7())
            {
                Assert.Fail("Метод userWin неверно определяет выигрышную комбинацию на поле.");
            }
        }


        [TestMethod]
        public void TestMethoduserWinCherta()
        {
            Game game;

            int[][] matr;
            game = new Game();

            matr = game.getMatr();

            matr[0][0] = 2;
            matr[2][0] = 2; // cherta = 1, cell = 2
            
            game.winUser2();

            if (game.cherta != 1)
            {
                Assert.Fail("Метод userWin неверно отрисовывет выигрышную комбинацию (cherta = " + game.cherta + ", должно быть 1 ).");
            }
        }

        [TestMethod]
        public void TestMethoduserWinCherta2()
        {
            Game game;

            int[][] matr;
            game = new Game();

            matr = game.getMatr();

            matr[0][0] = 2;
            matr[0][1] = 2; // cherta = 4, cell = 7

            game.winUser7();

            if (game.cherta != 4)
            {
                Assert.Fail("Метод userWin неверно отрисовывет выигрышную комбинацию (cherta = " + game.cherta + ", должно быть 4 ).");
            }
        }

        [TestMethod]
        public void TestMethoduserWinCherta3()
        {
            Game game;

            int[][] matr;
            game = new Game();

            matr = game.getMatr();

            matr[0][2] = 2;
            matr[2][0] = 2; // cherta = 8, cell = 5

            game.winUser5();

            if (game.cherta != 8)
            {
                Assert.Fail("Метод userWin неверно отрисовывет выигрышную комбинацию (cherta = " + game.cherta + ", должно быть 8 ).");
            }
        }


        //Нападение компьютера
        [TestMethod]
        public void TestMethoduserWin()
        {
            Game game;

            int[][] matr;
            game = new Game();

            matr = game.getMatr();

            matr[0][0] = 2;
            matr[2][0] = 2; // cherta = 1, cell = 2

            if (!game.winUser2())
            {
                Assert.Fail("Метод compWin неверно определяет выигрышную комбинацию на поле.");
            }
        }

        // Проверка выигрышных комбинаций компьютера
        [TestMethod]
        public void TestMethoduserWin()
        {
            Game game;

            int[][] matr;
            game = new Game();

            matr = game.getMatr();

            matr[0][0] = 2;
            matr[2][0] = 2; // cherta = 1, cell = 2

            if (!game.winUser2())
            {
                Assert.Fail("Метод compWin неверно определяет выигрышную комбинацию на поле.");
            }
        }

    }
}
