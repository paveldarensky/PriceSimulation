namespace PriceSimulationNewVersion
{
    partial class Form_Main
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tableLayoutPanel_Main = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel_TopPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel_InputsLabels = new System.Windows.Forms.TableLayoutPanel();
            this.button_StartStop = new System.Windows.Forms.Button();
            this.label_USD = new System.Windows.Forms.Label();
            this.textBox_USD = new System.Windows.Forms.TextBox();
            this.label_EUR = new System.Windows.Forms.Label();
            this.textBox_EUR = new System.Windows.Forms.TextBox();
            this.chart_Prices = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel_Main.SuspendLayout();
            this.tableLayoutPanel_TopPanel.SuspendLayout();
            this.tableLayoutPanel_InputsLabels.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Prices)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel_Main
            // 
            this.tableLayoutPanel_Main.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel_Main.ColumnCount = 1;
            this.tableLayoutPanel_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_Main.Controls.Add(this.tableLayoutPanel_TopPanel, 0, 0);
            this.tableLayoutPanel_Main.Controls.Add(this.chart_Prices, 0, 1);
            this.tableLayoutPanel_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Main.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel_Main.Name = "tableLayoutPanel_Main";
            this.tableLayoutPanel_Main.RowCount = 2;
            this.tableLayoutPanel_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.65505F));
            this.tableLayoutPanel_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 73.34495F));
            this.tableLayoutPanel_Main.Size = new System.Drawing.Size(1064, 575);
            this.tableLayoutPanel_Main.TabIndex = 0;
            // 
            // tableLayoutPanel_TopPanel
            // 
            this.tableLayoutPanel_TopPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel_TopPanel.ColumnCount = 2;
            this.tableLayoutPanel_TopPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel_TopPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel_TopPanel.Controls.Add(this.tableLayoutPanel_InputsLabels, 0, 0);
            this.tableLayoutPanel_TopPanel.Controls.Add(this.button_StartStop, 1, 0);
            this.tableLayoutPanel_TopPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_TopPanel.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel_TopPanel.Name = "tableLayoutPanel_TopPanel";
            this.tableLayoutPanel_TopPanel.RowCount = 1;
            this.tableLayoutPanel_TopPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_TopPanel.Size = new System.Drawing.Size(1056, 146);
            this.tableLayoutPanel_TopPanel.TabIndex = 0;
            // 
            // tableLayoutPanel_InputsLabels
            // 
            this.tableLayoutPanel_InputsLabels.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel_InputsLabels.ColumnCount = 2;
            this.tableLayoutPanel_InputsLabels.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_InputsLabels.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_InputsLabels.Controls.Add(this.textBox_EUR, 1, 1);
            this.tableLayoutPanel_InputsLabels.Controls.Add(this.label_EUR, 0, 1);
            this.tableLayoutPanel_InputsLabels.Controls.Add(this.label_USD, 0, 0);
            this.tableLayoutPanel_InputsLabels.Controls.Add(this.textBox_USD, 1, 0);
            this.tableLayoutPanel_InputsLabels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_InputsLabels.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel_InputsLabels.Name = "tableLayoutPanel_InputsLabels";
            this.tableLayoutPanel_InputsLabels.RowCount = 2;
            this.tableLayoutPanel_InputsLabels.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_InputsLabels.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_InputsLabels.Size = new System.Drawing.Size(415, 138);
            this.tableLayoutPanel_InputsLabels.TabIndex = 0;
            // 
            // button_StartStop
            // 
            this.button_StartStop.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button_StartStop.AutoSize = true;
            this.button_StartStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_StartStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_StartStop.Location = new System.Drawing.Point(844, 52);
            this.button_StartStop.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.button_StartStop.Name = "button_StartStop";
            this.button_StartStop.Size = new System.Drawing.Size(201, 42);
            this.button_StartStop.TabIndex = 1;
            this.button_StartStop.Text = "Старт / Стоп";
            this.button_StartStop.UseVisualStyleBackColor = true;
            this.button_StartStop.Click += new System.EventHandler(this.button_StartStop_Click);
            // 
            // label_USD
            // 
            this.label_USD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_USD.AutoSize = true;
            this.label_USD.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_USD.Location = new System.Drawing.Point(72, 20);
            this.label_USD.Name = "label_USD";
            this.label_USD.Size = new System.Drawing.Size(63, 29);
            this.label_USD.TabIndex = 0;
            this.label_USD.Text = "USD";
            // 
            // textBox_USD
            // 
            this.textBox_USD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_USD.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_USD.Location = new System.Drawing.Point(261, 17);
            this.textBox_USD.Name = "textBox_USD";
            this.textBox_USD.Size = new System.Drawing.Size(100, 34);
            this.textBox_USD.TabIndex = 1;
            this.textBox_USD.Text = "80,89";
            // 
            // label_EUR
            // 
            this.label_EUR.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_EUR.AutoSize = true;
            this.label_EUR.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_EUR.Location = new System.Drawing.Point(72, 88);
            this.label_EUR.Name = "label_EUR";
            this.label_EUR.Size = new System.Drawing.Size(63, 29);
            this.label_EUR.TabIndex = 2;
            this.label_EUR.Text = "EUR";
            // 
            // textBox_EUR
            // 
            this.textBox_EUR.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_EUR.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_EUR.Location = new System.Drawing.Point(261, 86);
            this.textBox_EUR.Name = "textBox_EUR";
            this.textBox_EUR.Size = new System.Drawing.Size(100, 34);
            this.textBox_EUR.TabIndex = 3;
            this.textBox_EUR.Text = "90,11";
            // 
            // chart_Prices
            // 
            chartArea1.Name = "ChartArea1";
            this.chart_Prices.ChartAreas.Add(chartArea1);
            this.chart_Prices.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend_USD_EUR";
            this.chart_Prices.Legends.Add(legend1);
            this.chart_Prices.Location = new System.Drawing.Point(4, 157);
            this.chart_Prices.Name = "chart_Prices";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            series1.Legend = "Legend_USD_EUR";
            series1.MarkerSize = 10;
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series1.Name = "USD";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            series2.Legend = "Legend_USD_EUR";
            series2.MarkerSize = 10;
            series2.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series2.Name = "EUR";
            this.chart_Prices.Series.Add(series1);
            this.chart_Prices.Series.Add(series2);
            this.chart_Prices.Size = new System.Drawing.Size(1056, 414);
            this.chart_Prices.TabIndex = 1;
            this.chart_Prices.Text = "chart1";
            // 
            // timer
            // 
            this.timer.Interval = 250;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 575);
            this.Controls.Add(this.tableLayoutPanel_Main);
            this.Name = "Form_Main";
            this.Text = "PriceSimulation";
            this.tableLayoutPanel_Main.ResumeLayout(false);
            this.tableLayoutPanel_TopPanel.ResumeLayout(false);
            this.tableLayoutPanel_TopPanel.PerformLayout();
            this.tableLayoutPanel_InputsLabels.ResumeLayout(false);
            this.tableLayoutPanel_InputsLabels.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Prices)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Main;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_TopPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_InputsLabels;
        private System.Windows.Forms.Button button_StartStop;
        private System.Windows.Forms.Label label_USD;
        private System.Windows.Forms.TextBox textBox_USD;
        private System.Windows.Forms.Label label_EUR;
        private System.Windows.Forms.TextBox textBox_EUR;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_Prices;
        private System.Windows.Forms.Timer timer;
    }
}

