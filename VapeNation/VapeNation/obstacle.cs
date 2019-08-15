using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace VapeNation
{
    class Obstacle
    {
        // declare fields to use in the class
        public int x, y, width, height;//variables for the rectangle
        public Image obstacleImage;//variable for the planet's image

        public Rectangle obstacleRec;//variable for a rectangle to place our image in
        public int score;
        //Create a constructor (initialises the values of the fields)

        public Obstacle(int spacing)
        {
            x = 380;
            y = spacing;
            width = 30;
            height = 30;
            obstacleImage = Image.FromFile("Pod1.png");
            obstacleRec = new Rectangle(x, y, width, height);
        }
        // Methods for the Planet class
        public void drawobstacle(Graphics g)
        {
            obstacleRec = new Rectangle(x, y, width, height);
            g.DrawImage(obstacleImage, obstacleRec);
        }

    }
}
