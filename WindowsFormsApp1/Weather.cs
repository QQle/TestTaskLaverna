using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
	  
	internal class Weather
	{

		//классы коотрые содержат данные о погоде
		public class main
		{
			public double temp {  get; set; }	
			public double pressure { get; set; }


		}
		public class wind
		{
			public double speed { get; set; }	
		}
		public class weather
		{
			public string main { get; set; }
			public string description { get; set; }	

		}

		public class root
		{
			
			public main main {  get; set; }
			public List<weather> weather { get; set;}
			public wind wind {  get; set; }	

		}


	}
}
