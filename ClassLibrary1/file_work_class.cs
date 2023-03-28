using System;


namespace Tools
{
	public class file_work_class  //работа с файлами
	{
		//добавление данных в массив
		static public void open_file(ref string[] allmas, ref int[] mas)
		{
			//изменение длинны и очистка длинны
			Array.Resize(ref mas, (allmas.Length - 1) / 2);
			Array.Clear(mas, 0, mas.Length);

			int j = 0; //переменная положения в массиве
			for (int i = 0; i < allmas.Length - 2; i += 2)//значения подпибраются для текущего файла
			{
				mas[j] = Convert.ToInt32(1023 * Convert.ToDouble(allmas[i]));
				j++;
			}
			Array.Resize(ref mas, j);
		}

		//функция добавления данных к текущему массиву
		static public void add_file(ref string[] allmas, ref int[] mas)
		{
			int n = mas.Length; //текущая длинна
			Array.Resize(ref mas, n + ((allmas.Length - 1) / 2));
			int j = 0; //переменная положения в массиве
			for (int i = 0; i < allmas.Length - 2; i += 2)//значения подпибраются для текущего файла
			{
				mas[n + j] = Convert.ToInt32(1023 * Convert.ToDouble(allmas[i]));
				j++;
			}
			Array.Resize(ref mas, n + j);
		}

	}
	public class generating_class //класс для генерации
	{
		//функция добавления шума в массив
		static public void noise(int[] massive)
		{
			NormalRandom nrnd = new NormalRandom(); //генератор нормального распределения
			Random rnd = new Random();
			for (int i = 0; i < massive.Length; i++)
			{
				massive[i] -= 15;
				massive[i] += nrnd.Next(30);
			}
		}
	}

	public class find_peak
	{
		//поиск пиков и заполнение массива пиков
		static public void find(int[] massive, int[] mas_peaks, int window, int[] specter)
		{
			//очистка массива спектра
			if (specter != null)
			{ Array.Clear(specter, 0, specter.Length); }
			int min = 40;	// установка минимального значения, выше которого ищутся пики
			int i = window;		//начальное положение окна поиска
			if (window == 1)
			{
				for (; i < massive.Length - window; i++)
				{
					if (massive[i] >= 1023)
					{
						specter[1023]++;//для всех значений больших масимума спектра
					}
					else if (massive[i] > min & massive[i] >= massive[i - 1] & massive[i] >= massive[i + 1])
					{
						specter[massive[i]]++;		//добавление 1 в массив спектра
						mas_peaks[i] = massive[i];	//добавление значения пика
					}
				}
			}
			if (window == 2)
			{
				for (; i < massive.Length - window; i++)
				{
					if (massive[i] >= 1023)
					{
						specter[1023]++;
					}
					else if (massive[i] > min &
						massive[i] >= massive[i - 1] & massive[i] >= massive[i - 2] &
						massive[i] > massive[i + 1] & massive[i] > massive[i + 2])
					{
						specter[massive[i]]++;
						mas_peaks[i] = massive[i];
					}
				}
			}
			if (window == 3)
			{
				for (; i < massive.Length - window; i++)
				{
					if (massive[i] >= 1023)
					{
						specter[1023]++;
					}
					else if (massive[i] > min &
						massive[i] >= massive[i - 1] & massive[i] >= massive[i - 2] &
						massive[i] >= massive[i - 3] & massive[i] > massive[i + 1] &
						massive[i] > massive[i + 2] & massive[i] > massive[i + 3])
					{
						specter[massive[i]]++;
						mas_peaks[i] = massive[i];
					}
				}
			}
			if (window == 4)
			{
				for (; i < massive.Length - window; i++)
				{
					if (massive[i] >= 1023)
					{
						specter[1023]++;
					}
					else if (massive[i] > min &
						massive[i] >= massive[i - 1] & massive[i] >= massive[i - 2] &
						massive[i] >= massive[i - 3] & massive[i] >= massive[i - 4] &
						massive[i] > massive[i + 1] & massive[i] > massive[i + 2] &
						massive[i] > massive[i + 3] & massive[i] > massive[i + 4])
					{
						specter[massive[i]]++;
						mas_peaks[i] = massive[i];
					}
				}
			}
			if (window == 5)
			{
				for (; i < massive.Length - window; i++)
				{
					if (massive[i] >= 1023)
					{
						specter[1023]++;
					}
					else if (massive[i] > min &
						massive[i] >= massive[i - 1] & massive[i] >= massive[i - 2] &
						massive[i] >= massive[i - 3] & massive[i] >= massive[i - 4] &
						massive[i] >= massive[i - 5] & massive[i] > massive[i + 1] &
						massive[i] > massive[i + 2] & massive[i] > massive[i + 3] &
						massive[i] > massive[i + 4] & massive[i] > massive[i + 5])
					{
						specter[massive[i]]++;
						mas_peaks[i] = massive[i];
					}
				}
			}
			if (window == 6)
			{
				for (; i < massive.Length - window; i++)
				{
					if (massive[i] >= 1023)
					{
						specter[1023]++;
					}
					else if (massive[i] > min &
						massive[i] >= massive[i - 1] & massive[i] >= massive[i - 2] &
						massive[i] >= massive[i - 3] & massive[i] >= massive[i - 4] &
						massive[i] >= massive[i - 5] & massive[i] >= massive[i - 6] &
						massive[i] > massive[i + 1] & massive[i] > massive[i + 2] &
						massive[i] > massive[i + 3] & massive[i] > massive[i + 4] &
						massive[i] > massive[i + 5] & massive[i] > massive[i + 6])
					{
						specter[massive[i]]++;
						mas_peaks[i] = massive[i];
					}
				}
			}
			if (window == 7)
			{
				for (; i < massive.Length - window; i++)
				{
					if (massive[i] >= 1023)
					{
						specter[1023]++;
					}
					else if (massive[i] > min &
							massive[i] >= massive[i - 1] & massive[i] >= massive[i - 2] &
							massive[i] >= massive[i - 3] & massive[i] >= massive[i - 4] &
							massive[i] >= massive[i - 5] & massive[i] >= massive[i - 6] &
							massive[i] >= massive[i - 7] &
							massive[i] > massive[i + 1] & massive[i] > massive[i + 2] &
							massive[i] > massive[i + 3] & massive[i] > massive[i + 4] &
							massive[i] > massive[i + 5] & massive[i] > massive[i + 6] &
							massive[i] > massive[i + 7])
					{
						specter[massive[i]]++;
						mas_peaks[i] = massive[i];
					}
				}
			}
			if (window == 8)
			{
				for (; i < massive.Length - window; i++)
				{
					if (massive[i] >= 1023)
					{
						specter[1023]++;
					}
					else if (massive[i] > min &
							massive[i] >= massive[i - 1] & massive[i] >= massive[i - 2] &
							massive[i] >= massive[i - 3] & massive[i] >= massive[i - 4] &
							massive[i] >= massive[i - 5] & massive[i] >= massive[i - 6] &
							massive[i] >= massive[i - 7] & massive[i] >= massive[i - 8] &
							massive[i] > massive[i + 1] & massive[i] > massive[i + 2] &
							massive[i] > massive[i + 3] & massive[i] > massive[i + 4] &
							massive[i] > massive[i + 5] & massive[i] > massive[i + 6] &
							massive[i] > massive[i + 7] & massive[i] > massive[i + 8])
					{
						specter[massive[i]]++;
						mas_peaks[i] = massive[i];
					}
				}
			}
			if (window == 9)
			{
				for (; i < massive.Length - window; i++)
				{
					if (massive[i] >= 1023)
					{
						specter[1023]++;
					}
					else if (massive[i] > min &
							massive[i] >= massive[i - 1] & massive[i] >= massive[i - 2] &
							massive[i] >= massive[i - 3] & massive[i] >= massive[i - 4] &
							massive[i] >= massive[i - 5] & massive[i] >= massive[i - 6] &
							massive[i] >= massive[i - 7] & massive[i] >= massive[i - 8] &
							massive[i] >= massive[i - 9] &
							massive[i] > massive[i + 1] & massive[i] > massive[i + 2] &
							massive[i] > massive[i + 3] & massive[i] > massive[i + 4] &
							massive[i] > massive[i + 5] & massive[i] > massive[i + 6] &
							massive[i] > massive[i + 7] & massive[i] > massive[i + 8] &
							massive[i] > massive[i + 9])
					{
						specter[massive[i]]++;
						mas_peaks[i] = massive[i];
					}
				}
			}
			if (window == 10)
			{
				for (; i < massive.Length - window; i++)
				{
					if (massive[i] >= 1023)
					{
						specter[1023]++;
					}
					else if (massive[i] > min &
							massive[i] >= massive[i - 1] & massive[i] >= massive[i - 2] &
							massive[i] >= massive[i - 3] & massive[i] >= massive[i - 4] &
							massive[i] >= massive[i - 5] & massive[i] >= massive[i - 6] &
							massive[i] >= massive[i - 7] & massive[i] >= massive[i - 8] &
							massive[i] >= massive[i - 9] & massive[i] >= massive[i - 10] &
							massive[i] > massive[i + 1] & massive[i] > massive[i + 2] &
							massive[i] > massive[i + 3] & massive[i] > massive[i + 4] &
							massive[i] > massive[i + 5] & massive[i] > massive[i + 6] &
							massive[i] > massive[i + 7] & massive[i] > massive[i + 8] &
							massive[i] > massive[i + 9] & massive[i] > massive[i + 10])
					{
						specter[massive[i]]++;
						mas_peaks[i] = massive[i];
					}
				}
			}
		}
		//только поиск пиков
		static public int find_fast(int[] massive, int window)
		{
			int i = window;		//установка начального положения
			int min = 40;		//установка минимального значения для поиска
			int peaks = 0;		//сбор количества пиков
			if (window == 1)	
			{
				for (; i < massive.Length - window; i++)
				{
					if (massive[i] > min & massive[i] >= massive[i - 1] & massive[i] >= massive[i + 1])
					{
						peaks++;
					}
				}
			}
			if (window == 2)
			{
				for (; i < massive.Length - window; i++)
				{
					if (massive[i] > min &
						massive[i] >= massive[i - 1] & massive[i] >= massive[i - 2] &
						massive[i] > massive[i + 1] & massive[i] > massive[i + 2])
					{
						peaks++;
					}
				}
			}
			if (window == 3)
			{
				for (; i < massive.Length - window; i++)
				{
					if (massive[i] > min &
						massive[i] >= massive[i - 1] & massive[i] >= massive[i - 2] &
						massive[i] >= massive[i - 3] & massive[i] > massive[i + 1] &
						massive[i] > massive[i + 2] & massive[i] > massive[i + 3])
					{
						peaks++;
					}
				}
			}
			if (window == 4)
			{
				for (; i < massive.Length - window; i++)
				{
					if (massive[i] > min &
						massive[i] >= massive[i - 1] & massive[i] >= massive[i - 2] &
						massive[i] >= massive[i - 3] & massive[i] >= massive[i - 4] &
						massive[i] > massive[i + 1] & massive[i] > massive[i + 2] &
						massive[i] > massive[i + 3] & massive[i] > massive[i + 4])
					{
						peaks++;
					}
				}
			}
			if (window == 5)
			{
				for (; i < massive.Length - window; i++)
				{
					if (massive[i] > min &
						massive[i] >= massive[i - 1] & massive[i] >= massive[i - 2] &
						massive[i] >= massive[i - 3] & massive[i] >= massive[i - 4] &
						massive[i] >= massive[i - 5] & massive[i] > massive[i + 1] &
						massive[i] > massive[i + 2] & massive[i] > massive[i + 3] &
						massive[i] > massive[i + 4] & massive[i] > massive[i + 5])
					{
						peaks++;
					}
				}
			}
			if (window == 6)
			{
				for (; i < massive.Length - window; i++)
				{
					if (massive[i] > min &
						massive[i] >= massive[i - 1] & massive[i] >= massive[i - 2] &
						massive[i] >= massive[i - 3] & massive[i] >= massive[i - 4] &
						massive[i] >= massive[i - 5] & massive[i] >= massive[i - 6] &
						massive[i] > massive[i + 1] & massive[i] > massive[i + 2] &
						massive[i] > massive[i + 3] & massive[i] > massive[i + 4] &
						massive[i] > massive[i + 5] & massive[i] > massive[i + 6])
					{
						peaks++;
					}
				}
			}
			if (window == 7)
			{
				for (; i < massive.Length - window; i++)
				{
					if (massive[i] > min &
						massive[i] >= massive[i - 1] & massive[i] >= massive[i - 2] &
						massive[i] >= massive[i - 3] & massive[i] >= massive[i - 4] &
						massive[i] >= massive[i - 5] & massive[i] >= massive[i - 6] &
						massive[i] >= massive[i - 7] &
						massive[i] > massive[i + 1] & massive[i] > massive[i + 2] &
						massive[i] > massive[i + 3] & massive[i] > massive[i + 4] &
						massive[i] > massive[i + 5] & massive[i] > massive[i + 6] &
						massive[i] > massive[i + 7])
					{
						peaks++;
					}
				}
			}
			if (window == 8)
			{
				for (; i < massive.Length - window; i++)
				{
					if (massive[i] > min &
						massive[i] >= massive[i - 1] & massive[i] >= massive[i - 2] &
						massive[i] >= massive[i - 3] & massive[i] >= massive[i - 4] &
						massive[i] >= massive[i - 5] & massive[i] >= massive[i - 6] &
						massive[i] >= massive[i - 7] & massive[i] >= massive[i - 8] &
						massive[i] > massive[i + 1] & massive[i] > massive[i + 2] &
						massive[i] > massive[i + 3] & massive[i] > massive[i + 4] &
						massive[i] > massive[i + 5] & massive[i] > massive[i + 6] &
						massive[i] > massive[i + 7] & massive[i] > massive[i + 8])
					{
						peaks++;
					}
				}
			}
			if (window == 9)
			{
				for (; i < massive.Length - window; i++)
				{
					if (massive[i] > min &
						massive[i] >= massive[i - 1] & massive[i] >= massive[i - 2] &
						massive[i] >= massive[i - 3] & massive[i] >= massive[i - 4] &
						massive[i] >= massive[i - 5] & massive[i] >= massive[i - 6] &
						massive[i] >= massive[i - 7] & massive[i] >= massive[i - 8] &
						massive[i] >= massive[i - 9] &
						massive[i] > massive[i + 1] & massive[i] > massive[i + 2] &
						massive[i] > massive[i + 3] & massive[i] > massive[i + 4] &
						massive[i] > massive[i + 5] & massive[i] > massive[i + 6] &
						massive[i] > massive[i + 7] & massive[i] > massive[i + 8] &
						massive[i] > massive[i + 9])
					{
						peaks++;
					}
				}
			}
			if (window == 10)
			{
				for (; i < massive.Length - window; i++)
				{
					if (massive[i] > min &
						massive[i] >= massive[i - 1] & massive[i] >= massive[i - 2] &
						massive[i] >= massive[i - 3] & massive[i] >= massive[i - 4] &
						massive[i] >= massive[i - 5] & massive[i] >= massive[i - 6] &
						massive[i] >= massive[i - 7] & massive[i] >= massive[i - 8] &
						massive[i] >= massive[i - 9] & massive[i] >= massive[i - 10] &
						massive[i] > massive[i + 1] & massive[i] > massive[i + 2] &
						massive[i] > massive[i + 3] & massive[i] > massive[i + 4] &
						massive[i] > massive[i + 5] & massive[i] > massive[i + 6] &
						massive[i] > massive[i + 7] & massive[i] > massive[i + 8] &
						massive[i] > massive[i + 9] & massive[i] > massive[i + 10])
					{
						peaks++;
					}
				}
			}
			return peaks;
		}
	}

	public class NormalRandom : Random
	{
		// сохранённое предыдущее значение
		double prevSample = double.NaN;
		//не понятно как но оно работает
		public NormalRandom() : base()
		{

		}
	}

	public class Smoothing
	{
		//удаление нулевых значений из массива
		static public void cut_null(ref int[] massive)
		{
			int[] wn = new int[massive.Length]; //массив без нулей
			int l = 0; //положение в массиве без нулей
			for (int i = 0; i < massive.Length; i++)
			{
				if (massive[i] > 0)
				{
					wn[l] = massive[i];
					l++;
				}
			}
			//перенос данных в основной масив
			Array.Resize(ref massive, l);
			Array.Copy(wn, massive, l);
		}
		//простое скользящее среднее
		static public void moving_areas_simple(int[] massive, int[] massive_smooth, int window, int half)
		{
			int sum = 0;	//переменная суммы
			//очистка сглаженного массива
			if (massive_smooth != null)
			{ Array.Clear(massive_smooth, 0, massive_smooth.Length);}
			//переменная начала массива
			int a = 0;
			if (half == 1)
			{ a = -window / 2; }
			//первичное суммирование
			for (int i = 0; i < window; i++)
			{ sum += massive[i];}
			//основной цикл
			for (int i = window; i < massive.Length; i++)
			{
				//передвижение окна суммирования
				if (i != window)
				{
					sum += massive[i];
					sum -= massive[i - window];
				}
				massive_smooth[a + i] = Convert.ToInt32(sum / (window));
			}
		}
		//взвешенное скользящее среднее
		static public void moving_areas_weighted(int[] massive, int[] massive_smooth, int window, int half)
		{
			//очистка сглаженного массива
			if (massive_smooth != null)
			{ Array.Clear(massive_smooth, 0, massive_smooth.Length); }
			//переменная начала сглаженного массива
			int a = 0;
			if (half == 1)
			{ a = -window / 2; }
			//коэффициент для деления
			double coef = 0;
			for (int i = 0; i < window; i++)
			{
				coef += window - i;
			}
			//переменная суммы
			double sum;
			//основной цикл
			for (int i = window; i < massive.Length; i++)
			{
				//цикл подсчета суммы для сглаживания(начинает в текущем значении, заканчивает в текущее-период)
				sum = 0;
				for (int l = 0; l < window; l++)
				{
					sum += (window - l) * massive[i - l];
				}
				massive_smooth[a + i] = Convert.ToInt32(sum / coef);
			}
		}
		//экспоненциальное скользящее среднее
		static public void moving_areas_exp(int[] massive, int[] massive_smooth, int window, int coefic, int opt, int half)
		{
			//очистка сглаженного массива
			if (massive_smooth != null)
			{ Array.Clear(massive_smooth, 0, massive_smooth.Length); }
			//переменная начала массива
			int a = 0;
			if (half == 1)
			{ a = -window / 2; }
			//подчсет коэффициента
			double coef;
			//если выбран оптимальный
			if (opt == 1)
			{ coef = 2 / Convert.ToDouble(window + 1); }
			else
			{ coef = Convert.ToDouble(coefic) / 100; }

			double sum = 0;	//переменная начальной суммы
			//подсчет начальной суммы
			for (int i = 0; i < window; i++)
			{ sum += massive[i]; }
			sum /= window;
			//основной цикл
			for (int i = window; i < massive.Length; i++)
			{
				massive_smooth[a + i] = Convert.ToInt32(coef * massive[i] + (1 - coef) * sum);	
				//используется формула с учетом начальной суммы
				sum = massive_smooth[a + i];
			}
		}
		//усредняющий фильтр
		static public void average_filter(int[] massive, int[] massive_smooth, int window, int peak, int half)
		{
			//очистка массива сглаживания
			if (massive_smooth != null)
			{ Array.Clear(massive_smooth, 0, massive_smooth.Length);}
			//переменная начала массива
			int a = 0;
			if (half == 1)
			{ a = -window / 2; }
			//переменная усреднения
			double sum;
			//основной цикл
			for (int i = window; i < massive.Length; i++)
			{
				sum = 0;
				//подсчет среднего
				for (int l = i - window; l < i; l++)
				{
					sum += massive[l] / window;
				}
				if (massive[i] - sum > peak) //если текущее значение больше среднее + отклонение
				{
					massive_smooth[a + i] = Convert.ToInt32(sum) + peak / 2;
				}
				else if (massive[i] - sum < -peak) //если текущее значение меньше среднее - отклонение
				{
					massive_smooth[a + i] = Convert.ToInt32(sum) - peak / 2;
				}
				else
				{
					massive_smooth[a + i] = massive[i];
				}

			}
		}
		//медианный фильтр
		static public void medial_filter(int[] massive, int[] massive_smooth, int window, int half)
		{
			//очистка сглаженного массива
			if (massive_smooth != null)
			{ Array.Clear(massive_smooth, 0, massive_smooth.Length); }
			//переменная начала массива
			int a = 0;
			if (half == 1)
			{ a = -window / 2; }

			int[] mas = new int[window];	//массив для хранения последовательности
			int[] sr = new int[window];		//массив для сортировки

			//перенос данных из основного массива в массив для хранения
			Array.Copy(massive, mas, window);

			//функция сортировки и выбора центрального значения
			int avg()
			{
				Array.Sort(sr);
				return sr[Convert.ToInt32((window + 1) / 2) - 1];
			}
			//основной цикл
			for (int i = window; i < massive.Length; i++)
			{
				//сдвиг данных в массиве для хранения
				for (int l = 0; l < window - 1; l++)
				{
					mas[l] = mas[l + 1];
				}
				mas[window - 1] = massive[i];	//дополнение массива для хранения текущим значением
				Array.Copy(mas, sr, window);	//копирование в массив для сортировки и выбора среднего
				massive_smooth[a+i] = avg();
			}
		}
	}
}