using Newtonsoft.Json;
using System;
using System.Net;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		//апи ключ для выполнения запросов к openweathermap.org
		string ApiKey = "fcbd8daaee81c44b7c2644e9c4a9a81b";

		//блок проверки введенного значеения в поле "город"
		private void txbCity_KeyPress(object sender, KeyPressEventArgs e)
		{
			{
				//запрещаем ввод цифр с клавиатуры
				if (!Char.IsNumber(e.KeyChar))
				{
					return;
				}

				e.Handled = true;

			}
		}
		//обработчик события нажатия на кнопку "Вывести погоду"
		private void btnSearchWeather_Click(object sender, EventArgs e)
		{
			//Проверка на пустоту поля ввода города
			if (txbCity.Text == String.Empty) 
			{ 
				MessageBox.Show("Введите город");
				return; 
			}
			//вызов метода getWeather
			getWeather();
		}
		//метод поиска погоды по заданному городу 
		void getWeather()
		{
			using (WebClient client = new WebClient())
			{
				//запрос на openweathermap.org с параметрами, которые задал пользователь
				string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}", txbCity.Text, ApiKey);
				//получение ответа с openweathermap.org
				var json = client.DownloadString(url);
				//создаем переменную info типа Weather.root, которая будет содержать десериализованные данные из JSON-строки json.
				Weather.root info = JsonConvert.DeserializeObject<Weather.root>(json);
				//переводим температуры из Кеальн в Цельсий и сотавляемм 2 знака полсе запятой
				double tempC = Math.Round((((Convert.ToDouble(info.main.temp)) - 273)),2);
				//присваиваем значения соответствующим полям
				temp.Text = tempC.ToString();
				condition.Text = info.weather[0].main;
				description.Text = info.weather[0].description.ToString();
				WindSpeed.Text = info.wind.speed.ToString();
				Pressure.Text = info.main.pressure.ToString();


			}
		}


	}
}
