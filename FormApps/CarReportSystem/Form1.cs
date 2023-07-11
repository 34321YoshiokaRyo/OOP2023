using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarReportSystem {
    public partial class Form1 : Form {
        //管理用データ
        BindingList<CarReport> CarReports = new BindingList<CarReport>();

        public Form1() {
            InitializeComponent();
            dgvCarReports.DataSource = CarReports;
        }

        //追加ボタンがクリックされた時のイベントハンドラー
        private void btAddReport_Click(object sender, EventArgs e) {
            CarReport cr = new CarReport {
                date = dtpDate.Value,
                Author = cbAuthor.Text,
                Maker = getSelectedMaker(),
                CarName = cbCarName.Text,
                Report = tbReport.Text,
                CarImage = pbCarImage.Image,
            };
            CarReports.Add(cr);
        }

        //ラジオボタンで選択されているメーカーを返却
        private CarReport.MakerGroup getSelectedMaker() {
            int tag = 0;
            foreach (var item in gbMaker.Controls) {
                if (((RadioButton)item).Checked) {
                    tag = int.Parse(((RadioButton)item).Tag.ToString());
                    break;
                }
            }
            return (CarReport.MakerGroup)tag;

            /*         if (rbToyota.Checked) {
                         return CarReport.MakerGroup.トヨタ;
                     }else if (rbNissan.Checked) {
                         return CarReport.MakerGroup.日産;
                     }
                     else if (rbHonda.Checked) {
                         return CarReport.MakerGroup.ホンダ;
                     }
                     else if (rbImported.Checked) {
                         return CarReport.MakerGroup.輸入車;
                     }
                     else if (rbSubaru.Checked) {
                         return CarReport.MakerGroup.スバル;
                     }
                     else if (rbSuzuki.Checked) {
                         return CarReport.MakerGroup.スズキ;
                     }
                     else if (rbDaihatsu.Checked) {
                         return CarReport.MakerGroup.ダイハツ;
                     }

                     return CarReport.MakerGroup.その他;
           */
        }

        //指定したメーカーのラジオボタンをセット
        private void setSelectedMaker(CarReport.MakerGroup makerGroup) {
            switch (makerGroup) {
                case CarReport.MakerGroup.トヨタ:
                    rbToyota.Checked = true;
                    break;
                case CarReport.MakerGroup.日産:
                    break;
                case CarReport.MakerGroup.ホンダ:
                    break;
                case CarReport.MakerGroup.輸入車:
                    break;
                case CarReport.MakerGroup.スバル:
                    break;
                case CarReport.MakerGroup.スズキ:
                    break;
                case CarReport.MakerGroup.ダイハツ:
                    break;
                case CarReport.MakerGroup.その他:
                    break;
            }
        }


        private void btImageOpen_Click(object sender, EventArgs e) {
            ofdImageFileOpen.ShowDialog();
            pbCarImage.Image = Image.FromFile(ofdImageFileOpen.FileName);
        }

        //削除ボタンイベントハンドラ
        private void btDeleteReport_Click(object sender, EventArgs e) {
            //   foreach (DataGridViewRow item in dgvCarReports.SelectedRows) {
            //       if (!item.IsNewRow) {
            //          dgvCarReports.Rows.Remove(item);
            //       }
            //   }
            CarReports.RemoveAt(dgvCarReports.CurrentRow.Index);
        }

        //レコード選択時
        private void dgvCarReports_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            dtpDate.Value = (DateTime)dgvCarReports.CurrentRow.Cells[0].Value;
            cbAuthor.Text = dgvCarReports.CurrentRow.Cells[1].Value.ToString();
            setSelectedMaker((CarReport.MakerGroup)dgvCarReports.CurrentRow.Cells[2].Value);
            cbCarName.Text = dgvCarReports.CurrentRow.Cells[3].Value.ToString();
            tbReport.Text = dgvCarReports.CurrentRow.Cells[4].Value.ToString();
            pbCarImage.Image = (Image)dgvCarReports.CurrentRow.Cells[5].Value;
        }

        private void Form1_Load(object sender, EventArgs e) {
            dgvCarReports.Columns[5].Visible = false;   //画像項目非表示
            btModifyReport.Enabled = false;//マスク
        }

        //更新ボタンイベントハンドラ
        private void btModifyReport_Click(object sender, EventArgs e) {
            CarReports[dgvCarReports.CurrentRow.Index].date = dtpDate.Value;
            CarReports[dgvCarReports.CurrentRow.Index].Author = cbAuthor.Text;
            CarReports[dgvCarReports.CurrentRow.Index].Maker = getSelectedMaker();
            CarReports[dgvCarReports.CurrentRow.Index].CarName = cbCarName.Text;
            CarReports[dgvCarReports.CurrentRow.Index].Report = tbReport.Text;
            dgvCarReports.Refresh();
        }
    }

}
