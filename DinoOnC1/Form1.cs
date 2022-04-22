using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace DinoOnC1
{
    public partial class Form1 : Form
    {
        public bool isLiving = true;

        public Bitmap road = Resource1.road;

        public Bitmap Dino1 = Resource1.rgb_run1;
        public Bitmap Dino2 = Resource1.rgb_run2;
        public Bitmap DinoJump = Resource1.rgb_jump;
        public int road1PosX=0;
        public int road2PosX=2404;
        public int speed=1;//influences on road, cactuses and dino animation
        public byte dinoAnim=1;//type of the animation of dino
        public int animFrames = 0;//AnimationFrames
        public bool canBeAnimated=true;//if true dino can be animated
        public Form1()
        {
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint, true);
        }
        void MoveRoads(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImage(road, new Rectangle(road1PosX, 570, 2404, 28));
            g.DrawImage(road, new Rectangle(road2PosX, 570, 2404, 28));
            if (road1PosX <= -2402)
            {
                road1PosX = 2403;
            }
            if (road2PosX <= -2402)
            {
                road2PosX = 2403;
            }
            road1PosX -= (int)Math.Ceiling(speed * 0.001);
            road2PosX -= (int)Math.Ceiling(speed * 0.001);
        }
        public void RunDino(PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            if (dinoAnim == 1)
            {
                g.DrawImage(Dino1, new Rectangle(25, 493, 88, 94));
                if (animFrames * (speed / 125) >= 100)
                {
                    dinoAnim++;
                    animFrames = 0;
                }
                else
                {
                    animFrames++;
                }
            }
            else if (dinoAnim == 2)
            {
                g.DrawImage(Dino2, new Rectangle(25, 493, 88, 94));
                if (animFrames * (speed / 125) >= 100)
                {
                    dinoAnim--;
                    animFrames = 0;
                }
                else
                {
                    animFrames++;
                }
            }
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            speed += 3;
            MoveRoads(e);
            RunDino(e);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isLiving)
            {
                Refresh();
            }
        }
    }
}