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

		private void button3_Click(object sender, EventArgs e) {
			button3.Enabled = false;
			button5.Enabled = true;
			button3.Text = "再開";
			t.StartTimer();
		}

		private void button5_Click(object sender, EventArgs e) {
			button3.Enabled = true;
			button5.Enabled = false;
			t.StopTimer();
		}

	/*	public void F1_OnTimerEvent() {
			f_s.Value = 12;
		}*/
	}

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
			

		}
		
		public void StartTimer() {
			timer.Start();
		}

		public void StopTimer() {
			timer.Stop();
		}
	}

}

