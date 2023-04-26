using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallApp {
    class SoccerBall : Obj{

        Random random = new Random();
        private static int cnt;

        //コンストラクタ
        public SoccerBall(double x, double y)
            :base(x,y, @"pic\soccer_ball.png"){
            int rndX = random.Next(-15, 15);
            MoveX = (rndX != 0 ? rndX : 1);
            int rndY = random.Next(-15, 15);
            MoveY = (rndY != 0 ? rndY : 1);
            Cnt++;
        }

        
        public static int Cnt { get => cnt; set => cnt = value; }

        //メソッド
        public override void Move() {
            Console.WriteLine("x座標 = {0},y座標 = {1}", PosX,PosY);

            PosX += MoveX;
            PosY += MoveY;

            if (PosX > 750 || PosX < 0)
            {
                MoveX = -MoveX;
            }

            if (PosY > 550 || PosY < 0)
            {
                MoveY = -MoveY;
            }
        }

    }
}
