using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChangeColor
{
    public partial class Form1 : Form
    {
        private Timer timer = new Timer();
        private int R = 0;
        private int G = 0;
        private int B = 0;
        private Random r = new Random();
        private bool isUpR = true;
        private bool isUpG = true;
        private bool isUpB = true;
        private void ChangeColor(object sender, EventArgs e)
        {
            switch(r.Next(0,3))
            {
                case 0:
                    if (isUpR)
                    {
                        R++;
                        if (R == 255) isUpR = false;
                    }
                    else
                    {
                        R--;
                        if(R == 0) isUpR = true;
                    }
                    break;
                case 1:
                    if (isUpG)
                    {
                        G++;
                        if (G == 255) isUpG = false;
                    }
                    else
                    {
                        G--;
                        if (G == 0) isUpG = true;
                    }
                    break;
                case 2:
                    if (isUpB)
                    {
                        B++;
                        if (B == 255) isUpB = false;
                    }
                    else
                    {
                        B--;
                        if (B == 0) isUpB = true;
                    }
                    break;

            }
            BackColor = Color.FromArgb(R, G, B);
        }
        public Form1()
        {
            InitializeComponent();
            timer.Tick += new EventHandler(ChangeColor);
            timer.Interval = 5;
            timer.Start();
        }
    }
}
