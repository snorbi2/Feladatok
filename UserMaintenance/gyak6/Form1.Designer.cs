namespace gyak6
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartRateData = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.getExchangeRatesResponseBodyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chartRateData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getExchangeRatesResponseBodyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // chartRateData
            // 
            chartArea1.Name = "ChartArea1";
            this.chartRateData.ChartAreas.Add(chartArea1);
            this.chartRateData.DataSource = this.getExchangeRatesResponseBodyBindingSource;
            legend1.Name = "Legend1";
            this.chartRateData.Legends.Add(legend1);
            this.chartRateData.Location = new System.Drawing.Point(112, 67);
            this.chartRateData.Name = "chartRateData";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartRateData.Series.Add(series1);
            this.chartRateData.Size = new System.Drawing.Size(585, 319);
            this.chartRateData.TabIndex = 0;
            this.chartRateData.Text = "chart1";
            // 
            // getExchangeRatesResponseBodyBindingSource
            // 
            this.getExchangeRatesResponseBodyBindingSource.DataSource = typeof(gyak6.MnbServiceReference.GetExchangeRatesResponseBody);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chartRateData);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chartRateData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getExchangeRatesResponseBodyBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartRateData;
        private System.Windows.Forms.BindingSource getExchangeRatesResponseBodyBindingSource;
    }
}

