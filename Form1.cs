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

namespace Kalkulator
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			
			InitializeComponent();
			
		}
		double result, firstNumber, secondNumber;

		private void b_0_Click(object sender, EventArgs e)
		{
			if (radioButton_l1.Checked) textBox_l1.Text += "0";
			else if (radioButton_l2.Checked) textBox_l2.Text += "0";
		}

		private void b_1_Click(object sender, EventArgs e)
		{
			if (radioButton_l1.Checked) textBox_l1.Text += "1";
			else if (radioButton_l2.Checked) textBox_l2.Text += "1";
		}

		private void b_2_Click(object sender, EventArgs e)
		{
			if (radioButton_l1.Checked) textBox_l1.Text += "2";
			else if (radioButton_l2.Checked) textBox_l2.Text += "2";
		}

		private void b_3_Click(object sender, EventArgs e)
		{
			if (radioButton_l1.Checked) textBox_l1.Text += "3";
			else if (radioButton_l2.Checked) textBox_l2.Text += "3";
		}

		private void b_4_Click(object sender, EventArgs e)
		{
			if (radioButton_l1.Checked) textBox_l1.Text += "4";
			else if (radioButton_l2.Checked) textBox_l2.Text += "4";
		}

		private void b_5_Click(object sender, EventArgs e)
		{
			if (radioButton_l1.Checked) textBox_l1.Text += "5";
			else if (radioButton_l2.Checked) textBox_l2.Text += "5";
		}

		private void b_6_Click(object sender, EventArgs e)
		{
			if (radioButton_l1.Checked) textBox_l1.Text += "6";
			else if (radioButton_l2.Checked) textBox_l2.Text += "6";
		}

		private void b_7_Click(object sender, EventArgs e)
		{
			if (radioButton_l1.Checked) textBox_l1.Text += "7";
			else if (radioButton_l2.Checked) textBox_l2.Text += "7";
		}

		private void b_8_Click(object sender, EventArgs e)
		{
			if (radioButton_l1.Checked) textBox_l1.Text += "8";
			else if (radioButton_l2.Checked) textBox_l2.Text += "8";
		}

		private void b_9_Click(object sender, EventArgs e)
		{
			if (radioButton_l1.Checked) textBox_l1.Text += "9";
			else if (radioButton_l2.Checked) textBox_l2.Text += "9";
		}

		private void b_mod_Click(object sender, EventArgs e)
		{

			radioButton_mod.Checked = true;
		}

		private void b_div_Click(object sender, EventArgs e)
		{
			radioButton_div.Checked = true;
		}

		private void b_mul_Click(object sender, EventArgs e)
		{
			radioButton_mul.Checked = true;
		}

		private void b_sub_Click(object sender, EventArgs e)
		{
			radioButton_sub.Checked = true;
		}

		private void b_add_Click(object sender, EventArgs e)
		{
			radioButton_add.Checked = true;
		}

		private void b_sin_Click(object sender, EventArgs e)
		{
			radioButton_sin.Checked = true;
		}

		private void b_cos_Click(object sender, EventArgs e)
		{
			radioButton_cos.Checked = true;
		}

		private void b_sqrt_Click(object sender, EventArgs e)
		{
			radioButton_sqrt.Checked = true;
		}

		private void b_sqr_Click(object sender, EventArgs e)
		{
			radioButton_sqr.Checked = true;
		}

		private void b_dot_Click(object sender, EventArgs e)
		{
			if (radioButton_l1.Checked) textBox_l1.Text += ",";
			else if (radioButton_l2.Checked) textBox_l2.Text += ",";
		}

			int time;
			private void timer1_Tick(object sender, EventArgs e)
			{
			
			time++;
			toolStripStatusLabel1.Text = ("Czas działania programu: " + time + " sekund");

		}



		private void setDefault_ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			textBox_l1.Text = null;
			textBox_l2.Text = null;
			textBox_result.Text = null;
			radioButton_add.Checked = true;
			radioButton_l1.Checked = true;
			listView1.Items.Clear();
		}

		private void quit_ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}



		private void b_clear_Click(object sender, EventArgs e)
		{
			listView1.Items.Clear();
		}

		private void b_ent_Click(object sender, EventArgs e)
		{
			if (String.IsNullOrEmpty(textBox_l1.Text)) firstNumber = 0;
			else firstNumber = Convert.ToDouble(textBox_l1.Text);
			if (String.IsNullOrEmpty(textBox_l2.Text)) secondNumber = 0;
			else secondNumber = Convert.ToDouble(textBox_l2.Text);


			if (radioButton_add.Checked)
			{
					

				result = firstNumber + secondNumber;		
				listView1.Items.Add(new ListViewItem(new[] {  firstNumber + "+" + secondNumber + "=" + result}));
			}
			if (radioButton_sub.Checked)
			{
				
				result = firstNumber - secondNumber;
				listView1.Items.Add(new ListViewItem(new[] { firstNumber + "-" + secondNumber + "=" + result }));
			}
			if (radioButton_mul.Checked)
			{
				
				result = firstNumber * secondNumber;
				listView1.Items.Add(new ListViewItem(new[] { firstNumber + "*" + secondNumber + "=" + result }));

			}
			if (radioButton_div.Checked)
			{
				if (secondNumber == 0)
				{
					listView1.Items.Add(new ListViewItem(new[] { firstNumber + "/" + secondNumber + "=" + " BŁĄD, nie można dzielić przez 0" }));
				}
				else
				{
					result = firstNumber / secondNumber;
					listView1.Items.Add(new ListViewItem(new[] { firstNumber + "/" + secondNumber + "=" + result }));
				}

			}
			
			if (radioButton_mod.Checked)
			{

				result = firstNumber % secondNumber;
				listView1.Items.Add(new ListViewItem(new[] { firstNumber + "%" + secondNumber + "=" + result }));


			}
			if (radioButton_sqr.Checked)
			{

				if (radioButton_l1.Checked)
				{
					result = firstNumber * firstNumber;
					listView1.Items.Add(new ListViewItem(new[] { firstNumber +"^2"+  "=" + result }));
				}
				else if (radioButton_l2.Checked)
				{
					result = secondNumber * secondNumber;
					listView1.Items.Add(new ListViewItem(new[] { secondNumber + "^2" + "=" + result }));
				}


			}
			if (radioButton_sqrt.Checked)
			{
				if (radioButton_l1.Checked)
				{
					result = Math.Sqrt(firstNumber);
					listView1.Items.Add(new ListViewItem(new[] { "sqrt(" + firstNumber + ")" + "=" + result }));

				}
				else if (radioButton_l2.Checked)
				{
					result = Math.Sqrt(secondNumber);
					listView1.Items.Add(new ListViewItem(new[] { "sqrt(" + secondNumber + ")" + "=" + result }));
				}
				

			}
			if (radioButton_cos.Checked)
			{
				if (radioButton_l1.Checked)
				{
					result = Math.Cos(firstNumber);
					listView1.Items.Add(new ListViewItem(new[] { "cos(" + firstNumber + ")" + "=" + result }));
				}
				else if (radioButton_l2.Checked)
				{
					result = Math.Cos(secondNumber);
					listView1.Items.Add(new ListViewItem(new[] { "cos(" + secondNumber + ")" + "=" + result }));
				}



				}
			if (radioButton_sin.Checked)
			{
				if (radioButton_l1.Checked)
				{
					result = Math.Sin(firstNumber);
					listView1.Items.Add(new ListViewItem(new[] { "sin(" + firstNumber + ")" + "=" + result }));
				}
				else if(radioButton_l2.Checked)
				{
					result = Math.Sin(secondNumber);
					listView1.Items.Add(new ListViewItem(new[] { "sin(" + secondNumber + ")" + "=" + result }));
				}


			}
			if (radioButton_div.Checked && secondNumber == 0)
			{
				textBox_result.Text = "BŁĄD";
			}
			else
			{
				textBox_result.Text = Convert.ToString(result);
			}
		}

		
		
	}
}
