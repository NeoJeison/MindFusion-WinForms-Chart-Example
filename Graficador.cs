using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

using MindFusion.Charting.WinForms;
using MindFusion.Charting;
using MindFusion.Charting.Components;

namespace Graficador
{
    class Graficador
    {
        public static readonly string RUTA = "D:/Image.jpg";
        public static readonly string NOMBRE_EJE_X = "# Elements";
        public static readonly string NOMBRE_EJE_Y = "Distance (m)";
        public static readonly int ANCHO = 1400;
        public static readonly int ALTO = 900;

        private LineChart chart;

        public Graficador()
        {
            chart = new LineChart();
            chart.XAxis.Title = NOMBRE_EJE_X;
            chart.YAxis.Title = NOMBRE_EJE_Y;
            chart.Theme = new Theme();
            chart.Theme.CommonSeriesFills = chart.Theme.CommonSeriesStrokes = new List<MindFusion.Drawing.Brush>
            {
                new MindFusion.Drawing.SolidBrush(Color.Orange),
                new MindFusion.Drawing.SolidBrush(Color.Purple),
                new MindFusion.Drawing.SolidBrush(Color.Green),
                new MindFusion.Drawing.SolidBrush(Color.Blue),
                new MindFusion.Drawing.SolidBrush(Color.Red)
            };
            chart.GridType = GridType.Horizontal;
            chart.Theme.GridLineColor = Color.White;
            chart.Theme.GridColor1 = Color.White;
            chart.Theme.GridColor2 = Color.White;
            chart.ShowLegendTitle = false;
            chart.Width = ANCHO;
            chart.Height = ALTO;
            chart.LegendHorizontalAlignment = LayoutAlignment.Center;
            chart.LegendVerticalAlignment = LayoutAlignment.Near;
        }

        public void AgregarSerie(string nombreSerie, IList<double> listaX, IList<double> listaY)
        {
            Series2D serie = new Series2D(listaX, listaY, null);
            serie.Title = nombreSerie;
            chart.Series.Add(serie);
        }

        public void GuardarGrafica()
        {
            chart.CreateImage();
            chart.ExportImage(RUTA);
        }

    }
}
