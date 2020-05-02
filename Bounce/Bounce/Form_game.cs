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
using System.IO;
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
        SolidBrush Pink = new SolidBrush(Color.DeepPink);
        Pen Field = new Pen(Color.Black, 1);
        Bitmap bitmap;
        Ball redBall;
        Enemies enemies;
       
        int sec = 0, min = 0, hour = 0;
        private bool isPressedAnyKey = false;
        Image enemy = Image.FromFile("123.png");
        
        
        

    

       

        public Form_game(string temp)
        {
            
            
            
            count = 0;
            InitializeComponent();
            bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            KeyPreview = true;
            this.KeyDown += new KeyEventHandler(keyboard);
            this.KeyUp += new KeyEventHandler(freeKeyb);
            label2.Hide();
            label2.Text = temp;





        }

        private void keyboard(object sender, KeyEventArgs e)
        {


            switch (e.KeyCode.ToString())
            {
                case "W":
                    {
                     

                            redBall.MoveUp();
                        
                        
                      
                      

                        break;

                    }
                case "A":
                    {
                        redBall.Navigation = 'L';
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
            if (redBall.coordinatBalls[0].x <= 0)
            {
                redBall.Navigation = 'R';
            }
            if (redBall.coordinatBalls[0].x >=830)
            {
                redBall.Navigation = 'L';
            }
            if ((redBall.coordinatBalls[0].x >= 800) && (redBall.coordinatBalls[0].y >= 430))
            {
                timer1.Stop();
                timer2.Stop();
                timer3.Stop();
                MessageBox.Show("Winner!");
                StreamWriter XF = new StreamWriter("123.txt", true);
                XF.WriteLine(label2.Text);
                XF.WriteLine(hour.ToString() + ":" + min.ToString() + ":" + sec.ToString());
                XF.Close();
                this.Close();
                Form_results k = new Form_results(label2.Text,label1.Text);
                this.Hide();
                k.ShowDialog();
                this.Close();
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
            enemies = new Enemies();
            timer3.Enabled = true;
            timer3.Interval = 10;
               
            timer1.Enabled = true;
            timer1.Interval = 1;
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
                g.DrawEllipse(Field, redBall.coordinatBalls[i].x * 1, redBall.coordinatBalls[i].y * 1, 20, 20);

                g.DrawImage(enemy,enemies.x * 1,enemies.y* 50, 70, 70);

                
                g.FillEllipse(Red, redBall.coordinatBalls[i].x * 1, redBall.coordinatBalls[i].y * 1, 20, 20);
                
            }
            
           

            Rectangle rectangle1 = new Rectangle(130, 300, 100, 20);
            Rectangle rectangle2 = new Rectangle(0, 50, 650, 20);
            Rectangle rectangle3 = new Rectangle(170, 120, 730, 20);
            Rectangle rectangle4 = new Rectangle(20, 300, 20, 185);
            Rectangle rectangle5 = new Rectangle(250, 440, 50, 20);
            Rectangle rectangle11 = new Rectangle(820, 430, 70, 70);
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

            if (redBall.coordinatBalls[0].x > 650 && redBall.coordinatBalls[0].y < 100)
            {
                do
                {
                    redBall.MoveDown();
                } while (redBall.coordinatBalls[0].y == 100);
            }
            if (redBall.coordinatBalls[0].x < 150 && redBall.coordinatBalls[0].y <= 280&& redBall.coordinatBalls[0].x < 320 && redBall.coordinatBalls[0].y > 100)
            {
                do
                {
                    redBall.MoveDown();
                } while (redBall.coordinatBalls[0].y == 280);

            }
            if (redBall.coordinatBalls[0].x >= 230 && redBall.coordinatBalls[0].y > 280&&redBall.coordinatBalls[0].y<=420)
            {
                do
                {
                    redBall.MoveDown();
                } while (redBall.coordinatBalls[0].y == 420);

            }
            if (redBall.coordinatBalls[0].x<120&&redBall.coordinatBalls[0].x>40&&redBall.coordinatBalls[0].y>280)
            {
                do
                {
                    redBall.MoveDown();
                } while (redBall.coordinatBalls[0].y == 440);

            }
           
            if (redBall.coordinatBalls[0].y > 420&&redBall.coordinatBalls[0].x>300&&redBall.coordinatBalls[0].y<=465)
            {
                do
                {
                    redBall.MoveDown();
                } while (redBall.coordinatBalls[0].y == 465);
            }
            if (redBall.coordinatBalls[0].y < 400&&redBall.coordinatBalls[0].y > 140 && redBall.coordinatBalls[0].x > 250 && redBall.coordinatBalls[0].x < 280)
            {
                do
                {
                    redBall.MoveDown();
                } while (redBall.coordinatBalls[0].y==400);
            }
            if (redBall.coordinatBalls[0].y <= 30)
            {
                redBall.MoveDown();
            }
            if(redBall.coordinatBalls[0].x >= 120&&redBall.coordinatBalls[0].x <=140&&redBall.coordinatBalls[0].y <= 35&&redBall.coordinatBalls[0].y>=17||
                redBall.coordinatBalls[0].x>=240&&redBall.coordinatBalls[0].x<=260&&redBall.coordinatBalls[0].y<=35&&redBall.coordinatBalls[0].y>=17||
                redBall.coordinatBalls[0].x>=40&&redBall.coordinatBalls[0].x<=300&&redBall.coordinatBalls[0].y>=440)
            {
                timer1.Stop();
                timer2.Stop();
          
                timer3.Stop();
                MessageBox.Show("Game over!");
            }




            pictureBox1.Image = bitmap;
        
    }

        private void pictureBox1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            
            if (enemies.x>=650)
            {
                enemies.MoveLeft();
               
             
            }
            else
            {
                for(int j = 650;j<=830; j++) { 
                    enemies.MoveRight();
                   
                }

              
            }
            if (redBall.coordinatBalls[0].x == enemies.x && redBall.coordinatBalls[0].y >= 50 && redBall.coordinatBalls[0].y <= 120)
            {
                MessageBox.Show("Game over!");
                timer1.Stop();
                timer3.Stop();
                timer2.Stop();
            }

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
