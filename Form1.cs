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
	public partial class Form1 : Form {
		Form2 f2;
		public Form1() {
			InitializeComponent();
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
			if(Scoreboard.Enabled!=true) f2.F1_TextChanged();
		}
		
		private void ValueChanged(object sender, EventArgs e) {
			int a = (int)numericUpDown1.Value + (int)numericUpDown2.Value;
			int b = (int)numericUpDown3.Value + (int)numericUpDown4.Value;
			textBox3.Text = "" + a + "";
			textBox4.Text = "" + b + "";
			if (Scoreboard.Enabled != true) f2.F1_TextChanged();
		}
	}

}

