using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BallApp {
    class Bar : Obj {
        public Bar(double x, double y)
         : base(x, y, @"pic\bar.png") {
            MoveX = 10;
            MoveY = 0;
            
        }

        public override void Move() {
            ;
        }

        public void Move(Keys direction) {
            if (direction == Keys.Right && PosX < 640){
                PosX += MoveX;
            }
            else if (direction == Keys.Left && PosX > 0) {
                PosX -= MoveX;
            }
        }
    }
}
