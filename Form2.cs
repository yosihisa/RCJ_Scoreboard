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
		
		public class LabelSize {
			public float FonsSize;
			public float XRation;
			public float YRation;
			public float WithRatio;
			public float HeightRatio;
		}

		public Form2(Form1 f) {
			InitializeComponent();
			f1 = f;

			this.MouseDown += new MouseEventHandler(Form2_MouseDown);
			this.MouseMove += new MouseEventHandler(Form2_MouseMove);
		}
		
		public LabelSize l1 = new LabelSize();
		public LabelSize l2 = new LabelSize();
		public LabelSize l3 = new LabelSize();
		public LabelSize l4 = new LabelSize();
		public LabelSize l5 = new LabelSize();
		public LabelSize l6 = new LabelSize();
		public LabelSize l7 = new LabelSize();
		public LabelSize l8 = new LabelSize();
		public LabelSize l9 = new LabelSize();
		public LabelSize l10= new LabelSize();
		public LabelSize l11= new LabelSize();
		public LabelSize l12= new LabelSize();
		public LabelSize l13= new LabelSize();
		public LabelSize l14 = new LabelSize();
		public LabelSize l15 = new LabelSize();
		public LabelSize l16 = new LabelSize();
		public LabelSize l17 = new LabelSize();
		public LabelSize l18 = new LabelSize();
		public LabelSize l19 = new LabelSize();
		public LabelSize l20 = new LabelSize();
		public LabelSize l21 = new LabelSize();
		public LabelSize l22 = new LabelSize();
		public LabelSize l23 = new LabelSize();
		public LabelSize l24 = new LabelSize();


		//ウィンドウが変更されたとき
		private void Form2_Load(object sender, EventArgs e) {

			GetSize_label(label1, l1, 0);ScalingController_label(label1, l1, 0);
			GetSize_label(label2, l2, 0);ScalingController_label(label2, l2, 0);
			GetSize_label(label3, l3, 1);ScalingController_label(label3, l3, 1);
			GetSize_label(label4, l4, 0);ScalingController_label(label4, l4, 0);
			GetSize_label(label5, l5, 0);ScalingController_label(label5, l5, 0);
			GetSize_label(label6, l6, 1);ScalingController_label(label6, l6, 1);
			GetSize_label(label7, l7, 0);ScalingController_label(label7, l7, 0);
			GetSize_label(label8, l8, 0);ScalingController_label(label8, l8, 0);
			GetSize_label(label9, l9, 1);ScalingController_label(label9, l9, 1);
			GetSize_label(label10, l10, 0);ScalingController_label(label10, l10, 0);
			GetSize_label(label11, l11, 0);ScalingController_label(label11, l11, 0);
			GetSize_label(label12, l12, 1);ScalingController_label(label12, l12, 1);
			GetSize_label(label13, l13, 0);ScalingController_label(label13, l13, 0);
			GetSize_label(label14, l14, 0);ScalingController_label(label14, l14, 0);
			GetSize_label(label15, l15, 1);ScalingController_label(label15, l15, 1);
			GetSize_label(label16, l16, 0);ScalingController_label(label16, l16, 0);
			GetSize_label(label17, l17, 0);ScalingController_label(label17, l17, 0);
			GetSize_label(label18, l18, 1);ScalingController_label(label18, l18, 1);
			GetSize_label(label19, l19, 0);ScalingController_label(label19, l19, 0);
			GetSize_label(label20, l20, 0);ScalingController_label(label20, l20, 0);
			GetSize_label(label21, l21, 1); ScalingController_label(label21, l21, 1);
			GetSize_label(label22, l22, 1); ScalingController_label(label22, l22, 1);
			GetSize_label(label23, l23, 1); ScalingController_label(label23, l23, 1);
			GetSize_label(label24, l24, 0); ScalingController_label(label24, l24, 0);
			F1_TextChanged();
		}
		//サイズが変更されたとき
		private void Form2_Resize(object sender, EventArgs e) {
			ScalingController_label(label1, l1, 0);
			ScalingController_label(label2, l2, 0);
			ScalingController_label(label3, l3, 1);
			ScalingController_label(label4, l4, 0);
			ScalingController_label(label5, l5, 0);
			ScalingController_label(label6, l6, 1);
			ScalingController_label(label7, l7, 0);
			ScalingController_label(label8, l8, 0);
			ScalingController_label(label9, l9, 1);
			ScalingController_label(label10, l10, 0);
			ScalingController_label(label11, l11, 0);
			ScalingController_label(label12, l12, 1);
			ScalingController_label(label13, l13, 0);
			ScalingController_label(label14, l14, 0);
			ScalingController_label(label15, l15, 1);
			ScalingController_label(label16, l16, 0);
			ScalingController_label(label17, l17, 0);
			ScalingController_label(label18, l18, 1);
			ScalingController_label(label19, l19, 0);
			ScalingController_label(label20, l20, 0);
			ScalingController_label(label21, l21, 1);
			ScalingController_label(label22, l22, 1);
			ScalingController_label(label23, l23, 1);
			ScalingController_label(label24, l24, 0);
		}

		//F1のテキストが変更されたとき
		public void F1_TextChanged() {
			label1.Text = f1.textBox1.Text;
			label2.Text = f1.textBox2.Text;
			label20.Text = f1.textBox6.Text;
			label19.Text = f1.textBox5.Text;
			label3.Text = f1.textBox3.Text;
			label18.Text = f1.textBox4.Text;
			label9.Text = "" + f1.numericUpDown1.Value + "";
			label6.Text = "" + f1.numericUpDown2.Value + "";
			label12.Text = "" + f1.numericUpDown4.Value + "";
			label15.Text = "" + f1.numericUpDown3.Value + "";
			label22.BeginInvoke((MethodInvoker)delegate () { label22.Text = f1.textBox_state.Text; });
			label21.BeginInvoke((MethodInvoker)delegate () { label21.Text = f1.textBox_M.Text; });
			label23.BeginInvoke((MethodInvoker)delegate () { label23.Text = f1.textBox_S.Text; });
		}

		//閉じられたとき
		private void From2_Closing(object sender, FormClosingEventArgs e) {
			f1.Scoreboard.Enabled = true;
		}
		
		//マウスポインタの位置を保存する
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


		//サイズ変更計算
		public void GetSize_label(Label label, LabelSize size,int type) {
			if(type != 0) {
				size.WithRatio = (float)label.Width / (float)ClientSize.Width;
				size.HeightRatio = (float)label.Height / (float)ClientSize.Height;
			}
			size.FonsSize = (float)label.Font.Size / (float)ClientSize.Height;
			size.XRation = (float)label.Location.X / (float)ClientSize.Width;
			size.YRation = (float)label.Location.Y / (float)ClientSize.Height;
		}
		public void ScalingController_label(Label label, LabelSize size, int type) {
			Point ControllerPosition = new Point();
			if (type != 0) { 
				label.Width = (int)(size.WithRatio * (float)ClientSize.Width);
				label.Height = (int)(size.HeightRatio * (float)ClientSize.Height);
			}
			label.Font = new Font(label.Font.FontFamily, (int)(size.FonsSize * (float)ClientSize.Height));
			ControllerPosition.X = (int)(size.XRation * (float)ClientSize.Width);
			ControllerPosition.Y = (int)(size.YRation * (float)ClientSize.Height);
			label.Location = ControllerPosition;
		}
	}
}
