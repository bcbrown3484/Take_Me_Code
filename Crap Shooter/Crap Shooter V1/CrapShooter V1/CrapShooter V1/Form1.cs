using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace CrapShooter_V1
{
    public partial class mainWindow : Form
    {
        public mainWindow()
        {
            InitializeComponent();
            // Intializes this componet not really sure of its purpose
            // Ask Chris about this below
            KeyDown += new KeyEventHandler(Form1_KeyDown);
        }
        // Things to load on start
        private void mainWindow_Load(object sender, EventArgs e)
        {
            lazerBeam.Visible = false;
        }

        void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // Shortens the location to just one character varaiable
            // To be fed into parameters later
            int x = laserCannon.Location.X;
            int y = laserCannon.Location.Y;
            int xy = 293;
            
            if (e.KeyCode == Keys.Space)
            {
                lazerBeam.Visible = true;
                int xyz = x;
                for (int i = 1; i <= 300; i++)
                {
                    xy += 1;
                    lazerBeam.Location = new Point(xyz, xy);
                    for (double n = 1; n <= 999; n++) ;
                }
                
            }
            // Checks for Pressed Keys
            // Checks right key
            if (e.KeyCode == Keys.Right)
            {
                for (int i = 1; i <= 5; i++)
                {
                    // Adds a field limit
                    if (x >= 625)
                    {
                        // Prevents element from moving OOF
                        laserCannon.Location = new Point(x, y);
                    }
                    else
                    {
                        x += 1;
                        laserCannon.Location = new Point(x, y);
                        // Adds frames for an animated effect
                        for (double n = 1; n <= 400; n++) ;
                    }
                }
            }
            //Checks left key
            else if (e.KeyCode == Keys.Left)
            {
                for (int i = 1; i <= 5; i++)
                {
                    if (x <= 0)
                    {
                        laserCannon.Location = new Point(x, y);
                    }
                    else
                    {
                        x -= 1;
                        laserCannon.Location = new Point(x, y);
                        for (double n = 1; n <= 400; n++) ;
                    }
                }
            }
            // Will use to make longer faster slides left
            else if (e.KeyCode == Keys.A)
            {
                for (int i = 1; i <= 100; i++)
                {
                    if (x <= 0)
                    {
                        laserCannon.Location = new Point(x, y);
                    }
                    else {
                        x -= 1;
                        laserCannon.Location = new Point(x, y);
                        for (int n = 1; n <= 400; n++) ;
                    }
                }
            }

            // Will use to make longer faster slides right
            else if (e.KeyCode == Keys.D)
            {
                for (double i = 1; i <= 100; i++)
                {
                    if (x >= 625)
                    {
                        laserCannon.Location = new Point(x, y);
                    }
                    else
                    {
                        x += 1;
                        laserCannon.Location = new Point(x, y);
                        for (double n = 1; n <= 400; n++) ;
                    }
                }
            }

        }

    }
}
