using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace PriceSimulationNewVersion
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        int flag = 0; // 0 - stop, 1 - start
        const double k = 0.03;
        int current_day = 0;
        double usd_price_Value, eur_price_Value;
        Random random = new Random(); // seed

        private double GenerateNormal(double mean, double variance)
        {
            // Метод Бокса-Мюллера
            double alpha1 = random.NextDouble();
            double alpha2 = random.NextDouble();
            double factor = Math.Sqrt(-2.0 * Math.Log(alpha1));
            double ksi = factor * Math.Cos(2 * Math.PI * alpha2);

            return mean + variance * ksi;
        }

        double mu = 0.01;       // средний рост
        double sigma = 0.05;    // волатильность
        double delta_t = 1.0;   // шаг по времени (например, 1 день)

        private void timer_Tick(object sender, EventArgs e)
        {

            chart_Prices.Series[0].Points.AddXY(current_day, usd_price_Value);
            chart_Prices.Series[1].Points.AddXY(current_day, eur_price_Value);

            chart_Prices.Series[0].Points.Last().Label = usd_price_Value.ToString("F2");
            chart_Prices.Series[1].Points.Last().Label = eur_price_Value.ToString("F2");

            current_day++;

            // Geometric Brownian motion
            double ksi_usd = GenerateNormal(0, 1);
            double ksi_eur = GenerateNormal(0, 1);

            usd_price_Value = usd_price_Value * Math.Exp((mu - 0.5 * sigma * sigma) * delta_t + sigma * Math.Sqrt(delta_t) * ksi_usd);
            eur_price_Value = eur_price_Value * Math.Exp((mu - 0.5 * sigma * sigma) * delta_t + sigma * Math.Sqrt(delta_t) * ksi_eur);
        }

        private void button_StartStop_Click(object sender, EventArgs e)
        {
            //Validation
            string usd_price = textBox_USD.Text;
            string eur_price = textBox_EUR.Text;

            if (!double.TryParse(usd_price.Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out usd_price_Value) || usd_price_Value < 0)
            {
                MessageBox.Show("Введите корректное значение для цены USD (>= 0)!");
                return;
            }

            if (!double.TryParse(eur_price.Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out eur_price_Value) || eur_price_Value < 0)
            {
                MessageBox.Show("Введите корректное значение для цены EUR (>= 0)!");
                return;
            }

            if (flag == 0)
            {
                timer.Start();
                flag = 1;
            }
            else
            {
                timer.Stop();
                flag = 0;
            }

            chart_Prices.ChartAreas[0].AxisX.Minimum = 0;
            chart_Prices.ChartAreas[0].AxisY.Minimum = 0;
        }
    }
}
