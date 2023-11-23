using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace chart_from_a_list
{
    public partial class Form1 : Form
    {       

        public Form1()
        {
            InitializeComponent();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {

            // Create a list with sample data
            List<KeyValuePair<string, int>> dataPoints = new List<KeyValuePair<string, int>>
            {
                new KeyValuePair<string, int>("2018", 1320),
                new KeyValuePair<string, int>("2019", 1392),
                new KeyValuePair<string, int>("2020", 1735),
                new KeyValuePair<string, int>("2021", 1218),
                new KeyValuePair<string, int>("2022", 1320)
            };

            // Create a series
            Series series = new Series("Average rainfall in mm");
            series.ChartType = SeriesChartType.Column; // Choose the chart type (Column, Bar, Line, etc.)

            // Bind the series to the list
            foreach (var dataPoint in dataPoints)
            {
                series.Points.AddXY(dataPoint.Key, dataPoint.Value);
            }

            // Add the series to the chart
            chart1.Series.Add(series);

            // Customize chart appearance if needed
            chart1.ChartAreas[0].AxisX.Title = "Year";
            chart1.ChartAreas[0].AxisY.Title = "Rainfall in mm";

        }
    }
}
