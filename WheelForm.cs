using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BardsTaleCodeWHeel
{
    public partial class WheelForm : Form
    {
        Image wheelA;
        Image wheelB;
        Image wheelC;

        public WheelForm()
        {
            InitializeComponent();
            this.BackColor = Color.DarkBlue;
            this.TransparencyKey = Color.DarkBlue;

            wheelA = Bitmap.FromFile("wheelA.png");
            wheelB = Bitmap.FromFile("wheelB.png");
            wheelC = Bitmap.FromFile("wheelC.png");

            this.picA.BackgroundImage = mergewheel(0, 0);
        }

        private bool mouseDown;
        private Point lastLocation;
        private double wheelCangle = 0;
        private double wheelBangle = 0;

        public float NearestRound(float x, float delX)
        {
            if (delX < 1)
            {
                float i = (float)Math.Floor(x);
                float x2 = i;
                while ((x2 += delX) < x) ;
                float x1 = x2 - delX;
                return (Math.Abs(x - x1) < Math.Abs(x - x2)) ? x1 : x2;
            }
            else
            {
                return (float)Math.Round(x / delX, MidpointRounding.AwayFromZero) * delX;
            }
        }

        private Bitmap RotateImage(Bitmap bmp, float angle)
        {
            Bitmap rotatedImage = new Bitmap(bmp.Width, bmp.Height);
            using (Graphics g = Graphics.FromImage(rotatedImage))
            {
                // Set the rotation point to the center in the matrix
                g.TranslateTransform(bmp.Width / 2, bmp.Height / 2);
                // Rotate
                g.RotateTransform(angle);
                // Restore rotation point in the matrix
                g.TranslateTransform(-bmp.Width / 2, -bmp.Height / 2);
                // Draw the image on the bitmap
                g.DrawImage(bmp, new Point(0, 0));
            }

            return rotatedImage;
        }

        private Bitmap mergewheel(double angleC, double angleB)
        {
            Bitmap b = new Bitmap(wheelA);
            Graphics g = Graphics.FromImage(b);

            //add B
            Bitmap b_rotate = new Bitmap(wheelB);
            g.DrawImageUnscaledAndClipped(RotateImage(b_rotate, (float)angleB), new Rectangle(0,0,b.Width,b.Height));

            //add C
            Bitmap c_rotate = new Bitmap(wheelC);
            g.DrawImageUnscaledAndClipped(RotateImage(c_rotate, (float)angleC), new Rectangle(0, 0, b.Width, b.Height));

            g.Dispose();

            return b;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MouseEventArgs m = (MouseEventArgs)e;

            if (m.X > 791 && m.X < 838 && m.Y > 19 && m.Y < 63)
                this.Close();

            double mx = m.X - (picA.Width / 2);
            double my = m.Y - (picA.Height / 2);

            double radius = Math.Sqrt((mx * mx) + (my *my));
            double angle = GetAngleFromPoint(mx,my);

            Debug.WriteLine("angle = " + angle + ", radius = " + radius);

            if (radius > 299 && radius < 331)
            {
                //wheelC angle
                wheelCangle = NearestRound((float)(angle - 7), 15);
                this.picA.BackgroundImage = mergewheel(wheelBangle, wheelCangle);
                return;
            }
            if (radius > 330 && radius < 424)
            {
                //wheelB angle
                wheelBangle = NearestRound((float)(angle - 15), 30);
                this.picA.BackgroundImage = mergewheel(wheelBangle, wheelCangle);
                return;
            }
        }

        internal double GetAngleFromPoint(double dx, double dy)
        {
            var theta = Math.Atan2(dx, -dy);
            var angle = ((theta * 180 / Math.PI) + 360) % 360;
            return angle;
        }

        private void picA_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }
        
        private void picA_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void picA_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
