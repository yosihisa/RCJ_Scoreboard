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
		//Form2 f2;
		public Form1() {
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e) {
			Scoreboard.Enabled = false;
			Form2 f2 = new Form2(this); // 子フォームの生成
			f2.Text = "ロボカップ　得点板";
			f2.Show(); // 子フォームの表示
		}

		//form2が閉じられた
		public void f2_Closed() {
			Scoreboard.Enabled = true;
		}

		private void Form1_Load(object sender, EventArgs e) {

		}
	}
}
