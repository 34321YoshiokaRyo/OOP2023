using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallApp {
    class SoccerBall {
        //フィールド
        private Image image;    //画像データ

        private double posX;  //x座標
        private double posY;  //y座標

        private double moveX;  //移動量（x方向）
        private double moveY;  //移動量（y方向）

        //Random rx = new System.Random();    
        //Random ry = new System.Random();
        Random random = new Random();

        //コンストラクタ
        public SoccerBall(double x, double y) {
            Image = Image.FromFile(@"pic\soccer_ball.png");
            PosX = x;
            PosY = y;

            int rndX = random.Next(-15, 15);
            moveX = (rndX != 0 ? rndX : 1);
            int rndY = random.Next(-15, 15);
            moveY = (rndY != 0 ? rndY : 1);
            //moveX = rx.Next(1, 20);
            //moveY = ry.Next(1, 20);
        }

        //プロパティ
        public double PosX { get => posX; set => posX = value; }
        public double PosY { get => posY; set => posY = value; }
        public Image Image { get => image; set => image = value; }
   
        //メソッド
        public void Move() {
            Console.WriteLine("x座標 = {0},y座標 = {1}", posX,PosY);

            posX += moveX;
            posY += moveY;

            if (posX > 750 || posX < 0)
            {
                moveX = -moveX;
            }

            if (posY > 550 || posY < 0)
            {
                moveY = -moveY;
            }

            
        }

    }
}
