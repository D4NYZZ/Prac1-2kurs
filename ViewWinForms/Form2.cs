using BusinessLogic;
using Microsoft.VisualBasic.Logging;
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

namespace ViewWinForms
{
    public partial class Form2 : Form
    {
        public Logic _logic;
        public Form2(Logic logic)
        {
            this._logic = logic;
            InitializeComponent();
        }

        /// <summary>
        /// Метод выводит гистограмму
        /// </summary>
        private void Form2_Load(object sender, EventArgs e)
        {
            var specialityDistribution = _logic.GetSpecialityDistribution();
            List<string> specialities = specialityDistribution.Keys.ToList();
            List<int> counts = specialityDistribution.Values.ToList();

            chart1.Palette = ChartColorPalette.Chocolate;

            chart1.Titles.Add("Распределение студентов по направлениям");
            chart1.Series.Clear();
            for (int i = 0; i < specialities.Count; i++)
            {
                Series series = chart1.Series.Add(specialities[i]);

                series.Points.Add(counts[i]);
            }


        }
    }
}
