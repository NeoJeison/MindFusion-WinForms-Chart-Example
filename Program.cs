using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graficador
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] xs = { 0.0, 1.0, 2.0, 3.0, 4.0 };
            double[] ys = { 3.34, 3.29, 2.5, 2.25, 1, 8 };

            double[] xz = { 0.0, 1.0, 2.0, 3.0, 4.0 };
            double[] yz = { 3.47, 2.73, 2.8, 2.32, 1.8 };

            double[] xc = { 0.0, 1.0, 2.0, 3.0, 4.0 };
            double[] yc = { 3.4, 3.25, 2.75, 2.25, 1.82 };

            Graficador graficador = new Graficador();

            graficador.AgregarSerie("Left", xs, ys);
            graficador.AgregarSerie("Right", xz, yz);
            graficador.AgregarSerie("Center", xc, yc);
            graficador.GuardarGrafica();
            //Console.ReadKey();
        }
    }
}
