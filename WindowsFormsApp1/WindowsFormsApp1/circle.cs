using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApp1
{
    class circle
    {
        public int bkinh;
        public Point tam;
        public Color mau;
        public int b;

        public Point getdiemdau()
        {
            return this.tam;
        }
        public void setdiemcuoi(Point a)
        {
            this.tam = a;

        }
        public void gettt(int x,int y,int r)
        {
            tam = new Point(x, y);
            bkinh = r;
        }
        public circle(int x1, int y1, int r)
        {
            tam = new Point(x1, y1);
            bkinh = r;

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



        private void put8pitxel(int x, int y, int cx, int cy, Graphics m)
        {
            putpixel(cx + x, cy + y, m);
            putpixel(cx + x, cy - y, m);
            putpixel(cx - x, cy + y, m);
            putpixel(cx - x, cy - y, m);
            putpixel(cx + y, cy + x, m);
            putpixel(cx + y, cy - x, m);
            putpixel(cx - y, cy + x, m);
            putpixel(cx - y, cy - x, m);
        }
        public int round(double tds)
        {
            int tdm;
            double sodu = tds % 1;
            if (sodu != 0)
            {
                if (sodu >= 3) tdm = (int)(tds + 5 - sodu);
                else tdm = (int)(tds - sodu);
            }
            else tdm = (int)tds;
            if (tdm > 750) tdm = 750;
            return tdm;
        }

        public void drawC(Graphics g)
        {
            int x, y, cx, cy, p, R;
            Color m = this.mau;
            cx = this.tam.X; cy = this.tam.Y;
            x = 0;
            y = R = this.bkinh;
            int maxX = round((float)(Math.Sqrt(2) / 2 * R));
            // int maxX = Math.Sqrt(2) / 2 * R;
            p = 1 - R;
            put8pitxel(x, y, cx, cy, g);
            while (x <= maxX)
            {
                if (p < 0) p += 2 * x + 3;
                else { p += 2 * (x - y) + 5; y -= 5; }
                x += 5;
                put8pitxel(x, y, cx, cy, g);
            }

        }
        
    }
}
