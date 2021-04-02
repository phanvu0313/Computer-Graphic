using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApp1
{
    class elipse
    {
        public Point tam; 
        public int a, b;
        public double p;

        public elipse(Point tam, int a, int b)
        {
            this.tam = tam;
            this.a = Math.Abs(a);
            this.b = Math.Abs(b);
            this.p = b * b - a * a * b + a * a / 4;

        }
        private void putpixel(int x, int y, Graphics grfx)
        {
            if (x < 0 || x > 750 || y < 0 || y > 500) return;
            Pen p = new Pen(Color.Red);
            SolidBrush b = new SolidBrush(Color.Red);
            grfx.FillRectangle(b, x, y, 3, 3);
            grfx.FillRectangle(b, x - 1, y - 1, 3, 3);
            grfx.FillRectangle(b, x, y - 1, 3, 3);
            grfx.FillRectangle(b, x - 1, y, 3, 3);


        }
      
        public int round(double tds)
        {
            int tdm;
            double sodu = tds % 3;
            if (sodu != 0)
            {
                if (sodu >= 3) tdm = (int)(tds + 5 - sodu);
                else tdm = (int)(tds - sodu);
            }
            else tdm = (int)tds;
            if (tdm > 750) tdm = 750;
            return tdm;
        }
        private void putpixel1(int x, int y, Graphics grfx)
        {
            if (x < 0 || x > 750 || y < 0 || y > 500) return;
            Pen p = new Pen(Color.Red);
            SolidBrush b = new SolidBrush(Color.Red);
            grfx.DrawEllipse(p, x, y, 2, 2);

        }
        private void put4pitxel(int x, int y, int cx, int cy, Graphics m)
        {
            putpixel(x + cx, y + cy, m);
            putpixel(-x + cx, y + cy, m);
            putpixel(x + cx, -y + cy, m);
            putpixel(-x + cx, -y + cy, m);
        }
        private void put4pitxel1(int x, int y, int cx, int cy, Graphics m)
        {
            putpixel(x + cx, y + cy, m);
            putpixel(-x + cx, y + cy, m);
            putpixel1(x + cx, -y + cy, m);
            putpixel1(-x + cx, -y + cy, m);
        }
        public void Midpoint_elipse(Graphics g)
        {
            int x, y, cx, cy, a, b;
            cx = tam.X; cy = tam.Y;
            a = this.a; b = this.b;

            x = 0; y = b;
            int A, B;
            A = a * a;
            B = b * b;
            double p = B + A / 4 - A * b;
            x = 0;
            y = b;
            int Dx = 0;
            int Dy = 2 * A * y;
            put4pitxel(x, y, cx, cy, g);

            while (Dx < Dy)
            {
                x++;
                Dx += 2 * B;
                if (p < 0)
                    p = p + 2 * b * b * x + b * b;
                else
                {
                    y--;
                    Dy -= 2 * A;
                    p = p + 2 * b * b * x - 2 * a * a * y - b * b;
                }
                put4pitxel(round(x), round(y), cx, cy, g);
            }
            p = B * (x + 0.5) * (x + 0.5) + A * (y - 1) * (y - 1) - A * B;
            while (y > 0)
            {
                y--;
                Dy -= A * 2;
                if (p > 0)
                    p += A - Dy;
                else
                {
                    x++;
                    Dx += B * 2;
                    p += A - Dy + Dx;
                }
                 put4pitxel(round(x), round(y), cx, cy, g);

            }

        }
        public void Midpoint_elipse1(Graphics g)
        {
            int x, y, cx, cy, a, b;
            cx = tam.X; cy = tam.Y;
            a = this.a; b = this.b;

            x = 0; y = b;
            int A, B;
            A = a * a;
            B = b * b;
            double p = B + A / 4 - A * b;
            x = 0;
            y = b;
            int Dx = 0;
            int Dy = 2 * A * y;
            put4pitxel1(x, y, cx, cy, g);

            while (Dx < Dy)
            {
                x++;
                Dx += 2 * B;
                if (p < 0)
                    p = p + 2 * b * b * x + b * b;
                else
                {
                    y--;
                    Dy -= 2 * A;
                    p = p + 2 * b * b * x - 2 * a * a * y - b * b;
                }
                put4pitxel1(round(x), round(y), cx, cy, g);

            }
            p = B * (x + 0.5) * (x + 0.5) + A * (y - 1) * (y - 1) - A * B;
            while (y > 0)
            {
                y--;
                Dy -= A * 2;
                if (p > 0)
                    p += A - Dy;
                else
                {
                    x++;
                    Dx += B * 2;
                    p += A - Dy + Dx;
                }
                put4pitxel1(round(x), round(y), cx, cy, g);

            }

        }
        //public void Midpoint_elipse(Graphics g)
        //{
        //    int x, y, cx, cy;
        //    cx = tam.X; cy = tam.Y;
        //    x = 0;
        //    y = cy;

        //    put4pitxel(x, y, cx, cy, g);

        //    while (2.0 * b * b * x <= 2.0 * b * b * y)
        //    {
        //        if (p < 0)
        //        {
        //            x++;
        //            p = p + 2 * b * b * x + b * b;
        //        }
        //        else
        //        {
        //            x++; y--;
        //            p = p + 2 * b * b * x - 2 * a * a * y - b * b;
        //        }
        //        put4pitxel(x, y, cx, cy,g);
        //    }
        //    p = b * b * (x + 0.5) * (x + 0.5) + a * a * (y - 1) * (y - 1) - a * a * b * b;
        //    while (y > 0)
        //    {

        //        if (p <= 0)
        //        {
        //            x++; y--;
        //            p = p + 2 * b * b * x - 2 * a * a * y + a * a;
        //        }
        //        else
        //        {
        //            y--;
        //            p = p - 2 * a * a * y + a * a;
        //        }
        //        put4pitxel(x, y, cx, cy, g);
        //    }

        //}
    }
}
