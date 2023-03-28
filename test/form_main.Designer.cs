namespace test
{
	partial class form_main
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_main));
            this.button_replot = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.trackbar_start_point = new System.Windows.Forms.TrackBar();
            this.trackbar_finish_point = new System.Windows.Forms.TrackBar();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label_start_point = new System.Windows.Forms.Label();
            this.label_finish_point = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.win_fil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.find1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.find2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.find3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.find4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.find5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.find6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.find7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.find8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.find9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.find10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_plot_spector = new System.Windows.Forms.Button();
            this.button_smooth = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.domainUpDown1 = new System.Windows.Forms.DomainUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.button_noise = new System.Windows.Forms.Button();
            this.button_copy = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.file_stripmenu = new System.Windows.Forms.ToolStripMenuItem();
            this.import_stripmenu = new System.Windows.Forms.ToolStripMenuItem();
            this.add_file_stripmenu = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьГрафикВФайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generation_stripmenu = new System.Windows.Forms.ToolStripMenuItem();
            this.filter_stripmenu = new System.Windows.Forms.ToolStripMenuItem();
            this.test_stripmenu = new System.Windows.Forms.ToolStripMenuItem();
            this.simple_ma_stripmenu = new System.Windows.Forms.ToolStripMenuItem();
            this.weigh_ma_stripmenu = new System.Windows.Forms.ToolStripMenuItem();
            this.exp_ma_stripmenu = new System.Windows.Forms.ToolStripMenuItem();
            this.aver_filter_check = new System.Windows.Forms.ToolStripMenuItem();
            this.medial_filter_check = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.button_graph = new System.Windows.Forms.Button();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackbar_start_point)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackbar_finish_point)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_replot
            // 
            this.button_replot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_replot.Location = new System.Drawing.Point(765, 123);
            this.button_replot.Name = "button_replot";
            this.button_replot.Size = new System.Drawing.Size(147, 26);
            this.button_replot.TabIndex = 1;
            this.button_replot.Text = "Построить";
            this.button_replot.UseVisualStyleBackColor = true;
            this.button_replot.Click += new System.EventHandler(this.button_replot_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 460);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(924, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(111, 17);
            this.toolStripStatusLabel1.Text = "количество точек: ";
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.AxisX.Title = "Количество точек";
            chartArea1.AxisY.Title = "Номер канала";
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(-28, -9);
            this.chart1.Margin = new System.Windows.Forms.Padding(0);
            this.chart1.Name = "chart1";
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastPoint;
            series1.Color = System.Drawing.Color.Blue;
            series1.IsVisibleInLegend = false;
            series1.Name = "Series1";
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastPoint;
            series2.Color = System.Drawing.Color.Red;
            series2.Name = "Series2";
            series3.BorderWidth = 3;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastPoint;
            series3.Color = System.Drawing.Color.Yellow;
            series3.MarkerSize = 15;
            series3.Name = "Series3";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(807, 433);
            this.chart1.TabIndex = 6;
            this.chart1.Text = "chart1";
            // 
            // trackbar_start_point
            // 
            this.trackbar_start_point.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trackbar_start_point.Location = new System.Drawing.Point(762, 43);
            this.trackbar_start_point.Name = "trackbar_start_point";
            this.trackbar_start_point.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trackbar_start_point.Size = new System.Drawing.Size(162, 45);
            this.trackbar_start_point.SmallChange = 20;
            this.trackbar_start_point.TabIndex = 7;
            this.trackbar_start_point.TickFrequency = 20;
            this.trackbar_start_point.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackbar_start_point.Scroll += new System.EventHandler(this.trackbar_start_point_Scroll);
            // 
            // trackbar_finish_point
            // 
            this.trackbar_finish_point.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trackbar_finish_point.LargeChange = 20;
            this.trackbar_finish_point.Location = new System.Drawing.Point(762, 91);
            this.trackbar_finish_point.Name = "trackbar_finish_point";
            this.trackbar_finish_point.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trackbar_finish_point.Size = new System.Drawing.Size(162, 45);
            this.trackbar_finish_point.SmallChange = 20;
            this.trackbar_finish_point.TabIndex = 8;
            this.trackbar_finish_point.TickFrequency = 20;
            this.trackbar_finish_point.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackbar_finish_point.Scroll += new System.EventHandler(this.trackbar_finish_point_Scroll);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label_start_point
            // 
            this.label_start_point.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_start_point.AutoSize = true;
            this.label_start_point.Location = new System.Drawing.Point(762, 27);
            this.label_start_point.Name = "label_start_point";
            this.label_start_point.Size = new System.Drawing.Size(115, 13);
            this.label_start_point.TabIndex = 9;
            this.label_start_point.Text = "Начальное значение:";
            // 
            // label_finish_point
            // 
            this.label_finish_point.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_finish_point.AutoSize = true;
            this.label_finish_point.Location = new System.Drawing.Point(762, 75);
            this.label_finish_point.Name = "label_finish_point";
            this.label_finish_point.Size = new System.Drawing.Size(108, 13);
            this.label_finish_point.TabIndex = 10;
            this.label_finish_point.Text = "Конечное значение:";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.HotTrack = true;
            this.tabControl1.Location = new System.Drawing.Point(0, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(759, 443);
            this.tabControl1.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.chart1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(751, 417);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "График";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.chart2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(751, 417);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Спектр";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // chart2
            // 
            this.chart2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.AxisX.Title = "Номер канала";
            chartArea2.AxisY.Title = "Количество пиков";
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            this.chart2.Location = new System.Drawing.Point(-28, -6);
            this.chart2.Margin = new System.Windows.Forms.Padding(0);
            this.chart2.Name = "chart2";
            series4.ChartArea = "ChartArea1";
            series4.Name = "Series1";
            this.chart2.Series.Add(series4);
            this.chart2.Size = new System.Drawing.Size(803, 410);
            this.chart2.TabIndex = 0;
            this.chart2.Text = "chart2";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(751, 417);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Результаты тестирования";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.win_fil,
            this.find1,
            this.find2,
            this.find3,
            this.find4,
            this.find5,
            this.find6,
            this.find7,
            this.find8,
            this.find9,
            this.find10});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(751, 417);
            this.dataGridView1.TabIndex = 0;
            // 
            // win_fil
            // 
            this.win_fil.HeaderText = "окно фильтра";
            this.win_fil.Name = "win_fil";
            this.win_fil.ReadOnly = true;
            // 
            // find1
            // 
            this.find1.HeaderText = "= 1";
            this.find1.Name = "find1";
            this.find1.ReadOnly = true;
            // 
            // find2
            // 
            this.find2.HeaderText = "= 2";
            this.find2.Name = "find2";
            this.find2.ReadOnly = true;
            // 
            // find3
            // 
            this.find3.HeaderText = "= 3";
            this.find3.Name = "find3";
            this.find3.ReadOnly = true;
            // 
            // find4
            // 
            this.find4.HeaderText = "= 4";
            this.find4.Name = "find4";
            this.find4.ReadOnly = true;
            // 
            // find5
            // 
            this.find5.HeaderText = "= 5";
            this.find5.Name = "find5";
            this.find5.ReadOnly = true;
            // 
            // find6
            // 
            this.find6.HeaderText = "= 6";
            this.find6.Name = "find6";
            this.find6.ReadOnly = true;
            // 
            // find7
            // 
            this.find7.HeaderText = "= 7";
            this.find7.Name = "find7";
            this.find7.ReadOnly = true;
            // 
            // find8
            // 
            this.find8.HeaderText = "= 8";
            this.find8.Name = "find8";
            this.find8.ReadOnly = true;
            // 
            // find9
            // 
            this.find9.HeaderText = "= 9";
            this.find9.Name = "find9";
            this.find9.ReadOnly = true;
            // 
            // find10
            // 
            this.find10.HeaderText = "= 10";
            this.find10.Name = "find10";
            this.find10.ReadOnly = true;
            // 
            // button_plot_spector
            // 
            this.button_plot_spector.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_plot_spector.Location = new System.Drawing.Point(765, 354);
            this.button_plot_spector.Name = "button_plot_spector";
            this.button_plot_spector.Size = new System.Drawing.Size(147, 26);
            this.button_plot_spector.TabIndex = 13;
            this.button_plot_spector.Text = "Построить спектр";
            this.button_plot_spector.UseVisualStyleBackColor = true;
            this.button_plot_spector.Click += new System.EventHandler(this.button_plot_spector_Click);
            // 
            // button_smooth
            // 
            this.button_smooth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_smooth.Location = new System.Drawing.Point(765, 219);
            this.button_smooth.Name = "button_smooth";
            this.button_smooth.Size = new System.Drawing.Size(147, 26);
            this.button_smooth.TabIndex = 14;
            this.button_smooth.Text = "Сгладить";
            this.button_smooth.UseVisualStyleBackColor = true;
            this.button_smooth.Click += new System.EventHandler(this.button_smooth_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(765, 331);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(113, 17);
            this.checkBox1.TabIndex = 16;
            this.checkBox1.Text = "отображать пики";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // domainUpDown1
            // 
            this.domainUpDown1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.domainUpDown1.Items.Add("10");
            this.domainUpDown1.Items.Add("9");
            this.domainUpDown1.Items.Add("8");
            this.domainUpDown1.Items.Add("7");
            this.domainUpDown1.Items.Add("6");
            this.domainUpDown1.Items.Add("5");
            this.domainUpDown1.Items.Add("4");
            this.domainUpDown1.Items.Add("3");
            this.domainUpDown1.Items.Add("2");
            this.domainUpDown1.Items.Add("1");
            this.domainUpDown1.Location = new System.Drawing.Point(765, 305);
            this.domainUpDown1.Name = "domainUpDown1";
            this.domainUpDown1.ReadOnly = true;
            this.domainUpDown1.Size = new System.Drawing.Size(147, 20);
            this.domainUpDown1.TabIndex = 17;
            this.domainUpDown1.Text = "4";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(762, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "окно поиска пиков";
            // 
            // button_noise
            // 
            this.button_noise.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_noise.Location = new System.Drawing.Point(765, 187);
            this.button_noise.Name = "button_noise";
            this.button_noise.Size = new System.Drawing.Size(147, 26);
            this.button_noise.TabIndex = 20;
            this.button_noise.Text = "Добавить шум";
            this.button_noise.UseVisualStyleBackColor = true;
            this.button_noise.Click += new System.EventHandler(this.button_noise_Click);
            // 
            // button_copy
            // 
            this.button_copy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_copy.Location = new System.Drawing.Point(765, 251);
            this.button_copy.Name = "button_copy";
            this.button_copy.Size = new System.Drawing.Size(147, 35);
            this.button_copy.TabIndex = 21;
            this.button_copy.Text = "Перенести сглаженный \r\nмассив в основной";
            this.button_copy.UseVisualStyleBackColor = true;
            this.button_copy.Click += new System.EventHandler(this.button_copy_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(765, 400);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(147, 20);
            this.textBox1.TabIndex = 22;
            this.textBox1.Text = "10";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(765, 383);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "количество пиков :";
            // 
            // file_stripmenu
            // 
            this.file_stripmenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.import_stripmenu,
            this.add_file_stripmenu,
            this.сохранитьГрафикВФайлToolStripMenuItem});
            this.file_stripmenu.Name = "file_stripmenu";
            this.file_stripmenu.Size = new System.Drawing.Size(48, 20);
            this.file_stripmenu.Text = "Файл";
            // 
            // import_stripmenu
            // 
            this.import_stripmenu.Name = "import_stripmenu";
            this.import_stripmenu.Size = new System.Drawing.Size(242, 22);
            this.import_stripmenu.Text = "Открыть график";
            this.import_stripmenu.Click += new System.EventHandler(this.import_file_stripmenu_Click);
            // 
            // add_file_stripmenu
            // 
            this.add_file_stripmenu.Name = "add_file_stripmenu";
            this.add_file_stripmenu.Size = new System.Drawing.Size(242, 22);
            this.add_file_stripmenu.Text = "Добавить к текущему графику";
            this.add_file_stripmenu.Click += new System.EventHandler(this.add_file_stripmenu_Click);
            // 
            // сохранитьГрафикВФайлToolStripMenuItem
            // 
            this.сохранитьГрафикВФайлToolStripMenuItem.Name = "сохранитьГрафикВФайлToolStripMenuItem";
            this.сохранитьГрафикВФайлToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.сохранитьГрафикВФайлToolStripMenuItem.Text = "Сохранить график в файл";
            this.сохранитьГрафикВФайлToolStripMenuItem.Click += new System.EventHandler(this.save_file_stripmenu_Click);
            // 
            // generation_stripmenu
            // 
            this.generation_stripmenu.Name = "generation_stripmenu";
            this.generation_stripmenu.Size = new System.Drawing.Size(126, 20);
            this.generation_stripmenu.Text = "Генерация графика";
            this.generation_stripmenu.Click += new System.EventHandler(this.generation_stripmenu_Click);
            // 
            // filter_stripmenu
            // 
            this.filter_stripmenu.Name = "filter_stripmenu";
            this.filter_stripmenu.Size = new System.Drawing.Size(140, 20);
            this.filter_stripmenu.Text = "Параметры фильтров";
            this.filter_stripmenu.Click += new System.EventHandler(this.filter_stripmenu_Click);
            // 
            // test_stripmenu
            // 
            this.test_stripmenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.simple_ma_stripmenu,
            this.weigh_ma_stripmenu,
            this.exp_ma_stripmenu,
            this.aver_filter_check,
            this.medial_filter_check});
            this.test_stripmenu.Name = "test_stripmenu";
            this.test_stripmenu.Size = new System.Drawing.Size(146, 20);
            this.test_stripmenu.Text = "Тестирование фильтра";
            // 
            // simple_ma_stripmenu
            // 
            this.simple_ma_stripmenu.Name = "simple_ma_stripmenu";
            this.simple_ma_stripmenu.Size = new System.Drawing.Size(199, 22);
            this.simple_ma_stripmenu.Text = "Простое СС";
            this.simple_ma_stripmenu.Click += new System.EventHandler(this.simple_ma_stripmenu_Click);
            // 
            // weigh_ma_stripmenu
            // 
            this.weigh_ma_stripmenu.Name = "weigh_ma_stripmenu";
            this.weigh_ma_stripmenu.Size = new System.Drawing.Size(199, 22);
            this.weigh_ma_stripmenu.Text = "Взвешанное СС";
            this.weigh_ma_stripmenu.Click += new System.EventHandler(this.weigh_ma_stripmenu_Click);
            // 
            // exp_ma_stripmenu
            // 
            this.exp_ma_stripmenu.Name = "exp_ma_stripmenu";
            this.exp_ma_stripmenu.Size = new System.Drawing.Size(199, 22);
            this.exp_ma_stripmenu.Text = "Экспоненциальное СС";
            this.exp_ma_stripmenu.Click += new System.EventHandler(this.exp_ma_stripmenu_Click);
            // 
            // aver_filter_check
            // 
            this.aver_filter_check.CheckOnClick = true;
            this.aver_filter_check.Name = "aver_filter_check";
            this.aver_filter_check.Size = new System.Drawing.Size(199, 22);
            this.aver_filter_check.Text = "Предварительный УФ";
            this.aver_filter_check.Click += new System.EventHandler(this.aver_filter_check_Click);
            // 
            // medial_filter_check
            // 
            this.medial_filter_check.CheckOnClick = true;
            this.medial_filter_check.Name = "medial_filter_check";
            this.medial_filter_check.Size = new System.Drawing.Size(199, 22);
            this.medial_filter_check.Text = "Предварительный МФ";
            this.medial_filter_check.Click += new System.EventHandler(this.medial_filter_check_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.file_stripmenu,
            this.generation_stripmenu,
            this.filter_stripmenu,
            this.test_stripmenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(924, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // button_graph
            // 
            this.button_graph.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_graph.Location = new System.Drawing.Point(765, 155);
            this.button_graph.Name = "button_graph";
            this.button_graph.Size = new System.Drawing.Size(147, 26);
            this.button_graph.TabIndex = 24;
            this.button_graph.Text = "Простой график";
            this.button_graph.UseVisualStyleBackColor = true;
            this.button_graph.Click += new System.EventHandler(this.button_graph_Click);
            // 
            // checkBox2
            // 
            this.checkBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(765, 426);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(151, 30);
            this.checkBox2.TabIndex = 25;
            this.checkBox2.Text = "использовать заданное \r\nчисло";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 482);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.button_graph);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button_copy);
            this.Controls.Add(this.button_noise);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.domainUpDown1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button_smooth);
            this.Controls.Add(this.button_plot_spector);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label_finish_point);
            this.Controls.Add(this.label_start_point);
            this.Controls.Add(this.trackbar_start_point);
            this.Controls.Add(this.button_replot);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.trackbar_finish_point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(861, 489);
            this.Name = "form_main";
            this.Text = "программа";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackbar_start_point)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackbar_finish_point)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button button_replot;
		private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TrackBar trackbar_start_point;
        private System.Windows.Forms.TrackBar trackbar_finish_point;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Label label_start_point;
        private System.Windows.Forms.Label label_finish_point;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Button button_plot_spector;
        private System.Windows.Forms.Button button_smooth;
        public System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DomainUpDown domainUpDown1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_noise;
        private System.Windows.Forms.Button button_copy;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn win_fil;
        private System.Windows.Forms.DataGridViewTextBoxColumn find1;
        private System.Windows.Forms.DataGridViewTextBoxColumn find2;
        private System.Windows.Forms.DataGridViewTextBoxColumn find3;
        private System.Windows.Forms.DataGridViewTextBoxColumn find4;
        private System.Windows.Forms.DataGridViewTextBoxColumn find5;
        private System.Windows.Forms.DataGridViewTextBoxColumn find6;
        private System.Windows.Forms.DataGridViewTextBoxColumn find7;
        private System.Windows.Forms.DataGridViewTextBoxColumn find8;
        private System.Windows.Forms.DataGridViewTextBoxColumn find9;
        private System.Windows.Forms.DataGridViewTextBoxColumn find10;
        private System.Windows.Forms.ToolStripMenuItem file_stripmenu;
        private System.Windows.Forms.ToolStripMenuItem import_stripmenu;
        private System.Windows.Forms.ToolStripMenuItem generation_stripmenu;
        private System.Windows.Forms.ToolStripMenuItem filter_stripmenu;
        private System.Windows.Forms.ToolStripMenuItem test_stripmenu;
        private System.Windows.Forms.ToolStripMenuItem simple_ma_stripmenu;
        private System.Windows.Forms.ToolStripMenuItem weigh_ma_stripmenu;
        private System.Windows.Forms.ToolStripMenuItem exp_ma_stripmenu;
        private System.Windows.Forms.ToolStripMenuItem aver_filter_check;
        private System.Windows.Forms.ToolStripMenuItem medial_filter_check;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button button_graph;
        private System.Windows.Forms.ToolStripMenuItem сохранитьГрафикВФайлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem add_file_stripmenu;
        private System.Windows.Forms.CheckBox checkBox2;
    }
}

