using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class form_filters : Form
    {
        public form_filters()
        {
            InitializeComponent();
            trackBar1.Scroll += trackBar1_Scroll;  //инициализация бегунков
            trackBar2.Scroll += trackBar2_Scroll;
            trackBar3.Scroll += trackBar3_Scroll;
            trackBar4.Scroll += trackBar4_Scroll;

            trackBar1.Value = Program.settings_moving_average_filter[0];
            textBox1.Text = Convert.ToString(Program.settings_moving_average_filter[2]);
            trackBar2.Value = Program.settings_average_filter[0];
            trackBar3.Value = Program.settings_average_filter[1];
            trackBar4.Value = Program.settings_media_filter[0];

            label_mov_ar_period.Text = String.Format("Период: {0}", trackBar1.Value);
            label_aver_period.Text = String.Format("Период: {0}", trackBar2.Value);
            label_aver_out.Text = String.Format("Минимальное отклонение \n выброса от среднего: {0}", trackBar3.Value);
            label_medial_period.Text = String.Format("Период: {0}", trackBar4.Value);

            if (Program.from_filter[0] == 1)
            {
                radioButton1.Checked = true;
                tabControl1.SelectTab(0);
            }
            if (Program.from_filter[0] == 2)
            {
                radioButton2.Checked = true;
                tabControl1.SelectTab(1);
            }
            if (Program.from_filter[0] == 3)
            {
                radioButton3.Checked = true;
                tabControl1.SelectTab(2);
            }
            if (Program.from_filter[1] == 1)
            { checkBox1.Checked = true;}
            if (Program.settings_moving_average_filter[1] == 0)
            { radioButton4.Checked = true; }
            if (Program.settings_moving_average_filter[1] == 1)
            { radioButton5.Checked = true;}
            if (Program.settings_moving_average_filter[1] == 2)
            { radioButton6.Checked = true; }
            if (Program.settings_moving_average_filter[3] == 1)
            { checkBox2.Checked = true; }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label_mov_ar_period.Text = String.Format("Период: {0}", trackBar1.Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked == true)
            { Program.from_filter[0] = 1; }
            if (radioButton2.Checked == true)
            { Program.from_filter[0] = 2; }
            if (radioButton3.Checked == true)
            { Program.from_filter[0] = 3; }

            if(checkBox1.Checked == true)
            { Program.from_filter[1] = 1; }
            else
            { Program.from_filter[1] = 0; }

            if(checkBox2.Checked == true)
            { Program.settings_moving_average_filter[2] = (2 / (Program.settings_moving_average_filter[0] - 1)); }

            Program.settings_moving_average_filter[0] = trackBar1.Value;
            if (radioButton4.Checked == true)
            { Program.settings_moving_average_filter[1] = 0; }
            if (radioButton5.Checked == true)
            { Program.settings_moving_average_filter[1] = 1; }
            if (radioButton6.Checked == true)
            { Program.settings_moving_average_filter[1] = 2; }
            Program.settings_moving_average_filter[2] = Convert.ToInt32(textBox1.Text);
            if(checkBox2.Checked ==true)
            { Program.settings_moving_average_filter[3] = 1; }
            else
            { Program.settings_moving_average_filter[3] = 0; }

            Program.settings_average_filter[0] = trackBar2.Value;
            Program.settings_average_filter[1] = trackBar3.Value;

            Program.settings_media_filter[0] = trackBar4.Value;

            this.Close();
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            label_aver_period.Text = String.Format("Период: {0}", trackBar2.Value);
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            label_aver_out.Text = String.Format("Минимальное отклонение \n выброса от среднего: {0}", trackBar3.Value);
        }

        private void trackBar4_Scroll(object sender, EventArgs e)
        {
            label_medial_period.Text = String.Format("Период: {0}", trackBar4.Value);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            tabControl1.SelectTab(0);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            tabControl1.SelectTab(1);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            tabControl1.SelectTab(2);
        }

        private void label_mov_ar_period_Click(object sender, EventArgs e)
        {

        }
    }
}
