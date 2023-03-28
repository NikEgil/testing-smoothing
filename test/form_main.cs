using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Tools;

namespace test
{

	public partial class form_main : Form
	{
		public form_main()
		{
			InitializeComponent();
			trackbar_start_point.Scroll += trackbar_start_point_Scroll;  //инициализация трекбаров
			trackbar_finish_point.Scroll += trackbar_finish_point_Scroll;
			dataGridView1.Rows.Add(29);     //добавление строк в таблицу теста
			checkBox1.Checked = true;      //установка отображения пиков
		}

		//открытие нового файла и добавление точек в массив
		private void import_file_stripmenu_Click(object sender, EventArgs e)
		{
			string[] allmas = new string[char.MaxValue];//строка для импорта из файла
			//функция импорта с учетом разделительных символов
			if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				StreamReader sr = new StreamReader(openFileDialog1.FileName);
				string allfile = sr.ReadToEnd();
				allmas = allfile.Split('\n', '\t', '\r');
				sr.Close();
			}
			//функция перемещения данных из строки в массив
			file_work_class.open_file(ref allmas, ref Program.mas);
			//измение максимальных значений трекбаров
			trackbar_finish_point.Maximum = Program.mas.Length;
			trackbar_start_point.Maximum = Program.mas.Length;
			//ограничение отображаемого графика
			if (Program.mas.Length > 5000)
			{ trackbar_finish_point.Value = 5000; }
			else
			{ trackbar_finish_point.Value = Program.mas.Length; }
			//очистка графиков и построение
			chart1.Series[0].Points.Clear();
			chart1.Series[1].Points.Clear();
			chart1.Series[2].Points.Clear();
			plot(Program.mas, 0);
		}

		//добавление файла к уже массиву
		private void add_file_stripmenu_Click(object sender, EventArgs e)
		{
			string[] allmas = new string[char.MaxValue];//строка для импорта из файла
														//функция импорта с учетом разделительных символов
			if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				StreamReader sr = new StreamReader(openFileDialog1.FileName);
				string allfile = sr.ReadToEnd();
				allmas = allfile.Split('\n', '\t', '\r');
				sr.Close();
			}
			//функция перемещения данных из строки в массив
			file_work_class.add_file(ref allmas, ref Program.mas);
			//измение максимальных значений трекбаров
			trackbar_finish_point.Maximum = Program.mas.Length;
			trackbar_start_point.Maximum = Program.mas.Length;
			//ограничение отображаемого графика
			if (Program.mas.Length > 5000)
			{ trackbar_finish_point.Value = 5000; }
			else
			{ trackbar_finish_point.Value = Program.mas.Length; }
			//очистка графиков и построение
			chart1.Series[0].Points.Clear();
			chart1.Series[1].Points.Clear();
			chart1.Series[2].Points.Clear();
			plot(Program.mas, 0);
		}

		//сохранение массива в файл
		private void save_file_stripmenu_Click(object sender, EventArgs e)
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

		//перестройка графика
		public void button_replot_Click(object sender, EventArgs e)
		{
			//выбор вкладки с графиками
			tabControl1.SelectTab(0);
			plot(Program.mas, 0);
			if (Program.mas_smooth != null)
			{ plot(Program.mas_smooth, 1); }
			if (Program.mas_peaks != null)
			{ plot(Program.mas_peaks, 2); }
		}
	
		//для обновления значиний трекбаров
		private void trackbar_start_point_Scroll(object sender, EventArgs e)
		{
			label_start_point.Text = String.Format("Начальное значение: {0}", trackbar_start_point.Value);
		}
		private void trackbar_finish_point_Scroll(object sender, EventArgs e)
		{
			label_finish_point.Text = String.Format("Конечное значение: {0}", trackbar_finish_point.Value);
		}

		//открытие меню генератора графика
		public void generation_stripmenu_Click(object sender, EventArgs e)
		{
			tabControl1.SelectTab(0);       //выбор вкладки с графиками
			form_gen fg = new form_gen();   //вызов формы генератора
			fg.ShowDialog();
			//измение максимальных значений трекбаров
			trackbar_start_point.Value = 0;
			trackbar_finish_point.Maximum = Program.mas.Length;
			trackbar_start_point.Maximum = Program.mas.Length;
			//ограничение отображаемого графика
			if (Program.mas.Length > 5000)
			{ trackbar_finish_point.Value = 5000; }
			else
			{ trackbar_finish_point.Value = Program.mas.Length; }
			//очистка массивов сглаживания и пиков
			if (Program.mas_smooth != null)
			{ Array.Clear(Program.mas_smooth, 0, Program.mas_smooth.Length); }
			if (Program.mas_peaks != null)
			{ Array.Clear(Program.mas_peaks, 0, Program.mas_peaks.Length); }
			//очистка поля для графиков и построение нового
			chart1.Series[0].Points.Clear();
			chart1.Series[1].Points.Clear();
			chart1.Series[2].Points.Clear();
			plot(Program.mas, 0);
			textBox1.Text = Convert.ToString(Program.numbers_peaks);//обновление данных в боксе количества пиков
		}
		
		//функция постройки графика(массив, номер слоя)
		public void plot(int[] massive, int type)
		{
			toolStripStatusLabel1.Text = String.Format("Количество точек: {0}", massive.Length);
			chart1.Series[type].Points.Clear();
			for (int i = trackbar_start_point.Value + 1; i < trackbar_finish_point.Value; i++)
			{
				if (type == 2)
				{
					if (massive[i] > 0)
					{
						chart1.Series[type].Points.AddXY(i, massive[i]);
					}
				}
				else
				{
					chart1.Series[type].Points.AddXY(i, massive[i]);
				}
			}
			label_start_point.Text = String.Format("Начальное значение: {0}", trackbar_start_point.Value);
			label_finish_point.Text = String.Format("Конечное значение: {0}", trackbar_finish_point.Value);
		}

		//кнопка построения спектра
		private void button_plot_spector_Click(object sender, EventArgs e)
		{
			chart1.Series[2].Points.Clear();//очистка точек пиков
			chart2.Series[0].Points.Clear();//очистка графика спектра
			//изменение размера и очистка массива с точками пиков
			Array.Resize(ref Program.mas_peaks, Program.mas_smooth.Length);
			Array.Clear(Program.mas_peaks, 0, Program.mas_peaks.Length);
			//поиск пиков
			find_peak.find(Program.mas_smooth, Program.mas_peaks, Convert.ToInt32(domainUpDown1.Text), Program.specter);
			//построение спектра
			for (int i = 0; i < 1023; i++) 
			{
				chart2.Series[0].Points.AddXY(i, Program.specter[i]);
			}
			//построение точек пиков
			if (checkBox1.Checked == true)
			{
				plot(Program.mas_peaks, 2);
			}
			//обновление данных о количестве пиков
			textBox1.Text = Convert.ToString(Program.numbers_peaks);
		}

		//кнопка сглаживания
		private void button_smooth_Click(object sender, EventArgs e)
		{
			tabControl1.SelectTab(0);	//выбор вкладки с графиками
			Array.Resize(ref Program.mas_smooth, Program.mas.Length);//изменение сглаженного массива
			chart1.Series[1].Points.Clear();//очистка сглаженного графика и пиков
			chart1.Series[2].Points.Clear();
			//простое СС
			if (Program.from_filter[0] == 1 && Program.settings_moving_average_filter[1] == 0)
			{
				Smoothing.moving_areas_simple(Program.mas, Program.mas_smooth, Program.settings_moving_average_filter[0], Program.from_filter[1]);
			}
			//взвешенное СС
			if (Program.from_filter[0] == 1 && Program.settings_moving_average_filter[1] == 1)
			{
				Smoothing.moving_areas_weighted(Program.mas, Program.mas_smooth, Program.settings_moving_average_filter[0], Program.from_filter[1]);
			}
			//экпоненциальное СС
			if (Program.from_filter[0] == 1 && Program.settings_moving_average_filter[1] == 2)
			{ 
				Smoothing.moving_areas_exp(Program.mas, Program.mas_smooth, Program.settings_moving_average_filter[0], Program.settings_moving_average_filter[2], Program.settings_moving_average_filter[3], Program.from_filter[1]);
			}
			//усредняющий фильтр
			if (Program.from_filter[0] == 2)
			{
				Smoothing.average_filter(Program.mas, Program.mas_smooth, Program.settings_average_filter[0], Program.settings_average_filter[1], Program.from_filter[1]);
			}
			//медианный фильтр
			if (Program.from_filter[0] == 3)
			{
				Smoothing.medial_filter(Program.mas, Program.mas_smooth, Program.settings_media_filter[0], Program.from_filter[1]);
			}
			plot(Program.mas_smooth, 1);    //построение сглаженного массива
		}

		//кнопка открытие формы с параметрами фильтров
		private void filter_stripmenu_Click(object sender, EventArgs e)
		{
			form_filters ff = new form_filters();
			ff.ShowDialog();
		}

		//кнопка построения простого графика
		private void button_graph_Click(object sender, EventArgs e)
		{
			Program.mas = new int[190];
			NormalRandom nrnd = new NormalRandom();
			double a = 0;
			double b;
			for (int i = 0; i < 10; i++)
			{
				Program.mas[i] = 20;
			}
			for (int i = 10; i < 20; i++)
			{
				Program.mas[i] = 2 * (i);
			}
			for (int i = 20; i < 30; i++)
			{
				Program.mas[i] = 40 - 2 * (i - 20);
			}
			for (int i = 30; i < 100; i++)
			{
				b = Math.Sin(Math.PI * a / 180);
				Program.mas[i] = 20 + Convert.ToInt32(20 * b);
				a += 5;
			}
			for (int i = 100; i < 120; i++)
			{
				Program.mas[i] = 20 + nrnd.Next(3);
			}
			for (int i = 120; i < 130; i++)
			{
				Program.mas[i] = 21;
			}
			for (int i = 130; i < 150; i++)
			{
				Program.mas[i] = 20 + nrnd.Next(5);
			}
			for (int i = 150; i < 160; i++)
			{
				Program.mas[i] = 23;
			}
			for (int i = 160; i < 180; i++)
			{
				Program.mas[i] = 20 + nrnd.Next(9);
			}
			for (int i = 180; i < 190; i++)
			{
				Program.mas[i] = 25;
			}
			trackbar_finish_point.Maximum = Program.mas.Length;
			trackbar_finish_point.Value = trackbar_finish_point.Maximum;
			plot(Program.mas, 0);
		}

		//кнопка добавления шума на график
		private void button_noise_Click(object sender, EventArgs e)
		{
			//вызов функции шума
			generating_class.noise(Program.mas);
			//очистка поля для графиков и построение нового
			chart1.Series[0].Points.Clear();
			chart1.Series[1].Points.Clear();
			chart1.Series[2].Points.Clear();
			plot(Program.mas, 0);
		}

		//кпопка копирования
		private void button_copy_Click(object sender, EventArgs e)
		{
			chart1.Series[1].Points.Clear();
			chart1.Series[2].Points.Clear();
			chart2.Series[0].Points.Clear();
			Array.Copy(Program.mas_smooth, Program.mas, Program.mas_smooth.Length);
			plot(Program.mas, 0);
		}

		//выбор предфильтров
		private void medial_filter_check_Click(object sender, EventArgs e)
		{
			test_stripmenu.ShowDropDown();
		}

		private void aver_filter_check_Click(object sender, EventArgs e)
		{
			test_stripmenu.ShowDropDown();
		}

		//тестирование простого СС
		private void simple_ma_stripmenu_Click(object sender, EventArgs e)
		{
			Array.Resize(ref Program.mas_smooth, Program.mas.Length);
			//проверка экспоненциальным фильтром, для сравнения методов
			if (checkBox2.Checked == false)
			{
				Smoothing.moving_areas_exp(Program.mas, Program.mas_smooth, 30, 5, 0, 0);
				int t = find_peak.find_fast(Program.mas_smooth, 10);
				if (Program.numbers_peaks > t)
				{
					Program.numbers_peaks = t;
					textBox1.Text = Convert.ToString(t);
				}
			}
			else { Program.numbers_peaks = Convert.ToInt32(textBox1.Text); }
			tabControl1.SelectTab(2); //выбор вкладки с таблицей теста
			int[] test = new int[Program.mas.Length]; //масив для работы
			//фильтрация предфильтрами
			if (aver_filter_check.Checked == true)
			{
				Smoothing.average_filter(Program.mas, test, Program.settings_average_filter[0], Program.settings_average_filter[1], Program.from_filter[1]);
			}
			if (medial_filter_check.Checked == true)
			{
				Smoothing.medial_filter(Program.mas, test, Program.settings_media_filter[0], Program.from_filter[1]);
			}
			else
			{
				Array.Copy(Program.mas, test, Program.mas.Length);
			}
			
			double result; //переменная с результатом теста
			double num = Convert.ToDouble( Program.numbers_peaks); //значение для сравнения
			
			for (int window_MA = 2; window_MA < 31; window_MA++)
			{
				//сглаживание рабочего массива
				Smoothing.moving_areas_simple(test, Program.mas_smooth, window_MA, Program.from_filter[1]);
				//заполнение перого столбца значением окна фильтра
				dataGridView1.Rows[window_MA-2].Cells[0].Value = window_MA;
				//цикл заполнения строк результатами теста
				for (int window_find = 1; window_find <= 10; window_find++)
				{
					result = find_peak.find_fast(Program.mas_smooth, window_find);	//поиск количества пиков
					dataGridView1.Rows[window_MA - 2].Cells[window_find].Value = result; //запись значения
					//настройка цветов заливки 
					int red = Math.Abs(Convert.ToInt32( (num - result)*100));
					int green = Math.Abs(Convert.ToInt32((num / result) * 100));
					if(red>100)
					{ red = 100; }
					if(green>100)
					{ green = 100; }
					dataGridView1.Rows[window_MA - 2].Cells[window_find].Style.BackColor = Color.FromArgb(Convert.ToInt32(red*2), Convert.ToInt32(green *2.55),0);
				}
			}
		}

		private void weigh_ma_stripmenu_Click(object sender, EventArgs e)
		{
			Array.Resize(ref Program.mas_smooth, Program.mas.Length);
			//проверка экспоненциальным фильтром, для сравнения методов
			if (checkBox2.Checked == false)
			{
				Smoothing.moving_areas_exp(Program.mas, Program.mas_smooth, 30, 5, 0, 0);
				int t = find_peak.find_fast(Program.mas_smooth, 10);
				if (Program.numbers_peaks > t)
				{
					Program.numbers_peaks = t;
					textBox1.Text = Convert.ToString(t);
				}
			}
			else { Program.numbers_peaks = Convert.ToInt32(textBox1.Text); }
			tabControl1.SelectTab(2); //выбор вкладки с таблицей теста
			int[] test = new int[Program.mas.Length]; //масив для работы
			//фильтрация предфильтрами
			if (aver_filter_check.Checked == true)
			{
				Smoothing.average_filter(Program.mas, test, Program.settings_average_filter[0], Program.settings_average_filter[1], Program.from_filter[1]);
			}
			if (medial_filter_check.Checked == true)
			{
				Smoothing.medial_filter(Program.mas, test, Program.settings_media_filter[0], Program.from_filter[1]);
			}
			else
			{
				Array.Copy(Program.mas, test, Program.mas.Length);
			}

			double result; //переменная с результатом теста
			double num = Convert.ToDouble(Program.numbers_peaks); //значение для сравнения
			for (int window_MA = 2; window_MA < 31; window_MA++)
			{
				//сглаживание рабочего массива
				Smoothing.moving_areas_weighted(test, Program.mas_smooth, window_MA, Program.from_filter[1]);
				//заполнение перого столбца значением окна фильтра
				dataGridView1.Rows[window_MA - 2].Cells[0].Value = window_MA;
				//цикл заполнения строк результатами теста
				for (int window_find = 1; window_find <= 10; window_find++)
				{
					result = find_peak.find_fast(Program.mas_smooth, window_find);  //поиск количества пиков
					dataGridView1.Rows[window_MA - 2].Cells[window_find].Value = result; //запись значения
					//настройка цветов заливки 
					int red = Math.Abs(Convert.ToInt32((num - result) * 100));
					int green = Math.Abs(Convert.ToInt32((num / result) * 100));
					if (red > 100)
					{ red = 100; }
					if (green > 100)
					{ green = 100; }
					dataGridView1.Rows[window_MA - 2].Cells[window_find].Style.BackColor = Color.FromArgb(Convert.ToInt32(red * 2), Convert.ToInt32(green * 2.55), 0);
				}
			}
		}

		private void exp_ma_stripmenu_Click(object sender, EventArgs e)
		{
			Array.Resize(ref Program.mas_smooth, Program.mas.Length);
			//проверка экспоненциальным фильтром, для сравнения методов
			if (checkBox2.Checked == false)
			{
				Smoothing.moving_areas_exp(Program.mas, Program.mas_smooth, 30, 5, 0, 0);
				int t = find_peak.find_fast(Program.mas_smooth, 10);
				if (Program.numbers_peaks > t)
				{
					Program.numbers_peaks = t;
					textBox1.Text = Convert.ToString(t);
				}
			}
			else { Program.numbers_peaks = Convert.ToInt32(textBox1.Text); }
			tabControl1.SelectTab(2); //выбор вкладки с таблицей теста
			int[] test = new int[Program.mas.Length]; //масив для работы
			//фильтрация предфильтрами
			if (aver_filter_check.Checked == true)
			{
				Smoothing.average_filter(Program.mas, test, Program.settings_average_filter[0], Program.settings_average_filter[1], Program.from_filter[1]);
			}
			if (medial_filter_check.Checked == true)
			{
				Smoothing.medial_filter(Program.mas, test, Program.settings_media_filter[0], Program.from_filter[1]);
			}
			else
			{
				Array.Copy(Program.mas, test, Program.mas.Length);
			}

			double result; //переменная с результатом теста
			double num = Convert.ToDouble(Program.numbers_peaks); //значение для сравнения
			for (int window_MA = 2; window_MA < 31; window_MA++)
			{
				//сглаживание рабочего массива
				Smoothing.moving_areas_exp(test, Program.mas_smooth, window_MA,Program.settings_moving_average_filter[2], Program.settings_moving_average_filter[3], Program.from_filter[1]);
				//заполнение перого столбца значением окна фильтра
				dataGridView1.Rows[window_MA - 2].Cells[0].Value = window_MA;
				//цикл заполнения строк результатами теста
				for (int window_find = 1; window_find <= 10; window_find++)
				{
					result = find_peak.find_fast(Program.mas_smooth, window_find);  //поиск количества пиков
					dataGridView1.Rows[window_MA - 2].Cells[window_find].Value = result; //запись значения
					//настройка цветов заливки 
					int red = Math.Abs(Convert.ToInt32((num - result) * 100));
					int green = Math.Abs(Convert.ToInt32((num / result) * 100));
					if (red > 100)
					{ red = 100; }
					if (green > 100)
					{ green = 100; }
					dataGridView1.Rows[window_MA - 2].Cells[window_find].Style.BackColor = Color.FromArgb(Convert.ToInt32(red * 2), Convert.ToInt32(green * 2.55), 0);
				}
			}
		}

		
	}
}
	

