using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PriceSimulation
{
    public partial class Form_main : Form
    {
        public Form_main()
        {
            InitializeComponent();
        }

        int flag = 0; // 0 - stop, 1 - start
        const double k = 0.03;
        int current_day = 0;
        double usd_price_Value, eur_price_Value;
        Random random_value = new Random();

        private void button_StartStop_Click_1(object sender, EventArgs e)
        {
            //Validation
            string usd_price = textBox_USD.Text;
            string eur_price = textBox_EUR.Text;

            if (!double.TryParse(usd_price, out usd_price_Value) || usd_price_Value < 0)
            {
                MessageBox.Show("Введите корректное значение для цены USD (>= 0)!");
                return;
            }

            if (!double.TryParse(eur_price, out eur_price_Value) || eur_price_Value < 0)
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

            chart.ChartAreas[0].AxisX.Minimum = 0;
            chart.ChartAreas[0].AxisY.Minimum = 0;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            // можно выводить на каждый день, но так симуляция будет очень быстрой,
            // для более комфортной читабельности выводим к примеру каждые 10 дней
            if (current_day % 1 == 0)
            {
                chart.Series[0].Points.AddXY(current_day, usd_price_Value);
                chart.Series[1].Points.AddXY(current_day, eur_price_Value);

                chart.Series[0].Points.Last().Label = usd_price_Value.ToString("F2");
                chart.Series[1].Points.Last().Label = eur_price_Value.ToString("F2");
            }
            current_day ++;
            usd_price_Value = usd_price_Value * (1 + k * (random_value.NextDouble() - 0.5));
            eur_price_Value = eur_price_Value * (1 + k * (random_value.NextDouble() - 0.5));
        }
    }
}
