using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Line
    {

        public Point diemdau;
        public Point diemcuoi;
        public Color mau=Color.Red;
        public double hesogoc, b1;
        public int b;

        public Point getdiemdau()
        {
            return this.diemdau;
        }

        public Point getdiemcuoi()
        {
            return this.diemcuoi;
        }

        public void setdiemcuoi(Point a)
        {
          
            this.diemcuoi = a;

        }
        public void setdiemdau(Point a)
        {
          
            this.diemdau = a;
        }
        public Color getmau()
        {
            return this.mau;
        }

        public void setmau(Color a)
        {
            this.mau = a;

        }
        public Line()
        {

        }

        public Line(int x1, int y1, int x2, int y2, Color m)
        {
            diemdau = new Point(x1, y1);
            diemcuoi = new Point(x2, y2);
            mau = m;
        }
        private void putpixel(int x, int y, Graphics grfx)
        {
            if (x < 0 || x > 1000 || y < 0 || y > 1000) return;
            Pen p = new Pen(Color.Red);
            SolidBrush b = new SolidBrush(mau);
            grfx.FillRectangle(b,x,y,3,3);
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
        public void DDA_Line(Graphics g) // Ve duong thang co dinh dang mau
        {
            Color m = mau;
            int Dx, Dy, count, temp_1, temp_2, dem = 1;
            //int temp_3, temp_4;
            Dx = diemcuoi.X - diemdau.X;
            Dy = diemcuoi.Y - diemdau.Y;
            if (Math.Abs(Dy) > Math.Abs(Dx)) count = Math.Abs(Dy);
            else count = Math.Abs(Dx);
            float x, y, delta_X, delta_Y;
            if (count > 0)
            {
                delta_X = Dx;
                delta_X /= count;
                delta_Y = Dy;
                delta_Y /= count;
                x = diemdau.X;
                y = diemdau.Y;
                do
                {
                    temp_1 = round(x);
                    temp_2 = round(y);
                    putpixel(temp_1, temp_2, g);
                    // temp_3 = temp_1;
                    // temp_4 = temp_2;
                    x += delta_X;
                    y += delta_Y;
                    --count;
                    dem++;
                } while (count != -1);

            }
        }
        public void DDA_Line_NetDut(Graphics g) // Ve duong thang co dinh dang mau
        {
            Color m = mau;
            int Dx, Dy, count, temp_1, temp_2, dem = 1;
            Dx = diemcuoi.X - diemdau.X;
            Dy = diemcuoi.Y - diemdau.Y;
            if (Math.Abs(Dy) > Math.Abs(Dx)) count = Math.Abs(Dy);
            else count = Math.Abs(Dx);
            float x, y, delta_X, delta_Y;
            if (count > 0)
            {
                delta_X = Dx;
                delta_X /= count;
                delta_Y = Dy;
                delta_Y /= count;
                x = diemdau.X;
                y = diemdau.Y;
                do
                {

                    temp_1 = round(x);
                    temp_2 = round(y);

                    putpixel1(temp_1, temp_2, g);

                    x += delta_X;
                    y += delta_Y;
                    --count;
                    dem++;
                } while (count != -1);

            }
        }
        private void putpixel1(int x, int y, Graphics grfx)
        {
            if (x < 0 || x > 750|| y < 0 || y > 500) return;
            Pen p = new Pen(Color.Red);
            SolidBrush b = new SolidBrush(Color.Red);
            grfx.DrawEllipse(p, x, y, 1, 1);

        }
        
        public static Point toado1(int x, int y)//lon ra nho
        {
            return (new Point(x / 5 - 40, 40 - y / 5));//voi x va y deu chia het cho 5
        }
        public static Point toado2(int x, int y)//nho ra lon
        {

            return (new Point(x * 5 + 200, 200 - 5 * y));
        }
    }
}
