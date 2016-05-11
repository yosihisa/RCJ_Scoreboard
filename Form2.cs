using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RCJ_Scoreboard {
    
    public partial class Form2 : Form {
		private Form1 f1;

		public Form2(Form1 f) {
            InitializeComponent();
			f1 = f;
			this.MouseDown += new MouseEventHandler(Form2_MouseDown);
			this.MouseMove += new MouseEventHandler(Form2_MouseMove);
		}

		private float WithRatio_Button; // ボタンの横幅の比率
		private float HeightRatio_Button; // ボタンの縦幅の比率
		private float XRation_Button; // ボタンのx座標位置の比率
		private float YRation_Button; // ボタンのy座標位置の比率

		private void Form2_Load(object sender, EventArgs e) {
			// ボタンの横幅を算出(ただし、比率で算出)
			WithRatio_Button = (float)button1.Width / (float)ClientSize.Width;

			// ボタンの縦幅を算出(ただし、比率で算出)
			HeightRatio_Button = (float)button1.Height / (float)ClientSize.Height;

			// ボタンのx座標位置を算出(ただし、比率で算出)
			XRation_Button = (float)button1.Location.X / (float)ClientSize.Width;

			// ボタンのy座標位置を算出(ただし、比率で算出)
			YRation_Button = (float)button1.Location.Y / (float)ClientSize.Height;

			ScalingController();

		}
		

        private void From2_Closing(object sender, FormClosingEventArgs e) {
			f1.Scoreboard.Enabled = true;
		}

		// マウスポインタの位置を保存する
		private Point mousePoint;

		//マウスのボタンが押されたとき
		private void Form2_MouseDown(object sender,
			System.Windows.Forms.MouseEventArgs e) {
			if ((e.Button & MouseButtons.Left) == MouseButtons.Left) {
				//位置を記憶する
				mousePoint = new Point(e.X, e.Y);
			}
		}

		//マウスが動いたとき
		private void Form2_MouseMove(object sender,
			System.Windows.Forms.MouseEventArgs e) {
			if ((e.Button & MouseButtons.Left) == MouseButtons.Left) {
				this.Left += e.X - mousePoint.X;
				this.Top += e.Y - mousePoint.Y;
			}
		}

		//サイズが変更されたとき
		private void Form2_Resize(object sender, EventArgs e) {

			// コントロールサイズをフォームサイズに合わせる処理容
			ScalingController();

		}

		public void ScalingController() {

			// 位置座標を格納する一時的作業用オブジェクト
			Point ControllerPosition = new Point();
			//------------
			// 比率と、サイズ変更後のフォームの大きさから、ボタンの大きさと位置を算出
			//------------

			button1.Width = (int)(WithRatio_Button * (float)ClientSize.Width);
			button1.Height = (int)(HeightRatio_Button * (float)ClientSize.Height);
			ControllerPosition.X = (int)(XRation_Button * (float)ClientSize.Width);
			ControllerPosition.Y = (int)(YRation_Button * (float)ClientSize.Height);
			button1.Location = ControllerPosition;
			

		}
	}


}
