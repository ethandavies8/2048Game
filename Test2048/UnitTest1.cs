using _2048Game;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Drawing;
using System;
using System.Text;

namespace Test2048
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestTile()
        {
            Tile noValTile = new Tile();
            int val = 5;
            Tile tile = new Tile(val);
            Assert.IsTrue(noValTile.getValue() == 0);
            Assert.IsTrue(tile.getValue() == 5);
            noValTile.setValue(val);
            Assert.IsTrue(noValTile.getValue() == tile.getValue());
        }

        [TestMethod]
        public void TestTileToString()
        {
            Tile tile = new Tile();
            Assert.IsTrue(tile.toString() == "0");
            tile.setValue(5);
            Assert.IsTrue(tile.toString() == "5");
        }

        [TestMethod]
        public void TestTileColor()
        {
            Tile tile = new Tile(2);
            Assert.IsTrue(tile.GetColor() == Color.FromArgb(238, 228, 218));
            tile.setValue(4);
            Assert.IsTrue(tile.GetColor() == Color.FromArgb(237, 224, 200));
        }

        [TestMethod]
        public void TestBoard()
        {
            Board board = new Board();
            Assert.IsTrue(board.getLength() == 16);
            board.print();
            board.spawnTile();
            board.print();
        }

        [TestMethod]
        public void TestMoveDownUp()
        {
            Board board = new Board();
            board.spawnTile();
            board.spawnTile();
            board.spawnTile();
            board.spawnTile();
            board.print();
            board.moveDown();
            board.print();
            board.moveUp();
            board.print();

        }

        [TestMethod]
        public void TestMoveLeftRight()
        {
            Board board = new Board();
            board.spawnTile();
            board.spawnTile();
            board.spawnTile();
            board.spawnTile();
            board.print();
            board.moveLeft();
            board.print();
            board.moveRight();
            board.print();
        }

    }
}
