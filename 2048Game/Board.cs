using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace _2048Game
{
    public class Board
    {
        public Tile[,] board;
        private int score = 0;
        private int border = 0;
        public int gridSize;
        public Board()
        {
            board = new Tile[4, 4];
            gridSize = 4;
            for (int i = 0; i <= board.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= board.GetUpperBound(1); j++)
                {
                    board[i, j] = new Tile();
                }
            }
        }

        public Board(int gridSize)
        {
            this.gridSize = gridSize;
            board = new Tile[gridSize, gridSize];
            for (int i = 0; i <= board.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= board.GetUpperBound(1); j++)
                {
                    board[i, j] = new Tile();
                }
            }
        }

        public int getLength()
        {
            return board.Length;
        }

        public Tile[,] getBoard()
        {
            return board;
        }

        public int getScore()
        {
            return score;
        }

        public String print()
        {
            String print = "";
            for (int i = 0; i <= board.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= board.GetUpperBound(1); j++)
                {
                    print += board[i, j].toString() + " ";
                }
                print += "\n";
                
            }
            return print;
        }

        public String getVal(int col, int row)
        {
            return board[row, col].getValue().ToString();
        }

        public Color getColor(int col, int row)
        {
            return board[row, col].GetColor();
        }

        public void spawnTile()
        {
            Random r = new Random();
            bool empty = true;
            while (empty)
            {
                int row = r.Next(0, board.GetUpperBound(0));
                int col = r.Next(0, board.GetUpperBound(0));
                double spawnVal = r.NextDouble();
                if (board[row, col].isEmpty())
                {
                    if (spawnVal < .2)
                    {
                        board[row, col] = new Tile(4);
                        empty = false;
                    }
                    else
                    {
                        board[row, col] = new Tile(2);
                        empty = false;
                    }
                }
            }
        }

        public bool isGameOver()
        {
            //when count == 16, no neighboring tiles have the same value, and thus can not be combined
            int count = 0;
            for (int i = 0; i <= board.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= board.GetUpperBound(1); j++)
                {
                    if (board[i, j].isEmpty() == false)
                    {
                        //at 0,0
                        if (i == 0 && j == 0)
                        {
                            //check neighboring values
                            if (board[i, j].getValue() != board[i + 1, j].getValue() && board[i, j].getValue() != board[i, j + 1].getValue())
                                count++;
                        }
                        // at [0,1] and [0,2]
                        else if (i == 0 && (j == 1 || j == 2))
                        {
                            //check neighboring values
                            if (board[i, j].getValue() != board[i + 1, j].getValue() && board[i, j].getValue() != board[i, j + 1].getValue() && board[i, j].getValue() != board[i, j - 1].getValue())
                                count++;
                        }
                        // at [0,3]
                        else if (i == 0 && j == 3)
                        {
                            if (board[i, j].getValue() != board[i + 1, j].getValue() && board[i, j].getValue() != board[i, j - 1].getValue())
                                count++;
                        }
                        // [1,0 and 2,0]
                        else if ((i == 1 || i == 2) && j == 0)
                        {
                            if (board[i, j].getValue() != board[i, j + 1].getValue() && board[i, j].getValue() != board[i - 1, j].getValue() && board[i, j].getValue() != board[i + 1, j].getValue())
                                count++;
                        }
                        // [3,0]
                        else if (i == 3 && j == 0)
                        {
                            if (board[i, j].getValue() != board[i, j + 1].getValue() && board[i, j].getValue() != board[i - 1, j].getValue())
                                count++;
                        }
                        // [3,1] and [3,2]
                        else if (i == 3 && (j == 1 || j == 2))
                        {
                            if (board[i, j].getValue() != board[i, j + 1].getValue() && board[i, j].getValue() != board[i, j - 1].getValue() && board[i, j].getValue() != board[i - 1, j].getValue())
                                count++;
                        }
                        // [3,3]
                        else if (i == 3 && j == 3)
                        {
                            if (board[i, j].getValue() != board[i, j - 1].getValue() && board[i, j].getValue() != board[i - 1, j].getValue())
                                count++;
                        }
                        // [1,3] and [2,3]
                        else if ((i == 1 || i == 2) && j == 3)
                        {
                            if (board[i, j].getValue() != board[i + 1, j].getValue() && board[i, j].getValue() != board[i - 1, j].getValue() && board[i, j].getValue() != board[i, j - 1].getValue())
                                count++;
                        }
                        //middle of board
                        else
                        {
                            if (board[i, j].getValue() != board[i + 1, j].getValue() && board[i, j].getValue() != board[i - 1, j].getValue()
                                && board[i, j].getValue() != board[i, j - 1].getValue() && board[i, j].getValue() != board[i, j + 1].getValue())
                                count++;
                        }
                    }
                }
            }
            if (count == 16)
            {
                return true;
            }

            return false;
        }

        public void moveUp()
        {
            for (int i = 0; i <= board.GetUpperBound(0); i++)
            {
                border = 0;
                for (int j = 0; j <= board.GetUpperBound(1); j++)
                {
                    if (board[j, i].isEmpty() == false)
                    {
                        if (border <= j)
                            verticalMove(j, i, "up");
                    }
                }
            }
        }

        public void moveDown()
        {
            for (int i = 0; i <= board.GetUpperBound(0); i++)
            {
                border = board.GetUpperBound(0);
                for (int j = board.GetUpperBound(1); j >= 0; j--)
                {
                    if (board[j, i].isEmpty() == false)
                    {
                        if (border >= j)
                            verticalMove(j, i, "down");
                    }
                }
            }
        }

        private void verticalMove(int row, int col, String direction)
        {
            Tile initial = board[border, col];
            Tile compare = board[row, col];
            if (initial.isEmpty() || initial.getValue() == compare.getValue())
            {
                if (row > border || (direction.Equals("down") && (row < border)))
                {

                    int addScore = initial.getValue() + compare.getValue();
                    if (initial.isEmpty() == false)
                    {
                        score += addScore;
                    }
                    initial.setValue(addScore);
                    compare.setValue(0);
                }
            }
            else
            {
                if (direction.Equals("down"))
                    border--;
                else
                    border++;
                verticalMove(row, col, direction);
            }
        }

        public void moveLeft()
        {
            for (int i = 0; i <= board.GetUpperBound(0); i++)
            {
                border = 0;
                for (int j = 0; j <= board.GetUpperBound(1); j++)
                {
                    if (board[i, j].isEmpty() == false)
                    {
                        if (border <= j)
                            horizontalMove(i, j, "left");
                    }
                }
            }
        }

        public void moveRight()
        {
            for (int i = 0; i <= board.GetUpperBound(0); i++)
            {
                border = board.GetUpperBound(0);
                for (int j = board.GetUpperBound(1); j >= 0; j--)
                {
                    if (board[i, j].isEmpty() == false)
                    {
                        if (border >= j)
                            horizontalMove(i, j, "right");
                    }
                }
            }
        }

        private void horizontalMove(int row, int col, String direction)
        {
            Tile initial = board[row, border];
            Tile compare = board[row, col];
            if (initial.isEmpty() || initial.getValue() == compare.getValue())
            {
                if (col > border || (direction.Equals("right") && (col < border)))
                {

                    int addScore = initial.getValue() + compare.getValue();
                    if (initial.isEmpty() == false)
                    {
                        score += addScore;
                    }
                    initial.setValue(addScore);
                    compare.setValue(0);
                }
            }
            else
            {
                if (direction.Equals("right"))
                    border--;
                else
                    border++;
                horizontalMove(row, col, direction);
            }

        }


    }


}
