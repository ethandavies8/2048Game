using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using _2048Game;

namespace GameView
{
    public partial class View : Form
    {
        Board board;
        public View()
        {
            InitializeComponent();
            board = new Board();
            board.spawnTile();
            setBoxes();
        }


        private void View_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W || e.KeyCode == Keys.Up)
                board.moveUp();
            if (e.KeyCode == Keys.S || e.KeyCode == Keys.Down)
                board.moveDown();
            if (e.KeyCode == Keys.A || e.KeyCode == Keys.Left)
                board.moveLeft();
            if (e.KeyCode == Keys.D || e.KeyCode == Keys.Right)
                board.moveRight();
            //prevent other key handlers from running
            e.SuppressKeyPress = true;
            e.Handled = true;
            if (board.isGameOver())
                endGame();
            else
            {

                board.spawnTile();
                scoreLabel.Text = "Score:" + board.getScore();
                setBoxes();
            }

        }
        private void setBoxes()
        {
            textBox0.Text = board.getVal(0, 0);
            textBox0.BackColor = board.getColor(0, 0);
            textBox1.Text = board.getVal(1, 0);
            textBox1.BackColor = board.getColor(1, 0);
            textBox2.Text = board.getVal(2, 0);
            textBox2.BackColor = board.getColor(2, 0);
            textBox3.Text = board.getVal(3, 0);
            textBox3.BackColor = board.getColor(3, 0);
            textBox4.Text = board.getVal(0, 1);
            textBox4.BackColor = board.getColor(0, 1);
            textBox5.Text = board.getVal(1, 1);
            textBox5.BackColor = board.getColor(1, 1);
            textBox6.Text = board.getVal(2, 1);
            textBox6.BackColor = board.getColor(2, 1);
            textBox7.Text = board.getVal(3, 1);
            textBox7.BackColor = board.getColor(3, 1);
            textBox8.Text = board.getVal(0, 2);
            textBox8.BackColor = board.getColor(0, 2);
            textBox9.Text = board.getVal(1, 2);
            textBox9.BackColor = board.getColor(1, 2);
            textBox10.Text = board.getVal(2, 2);
            textBox10.BackColor = board.getColor(2, 2);
            textBox11.Text = board.getVal(3, 2);
            textBox11.BackColor = board.getColor(3, 2);
            textBox12.Text = board.getVal(0, 3);
            textBox12.BackColor = board.getColor(0, 3);
            textBox13.Text = board.getVal(1, 3);
            textBox13.BackColor = board.getColor(1, 3);
            textBox14.Text = board.getVal(2, 3);
            textBox14.BackColor = board.getColor(2, 3);
            textBox15.Text = board.getVal(3, 3);
            textBox15.BackColor = board.getColor(3, 3);
        }

        private void endGame()
        {
            string message = "Game Over";
            string caption = "No More Available Moves";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.OK);

        }
    }

}
