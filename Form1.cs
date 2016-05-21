using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace RCJ_Scoreboard {

	public partial class Form1 : Form {
		Form2 f2;

		RCJ_timer t = new RCJ_timer();

		public Form1() {
			InitializeComponent();
			button5.Enabled = false;

			button3.Text = "開始";
			button5.Text = "一時停止";

			t.NewTimer(this);
		}

		private void button1_Click(object sender, EventArgs e) {
			Scoreboard.Enabled = false;
			Form2 f = new Form2(this); // 子フォームの生成

			f.Text = "ロボカップ　得点板";
			f.Show(); // 子フォームの表示
			f2 = f;
		}

		//form2が閉じられた
		public void f2_Closed() {
			Scoreboard.Enabled = true;
		}

		private void Form1_Load(object sender, EventArgs e) {

		}

		private void TextboxChanged(object sender, EventArgs e) {
			if (Scoreboard.Enabled != true) f2.F1_TextChanged();
		}

		private void ValueChanged(object sender, EventArgs e) {
			int a = (int)numericUpDown1.Value + (int)numericUpDown2.Value;
			int b = (int)numericUpDown3.Value + (int)numericUpDown4.Value;
			textBox3.Text = "" + a + "";
			textBox4.Text = "" + b + "";
			if (Scoreboard.Enabled != true) f2.F1_TextChanged();
		}

		//開始・再開
		private void button3_Click(object sender, EventArgs e) {
			button3.Enabled = false;
			button5.Enabled = true;
			button3.Text = "再開";
			t.StartTimer();
		}

		//一時停止
		private void button5_Click(object sender, EventArgs e) {
			button3.Enabled = true;
			button5.Enabled = false;
			t.StopTimer();
		}


		//チーム1　得点
		private void button1_Click_1(object sender, EventArgs e) {
			if (radioButton2.Checked) numericUpDown1.Value++;
			if (radioButton4.Checked) numericUpDown2.Value++;
		}

		//チーム2　得点
		private void button2_Click(object sender, EventArgs e) {
			if (radioButton2.Checked) numericUpDown4.Value++;
			if (radioButton4.Checked) numericUpDown3.Value++;
		}

		//リセット
		private void button_reset_Click(object sender, EventArgs e) {
			textBox_state.Text = "";
			textBox_M.Text = "";
			textBox_S.Text = "";
			b_s.Value = 10;
			f_m.Value = 10;
			f_s.Value = 0;
			h_m.Value = 5;
			h_s.Value = 0;
			s_m.Value = 10;
			s_s.Value = 0;
			numericUpDown1.Value = 0;
			numericUpDown2.Value = 0;
			numericUpDown3.Value = 0;
			numericUpDown4.Value = 0;
			radioButton1.Checked = true;

			button3.Enabled = true;
			button5.Enabled = false;
			button3.Text = "開始";
			button5.Text = "一時停止";
			t.StopTimer();
		}

		//試合終了が選択されたら
		private void radioButton5_CheckedChanged(object sender, EventArgs e) {
			textBox_state.BeginInvoke((MethodInvoker)delegate () { textBox_state.Text = "試合終了"; });
			textBox_M.BeginInvoke((MethodInvoker)delegate () { textBox_M.Text = "--"; });
			textBox_S.BeginInvoke((MethodInvoker)delegate () { textBox_S.Text = "--"; });
			button5.Enabled = false;
			t.StopTimer();
		}

		//1秒ごとに呼び出される
		public void F1_OnTimerEvent() {

			//試合前
			if (radioButton1.Checked) {
				if (b_s.Value == 1) BeginInvoke((MethodInvoker)delegate () { radioButton2.Checked = true; });

				if (b_s.Value != 0) { 
					b_s.BeginInvoke((MethodInvoker)delegate () { b_s.Value--; });
				}
			}

			//前半試合中
			if (radioButton2.Checked) {

				if (f_s.Value == 1 && f_m.Value == 0) BeginInvoke((MethodInvoker)delegate () { radioButton3.Checked = true; });


				if (f_s.Value == 0) {
					if (f_m.Value != 0) {
						f_m.BeginInvoke((MethodInvoker)delegate () { f_m.Value--; });
						f_s.BeginInvoke((MethodInvoker)delegate () { f_s.Value = 59; });
					}
				} else {
					f_s.BeginInvoke((MethodInvoker)delegate () { f_s.Value--; });
				}
			}

			//ハーフタイム
			if (radioButton3.Checked) {

				if (h_s.Value == 1 && h_m.Value == 0) BeginInvoke((MethodInvoker)delegate () { radioButton4.Checked = true; });

				if (h_s.Value == 0) {
					if (h_m.Value != 0) {
						h_m.BeginInvoke((MethodInvoker)delegate () { h_m.Value--; });
						h_s.BeginInvoke((MethodInvoker)delegate () { h_s.Value = 59; });
					}
				} else {
					h_s.BeginInvoke((MethodInvoker)delegate () { h_s.Value--; });
				}
			}

			//後半
			if (radioButton4.Checked) {

				if (s_s.Value == 1 && s_m.Value == 0) BeginInvoke((MethodInvoker)delegate () { radioButton5.Checked = true; });


				if (s_s.Value == 0) {
					if (s_m.Value != 0) {
						s_m.BeginInvoke((MethodInvoker)delegate () { s_m.Value--; });
						s_s.BeginInvoke((MethodInvoker)delegate () { s_s.Value = 59; });
					}
				} else {
					s_s.BeginInvoke((MethodInvoker)delegate () { s_s.Value--; });
				}
			}

			//表示更新
			if (radioButton1.Checked) {
				textBox_state.BeginInvoke((MethodInvoker)delegate () { textBox_state.Text = "試合開始まで"; });
				textBox_M.BeginInvoke((MethodInvoker)delegate () { textBox_M.Text = "0"; });
				textBox_S.BeginInvoke((MethodInvoker)delegate () { textBox_S.Text = "" + b_s.Value + ""; });
			}
			if (radioButton2.Checked) {
				textBox_state.BeginInvoke((MethodInvoker)delegate () { textBox_state.Text = "前半"; });
				textBox_M.BeginInvoke((MethodInvoker)delegate () { textBox_M.Text = "" + f_m.Value + ""; });
				textBox_S.BeginInvoke((MethodInvoker)delegate () { textBox_S.Text = "" + f_s.Value + ""; });
			}
			if (radioButton3.Checked) {
				textBox_state.BeginInvoke((MethodInvoker)delegate () { textBox_state.Text = "ハーフタイム"; });
				textBox_M.BeginInvoke((MethodInvoker)delegate () { textBox_M.Text = "" + h_m.Value + ""; });
				textBox_S.BeginInvoke((MethodInvoker)delegate () { textBox_S.Text = "" + h_s.Value + ""; });
			}
			if (radioButton4.Checked) {
				textBox_state.BeginInvoke((MethodInvoker)delegate () { textBox_state.Text = "後半"; });
				textBox_M.BeginInvoke((MethodInvoker)delegate () { textBox_M.Text = "" + s_m.Value + ""; });
				textBox_S.BeginInvoke((MethodInvoker)delegate () { textBox_S.Text = "" + s_s.Value + ""; });
			}

			//スコアボードに反映
			if (Scoreboard.Enabled != true) f2.F1_TextChanged();
		}

	}

	//タイマー
	public class RCJ_timer {
		Form1 f1;
		private System.Timers.Timer timer;


		public void NewTimer(Form1 form1) {
			timer = new System.Timers.Timer();
			timer.Enabled = false;
			timer.AutoReset = true;
			timer.Interval = 1000;
			timer.Elapsed += new ElapsedEventHandler(OnTimerEvent);
			f1 = form1;
		}

		public void OnTimerEvent(object source, ElapsedEventArgs e) {
			f1.F1_OnTimerEvent();

		}
		
		public void StartTimer() {
			timer.Start();
		}

		public void StopTimer() {
			timer.Stop();
		}
	}

}

