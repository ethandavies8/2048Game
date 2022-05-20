using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace _2048Game
{
    public class Tile
    {
        private int value;
        private Color color;
        bool empty;
        public Tile()
        {
            value = 0;
            empty = true;
        }
        /// <summary>
        ///  default constructor with value -0
        /// </summary>
        /// <param name="value"></param>
        public Tile(int value)
        {
            this.value = value;
            empty = false;
        }

        public bool isEmpty()
        {
            return empty == true;
        }

        public int getValue()
        {
            return value;
        }

        public void setValue(int value)
        {
            this.value = value;
            setColor();
            if(value == 0)
            {
                empty = true;
            }
            else
                empty = false;

        }

        public string toString()
        {
            return "" + value;
        }

        private void setColor()
        {
            switch (getValue())
            {
                case 0:
                    color = Color.FromArgb(255, 255, 255);
                    break;
                case 2:
                    color = Color.FromArgb(238, 228, 218);
                    break;
                case 4:
                    color = Color.FromArgb(237, 224, 200);
                    break;
                case 8:
                    color = Color.FromArgb(242, 177, 121);
                    break;
                case 16:
                    color = Color.FromArgb(245, 149, 99);
                    break;
                case 32:
                    color = Color.FromArgb(246, 124, 95);
                    break;
                case 64:
                    color = Color.FromArgb(246, 94, 59);
                    break;
                case 128:
                    color = Color.FromArgb(237, 207, 114);
                    break;
                case 256:
                    color = Color.FromArgb(237, 204, 97);
                    break;
                case 512:
                    color = Color.FromArgb(237, 200, 80);
                    break;
                case 1024:
                    color = Color.FromArgb(237, 197, 63);
                    break;
                default:
                    color = Color.FromArgb(237, 194, 46);
                    break;
            }
        }

        public Color GetColor()
        {
            setColor();
            return color;
        }


    }
}
