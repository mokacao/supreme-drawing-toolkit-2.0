﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingToolkit.Tools
{
    class Ellipse : DrawingObject
    {
        private const double EPSILON = 3.0;
        public Pen pen = new Pen(Color.Black, 5);
        public int mX { get; set; }
        public int mY { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public Ellipse(int mX, int mY, int width, int height)
        {
            this.mX = mX;
            this.mY = mY;
            this.Width = width;
            this.Height = height;
        }
        public override void DrawObject(Graphics g)
        {
            Debug.WriteLine("Drawing A Circle");
            g.DrawEllipse(pen, mX, mY, Width, Height);
        }

        public override bool Intersect(int xTest, int yTest)
        {
            if ((xTest >= mX && xTest <= mX + Width) && (yTest >= mY && yTest <= mY + Height))
            {
                Debug.WriteLine("Object " + "ellipse" + " is selected.");
                return true;
            }
            return false;
        }
    }
}