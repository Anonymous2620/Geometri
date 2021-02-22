using System;
using System.Collections.Generic;
using System.Text;

namespace Geometri
{
    public class Square
    {
        private double Side { get; set; }
        public Square(double a)
        {
            this.Side = a;
        }


        public double CPerimeter()
        {
            return 4 * Side;
        }
        //Her ganger jeg med 4 fordi når man har en kvadrat. Finder man omkreds ved at gange antallet af sider med et af siderne.

        public double CArea()
        {
            return Side * Side;
        }
        //Her ganger jeg tallet med sig selv da det er en og alle sider er lige lange.
    }
}
