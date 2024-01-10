namespace WindowsFormsApp1
{
	partial class Form1
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.label1 = new System.Windows.Forms.Label();
			this.txbCity = new System.Windows.Forms.TextBox();
			this.btnSearchWeather = new System.Windows.Forms.Button();
			this.condition = new System.Windows.Forms.Label();
			this.description = new System.Windows.Forms.Label();
			this.WindSpeed = new System.Windows.Forms.Label();
			this.Pressure = new System.Windows.Forms.Label();
			this.temp = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			resources.ApplyResources(this.label1, "label1");
			this.label1.Name = "label1";
			// 
			// txbCity
			// 
			resources.ApplyResources(this.txbCity, "txbCity");
			this.txbCity.Name = "txbCity";
			this.txbCity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbCity_KeyPress);
			// 
			// btnSearchWeather
			// 
			resources.ApplyResources(this.btnSearchWeather, "btnSearchWeather");
			this.btnSearchWeather.Name = "btnSearchWeather";
			this.btnSearchWeather.UseVisualStyleBackColor = true;
			this.btnSearchWeather.Click += new System.EventHandler(this.btnSearchWeather_Click);
			// 
			// condition
			// 
			resources.ApplyResources(this.condition, "condition");
			this.condition.Name = "condition";
			// 
			// description
			// 
			resources.ApplyResources(this.description, "description");
			this.description.Name = "description";
			// 
			// WindSpeed
			// 
			resources.ApplyResources(this.WindSpeed, "WindSpeed");
			this.WindSpeed.Name = "WindSpeed";
			// 
			// Pressure
			// 
			resources.ApplyResources(this.Pressure, "Pressure");
			this.Pressure.Name = "Pressure";
			// 
			// temp
			// 
			resources.ApplyResources(this.temp, "temp");
			this.temp.Name = "temp";
			// 
			// label2
			// 
			resources.ApplyResources(this.label2, "label2");
			this.label2.Name = "label2";
			// 
			// label3
			// 
			resources.ApplyResources(this.label3, "label3");
			this.label3.Name = "label3";
			// 
			// label4
			// 
			resources.ApplyResources(this.label4, "label4");
			this.label4.Name = "label4";
			// 
			// label5
			// 
			resources.ApplyResources(this.label5, "label5");
			this.label5.Name = "label5";
			// 
			// label6
			// 
			resources.ApplyResources(this.label6, "label6");
			this.label6.Name = "label6";
			// 
			// Form1
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.temp);
			this.Controls.Add(this.Pressure);
			this.Controls.Add(this.WindSpeed);
			this.Controls.Add(this.description);
			this.Controls.Add(this.condition);
			this.Controls.Add(this.btnSearchWeather);
			this.Controls.Add(this.txbCity);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txbCity;
		private System.Windows.Forms.Button btnSearchWeather;
		private System.Windows.Forms.Label condition;
		private System.Windows.Forms.Label description;
		private System.Windows.Forms.Label WindSpeed;
		private System.Windows.Forms.Label Pressure;
		private System.Windows.Forms.Label temp;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
	}
}

