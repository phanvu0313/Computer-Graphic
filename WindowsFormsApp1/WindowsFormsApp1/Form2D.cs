using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2D : Form
    {
        Line AB = new Line(0, 0, 0, 0, Color.Black);
        Line BC = new Line(0, 0, 0, 0, Color.Black);
        Line CD = new Line(0, 0, 0, 0, Color.Black);
        Line DA = new Line(0, 0, 0, 0, Color.Black);
        Line CA = new Line(0, 0, 0, 0, Color.Black);
        Point tam = new Point();
        Point ss = new Point();
        Point mm = new Point();
        Point hh = new Point();
        Line ls = new Line();
        Line lm = new Line();
        Line lh = new Line();
        
        Graphics g;
        Boolean checkve = false;
        Point mouse;
        int i = 0;
        int r;
        Point[] diem = new Point[50];
        int hinh = -1;
        public Form2D()
        {

            InitializeComponent();
        }
        private void screen1_Paint(object sender, PaintEventArgs e)
        {
            g = this.screen1.CreateGraphics();

            //ve truc toa do
            g.DrawLine(new Pen(Color.Red), 0, 250, 750, 250);
            g.DrawLine(new Pen(Color.Red), 375, 0, 375, 500);
            //ve vien
            g.DrawLine(new Pen(Color.Black), 0, 0, 0, 500);//trai
            g.DrawLine(new Pen(Color.Black), 0, 0, 750, 0);//tren
            g.DrawLine(new Pen(Color.Black), 0, 499, 750, 499);//duoi
            g.DrawLine(new Pen(Color.Black), 749, 0, 749, 499);//phai
            if (checkve==true)
            {
                r = Math.Abs(220 );
                
                circle ax = new circle(375,250, r);
                ax.drawC(g);
                g.DrawString("12", new Font("Arial", 12), Brushes.Black, 375, 40);

                g.DrawString("3", new Font("Arial", 12), Brushes.Black, 575, 250);

                g.DrawString("6", new Font("Arial", 12), Brushes.Black, 375, 440);

                g.DrawString("9", new Font("Arial", 12), Brushes.Black, 175, 250);
            }
        }
        
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                for (int i = 0; i <= 750; i++)
                {
                    g.DrawLine(new Pen(Color.White), 5 * i, 0, 5 * i, 500);
                }
                for (int i = 0; i <= 500; i++)
                {
                    g.DrawLine(new Pen(Color.White), 0, 5 * i, 750, 5 * i);
                }
                g.DrawLine(new Pen(Color.Red), 0, 250, 750, 250);
                g.DrawLine(new Pen(Color.Red), 375, 0, 375, 500);
                g.DrawLine(new Pen(Color.Black), 0, 0, 0, 500);//trai
                g.DrawLine(new Pen(Color.Black), 0, 0, 750, 0);//tren
                g.DrawLine(new Pen(Color.Black), 0, 499, 750, 499);//duoi
                g.DrawLine(new Pen(Color.Black), 749, 0, 749, 499);//phai
            }
            else
            {
                screen1.Refresh();
            }

        }
        //khai bao
        public Pen p = new Pen(Color.Black);
        public SolidBrush brush = new SolidBrush(Color.Black);
        private void drawLine_Click(object sender, EventArgs e)
        {
            i = 0;
            hinh = 0;
        }


        //hien thi toa do cua chuot
        private void showPos(object sender, MouseEventArgs e)
        {
            mouse = this.PointToClient(Cursor.Position);
            int a = mouse.X - 527 - 27;
            int b = -mouse.Y + 399 + 3;
            mousePos.Text = "X: " + a + " Y:" + b;
        }
        // 
        private void screen1_MouseClick(object sender, MouseEventArgs e)
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
            listBox1.Items.Add(i + "        :   x:  " + a + "  y: " + (-b));
            //duong thang
            if (hinh == 0)
            {
                //int temp = i + 1;
                if (i%2 != 0)
                {
                    this.veduongthang();
                }

            }
            //hinh chu nhat
            else if (hinh == 1)
            {
                if (i > 0)
                {
                    //AB,BC,CD,DA gia su co A vaf C la hai diem dc chon  diem 0 va 1 la A va C
                    if (i % 2 != 0)
                    {

                        this.vehinhchunhat();
                    }
                }
            }
            //ve hinh binh hanh
            else if (hinh == 2)
            {
                int temp = i + 1;
                if (i > 0)
                {

                    if (temp % 3 == 0)
                    {
                        this.vehinhbinhhanh();
                    }
                }
            }
            //ve hinh tron
            else if (hinh == 3)
            {
                if (i > 0)
                {
                    if (i % 2 != 0)
                    {
                        this.vehinhtron();
                    }
                }
            }
            //hinh elipse 
            else if (hinh == 4)
            {
                int temp = i + 1;
                if (i > 0)
                {

                    if (temp % 3 == 0)
                    {
                        this.vehinhelipse();
                    }
                }
            }
            //ve hinh tam giac
            else if (hinh == 5)
            {
                int temp = i + 1;
                if (i > 0)
                {

                    if (temp % 3 == 0)
                    {
                        this.vehinhtamgiac();
                    }
                }
            }
            i++;
        }
        private void veduongthang()
        {
           
            AB.setdiemdau(diem[i - 1]);
            AB.setdiemcuoi(diem[i]);
            AB.DDA_Line(this.screen1.CreateGraphics());
            listBox2.Items.Add("Đoạn thẳng  ");
            listBox2.Items.Add(" A       :   x:  " + (diem[i - 1].X - 375) + "  y: " + (250 - diem[i - 1].Y));
            listBox2.Items.Add(" B       :   x:  " + (diem[i].X - 375) + "  y: " + (250 - diem[i].Y));
            listBox2.Items.Add("---------------------------------------------------");
            
        }
        private void vehinhchunhat()
        {
            //AB,BC,CD,DA gia su co A vaf C la hai diem dc chon  diem 0 va 1 la A va C

            
            Point B = new Point();
            B.X = diem[i].X;
            B.Y = diem[i - 1].Y;
            Point D = new Point();
            D.X = diem[i - 1].X;
            D.Y = diem[i].Y;
            AB.setdiemdau(diem[i - 1]);
            AB.setdiemcuoi(B);
            BC.setdiemdau(B);
            BC.setdiemcuoi(diem[i]);
            CD.setdiemdau(diem[i]);
            CD.setdiemcuoi(D);
            DA.setdiemdau(D);
            DA.setdiemcuoi(diem[i - 1]);
            AB.DDA_Line(this.screen1.CreateGraphics());
            BC.DDA_Line(this.screen1.CreateGraphics());
            CD.DDA_Line(this.screen1.CreateGraphics());
            DA.DDA_Line(this.screen1.CreateGraphics());
            listBox2.Items.Add("Hình chữ nhật  ");
            listBox2.Items.Add(" A       :   x:  " + (diem[i - 1].X - 375) + "  y: " + (250 - diem[i - 1].Y));
            listBox2.Items.Add(" B       :   x:  " + (B.X - 375) + "  y: " + (250 - B.Y));
            listBox2.Items.Add(" C       :   x:  " + (diem[i].X - 375) + "  y: " + (250 - diem[i].Y));
            listBox2.Items.Add(" D       :   x:  " + (D.X - 375) + "  y: " + (250 - D.Y));
            listBox2.Items.Add("---------------------------------------------------");


        }
        private void vehinhbinhhanh()
        {

            
            Point D = new Point();
            D.X = diem[i - 1].X;
            D.Y = diem[i - 2].Y;
            Point C = new Point();
            C.X = diem[i ].X - (diem[i -2].X - diem[i - 1].X);
            C.Y = diem[i ].Y;
            AB.setdiemdau(diem[i -2]);
            AB.setdiemcuoi(diem[i ]);
            BC.setdiemdau(diem[i ]);
            BC.setdiemcuoi(C);
            CD.setdiemdau(C);
            CD.setdiemcuoi(D);
            DA.setdiemdau(D);
            DA.setdiemcuoi(diem[i - 2]);
            AB.DDA_Line(this.screen1.CreateGraphics());
            BC.DDA_Line(this.screen1.CreateGraphics());
            CD.DDA_Line(this.screen1.CreateGraphics());
            DA.DDA_Line(this.screen1.CreateGraphics());
            listBox2.Items.Add("Hình bình hành  ");
            listBox2.Items.Add(" A       :   x:  " + (diem[i - 2].X - 375) + "  y: " + (250 - diem[i - 2].Y));
            listBox2.Items.Add(" B       :   x:  " + (diem[i].X - 375) + "  y: " + (250 - diem[i].Y));
            listBox2.Items.Add(" C       :   x:  " + (C.X - 375) + "  y: " + (250 - C.Y));
            listBox2.Items.Add(" D       :   x:  " + (D.X - 375) + "  y: " + (250 - D.Y));
            listBox2.Items.Add("---------------------------------------------------");
        }
        private void vehinhtron()
        {
            AB.setdiemdau(diem [i-1]);
            AB.setdiemcuoi(diem[i]);
            r = Math.Abs(diem[i].X - diem[i - 1].X);
            circle tr = new circle(diem[i].X, diem[i].Y, r);
            tr.drawC(g);
            listBox2.Items.Add("Hình Tròn   ");
            listBox2.Items.Add(" Tâm O      :   x:  " + (diem[i].X - 375) + "  y: " + (250 - diem[i].Y));
            listBox2.Items.Add(" Bán kính r :  " + r);
            listBox2.Items.Add("---------------------------------------------------");
        }
        private void vehinhelipse()
        {
            AB.setdiemdau(diem[i-2]);
            AB.setdiemcuoi(diem[i - 1]);
            BC.setdiemcuoi(diem[i]);
            elipse elip = new elipse(diem[i - 2], (diem[i - 1].X - diem[i - 2].X), (diem[i].Y - diem[i - 2].Y));
            elip.Midpoint_elipse(g);
            listBox2.Items.Add("Hình elipse  ");
            listBox2.Items.Add(" Tâm         :   x:  " + (diem[i - 2].X - 375) + "  y: " + (250 - diem[i - 2].Y));
            listBox2.Items.Add("Bán kính Ox  :   " + (diem[i - 1].X - diem[i - 2].X));
            listBox2.Items.Add("Bán kính Oy  :   " + (diem[i].Y - diem[i - 2].Y));
            listBox2.Items.Add("---------------------------------------------------");
        }
        private void vehinhtamgiac()
        {
            
            
            AB.setdiemdau(diem[i - 2]);
            AB.setdiemcuoi(diem[i - 1]);
            BC.setdiemdau(diem[i - 1]);
            BC.setdiemcuoi(diem[i]);
            CA.setdiemdau(diem[i]);
            CA.setdiemcuoi(diem[i - 2]);
            AB.DDA_Line(this.screen1.CreateGraphics());
            BC.DDA_Line(this.screen1.CreateGraphics());
            CA.DDA_Line(this.screen1.CreateGraphics());
            listBox2.Items.Add("Hình tam giác  ");
            listBox2.Items.Add(" A       :   x:  " + (diem[i - 2].X - 375) + "  y: " + (250 - diem[i - 2].Y));
            listBox2.Items.Add(" B       :   x:  " + (diem[i - 1].X - 375) + "  y: " + (250 - diem[i - 1].Y));
            listBox2.Items.Add(" C       :   x:  " + (diem[i].X - 375) + "  y: " + (250 - diem[i].Y));
            listBox2.Items.Add("---------------------------------------------------");
        }
        //doi xung oy
        private void doiXungOy_Click_1(object sender, EventArgs e)
        {
            if (hinh == -1)
            {
                MessageBox.Show("Chưa vẽ hình ");
                this.Refresh();
                return;
            }
            //doi xung duong thang
            else if (hinh == 0)
            {
                Point tempA = new Point();
                Point tempB = new Point();
                tempA = AB.getdiemdau();
                tempB = AB.getdiemcuoi();

                tempA.X = 375 - (tempA.X - 375);
                tempB.X = 375 - (tempB.X - 375);
                AB.setdiemdau(tempA);
                AB.setdiemcuoi(tempB);
                screen1.Refresh();
                AB.DDA_Line(this.screen1.CreateGraphics());
                listBox2.Items.Add("toa do moi");
                listBox2.Items.Add(" A       :   x:  " + (tempA.X - 375) + "  y: " + (250 - tempA.Y));
                listBox2.Items.Add(" B       :   x:  " + (tempB.X - 375) + "  y: " + (250 - tempB.Y));
                listBox2.Items.Add("---------------------------------------------------");
            }
            //doi xung hinh chu nhat
            else if (hinh == 1)
            {
                Point tempA = new Point();
                Point tempB = new Point();
                Point tempC = new Point();
                Point tempD = new Point();
                tempA = AB.getdiemdau();
                tempB = AB.getdiemcuoi();
                tempA.X = 375 - (tempA.X - 375);
                tempB.X = 375 - (tempB.X - 375);

                tempC = BC.getdiemcuoi();
                tempD = DA.getdiemdau();
                tempC.X = 375 - (tempC.X - 375);
                tempD.X = 375 - (tempD.X - 375);

                AB.setdiemdau(tempA);
                AB.setdiemcuoi(tempB);

                BC.setdiemdau(tempB);
                BC.setdiemcuoi(tempC);

                CD.setdiemdau(tempC);
                CD.setdiemcuoi(tempD);

                DA.setdiemdau(tempD);
                DA.setdiemcuoi(tempA);
                screen1.Refresh();
                AB.DDA_Line(this.screen1.CreateGraphics());
                BC.DDA_Line(this.screen1.CreateGraphics());
                CD.DDA_Line(this.screen1.CreateGraphics());
                DA.DDA_Line(this.screen1.CreateGraphics());
                listBox2.Items.Add("Hình chữ nhật mới  ");
                listBox2.Items.Add(" A       :   x:  " + (tempA.X - 375) + "  y: " + (250 - tempA.Y));
                listBox2.Items.Add(" B       :   x:  " + (tempB.X - 375) + "  y: " + (250 - tempB.Y));
                listBox2.Items.Add(" C       :   x:  " + (tempC.X - 375) + "  y: " + (250 - tempC.Y));
                listBox2.Items.Add(" D       :   x:  " + (tempD.X - 375) + "  y: " + (250 - tempD.Y));
                listBox2.Items.Add("---------------------------------------------------");
            }
            //doi xung hinh binh hanh
            else if (hinh == 2)
            {
                Point tempA = new Point();
                Point tempB = new Point();
                Point tempC = new Point();
                Point tempD = new Point();
                tempA = AB.getdiemdau();
                tempB = AB.getdiemcuoi();
                tempA.X = 375 - (tempA.X - 375);
                tempB.X = 375 - (tempB.X - 375);

                tempC = BC.getdiemcuoi();
                tempD = DA.getdiemdau();
                tempC.X = 375 - (tempC.X - 375);
                tempD.X = 375 - (tempD.X - 375);

                AB.setdiemdau(tempA);
                AB.setdiemcuoi(tempB);

                BC.setdiemdau(tempB);
                BC.setdiemcuoi(tempC);

                CD.setdiemdau(tempC);
                CD.setdiemcuoi(tempD);

                DA.setdiemdau(tempD);
                DA.setdiemcuoi(tempA);
                screen1.Refresh();
                AB.DDA_Line(this.screen1.CreateGraphics());
                BC.DDA_Line(this.screen1.CreateGraphics());
                CD.DDA_Line(this.screen1.CreateGraphics());
                DA.DDA_Line(this.screen1.CreateGraphics());
                listBox2.Items.Add("Hình mới  ");
                listBox2.Items.Add(" A       :   x:  " + (tempA.X - 375) + "  y: " + (250 - tempA.Y));
                listBox2.Items.Add(" B       :   x:  " + (tempB.X - 375) + "  y: " + (250 - tempB.Y));
                listBox2.Items.Add(" C       :   x:  " + (tempC.X - 375) + "  y: " + (250 - tempC.Y));
                listBox2.Items.Add(" D       :   x:  " + (tempD.X - 375) + "  y: " + (250 - tempD.Y));
                listBox2.Items.Add("---------------------------------------------------");
            }
            //doi xung hinh tron
            else if(hinh==3)
            {
                Point tempA = new Point();
                Point tempB = new Point();
                tempA = AB.getdiemdau();
                tempB = AB.getdiemcuoi();
                tempA.X = 375 - (tempA.X - 375);
                tempB.X = 375 - (tempB.X - 375);
                r = Math.Abs(tempB.X - tempA.X);
                


                this.screen1.Refresh();
                circle ax = new circle(tempB.X, tempB.Y, r);
                ax.drawC(g);
                listBox2.Items.Add("Hình Tròn mới  ");
                listBox2.Items.Add(" Tâm O      :   x:  " + (tempB.X - 375) + "  y: " + (250 - tempB.Y));
                listBox2.Items.Add(" Bán kính r :  " + r);
                listBox2.Items.Add("---------------------------------------------------");
            }
            //doi xung hinh elipse
            else if(hinh==4)
            {
                Point tempA = new Point();
                Point tempB = new Point();
                Point tempC = new Point();

                tempA = AB.getdiemdau();
                tempB = AB.getdiemcuoi();
                tempA.X = 375 - (tempA.X - 375);
                tempB.X = 375 - (tempB.X - 375);
                tempC = BC.getdiemcuoi();
                tempC.X = 375 - (tempC.X - 375);
                this.screen1.Refresh();
                elipse elip = new elipse(tempA, (tempB.X - tempA.X), (tempC.Y - tempA.Y));
                elip.Midpoint_elipse(g);
                listBox2.Items.Add("Hình elipse  ");
                listBox2.Items.Add(" Tâm         :   x:  " + (tempA.X - 375) + "  y: " + (250 - tempA.Y));
                listBox2.Items.Add("Bán kính Ox  :   " + (tempB.X - tempA.X));
                listBox2.Items.Add("Bán kính Oy  :   " + (tempC.Y - tempA.Y));
                listBox2.Items.Add("---------------------------------------------------");
            }
            //doi xung hinh tam giac
            else if(hinh==5)
            {
                Point tempA = new Point();
                Point tempB = new Point();
                Point tempC = new Point();
                
                tempA = AB.getdiemdau();
                tempB = AB.getdiemcuoi();
                tempA.X = 375 - (tempA.X - 375);
                tempB.X = 375 - (tempB.X - 375);

                tempC = BC.getdiemcuoi();
               
                tempC.X = 375 - (tempC.X - 375);
                

                AB.setdiemdau(tempA);
                AB.setdiemcuoi(tempB);

                BC.setdiemdau(tempB);
                BC.setdiemcuoi(tempC);

                CA.setdiemdau(tempC);
                CA.setdiemcuoi(tempA);
                
                screen1.Refresh();
                AB.DDA_Line(this.screen1.CreateGraphics());
                BC.DDA_Line(this.screen1.CreateGraphics());
                CA.DDA_Line(this.screen1.CreateGraphics());
                listBox2.Items.Add("Hình mới  ");
                listBox2.Items.Add(" A       :   x:  " + (tempA.X - 375) + "  y: " + (250 - tempA.Y));
                listBox2.Items.Add(" B       :   x:  " + (tempB.X - 375) + "  y: " + (250 - tempB.Y));
                listBox2.Items.Add(" C       :   x:  " + (tempC.X - 375) + "  y: " + (250 - tempC.Y));
                
                listBox2.Items.Add("---------------------------------------------------");
            }
        }
        //doi xung ox
        private void doiXungOx_MouseClick(object sender, MouseEventArgs e)
        {
            if(hinh==-1)
            {
                MessageBox.Show("Chưa vẽ hình ");
                this.Refresh();
                return;
            }
            //doi xung duong thang
            else if (hinh == 0)
            {
                Point tempA = new Point();
                Point tempB = new Point();
                tempA = AB.getdiemdau();
                tempB = AB.getdiemcuoi();

                tempA.Y = 250 - (tempA.Y - 250);
                tempB.Y = 250 - (tempB.Y - 250);
                AB.setdiemdau(tempA);
                AB.setdiemcuoi(tempB);
                screen1.Refresh();
                AB.DDA_Line(this.screen1.CreateGraphics());
                listBox2.Items.Add("toa do moi");
                listBox2.Items.Add(" A       :   x:  " + (tempA.X - 375) + "  y: " + (250 - tempA.Y));
                listBox2.Items.Add(" B       :   x:  " + (tempB.X - 375) + "  y: " + (250 - tempB.Y));
                listBox2.Items.Add("---------------------------------------------------");
            }
            //doi xung hinh chu nhat
            else if (hinh == 1)
            {
                Point tempA = new Point();
                Point tempB = new Point();
                Point tempC = new Point();
                Point tempD = new Point();
                tempA = AB.getdiemdau();
                tempB = AB.getdiemcuoi();
                

                tempC = BC.getdiemcuoi();
                tempD = DA.getdiemdau();
                tempA.Y = 250 - (tempA.Y - 250);
                tempB.Y = 250 - (tempB.Y - 250);
                tempC.Y = 250 - (tempC.Y - 250);
                tempD.Y = 250 - (tempD.Y - 250);

                AB.setdiemdau(tempA);
                AB.setdiemcuoi(tempB);

                BC.setdiemdau(tempB);
                BC.setdiemcuoi(tempC);

                CD.setdiemdau(tempC);
                CD.setdiemcuoi(tempD);

                DA.setdiemdau(tempD);
                DA.setdiemcuoi(tempA);
                screen1.Refresh();
                AB.DDA_Line(this.screen1.CreateGraphics());
                BC.DDA_Line(this.screen1.CreateGraphics());
                CD.DDA_Line(this.screen1.CreateGraphics());
                DA.DDA_Line(this.screen1.CreateGraphics());
                listBox2.Items.Add("Hình chữ nhật mới  ");
                listBox2.Items.Add(" A       :   x:  " + (tempA.X - 375) + "  y: " + (250 - tempA.Y));
                listBox2.Items.Add(" B       :   x:  " + (tempB.X - 375) + "  y: " + (250 - tempB.Y));
                listBox2.Items.Add(" C       :   x:  " + (tempC.X - 375) + "  y: " + (250 - tempC.Y));
                listBox2.Items.Add(" D       :   x:  " + (tempD.X - 375) + "  y: " + (250 - tempD.Y));
                listBox2.Items.Add("---------------------------------------------------");
            }
            //doi xung hinh binh hanh
            else if (hinh == 2)
            {
                Point tempA = new Point();
                Point tempB = new Point();
                Point tempC = new Point();
                Point tempD = new Point();
                tempA = AB.getdiemdau();
                tempB = AB.getdiemcuoi();
                tempC = BC.getdiemcuoi();
                tempD = DA.getdiemdau();
                tempA.Y = 250 - (tempA.Y - 250);
                tempB.Y = 250 - (tempB.Y - 250);

                
                tempC.Y = 250 - (tempC.Y - 250);
                tempD.Y = 250 - (tempD.Y - 250);

                AB.setdiemdau(tempA);
                AB.setdiemcuoi(tempB);

                BC.setdiemdau(tempB);
                BC.setdiemcuoi(tempC);

                CD.setdiemdau(tempC);
                CD.setdiemcuoi(tempD);

                DA.setdiemdau(tempD);
                DA.setdiemcuoi(tempA);
                screen1.Refresh();
                AB.DDA_Line(this.screen1.CreateGraphics());
                BC.DDA_Line(this.screen1.CreateGraphics());
                CD.DDA_Line(this.screen1.CreateGraphics());
                DA.DDA_Line(this.screen1.CreateGraphics());
                listBox2.Items.Add("Hình mới  ");
                listBox2.Items.Add(" A       :   x:  " + (tempA.X - 375) + "  y: " + (250 - tempA.Y));
                listBox2.Items.Add(" B       :   x:  " + (tempB.X - 375) + "  y: " + (250 - tempB.Y));
                listBox2.Items.Add(" C       :   x:  " + (tempC.X - 375) + "  y: " + (250 - tempC.Y));
                listBox2.Items.Add(" D       :   x:  " + (tempD.X - 375) + "  y: " + (250 - tempD.Y));
                listBox2.Items.Add("---------------------------------------------------");
            }
            //doi xung hinh tron
            else if (hinh == 3)
            {
                Point tempA = new Point();
                Point tempB = new Point();
                tempA = AB.getdiemdau();
                tempB = AB.getdiemcuoi();
                tempA.Y = 250 - (tempA.Y - 250);
                tempB.Y = 250 - (tempB.Y - 250);
                r = Math.Abs(tempB.X - tempA.X);



                this.screen1.Refresh();
                circle ax = new circle(tempB.X, tempB.Y, r);
                ax.drawC(g);
                listBox2.Items.Add("Hình Tròn mới  ");
                listBox2.Items.Add(" Tâm O      :   x:  " + (tempB.X - 375) + "  y: " + (250 - tempB.Y));
                listBox2.Items.Add(" Bán kính r :  " + r);
                listBox2.Items.Add("---------------------------------------------------");
            }
            //doi xung hinh elipse
            else if (hinh == 4)
            {
                Point tempA = new Point();
                Point tempB = new Point();
                Point tempC = new Point();

                tempA = AB.getdiemdau();
                tempB = AB.getdiemcuoi();
                
                tempC = BC.getdiemcuoi();
                tempA.Y = 250 - (tempA.Y - 250);
                tempB.Y = 250 - (tempB.Y - 250);
                tempC.Y = 250 - (tempC.Y - 250);
                this.screen1.Refresh();
                elipse elip = new elipse(tempA, (tempB.X - tempA.X), (tempC.Y - tempA.Y));
                elip.Midpoint_elipse(g);
                listBox2.Items.Add("Hình elipse  ");
                listBox2.Items.Add(" Tâm         :   x:  " + (tempA.X - 375) + "  y: " + (250 - tempA.Y));
                listBox2.Items.Add("Bán kính Ox  :   " + (tempB.X - tempA.X));
                listBox2.Items.Add("Bán kính Oy  :   " + (tempC.Y - tempA.Y));
                listBox2.Items.Add("---------------------------------------------------");
            }
            //doi xung hinh tam giac
            else if (hinh == 5)
            {
                Point tempA = new Point();
                Point tempB = new Point();
                Point tempC = new Point();

                tempA = AB.getdiemdau();
                tempB = AB.getdiemcuoi();
                tempC = BC.getdiemcuoi();
                tempA.Y = 250 - (tempA.Y - 250);
                tempB.Y = 250 - (tempB.Y - 250);
                tempC.Y = 250 - (tempC.Y - 250);
                AB.setdiemdau(tempA);
                AB.setdiemcuoi(tempB);

                BC.setdiemdau(tempB);
                BC.setdiemcuoi(tempC);

                CA.setdiemdau(tempC);
                CA.setdiemcuoi(tempA);

                screen1.Refresh();
                AB.DDA_Line(this.screen1.CreateGraphics());
                BC.DDA_Line(this.screen1.CreateGraphics());
                CA.DDA_Line(this.screen1.CreateGraphics());
                listBox2.Items.Add("Hình mới  ");
                listBox2.Items.Add(" A       :   x:  " + (tempA.X - 375) + "  y: " + (250 - tempA.Y));
                listBox2.Items.Add(" B       :   x:  " + (tempB.X - 375) + "  y: " + (250 - tempB.Y));
                listBox2.Items.Add(" C       :   x:  " + (tempC.X - 375) + "  y: " + (250 - tempC.Y));

                listBox2.Items.Add("---------------------------------------------------");
            }
        }
        //doi xung O
        private void doiXungO_MouseClick(object sender, MouseEventArgs e)
        {
            if (hinh == -1)
            {
                MessageBox.Show("Chưa vẽ hình ");
                this.Refresh();
                return;
            }
            else if(hinh==0)
            {
                Point tempA = new Point();
                Point tempB = new Point();
                tempA = AB.getdiemdau();
                tempB = AB.getdiemcuoi();

                tempA.X = 375 - (tempA.X - 375);
                tempB.X = 375 - (tempB.X - 375);
                tempA.Y = 250 - (tempA.Y - 250);
                tempB.Y = 250 - (tempB.Y - 250);
                AB.setdiemdau(tempA);
                AB.setdiemcuoi(tempB);
                screen1.Refresh();
                AB.DDA_Line(this.screen1.CreateGraphics());
                listBox2.Items.Add("toa do moi");
                listBox2.Items.Add(" A       :   x:  " + (tempA.X - 375) + "  y: " + (250 - tempA.Y));
                listBox2.Items.Add(" B       :   x:  " + (tempB.X - 375) + "  y: " + (250 - tempB.Y));
                listBox2.Items.Add("---------------------------------------------------");
            }//duong thang
            else if(hinh==1)
            {
                Point tempA = new Point();
                Point tempB = new Point();
                Point tempC = new Point();
                Point tempD = new Point();
                tempA = AB.getdiemdau();
                tempB = AB.getdiemcuoi();
                tempA.X = 375 - (tempA.X - 375);
                tempB.X = 375 - (tempB.X - 375);

                tempC = BC.getdiemcuoi();
                tempD = DA.getdiemdau();
                tempC.X = 375 - (tempC.X - 375);
                tempD.X = 375 - (tempD.X - 375);
                tempA.Y = 250 - (tempA.Y - 250);
                tempB.Y = 250 - (tempB.Y - 250);
                tempC.Y = 250 - (tempC.Y - 250);
                tempD.Y = 250 - (tempD.Y - 250);

                AB.setdiemdau(tempA);
                AB.setdiemcuoi(tempB);

                BC.setdiemdau(tempB);
                BC.setdiemcuoi(tempC);

                CD.setdiemdau(tempC);
                CD.setdiemcuoi(tempD);

                DA.setdiemdau(tempD);
                DA.setdiemcuoi(tempA);
                screen1.Refresh();
                AB.DDA_Line(this.screen1.CreateGraphics());
                BC.DDA_Line(this.screen1.CreateGraphics());
                CD.DDA_Line(this.screen1.CreateGraphics());
                DA.DDA_Line(this.screen1.CreateGraphics());
                listBox2.Items.Add("Hình chữ nhật mới  ");
                listBox2.Items.Add(" A       :   x:  " + (tempA.X - 375) + "  y: " + (250 - tempA.Y));
                listBox2.Items.Add(" B       :   x:  " + (tempB.X - 375) + "  y: " + (250 - tempB.Y));
                listBox2.Items.Add(" C       :   x:  " + (tempC.X - 375) + "  y: " + (250 - tempC.Y));
                listBox2.Items.Add(" D       :   x:  " + (tempD.X - 375) + "  y: " + (250 - tempD.Y));
                listBox2.Items.Add("---------------------------------------------------");
            }//hinh chu nhat
            else if(hinh==2)
            {
                Point tempA = new Point();
                Point tempB = new Point();
                Point tempC = new Point();
                Point tempD = new Point();
                tempA = AB.getdiemdau();
                tempB = AB.getdiemcuoi();
                tempA.X = 375 - (tempA.X - 375);
                tempB.X = 375 - (tempB.X - 375);

                tempC = BC.getdiemcuoi();
                tempD = DA.getdiemdau();
                tempC.X = 375 - (tempC.X - 375);
                tempD.X = 375 - (tempD.X - 375);
                tempA.Y = 250 - (tempA.Y - 250);
                tempB.Y = 250 - (tempB.Y - 250);


                tempC.Y = 250 - (tempC.Y - 250);
                tempD.Y = 250 - (tempD.Y - 250);

                AB.setdiemdau(tempA);
                AB.setdiemcuoi(tempB);

                BC.setdiemdau(tempB);
                BC.setdiemcuoi(tempC);

                CD.setdiemdau(tempC);
                CD.setdiemcuoi(tempD);

                DA.setdiemdau(tempD);
                DA.setdiemcuoi(tempA);
                screen1.Refresh();
                AB.DDA_Line(this.screen1.CreateGraphics());
                BC.DDA_Line(this.screen1.CreateGraphics());
                CD.DDA_Line(this.screen1.CreateGraphics());
                DA.DDA_Line(this.screen1.CreateGraphics());
                listBox2.Items.Add("Hình mới  ");
                listBox2.Items.Add(" A       :   x:  " + (tempA.X - 375) + "  y: " + (250 - tempA.Y));
                listBox2.Items.Add(" B       :   x:  " + (tempB.X - 375) + "  y: " + (250 - tempB.Y));
                listBox2.Items.Add(" C       :   x:  " + (tempC.X - 375) + "  y: " + (250 - tempC.Y));
                listBox2.Items.Add(" D       :   x:  " + (tempD.X - 375) + "  y: " + (250 - tempD.Y));
                listBox2.Items.Add("---------------------------------------------------");
            }//hinh binh hanh
            else if(hinh==3)
            {
                Point tempA = new Point();
                Point tempB = new Point();
                tempA = AB.getdiemdau();
                tempB = AB.getdiemcuoi();
                tempA.X = 375 - (tempA.X - 375);
                tempB.X = 375 - (tempB.X - 375);
                tempA.Y = 250 - (tempA.Y - 250);
                tempB.Y = 250 - (tempB.Y - 250);
                r = Math.Abs(tempB.X - tempA.X);
                this.screen1.Refresh();
                circle ax = new circle(tempB.X, tempB.Y, r);
                ax.drawC(g);
                listBox2.Items.Add("Hình Tròn mới  ");
                listBox2.Items.Add(" Tâm O      :   x:  " + (tempB.X - 375) + "  y: " + (250 - tempB.Y));
                listBox2.Items.Add(" Bán kính r :  " + r);
                listBox2.Items.Add("---------------------------------------------------");
            }//hinh tron
            else if(hinh==4)
            {
                Point tempA = new Point();
                Point tempB = new Point();
                Point tempC = new Point();

                tempA = AB.getdiemdau();
                tempB = AB.getdiemcuoi();
                tempA.X = 375 - (tempA.X - 375);
                tempB.X = 375 - (tempB.X - 375);
                tempC = BC.getdiemcuoi();
                tempC.X = 375 - (tempC.X - 375);
                tempA.Y = 250 - (tempA.Y - 250);
                tempB.Y = 250 - (tempB.Y - 250);
                tempC.Y = 250 - (tempC.Y - 250);
                this.screen1.Refresh();
                elipse elip = new elipse(tempA, (tempB.X - tempA.X), (tempC.Y - tempA.Y));
                elip.Midpoint_elipse(g);
                listBox2.Items.Add("Hình elipse  ");
                listBox2.Items.Add(" Tâm         :   x:  " + (tempA.X - 375) + "  y: " + (250 - tempA.Y));
                listBox2.Items.Add("Bán kính Ox  :   " + (tempB.X - tempA.X));
                listBox2.Items.Add("Bán kính Oy  :   " + (tempC.Y - tempA.Y));
                listBox2.Items.Add("---------------------------------------------------");
            }//hinh elipse   
            else if(hinh==5)
            {
                Point tempA = new Point();
                Point tempB = new Point();
                Point tempC = new Point();

                tempA = AB.getdiemdau();
                tempB = AB.getdiemcuoi();
                tempA.X = 375 - (tempA.X - 375);
                tempB.X = 375 - (tempB.X - 375);

                tempC = BC.getdiemcuoi();

                tempC.X = 375 - (tempC.X - 375);

                tempA.Y = 250 - (tempA.Y - 250);
                tempB.Y = 250 - (tempB.Y - 250);
                tempC.Y = 250 - (tempC.Y - 250);
                AB.setdiemdau(tempA);
                AB.setdiemcuoi(tempB);

                BC.setdiemdau(tempB);
                BC.setdiemcuoi(tempC);

                CA.setdiemdau(tempC);
                CA.setdiemcuoi(tempA);

                screen1.Refresh();
                AB.DDA_Line(this.screen1.CreateGraphics());
                BC.DDA_Line(this.screen1.CreateGraphics());
                CA.DDA_Line(this.screen1.CreateGraphics());
                listBox2.Items.Add("Hình mới  ");
                listBox2.Items.Add(" A       :   x:  " + (tempA.X - 375) + "  y: " + (250 - tempA.Y));
                listBox2.Items.Add(" B       :   x:  " + (tempB.X - 375) + "  y: " + (250 - tempB.Y));
                listBox2.Items.Add(" C       :   x:  " + (tempC.X - 375) + "  y: " + (250 - tempC.Y));

                listBox2.Items.Add("---------------------------------------------------");
            }//hinh tam giac
        }

        //ve hinh
        private void Refresh_MouseClick(object sender, MouseEventArgs e)
        {
            checkve = false;
            timer1.Stop();
            this.label6.Text = "";
            this.label7.Text = "";
            i = 0;
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            checkBox1.Checked = false;
            screen1.Refresh();

        }

        private void exit_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }
        
        private void drawBox_Click(object sender, EventArgs e)
        {
            i = 0;
            hinh = 1;
            
        }

        private void drawThoi_Click(object sender, EventArgs e)
        {
            i = 0;
            hinh = 2;
            
        }

        private void drawTron_Click(object sender, EventArgs e)
        {
            i = 0;
            hinh = 3;
            
        }

        private void drawElip_Click(object sender, EventArgs e)
        {
            i = 0;
            hinh = 4;
            
        }

        private void drawTG_Click(object sender, EventArgs e)
        {
            i = 0;
            hinh = 5;
            
        }

        private void drawLine_MouseHover(object sender, EventArgs e)
        {
            help.Show("Vẽ đoạn thẳng nối nhau, nếu muốn vẽ đoạn thẳng riêng hãy click lại để vẽ đoạn mới ",drawLine);
        }

        private void drawBox_MouseHover(object sender, EventArgs e)
        {
            help.Show("Vẽ hình chữ nhật bằng 2 điểm riêng biệt (2 điểm này là đường chéo của hình chữ nhật)  ", drawBox);
        }

        private void drawThoi_MouseHover(object sender, EventArgs e)
        {
            help.Show("Vẽ hình bình hành : + Điểm đầu là đỉnh đầu của hình bình hành " +
                                        "\n\t\t   + Điểm 2 là điểm tính độ dài cạnh trên và cạnh đáy theo Ox" +
                                        "\n\t\t   + Điểm 3 là điểm để vẽ cạnh bên của hình bình hành ",drawThoi);
        }

        private void drawElip_MouseHover(object sender, EventArgs e)
        {
            help.Show("Vẽ hình elip :          + Điểm đầu tiên là tâm hình elip " +
                                       "\n\t\t + Điểm thứ 2 là bán kính 1 theo trục Ox " +
                                       "\n\t\t + Điểm 3 là bán kính theo 2 trục Oy", drawElip);
        }

        private void drawTG_MouseHover(object sender, EventArgs e)
        {
            help.Show("Vẽ hình tam giác bằng cách chọn 3 điểm ", drawTG);
        }

        private void drawTron_MouseHover(object sender, EventArgs e)
        {
            help.Show("Vẽ hình tròn bằng cách chọn điểm đầu là tâm và điểm 2 là bán kình theo Ox", drawTron);
        }

        //tinhtien doan thang
        private Line TinhTienDT(Line ab)
        {
            int xA = ab.getdiemdau().X + Int32.Parse(numericUpDown1.Value.ToString()) * 1;
            int yA = ab.getdiemdau().Y + Int32.Parse(numericUpDown2.Value.ToString()) * -1;
            int xB = ab.getdiemcuoi().X + Int32.Parse(numericUpDown1.Value.ToString()) * 1;
            int yB = ab.getdiemcuoi().Y + Int32.Parse(numericUpDown2.Value.ToString()) * -1;

            Point p1 = new Point(xA, yA);
            Point p2 = new Point(xB, yB);

            Line dt = new Line(p1.X, p1.Y, p2.X, p2.Y, ab.getmau());
            return dt;
        }
        //tinh tien diem
        private Point TinhTienDiem(Point a)
        {
            int xA = a.X + Int32.Parse(numericUpDown1.Value.ToString()) * 1;
            int yA = a.Y + Int32.Parse(numericUpDown2.Value.ToString()) * -1;

            Point b = new Point(xA, yA);
            return b;
        }

        private void tinhtien_Click(object sender, EventArgs e)
        {
            if (hinh == -1)
            {
                MessageBox.Show("Chưa vẽ hình ");
                this.Refresh();
                return;
            }
            else if (hinh==0)
            {
                Point tempA = new Point();
                Point tempB = new Point();
                
                this.Refresh();
                AB = TinhTienDT(AB);
                tempA = AB.getdiemdau();
                tempB = AB.getdiemcuoi();
                AB.DDA_Line(this.screen1.CreateGraphics());
                listBox2.Items.Add("toa do moi");
                listBox2.Items.Add(" A       :   x:  " + (tempA.X - 375) + "  y: " + (250 - tempA.Y));
                listBox2.Items.Add(" B       :   x:  " + (tempB.X - 375) + "  y: " + (250 - tempB.Y));
                listBox2.Items.Add("---------------------------------------------------");
            }
            else if(hinh==1)
            {
                Point tempA = new Point();
                Point tempB = new Point();
                Point tempC = new Point();
                Point tempD = new Point();
                this.Refresh();
                AB = TinhTienDT(AB);
                BC = TinhTienDT(BC);
                CD = TinhTienDT(CD);
                DA = TinhTienDT(DA);
                tempA = AB.getdiemdau();
                tempB = AB.getdiemcuoi();
                tempC = BC.getdiemcuoi();
                tempD = DA.getdiemdau();
                AB.DDA_Line(this.screen1.CreateGraphics());
                BC.DDA_Line(this.screen1.CreateGraphics());
                CD.DDA_Line(this.screen1.CreateGraphics());
                DA.DDA_Line(this.screen1.CreateGraphics());
                listBox2.Items.Add("Hình chữ nhật mới  ");
                listBox2.Items.Add(" A       :   x:  " + (tempA.X - 375) + "  y: " + (250 - tempA.Y));
                listBox2.Items.Add(" B       :   x:  " + (tempB.X - 375) + "  y: " + (250 - tempB.Y));
                listBox2.Items.Add(" C       :   x:  " + (tempC.X - 375) + "  y: " + (250 - tempC.Y));
                listBox2.Items.Add(" D       :   x:  " + (tempD.X - 375) + "  y: " + (250 - tempD.Y));
                listBox2.Items.Add("---------------------------------------------------");
            }
            else if (hinh == 2)
            {
                Point tempA = new Point();
                Point tempB = new Point();
                Point tempC = new Point();
                Point tempD = new Point();
                this.Refresh();
                AB = TinhTienDT(AB);
                BC = TinhTienDT(BC);
                CD = TinhTienDT(CD);
                DA = TinhTienDT(DA);
                tempA = AB.getdiemdau();
                tempB = AB.getdiemcuoi();
                tempC = BC.getdiemcuoi();
                tempD = DA.getdiemdau();
                AB.DDA_Line(this.screen1.CreateGraphics());
                BC.DDA_Line(this.screen1.CreateGraphics());
                CD.DDA_Line(this.screen1.CreateGraphics());
                DA.DDA_Line(this.screen1.CreateGraphics());
                listBox2.Items.Add("Hình mới  ");
                listBox2.Items.Add(" A       :   x:  " + (tempA.X - 375) + "  y: " + (250 - tempA.Y));
                listBox2.Items.Add(" B       :   x:  " + (tempB.X - 375) + "  y: " + (250 - tempB.Y));
                listBox2.Items.Add(" C       :   x:  " + (tempC.X - 375) + "  y: " + (250 - tempC.Y));
                listBox2.Items.Add(" D       :   x:  " + (tempD.X - 375) + "  y: " + (250 - tempD.Y));
                listBox2.Items.Add("---------------------------------------------------");
            }
            else if (hinh == 3)
            {
                this.Refresh();
                
                Point tempB = new Point();
                tempB = AB.getdiemcuoi();
                tempB = TinhTienDiem(tempB);
                circle ax = new circle(tempB.X, tempB.Y, r);
                ax.drawC(g);
                listBox2.Items.Add("Hình Tròn mới  ");
                listBox2.Items.Add(" Tâm O      :   x:  " + (tempB.X - 375) + "  y: " + (250 - tempB.Y));
                listBox2.Items.Add(" Bán kính r :  " + r);
                listBox2.Items.Add("---------------------------------------------------");
            }
            else if (hinh == 4)
            {
                Point tempA = new Point();
                Point tempB = new Point();
                Point tempC = new Point();
                tempA = AB.getdiemdau();
                tempB = AB.getdiemcuoi();
                tempC = BC.getdiemcuoi();  
                this.screen1.Refresh();
                tempA = TinhTienDiem(tempA);
                tempB = TinhTienDiem(tempB);
                tempC = TinhTienDiem(tempC);
                elipse elip = new elipse(tempA, (tempB.X - tempA.X), (tempC.Y - tempA.Y));
                elip.Midpoint_elipse(g);
                listBox2.Items.Add("Hình elipse  ");
                listBox2.Items.Add(" Tâm         :   x:  " + (tempA.X - 375) + "  y: " + (250 - tempA.Y));
                listBox2.Items.Add("Bán kính Ox  :   " + (tempB.X - tempA.X));
                listBox2.Items.Add("Bán kính Oy  :   " + (tempC.Y - tempA.Y));
                listBox2.Items.Add("---------------------------------------------------");
            }
            else if (hinh == 5)
            {
                Point tempA = new Point();
                Point tempB = new Point();
                Point tempC = new Point();
                AB = TinhTienDT(AB);
                BC = TinhTienDT(BC);
                CA = TinhTienDT(CA);
                tempA = AB.getdiemdau();
                tempB = AB.getdiemcuoi();
                tempC = BC.getdiemcuoi();
                screen1.Refresh();
                AB.DDA_Line(this.screen1.CreateGraphics());
                BC.DDA_Line(this.screen1.CreateGraphics());
                CA.DDA_Line(this.screen1.CreateGraphics());
                listBox2.Items.Add("Hình mới  ");
                listBox2.Items.Add(" A       :   x:  " + (tempA.X - 375) + "  y: " + (250 - tempA.Y));
                listBox2.Items.Add(" B       :   x:  " + (tempB.X - 375) + "  y: " + (250 - tempB.Y));
                listBox2.Items.Add(" C       :   x:  " + (tempC.X - 375) + "  y: " + (250 - tempC.Y));

                listBox2.Items.Add("---------------------------------------------------");
            }
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
 
        private void Rota_Click(object sender, EventArgs e)
        {
            if (hinh == -1)
            {
                MessageBox.Show("Chưa vẽ hình ");
                this.Refresh();
                return;
            }
            else if (hinh==0)
            {
                Point tempA = new Point();
                Point tempB = new Point();
                tempA = AB.getdiemdau();
                tempB = AB.getdiemcuoi();
                int goc = Int32.Parse(numericUpDown3.Value.ToString()) * 1;
                this.Refresh();
                tempB = RotatePoint(tempB, tempA,goc);
                AB.setdiemcuoi(tempB);
                AB.setdiemdau(tempA);
                AB.DDA_Line(this.screen1.CreateGraphics());
                listBox2.Items.Add("toa do moi");
                listBox2.Items.Add(" A       :   x:  " + (tempA.X - 375) + "  y: " + (250 - tempA.Y));
                listBox2.Items.Add(" B       :   x:  " + (tempB.X - 375) + "  y: " + (250 - tempB.Y));
                listBox2.Items.Add("---------------------------------------------------");
                //tempB.X -= 375;
                //tempB.Y = 250 - tempB.Y;
                //this.label6.Text = tempB.ToString();
            }
            else if(hinh==1)
            {
                Point tempA = new Point();
                Point tempB = new Point();
                Point tempC = new Point();
                Point tempD = new Point();
                int goc = Int32.Parse(numericUpDown3.Value.ToString()) * 1;
                this.Refresh();
                tempA = AB.getdiemdau();
                tempB = AB.getdiemcuoi();
                tempC = BC.getdiemcuoi();
                tempD = DA.getdiemdau();
                tempB = RotatePoint(tempB, tempA, goc);
                tempC = RotatePoint(tempC, tempA, goc);
                tempD = RotatePoint(tempD, tempA, goc);
                AB.setdiemdau(tempA);
                AB.setdiemcuoi(tempB);
                BC.setdiemdau(tempB);
                BC.setdiemcuoi(tempC);
                CD.setdiemdau(tempC);
                CD.setdiemcuoi(tempD);
                DA.setdiemdau(tempD);
                DA.setdiemcuoi(tempA);
                AB.DDA_Line(this.screen1.CreateGraphics());
                BC.DDA_Line(this.screen1.CreateGraphics());
                CD.DDA_Line(this.screen1.CreateGraphics());
                DA.DDA_Line(this.screen1.CreateGraphics());
                listBox2.Items.Add("Hình chữ nhật mới  ");
                listBox2.Items.Add(" A       :   x:  " + (tempA.X - 375) + "  y: " + (250 - tempA.Y));
                listBox2.Items.Add(" B       :   x:  " + (tempB.X - 375) + "  y: " + (250 - tempB.Y));
                listBox2.Items.Add(" C       :   x:  " + (tempC.X - 375) + "  y: " + (250 - tempC.Y));
                listBox2.Items.Add(" D       :   x:  " + (tempD.X - 375) + "  y: " + (250 - tempD.Y));
                listBox2.Items.Add("---------------------------------------------------");
            }
            else if (hinh == 2)
            {
                Point tempA = new Point();
                Point tempB = new Point();
                Point tempC = new Point();
                Point tempD = new Point();
                int goc = Int32.Parse(numericUpDown3.Value.ToString()) * 1;
                this.Refresh();
                tempA = AB.getdiemdau();
                tempB = AB.getdiemcuoi();
                tempC = BC.getdiemcuoi();
                tempD = DA.getdiemdau();
                tempB = RotatePoint(tempB, tempA, goc);
                tempC = RotatePoint(tempC, tempA, goc);
                tempD = RotatePoint(tempD, tempA, goc);
                AB.setdiemdau(tempA);
                AB.setdiemcuoi(tempB);
                BC.setdiemdau(tempB);
                BC.setdiemcuoi(tempC);
                CD.setdiemdau(tempC);
                CD.setdiemcuoi(tempD);
                DA.setdiemdau(tempD);
                DA.setdiemcuoi(tempA);
                AB.DDA_Line(this.screen1.CreateGraphics());
                BC.DDA_Line(this.screen1.CreateGraphics());
                CD.DDA_Line(this.screen1.CreateGraphics());
                DA.DDA_Line(this.screen1.CreateGraphics());
                listBox2.Items.Add("Hình bình hành mới  ");
                listBox2.Items.Add(" A       :   x:  " + (tempA.X - 375) + "  y: " + (250 - tempA.Y));
                listBox2.Items.Add(" B       :   x:  " + (tempB.X - 375) + "  y: " + (250 - tempB.Y));
                listBox2.Items.Add(" C       :   x:  " + (tempC.X - 375) + "  y: " + (250 - tempC.Y));
                listBox2.Items.Add(" D       :   x:  " + (tempD.X - 375) + "  y: " + (250 - tempD.Y));
                listBox2.Items.Add("---------------------------------------------------");
            }
            else if (hinh == 5)
            {
                Point tempA = new Point();
                Point tempB = new Point();
                Point tempC = new Point();
                int goc = Int32.Parse(numericUpDown3.Value.ToString()) * 1;
                tempA = AB.getdiemdau();
                tempB = AB.getdiemcuoi();
                tempC = BC.getdiemcuoi();
                tempB = RotatePoint(tempB, tempA, goc);
                tempC = RotatePoint(tempC, tempA, goc);
                AB.setdiemdau(tempA);
                AB.setdiemcuoi(tempB);

                BC.setdiemdau(tempB);
                BC.setdiemcuoi(tempC);

                CA.setdiemdau(tempC);
                CA.setdiemcuoi(tempA);

                screen1.Refresh();

                AB.DDA_Line(this.screen1.CreateGraphics());
                BC.DDA_Line(this.screen1.CreateGraphics());
                CA.DDA_Line(this.screen1.CreateGraphics());
                listBox2.Items.Add("Hình mới  ");
                listBox2.Items.Add(" A       :   x:  " + (tempA.X - 375) + "  y: " + (250 - tempA.Y));
                listBox2.Items.Add(" B       :   x:  " + (tempB.X - 375) + "  y: " + (250 - tempB.Y));
                listBox2.Items.Add(" C       :   x:  " + (tempC.X - 375) + "  y: " + (250 - tempC.Y));

                listBox2.Items.Add("---------------------------------------------------");
            }
        }
        //quay diem
        static Point RotatePoint(Point diemxoay, Point diemtam,double goc)
        {
            
            double angleInRadians = goc * (Math.PI / 180);
            double cosTheta = Math.Cos(angleInRadians);
            double sinTheta = Math.Sin(angleInRadians);
            return new Point
            {
                X =
                    (int)
                    (cosTheta * (diemxoay.X - diemtam.X) -
                    sinTheta * (diemxoay.Y - diemtam.Y) + diemtam.X),
                Y =
                    (int)
                    (sinTheta * (diemxoay.X - diemtam.X) +
                    cosTheta * (diemxoay.Y - diemtam.Y) + diemtam.Y)
            };
        }
        //xoay kim phut va giay
        static Point kimsm(int goc, int len)
        {
            goc *= 6;   

            if (goc >= 0 && goc <= 180)
            {
                return new Point
                {
                    X = 375 + (int)(len * Math.Sin(Math.PI * goc / 180)),
                    Y = 250 - (int)(len * Math.Cos(Math.PI * goc / 180))
                };
            }
            else
            {
                return new Point
                { 
                    X = 375 - (int)(len * -Math.Sin(Math.PI * goc / 180)),
                    Y = 250 - (int)(len * Math.Cos(Math.PI * goc / 180))
                };
            }
        }
        //xoay kim gio
        static Point kimh(int ho, int mm, int len)
        {
            

            //each hour makes 30 degree
            //each min makes 0.5 degree
            int val = (int)((ho * 30) + (mm * 0.5));

            if (val >= 0 && val <= 180)
            {
                return new Point
                {
                    X = 375 + (int)(len * Math.Sin(Math.PI * val / 180)),
                    Y = 250 - (int)(len * Math.Cos(Math.PI * val / 180))
                };
            }
            else
            {
                return new Point
                {
                    X = 375 - (int)(len * -Math.Sin(Math.PI * val / 180)),
                    Y = 250 - (int)(len * Math.Cos(Math.PI * val / 180))
                };
            }
            
        }
        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {

        }
        // kim phut va kim giay
        
        //kim gio
        private void vebutt_Click(object sender, EventArgs e)
        {
            
            tam.X = 375;
            tam.Y = 250;
            checkve = true;
            
            timer1.Start();
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {            
            int se = DateTime.Now.Second;
            int mi = DateTime.Now.Minute;
            int ho = DateTime.Now.Hour;
            ss = kimsm(se, 180);
            ls.setdiemdau(tam);
            ls.setdiemcuoi(ss);
            mm = kimsm(mi, 140);
            hh = kimh(ho,mi, 120);
            lm.setdiemdau(tam);
            lm.setdiemcuoi(mm);
            lh.setdiemdau(tam);
            lh.setdiemcuoi(hh);
            ls.setmau(Color.White);
            lm.setmau(Color.Green);
            lh.setmau(Color.Black);
            this.Refresh();
            lh.DDA_Line(this.screen1.CreateGraphics());
            lm.DDA_Line(this.screen1.CreateGraphics());
            ls.DDA_Line(this.screen1.CreateGraphics());
            this.label6.Text =hh+" : "+mm + " : "+ss;
            this.label7.Text = ho + " : " + mi + " : " + se;
            
        }
        private void stop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
                
        }
    }
}
