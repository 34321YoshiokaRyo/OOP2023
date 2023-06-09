﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BallApp {
    class TennisBall : Obj {
        
        Random random = new Random();
        private static int cnt = 0;

        public static int Cnt { get => cnt; set => cnt = value; }

        public TennisBall(double x, double y)
           : base(x, y, @"pic\tennis_ball.png") {
            int rndX = random.Next(-15, 15);
            MoveX = (rndX != 0 ? rndX : 1);
            int rndY = random.Next(-15, 15);
            MoveY = (rndY != 0 ? rndY : 1);
            Cnt++;
        }

        public override void Move(PictureBox pbBar, PictureBox pbBall) {
            Rectangle rBar = new Rectangle(pbBar.Location.X, pbBar.Location.Y, pbBar.Width, pbBar.Height);

            Rectangle rBall = new Rectangle(pbBall.Location.X, pbBall.Location.Y, pbBall.Width, pbBall.Height);

            PosX += MoveX;
            PosY += MoveY;

            if (PosX > 750 || PosX < 0)
            {
                MoveX = -MoveX;
            }

            if (PosY > 550 || PosY < 0 || rBar.IntersectsWith(rBall))
            {
                MoveY = -MoveY;
            }
        }
        public override void Move(Keys direction) {
            ; 
        }
    }
}
