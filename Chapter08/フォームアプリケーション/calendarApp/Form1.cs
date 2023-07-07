using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calendarApp {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();

        }

        private void btDayCalc_Click(object sender, EventArgs e) {
            var dtp = dtpDate.Value;
            var now = DateTime.Now;
            var days = now.Date - dtp.Date;

            tbMessage.Text = "Textプロパティへ文字列を渡すと表示されます。";
            tbMessage.Text = days.Days + "日";
        }



        private void btAge_Click(object sender, EventArgs e) {
            var birthday = dtpDate.Value;
            var today = DateTime.Today;
            int age = GetAge(birthday, today);
            tbMessage.Text = age.ToString() + "歳";
        }

        public static int GetAge(DateTime birthday, DateTime targetDay) {
            var age = targetDay.Year - birthday.Year;
            if (targetDay < birthday.AddYears(age)) {
                age--;
            }
            return age;
        }

        private void Form1_Load(object sender, EventArgs e) {
            
            tmTimeDisp.Start();
        }

        //タイマーイベントハンドラー
        private void tmTimeDisp_Tick(object sender, EventArgs e) {
            var now = DateTime.Now;
            tbTime.Text = now.ToString("yyyy年MM月dd日(ddd曜日) HH時mm分ss秒");
        }
    }
}
