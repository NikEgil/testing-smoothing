using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tools;
using System.IO;

namespace test
{
	
	public partial class form_main : Form
	{
		public form_main()
		{
			InitializeComponent();
			tc1_tab1.Scroll += tc1_Scroll;  //инициализация бегунков
			tc2_tab1.Scroll += tc2_Scroll;
		}



		//открытие нового файла и добавление точек в массив
		private void импортToolStripMenuItem_Click(object sender, EventArgs e)
		{
			string[] allmas = new string[char.MaxValue];
			if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				StreamReader sr = new StreamReader(openFileDialog1.FileName);
				string allfile = sr.ReadToEnd();
				allmas = allfile.Split('\n', '\t', '\r');
				sr.Close();
			}
			file_work_class.open_file(ref allmas, ref Program.mas, ref Program.n);
			tc2_tab1.Maximum = Program.mas.Length;
			tc2_tab1.Value = tc2_tab1.Maximum;
			plot(Program.mas, 0);
		}

		//перестройка графика
		public void button1_Click(object sender, EventArgs e)
		{
			plot(Program.mas, 0);
			plot(Program.mas_smooth, 1);
		}
		
		//для обновления значиний бегунка
		private void tc1_Scroll(object sender, EventArgs e)
		{
			label1.Text = String.Format("начальное значение: {0}", tc1_tab1.Value);
		}
		private void tc2_Scroll(object sender, EventArgs e)
		{
			label2.Text = String.Format("конечное значение: {0}", tc2_tab1.Value);
		}

		public void генерацияГрафикаToolStripMenuItem_Click(object sender, EventArgs e)
		{
			chart1.Series[1].Points.Clear();
			form_gen fg = new form_gen();
			fg.ShowDialog();
			tc2_tab1.Maximum = Program.mas.Length;
			tc2_tab1.Value = tc2_tab1.Maximum;
			plot(Program.mas, 0);
		}
		//добавление файла к уже массиву
		private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
		{
			string[] allmas = new string[char.MaxValue];
			if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				StreamReader sr = new StreamReader(openFileDialog1.FileName);
				string allfile = sr.ReadToEnd();
				allmas = allfile.Split('\n', '\t', '\r');
				sr.Close();
			}
			file_work_class.expend_file(ref allmas, ref Program.mas, ref Program.n);
			plot(Program.mas, 0);
		}

		public void plot(int[] massive, int type)
		{
			
			tc1_tab1.Maximum = massive.Length;
			tc2_tab1.Maximum = massive.Length;
			tc2_tab1.SendToBack();
			toolStripStatusLabel1.Text = String.Format("количество точек: {0}", massive.Length);
			if (type == 0)
			{
				chart1.Series[0].Points.Clear();
				for (int i = tc1_tab1.Value + 1; i < tc2_tab1.Value; i++)
				{
					if (massive[i] >= 0)
					{
						chart1.Series[0].Points.AddXY(i, massive[i]);
					}
				}
			}
			if (type == 1)
			{
				chart1.Series[1].Points.Clear();
				for (int i = tc1_tab1.Value + 1; i < tc2_tab1.Value; i++)
				{
					if (massive[i] >= 0)
					{
						chart1.Series[1].Points.AddXY(i, massive[i]);
					}
				}
			}
			label1.Text = String.Format("начальное значение: {0}", tc1_tab1.Value);
			label2.Text = String.Format("конечное значение: {0}", tc2_tab1.Value);
		}

		private void tabPage1_Click(object sender, EventArgs e)
		{

		}

		//plot spector
		private void button2_Click(object sender, EventArgs e)
		{
			chart2.Series[0].Points.Clear();
			find_peak.find(Program.mas_smooth, 4, Program.specter);
			//for (int i =Array.IndexOf(Program.specter, Program.specter.Min()); 
			//	i < Array.IndexOf(Program.specter, Program.specter.Max()); i++)
			for (int i = 0; i < 1023; i++) 
			{
				chart2.Series[0].Points.AddXY(i, Program.specter[i]);
			}
		}
		//кнопка "сглаживание"
		private void button1_Click_1(object sender, EventArgs e)
		{
			Array.Resize(ref Program.mas_smooth, Program.mas.Length);
			chart1.Series[1].Points.Clear();
			int window = 8;
			int sum = 0;
			/*for (int i = 5; i < Program.mas.Length-5; i ++) 
			{
				int cur = 0;
				
				for (int k = - 5; k < 5; k++) 
				{
					cur += Program.mas[i+k];
					
				}

				Program.mas_smooth[i] = Convert.ToInt32(cur / 10);
			}*/
			for (int i = 0; i < window; i++)
			{
				sum += Program.mas[i];
			}
			for (int i = window; i < Program.mas.Length; i++)
			{
				sum += Program.mas[i];
				if (i != window)
				{
					sum -= Program.mas[i - window];
				}
				Program.mas_smooth[i] = Convert.ToInt32(sum / window);
			}
			
				for (int i = 0; i < Program.mas_smooth.Length; i++)
				{
					if (Program.mas_smooth[i] >= 0)
					{
						chart1.Series[1].Points.AddXY(i, Program.mas_smooth[i]);
					}
				}
			
		}

		private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
				for (int i = 0; i < Program.mas.Length; i++)
				{
					sw.WriteLine("{0} \t {1}", i + 1, Program.mas[i]);
				}

			}
		}

		private void параметрыФильтровToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{

		}
	}
}
	

