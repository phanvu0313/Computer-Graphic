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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void button1_Click(object sender, EventArgs e)
        {
            Form2D draw2d = new Form2D();
            draw2d.ShowDialog();
           
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Form3D draw3d = new Form3D();
            draw3d.ShowDialog();
        }
        private void button3_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

       
    }
}
