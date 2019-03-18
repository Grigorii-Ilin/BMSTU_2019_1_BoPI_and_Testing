using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private int x;
        private int y;
        private int vectorX = 1;
        private int vectorY = 1;


        private const int SQUARE_LEN = 10;
        private const int SPEED = 5;

        private int bridgeX;
        private const int BRIDGE_WIDTH = 50;
        private const int BRIDGE_SPEED = 9;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.Green, x, y, SQUARE_LEN, SQUARE_LEN);
            e.Graphics.FillRectangle(Brushes.Red, bridgeX, this.Height - 47, BRIDGE_WIDTH, SQUARE_LEN);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            x = 50;
            y = 50;
            bridgeX = 200;
        }

        private void tmSquareMove_Tick(object sender, EventArgs e)
        {
            if (x <= 0 || x >= this.Width - 25)
            {
                vectorX *= -1;
            }
            else if (y <= 0 || y >= this.Height - 42)
            {
                vectorY *= -1;
            }
            else if (y >= this.Height - 50 && x >= bridgeX && x <= bridgeX + BRIDGE_WIDTH)
            {
                vectorY *= -1;
            }

            x += SPEED * vectorX;
            y += SPEED * vectorY;
            lbXCoord.Text = "X: " + x.ToString();
            lbYCoord.Text = "Y: " + y.ToString();



            Invalidate();
        }

        private void btStartStop_Click(object sender, EventArgs e)
        {
            tmOneMove.Enabled = !(tmOneMove.Enabled);
            btStart.Enabled = false;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
            {
                bridgeX -= BRIDGE_SPEED;
            }
            else if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
            {
                bridgeX += BRIDGE_SPEED;
            }
        }
    }
}
