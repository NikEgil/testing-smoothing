using System;
using System.Windows.Forms;
using Tools;

namespace test
{
    public partial class form_gen : Form
    {


        public form_gen()
        {
            InitializeComponent();
            //активация и установка значений трекбаров
            trackBar1.Scroll += trackBar1_Scroll;
            trackBar2.Scroll += trackBar2_Scroll;
            trackBar1.Value = Program.form_generator[2];
            trackBar2.Value = Program.form_generator[3];
            //
            label4.Text = String.Format("Количество тысяч точек : {0}", trackBar2.Value);
            label2.Text = String.Format("Время между имульсами \nнаносекунд : {0}", trackBar1.Value);

            Program.numbers_peaks = 0; //сброс числа пиков
            //перенос параметров из массива настроек
            UD_Q_min.Text = Convert.ToString(Program.form_generator[0]);
            UD_Q_max.Text = Convert.ToString(Program.form_generator[1]);
            if (Program.form_generator[4] == 1) 
            {
                checkBox1.Checked = true;
            }
        
        }
        //генерировать сглаженный
        public void button1_Click(object sender, EventArgs e)
        {
            //очистка массивов пиков и сглаженного
            if (Program.mas_peaks != null)
            { Array.Clear(Program.mas_peaks, 0, Program.mas_peaks.Length); }
            if (Program.mas_smooth != null)
            { Array.Clear(Program.mas_smooth, 0, Program.mas_smooth.Length); }

            //перенос параметров из формы в массив настроек
            Program.form_generator[0] = Convert.ToInt32(UD_Q_min.Text);
            Program.form_generator[1] = Convert.ToInt32(UD_Q_max.Text);
            Program.form_generator[2] = trackBar1.Value;
            Program.form_generator[3] = trackBar2.Value;

            //вызов генератора
            Program.DataGenerator dgen = new Program.DataGenerator();
            //задание длинны основного массива
            Array.Resize(ref Program.mas, Program.form_generator[3] * 1000);
            //заполение массива
            for (int i = 0; i < Program.mas.Length; i++)
            {
                Program.mas[i] = Convert.ToInt32(10 * dgen.Tick());
            }
            //удаление нулей
            if (checkBox1.Checked == true)
            {
                Program.form_generator[4] = 1;
                Smoothing.cut_null(ref Program.mas);
            }
            else
            { Program.form_generator[4] = 0; }
            this.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //очистка массивов пиков и сглаженного
            if (Program.mas_peaks != null)
            { Array.Clear(Program.mas_peaks, 0, Program.mas_peaks.Length); }
            if (Program.mas_smooth != null)
            { Array.Clear(Program.mas_smooth, 0, Program.mas_smooth.Length); }
            //перенос параметров из формы в массив настроек
            Program.form_generator[0] = Convert.ToInt32(UD_Q_min.Text);
            Program.form_generator[1] = Convert.ToInt32(UD_Q_max.Text);
            Program.form_generator[2] = trackBar1.Value;
            Program.form_generator[3] = trackBar2.Value;

            //вызов генератора
            Program.DataGenerator dgen = new Program.DataGenerator();
            //задание длинны основного массива
            Array.Resize(ref Program.mas, Program.form_generator[3] * 1000);
            //заполение массива
            for (int i = 0; i < Program.mas.Length; i++)
            {
                Program.mas[i] = Convert.ToInt32(10 * dgen.Tick());
            }
            //удаление нулей
            if (checkBox1.Checked == true)
            {
                Program.form_generator[4] = 1;
                Smoothing.cut_null(ref Program.mas);
            }
            else
            { Program.form_generator[4] = 0; }
            //добавление шума
            generating_class.noise(Program.mas);
            this.Close();
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            //обновление данных в label
            label4.Text = String.Format("Количество тысяч точек : {0}", trackBar2.Value);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            //обновление данных в label
            label2.Text = String.Format("Время между имульсами \nнаносекунд : {0}", trackBar1.Value);
        }
    }
}
//object sender, EventArgs e  ref int[] mas, ref int n