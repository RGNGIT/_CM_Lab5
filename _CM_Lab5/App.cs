using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _CM_Lab5
{
    public partial class App : Form
    {
        public App()
        {
            InitializeComponent();
            chart.Series.Clear();
        }

        void ChartSetter()
        {
            chart.Series.Clear();
            chart.Titles.Clear();
            chart.Titles.Add($"Скорость сходимости::{tabControl.SelectedTab.Text}");
        }

        List<List<double>> Mtr = new List<List<double>>() 
        {
            new List<double> {1, 1, 1, 1, 1},
            new List<double> {1, 2, 0.1, 0.5, -0.43},
            new List<double> {1, 0.1, 1, 0.2, -0.3},
            new List<double> {1, 0.5, 0.2, 2, 0.3},
            new List<double> {1, -0.43, -0.3, 0.3, 1}
        };

        List<double> Epsilon = new List<double>()
        {
            0.001,
            0.0001,
            0.00001,
            0.000001,
            0.0000001,
            0.00000001,
            0.000000001
        };

        private void buttonDeg_Click(object sender, EventArgs e)
        {
            ChartSetter();
            listBoxDeg.Items.Clear();
            foreach (var i in Epsilon)
            {
                int k = 1;
                listBoxDeg.Items.Add($"/// Точность: {i} ///");
                chart.Series.Add($"Точность {i}");
                foreach (var j in new DegreeMethod(Mtr, i).GetIterRes)
                {
                    listBoxDeg.Items.Add($"Итерация {k}. Значение: {j}");
                    k++;
                }
                chart.Series[$"Точность {i}"].Points.AddY(k);
            }
        }
    }
}
