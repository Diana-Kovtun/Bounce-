using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;

namespace Bounce
{
    struct coordinatBall
    {
        public int x;
        public int y;
    }
    class Ball
    {
        public int width = 20, height = 20;
        public List<coordinatBall> coordinatBalls = new List<coordinatBall>();
        public char Navigation;
        public char WantNavigation = 'N';
        public Ball()
        {
            coordinatBalls.Add(new coordinatBall() { x = 1, y = 30});
           




        }
        public void Move()
        {
             




                switch (Navigation)
                {
                    case 'L':
                        {
                        
                            var temp = coordinatBalls[0];
                            temp.x--;
                            coordinatBalls[0] = temp;
                      
                            break;
                        }
                    case 'R':
                        {
                            var temp = coordinatBalls[0];
                            temp.x++;
                            coordinatBalls[0] = temp;

                            break;
                        }
                    
                    
                case 'F':
                    {
                        var temp = coordinatBalls[0];
                        temp.x++;
                        temp.x--;
                        coordinatBalls[0] = temp;
                        break;
                    }
                }
            }
        public void MoveDown()
        {
            var temp = coordinatBalls[0];
            temp.y++;
            coordinatBalls[0] = temp;
            
        }
        public void MoveUp()
        {
            var temp = coordinatBalls[0];
            temp.y-=30;

            coordinatBalls[0] = temp;
        }
        }
    }
















