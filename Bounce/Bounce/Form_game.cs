using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bounce
{
    public partial class Form_game : Form
    {
        public static int width = 44, height = 23;
        public int count;
        SolidBrush darkred = new SolidBrush(Color.DarkRed);
        SolidBrush Red = new SolidBrush(Color.Red);
        SolidBrush Gray = new SolidBrush(Color.SlateGray);
        SolidBrush Pink = new SolidBrush(Color.Pink);
        Pen Field = new Pen(Color.Black, 1);
        Bitmap bitmap;
        Ball redBall;
       
        int sec = 0, min = 0, hour = 0;
        private bool isPressedAnyKey = false;
        Image enemy = Image.FromFile("123.png");
        

        

    

       

        public Form_game()
        {
            count = 0;
            InitializeComponent();
            bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            KeyPreview = true;
            this.KeyDown += new KeyEventHandler(keyboard);
            this.KeyUp += new KeyEventHandler(freeKeyb);

                 
        }

        private void keyboard(object sender, KeyEventArgs e)
        {
           
                switch (e.KeyCode.ToString())
                {
                    case "W":
                        {
                            redBall.Navigation = 'T';

                            break;

                        }
                    case "A":
                        {
                            redBall.Navigation = 'L';
                            break;
                        }
                    case "S":
                        {
                            redBall.Navigation = 'D';
                            break;
                        }
                    case "D":
                        {
                            redBall.Navigation = 'R';
                            break;
                        }
                    default:
                        {
                            redBall.WantNavigation = redBall.Navigation;
                            break;
                        }

                }
                isPressedAnyKey = true;
            }
        
        private void freeKeyb(object sender, KeyEventArgs e)
        {
            isPressedAnyKey = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            timer2.Enabled = true;
            timer2.Interval = 1000;
            redBall = new Ball();
          
            timer1.Enabled = true;
            timer1.Interval = 200;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            

            for (int i = redBall.coordinatBalls.Count() - 1; i >= 0; i--)
            {
                if (i == 0 && isPressedAnyKey)
                {
                    redBall.Move();
                    
                }

            }
            Point[] points1 = new Point[3];
            points1[0].X = 50; points1[0].Y = 460;
            points1[1].X = 60; points1[1].Y = 485;
            points1[2].X = 40; points1[2].Y = 485;

            Point[] points2 = new Point[3];
            points2[0].X = 70; points2[0].Y = 460;
            points2[1].X = 80; points2[1].Y = 485;
            points2[2].X = 60; points2[2].Y = 485;

            Point[] points3 = new Point[3];
            points3[0].X = 90; points3[0].Y = 460;
            points3[1].X = 100; points3[1].Y = 485;
            points3[2].X = 80; points3[2].Y = 485;

            Point[] points4 = new Point[3];
            points4[0].X = 110; points4[0].Y = 460;
            points4[1].X = 120; points4[1].Y = 485;
            points4[2].X = 100; points4[2].Y = 485;

            Point[] points5 = new Point[3];
            points5[0].X = 130; points5[0].Y = 460;
            points5[1].X = 140; points5[1].Y = 485;
            points5[2].X = 120; points5[2].Y = 485;

            Point[] points6 = new Point[3];
            points6[0].X = 140; points6[0].Y = 35;
            points6[1].X = 150; points6[1].Y = 50;
            points6[2].X = 130; points6[2].Y = 50;

            Point[] points7 = new Point[3];
            points7[0].X = 260; points7[0].Y = 35;
            points7[1].X = 270; points7[1].Y = 50;
            points7[2].X = 250; points7[2].Y = 50;

            Point[] points8 = new Point[3];
            points8[0].X = 150; points8[0].Y = 460;
            points8[1].X = 160; points8[1].Y = 485;
            points8[2].X = 140; points8[2].Y = 485;

            Point[] points9 = new Point[3];
            points9[0].X = 170; points9[0].Y = 460;
            points9[1].X = 180; points9[1].Y = 485;
            points9[2].X = 160; points9[2].Y = 485;

            Point[] points10 = new Point[3];
            points10[0].X = 190; points10[0].Y = 460;
            points10[1].X = 200; points10[1].Y = 485;
            points10[2].X = 180; points10[2].Y = 485;

            Point[] points11 = new Point[3];
            points11[0].X = 210; points11[0].Y = 460;
            points11[1].X = 220; points11[1].Y = 485;
            points11[2].X = 200; points11[2].Y = 485;

            Point[] points12 = new Point[3];
            points12[0].X = 230; points12[0].Y = 460;
            points12[1].X = 240; points12[1].Y = 485;
            points12[2].X = 220; points12[2].Y = 485;

            Point[] points13 = new Point[3];
            points13[0].X = 250; points13[0].Y = 460;
            points13[1].X = 260; points13[1].Y = 485;
            points13[2].X = 240; points13[2].Y = 485;

            Point[] points14 = new Point[3];
            points14[0].X = 270; points14[0].Y = 460;
            points14[1].X = 280; points14[1].Y = 485;
            points14[2].X = 260; points14[2].Y = 485;

            Point[] points15 = new Point[3];
            points15[0].X = 290; points15[0].Y = 460;
            points15[1].X = 300; points15[1].Y = 485;
            points15[2].X = 280; points15[2].Y = 485;

            Graphics g = Graphics.FromImage(bitmap);
            g.Clear(Color.LightGreen);

            for (int i = 0; i < redBall.coordinatBalls.Count(); i++)
            {
                g.DrawEllipse(Field, redBall.coordinatBalls[i].x * width, redBall.coordinatBalls[i].y * height, width, height);

                g.DrawImage(enemy, 750, 50, 70, 70);

                
                g.FillEllipse(Red, redBall.coordinatBalls[i].x * width, redBall.coordinatBalls[i].y * height, width, height);
                
            }

            Rectangle rectangle1 = new Rectangle(130, 300, 100, 20);
            Rectangle rectangle2 = new Rectangle(0, 50, 650, 20);
            Rectangle rectangle3 = new Rectangle(170, 120, 730, 20);
            Rectangle rectangle4 = new Rectangle(20, 300, 20, 185);
            Rectangle rectangle5 = new Rectangle(270, 440, 50, 20);
            Rectangle recnagle6 = new Rectangle(320, 420, 30, 20);
            Rectangle rectangle7 = new Rectangle(350, 400, 30, 20);
            Rectangle rectangle8 = new Rectangle(380, 380, 30, 20);
            Rectangle rectangle9 = new Rectangle(410, 360, 30, 20);
            Rectangle rectangle10 = new Rectangle(430, 320, 200, 20);
            Rectangle rectangle11 = new Rectangle(800, 435, 70, 70);
            g.DrawRectangle(Field, rectangle2);
            g.FillRectangle(darkred, rectangle2);
            g.DrawRectangle(Field, rectangle3);
            g.FillRectangle(darkred, rectangle3);
            g.DrawRectangle(Field, rectangle4);
            g.FillRectangle(darkred, rectangle4);
            g.DrawRectangle(Field, rectangle1);
            g.FillRectangle(darkred, rectangle1);
            g.DrawRectangle(Field, rectangle5);
            g.FillRectangle(darkred, rectangle5);
            g.DrawRectangle(Field, rectangle7);
            g.FillRectangle(darkred, rectangle7);
            g.DrawRectangle(Field, rectangle8);
            g.FillRectangle(darkred, rectangle8);
            g.DrawRectangle(Field, rectangle9);
            g.FillRectangle(darkred, rectangle9);
            g.DrawRectangle(Field, rectangle10);
            g.FillRectangle(darkred, rectangle10);
            g.DrawRectangle(Field, rectangle11);
            g.FillRectangle(Pink, rectangle11);
            g.DrawPolygon(Field, points1);
            g.FillPolygon(Gray, points1);
            g.DrawPolygon(Field, points2);
            g.FillPolygon(Gray, points2);
            g.DrawPolygon(Field, points3);
            g.FillPolygon(Gray, points3);
            g.DrawPolygon(Field, points4);
            g.FillPolygon(Gray, points4);
            g.DrawPolygon(Field, points5);
            g.FillPolygon(Gray, points5);
            g.DrawPolygon(Field, points6);
            g.FillPolygon(Gray, points6);
            g.DrawPolygon(Field, points7);
            g.FillPolygon(Gray, points7);
            g.DrawPolygon(Field, points8);
            g.FillPolygon(Gray, points8);
            g.DrawPolygon(Field, points9);
            g.FillPolygon(Gray, points9);
            g.DrawPolygon(Field, points10);
            g.FillPolygon(Gray, points10);
            g.DrawPolygon(Field, points11);
            g.FillPolygon(Gray, points11);
            g.DrawPolygon(Field, points12);
            g.FillPolygon(Gray, points12);
            g.DrawPolygon(Field, points13);
            g.FillPolygon(Gray, points13);
            g.DrawPolygon(Field, points14);
            g.FillPolygon(Gray, points14);
            g.DrawPolygon(Field, points15);
            g.FillPolygon(Gray, points15);


           






            pictureBox1.Image = bitmap;
        
    }

        private void pictureBox1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }

        private void Form_game_KeyDown_1(object sender, KeyEventArgs e)
        {
           
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            
                sec++;
                if (sec >= 60) { min++; sec = 0; }
                if (min >= 60) { hour++; min = 0; }
                label1.Text = hour.ToString() + ":" + min.ToString() + ":" + sec.ToString();
            

        }
       



        private void Form_game_Load(object sender, EventArgs e)
        {
            timer2.Stop();
            
        }
    }
}
