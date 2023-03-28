using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Tools;

namespace test
{
	static class Program
	{
		/// <summary>
		/// Главная точка входа для приложения.
		/// </summary>
		[STAThread]

		static void Main()
		{

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new form_main());
		}

		public static int[] mas;                        //основной массивы с графиком
		public static int[] mas_smooth;					//сглаженный массив
		public static int[] mas_peaks;					//массив с пиками
		public static int[] specter = new int[1024];	//массив спектра
		public static int numbers_peaks;						//количество пиков при генерации
		//public static int Lenght=1000;                  //коэффицент длинны генерируемого массива
		public static int[] from_filter = new int[2] { 1, 1 }; //параметры для формы фильтра
		//тип фильтра, есть ли сдвиг на пол периода
		public static int[] form_generator = new int[5] { 7, 50, 150, 10, 1 }; //параметры для формы генератора
		// мин напряжение, макс напряжение, время, количество точек, убирать ли нули
		public static int[] settings_moving_average_filter = new int[4] { 10, 0, 5, 0};	//настройки скользящего среднего
		//период, тип фильтра(0-обычный, 1-взвешенный,2-экспоненциальный),
		//коэффицент для экспоненциального, выбор оптимального(0-нет, 1- да)
		public static int[] settings_average_filter = new int[2] { 10, 10 };      //настройки усредняющего фильтра
		public static int[] settings_media_filter = new int[1] { 7 };    //настройки медиального фильтра

		//функция для генерации массива
		public class DataGenerator
		{
			static NormalRandom nrnd = new NormalRandom(); //генератор нормального распределения
			static Random rnd = new Random(); //генератор случайного распределения
									   //double dt; //длительность отсчета симуляции, сек
			double Gain = rnd.Next(form_generator[0], form_generator[1])/2.5; //Этим можно изменять амплитуду импульсов
			int ImpLenght = 110; //длительность фронта импульса (в отсчетах)
			
			double CoeffLoad = form_generator[2]*5; //Этот коэффициент отвечает за количество 
									//генерируемых импульсов в единицу времени
									//(загрузка детектора)
									//Чем значение больше, тем меньше импульсов 

			//Эти переменные сипользуются в методе Tick()
			int NextImpulseCounter;
			double Pulse;
			int ImpLenghtCounter;

			public DataGenerator()
			{
				NormalRandom nrnd = new NormalRandom();
				rnd = new Random();

				NextImpulseCounter = 0;
				NextImpulseCounter = 0;
				Pulse = 0;
				ImpLenghtCounter = 0;

				OutVal = 0;
			}

			public double Tick()
			{
				//Тут мы занимаемся генерацией прямоугольного ипульса от ФЭУ
				//Если время генерировать новый импульс еще не пришло
				if (NextImpulseCounter > 0)
				{
					NextImpulseCounter--;
				}
				else //настало время генерировать очередной импульс
				{
					numbers_peaks++;
					Pulse = GenImp(); //Генерируем амплитуду импульса
									  //Генерируем время генерации следующего импульса
					NextImpulseCounter = (int)(rnd.NextDouble() * CoeffLoad); //следующий импульс будет через указанное число тиков
					ImpLenghtCounter = 0; //Сбрасываем счетчик длительности импульса
				}

				//
				//Тут мы пропускаем сгенерированный испульс через фильтр
				//для получения фмпульса нужной формы
				//

				//Сейчас генерируем фронт импульса
				if (ImpLenghtCounter < ImpLenght)
				{
					ImpLenghtCounter++;
					return Filter(Pulse);
				}
				else //генерируем спад импульса
				{
					return Filter(0);
				}
			}

			//Эти переменные используются в функции Filter()
			double CoeffTau = 0.02; //Постоянная времени фильтра (Tau=R*C). Этим можно менять длительность спада импульса
			double OutVal;

			double Filter(double InVal)
			{
				double D = InVal - OutVal;
				OutVal += CoeffTau * D;
				return OutVal;
			}

			//Генерация значения амплитуды импульса
			double GenImp()
			{
				double val = (nrnd.NextDouble() + 5.0) * Gain;
				return val;
			}
		} 
	} 
}