using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form3D : Form
    {
        Graphics g;
        Point mouse;
        int i = 0;
        Point[] diem = new Point[50];
        int hinh = -1;
        public Pen p = new Pen(Color.Black);
        public SolidBrush brush = new SolidBrush(Color.Black);
        public Form3D()
        {
            InitializeComponent();
        }

        private void button3_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
            g = this.panel1.CreateGraphics();

            //ve truc toa do
            g.DrawLine(new Pen(Color.Red), 275, 325, 750, 325);
            g.DrawLine(new Pen(Color.Red), 275, 0, 275, 325);
            g.DrawLine(new Pen(Color.Red), 0, 500, 275, 325);

            //ve vien
            g.DrawLine(new Pen(Color.Black), 0, 0, 0, 500);//trai
            g.DrawLine(new Pen(Color.Black), 0, 0, 750, 0);//tren
            g.DrawLine(new Pen(Color.Black), 0, 499, 750, 499);//duoi
            g.DrawLine(new Pen(Color.Black), 749, 0, 749, 499);//phai
            
        }
        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            if (hinh == -1)
            {
                MessageBox.Show("Chọn hình để vẽ trước");
                this.Refresh();
                return;
            }
            mouse.X -= 179;
            mouse.Y -= 152;
            int a = mouse.X - 375;
            int b = mouse.Y - 250;
            g.FillRectangle(brush, mouse.X, mouse.Y, 3, 3);
            diem[i] = new Point(a + 375, b + 250);
            
            //duong thang
            
            //ve hinh binh hanh
            if (hinh == 0)
            {
                int temp = i + 1;
                if (i > 0)
                {

                    if (temp % 4 == 0)
                    {
                        //ve hinh thang mat tren cua hinh hop
                        Line AB = new Line(0, 0, 0, 0, Color.Black);
                        Line BC = new Line(0, 0, 0, 0, Color.Black);
                        Line CD = new Line(0, 0, 0, 0, Color.Black);
                        Line DA = new Line(0, 0, 0, 0, Color.Black);
                        Point D = new Point();
                        D.X = diem[i - 2].X;
                        D.Y = diem[i - 3].Y;
                        Point C = new Point();
                        C.X = diem[i-1].X - (diem[i - 3].X - diem[i - 2].X);
                        C.Y = diem[i-1].Y;
                        AB.setdiemdau(diem[i - 3]);
                        AB.setdiemcuoi(diem[i-1]);
                        BC.setdiemdau(diem[i-1]);
                        BC.setdiemcuoi(C);
                        CD.setdiemdau(C);
                        CD.setdiemcuoi(D);
                        DA.setdiemdau(D);
                        DA.setdiemcuoi(diem[i - 3]);
                        AB.DDA_Line(this.panel1.CreateGraphics());
                        BC.DDA_Line(this.panel1.CreateGraphics());
                        CD.DDA_Line(this.panel1.CreateGraphics());
                        DA.DDA_Line(this.panel1.CreateGraphics());

                       // ve hinh thang mat day hop
                        Line EF = new Line(0, 0, 0, 0, Color.Black);
                        Line FG = new Line(0, 0, 0, 0, Color.Black);
                        Line GH = new Line(0, 0, 0, 0, Color.Black);
                        Line HE = new Line(0, 0, 0, 0, Color.Black);
                        Point E = new Point();
                        E.X = diem[i - 3].X;
                        E.Y = diem[i].Y;
                        Point F = new Point();
                        F.X = diem[i-1].X;
                        F.Y = C.Y - (diem[i - 3].Y - E.Y);
                        Point G = new Point();
                        G.X = C.X;
                        G.Y = C.Y-(diem[i-3].Y-E.Y);
                        Point H = new Point();
                        H.X = D.X;
                        H.Y = diem[i].Y;
                        EF.setdiemdau(E);
                        EF.setdiemcuoi(F);
                        FG.setdiemdau(F);
                        FG.setdiemcuoi(G);
                        GH.setdiemdau(G);
                        GH.setdiemcuoi(H);
                        HE.setdiemdau(H);
                        HE.setdiemcuoi(E);
                        EF.DDA_Line(this.panel1.CreateGraphics());
                        FG.DDA_Line(this.panel1.CreateGraphics());
                        GH.DDA_Line_NetDut(this.panel1.CreateGraphics());
                        HE.DDA_Line_NetDut(this.panel1.CreateGraphics());
                        //noi 2 hinh nop lai voi nhau 
                        Line AE = new Line(diem[i-3].X, diem[i-3].Y, E.X, E.Y, Color.Black);
                        Line BF = new Line(diem[i-1].X, diem[i-1].Y, F.X, F.Y, Color.Black);
                        Line CG = new Line(C.X, C.Y, G.X, G.Y, Color.Black);
                        Line DH = new Line(D.X, D.Y, H.X, H.Y, Color.Black);
                        AE.DDA_Line(this.panel1.CreateGraphics());
                        BF.DDA_Line(this.panel1.CreateGraphics());
                        CG.DDA_Line(this.panel1.CreateGraphics());
                        DH.DDA_Line_NetDut(this.panel1.CreateGraphics());


                    }
                }
            }
            //ve hinh cau
            else if(hinh==1)
            {
                if (i > 0)
                {
                    if (i % 2 != 0)
                    {
                        int r = Math.Abs(diem[i].X - diem[i - 1].X);
                        circle tr = new circle(diem[i].X, diem[i].Y, r);
                        tr.drawC(g);
                        elipse elip = new elipse(diem[i],r, r/2);
                        elip.Midpoint_elipse1(g);
                    }
                }
            }
            i++;
        }
        private void hinhhop_Click(object sender, EventArgs e)
        {
            hinh = 0;
            i = 0;
        }
       

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            mouse = this.PointToClient(Cursor.Position);
            int a = mouse.X - 527 - 27;
            int b = -mouse.Y + 399 + 3;
            
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            panel1.Refresh();
            i = 0;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hinh = 1;
            i = 0;
        }
    }
}
