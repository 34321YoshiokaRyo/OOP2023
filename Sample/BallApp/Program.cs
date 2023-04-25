﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BallApp {
    class Program : Form{

        private Timer moveTimer;    //タイマー用
        // private SoccerBall soccerBall;
        private Obj obj;
        private PictureBox pb;       

        private List<Obj> balls = new List<Obj>(); //ボールインスタンス格納用
        private List<PictureBox> pbs = new List<PictureBox>();      //表示用

        static void Main(string[] args) {
            Application.Run(new Program());

        }

        public Program() {
            this.Size = new Size(800,600);
            this.BackColor = Color.Green;
            this.Text = "BallGame";
            this.MouseClick += Program_MouseClick;
            this.KeyDown += Program_KeyDown;


            moveTimer = new Timer();
            moveTimer.Interval = 30;//タイマーのインターバル
           
            moveTimer.Tick += MoveTimer_Tick;   //デリゲート登録
        }

        //キーが押された時のイベントハンドラ
        private void Program_KeyDown(object sender, KeyEventArgs e) {
           
        }

        //マウスクリック時のイベントハンドラ
        private void Program_MouseClick(object sender, MouseEventArgs e) {
            //ボールインスタンス生成
            if (e.Button == MouseButtons.Right)
            {
                obj = new TennisBall(e.X - 12, e.Y - 12);
                pb = new PictureBox();   //画像を表示するコントロール
                pb.Image = obj.Image;
                pb.Location = new Point((int)obj.PosX, (int)obj.PosY);//画像の位置
                pb.Size = new Size(25, 25);//画像の表示サイズ
                pb.SizeMode = PictureBoxSizeMode.StretchImage;  //画像の表示モード
                pb.Parent = this;

                balls.Add(obj);
                pbs.Add(pb);

                moveTimer.Start();//タイマースタート
          
                this.Text = "BallGame" + balls.Count;
            }
            else
            {
                obj = new SoccerBall(e.X - 25, e.Y - 25);
                pb = new PictureBox();   //画像を表示するコントロール
                pb.Image = obj.Image;
                pb.Location = new Point((int)obj.PosX, (int)obj.PosY);//画像の位置
                pb.Size = new Size(50, 50);//画像の表示サイズ
                pb.SizeMode = PictureBoxSizeMode.StretchImage;  //画像の表示モード
                pb.Parent = this;

                balls.Add(obj);
                pbs.Add(pb);

                moveTimer.Start();//タイマースタート

                this.Text = "BallGame" + balls.Count;
            }
        
    }

        //タイマーアウト時のイベントハンドラ
        private void MoveTimer_Tick(object sender, EventArgs e) {

            for (int i = 0; i < balls.Count; i++)
            {
                balls[i].Move(); //移動
                pbs[i].Location = new Point((int)balls[i].PosX, (int)balls[i].PosY); //画像の位置
            }
           
        }
    }
   
}
