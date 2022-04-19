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
        public Form1()
        {
            InitializeComponent();
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        static public void update()
        {
            while (true)
            {
                int a1 = road1.Location.X - 1;
                road1.Location = new Point(a1, road1.Location.Y);
                if (road1.Location.X < -1000)
                {
                    road1.Location = new Point(1000, road1.Location.Y);
                }
                int a2 = road2.Location.X - 1;
                road2.Location = new Point(a2, road2.Location.Y);
                if (road2.Location.X < -1000)
                {
                    road2.Location = new Point(road2.Location.X, 1000);
                }
            }
        }
    }
}