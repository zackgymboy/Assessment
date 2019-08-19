using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VapeNation
{
    public partial class FrmVape : Form
    {
        Graphics g; //declare a graphics object called g
                    // declare space for an array of 7 objects called planet 
        Obstacle[] obstacle = new Obstacle[7];


        public FrmVape()
        {
            InitializeComponent();
            for (int i = 0; i < 7; i++)
            {
                int y = 10 + (i * 75);
                obstacle[i] = new Obstacle(y);
            }

        }

        private void pnlGame_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < 7; i++)
            {
                //call the Planet class's drawPlanet method to draw the images
                obstacle[i].drawobstacle(g);
            }



            }
        }
}
