using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btButton_Click(object sender, EventArgs e) {
            // int ans = int.Parse(tbNum1.Text) + int.Parse(tbNum2.Text);;
            // tbAns.Text = ans.ToString();

            int num1 = int.Parse(tbNum1.Text);
            int num2 = int.Parse(tbNum2.Text);
            int sum = num1 + num2;
            tbAns.Text = sum.ToString();
            
        }

        private void label3_Click(object sender, EventArgs e) {

        }

        private void label4_Click(object sender, EventArgs e) {

        }

        private void tbResult_TextChanged(object sender, EventArgs e) {

        }

        private void label5_Click(object sender, EventArgs e) {

        }

        private void btPow_Click(object sender, EventArgs e) {
            
        }

        private void btPow_Click_1(object sender, EventArgs e) {
            
            decimal num = nudX.Value;
            
            for (int i = 1; i < nudY.Value; i++)
            {
                num = nudX.Value * num;
            }

            tbResult.Text = num.ToString(); 

        }

        //double result = Math.Pow((double)nudX.Value,(double)nudY.Value)
        //tbResult.Text = result.ToString();
        //


        private void nudX_ValueChanged(object sender, EventArgs e) {

        }
    }
}
