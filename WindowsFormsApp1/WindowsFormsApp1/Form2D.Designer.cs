namespace WindowsFormsApp1
{
    partial class Form2D
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2D));
            this.screen1 = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.mousePos = new System.Windows.Forms.ToolStripStatusLabel();
            this.xmax = new System.Windows.Forms.Label();
            this.ymax = new System.Windows.Forms.Label();
            this.size = new System.Windows.Forms.Label();
            this.drawLine = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Refresh = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.drawBox = new System.Windows.Forms.Button();
            this.drawThoi = new System.Windows.Forms.Button();
            this.drawTron = new System.Windows.Forms.Button();
            this.drawElip = new System.Windows.Forms.Button();
            this.drawTG = new System.Windows.Forms.Button();
            this.help = new System.Windows.Forms.ToolTip(this.components);
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.doiXungOy = new System.Windows.Forms.Button();
            this.doiXungOx = new System.Windows.Forms.Button();
            this.doiXungO = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.tinhtien = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Rota = new System.Windows.Forms.Button();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.vebutt = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.stop = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.screen1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            this.SuspendLayout();
            // 
            // screen1
            // 
            this.screen1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.screen1.Controls.Add(this.statusStrip1);
            this.screen1.Controls.Add(this.xmax);
            this.screen1.Controls.Add(this.ymax);
            this.screen1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.screen1.Location = new System.Drawing.Point(177, 149);
            this.screen1.Name = "screen1";
            this.screen1.Size = new System.Drawing.Size(750, 500);
            this.screen1.TabIndex = 0;
            this.screen1.Paint += new System.Windows.Forms.PaintEventHandler(this.screen1_Paint);
            this.screen1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.screen1_MouseClick);
            this.screen1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.showPos);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mousePos});
            this.statusStrip1.Location = new System.Drawing.Point(0, 478);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(750, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // mousePos
            // 
            this.mousePos.Name = "mousePos";
            this.mousePos.Size = new System.Drawing.Size(52, 17);
            this.mousePos.Text = "X: -  Y: - ";
            // 
            // xmax
            // 
            this.xmax.AutoSize = true;
            this.xmax.Location = new System.Drawing.Point(367, 0);
            this.xmax.Name = "xmax";
            this.xmax.Size = new System.Drawing.Size(12, 13);
            this.xmax.TabIndex = 1;
            this.xmax.Text = "y";
            // 
            // ymax
            // 
            this.ymax.AutoSize = true;
            this.ymax.Location = new System.Drawing.Point(735, 245);
            this.ymax.Name = "ymax";
            this.ymax.Size = new System.Drawing.Size(12, 13);
            this.ymax.TabIndex = 2;
            this.ymax.Text = "x";
            // 
            // size
            // 
            this.size.AutoSize = true;
            this.size.Location = new System.Drawing.Point(879, 133);
            this.size.Name = "size";
            this.size.Size = new System.Drawing.Size(54, 13);
            this.size.TabIndex = 3;
            this.size.Text = "750 x 500";
            // 
            // drawLine
            // 
            this.drawLine.BackColor = System.Drawing.Color.White;
            this.drawLine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.drawLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.drawLine.Location = new System.Drawing.Point(12, 149);
            this.drawLine.Name = "drawLine";
            this.drawLine.Size = new System.Drawing.Size(111, 23);
            this.drawLine.TabIndex = 4;
            this.drawLine.Text = "Đoạn Thẳng";
            this.drawLine.UseVisualStyleBackColor = false;
            this.drawLine.Click += new System.EventHandler(this.drawLine_Click);
            this.drawLine.MouseHover += new System.EventHandler(this.drawLine_MouseHover);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(951, 149);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(192, 199);
            this.listBox1.TabIndex = 1;
            // 
            // Refresh
            // 
            this.Refresh.BackColor = System.Drawing.Color.White;
            this.Refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Refresh.Location = new System.Drawing.Point(177, 120);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(121, 23);
            this.Refresh.TabIndex = 5;
            this.Refresh.Text = "Vẽ Lại";
            this.Refresh.UseVisualStyleBackColor = false;
            this.Refresh.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Refresh_MouseClick);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.White;
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exit.ForeColor = System.Drawing.Color.Maroon;
            this.exit.Location = new System.Drawing.Point(951, 24);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(121, 23);
            this.exit.TabIndex = 6;
            this.exit.Text = "Thoát";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.MouseClick += new System.Windows.Forms.MouseEventHandler(this.exit_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(948, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tọa độ các điểm chọn ";
            // 
            // drawBox
            // 
            this.drawBox.BackColor = System.Drawing.Color.White;
            this.drawBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.drawBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.drawBox.Location = new System.Drawing.Point(12, 193);
            this.drawBox.Name = "drawBox";
            this.drawBox.Size = new System.Drawing.Size(110, 23);
            this.drawBox.TabIndex = 8;
            this.drawBox.Text = "Hình chữ nhật";
            this.drawBox.UseVisualStyleBackColor = false;
            this.drawBox.Click += new System.EventHandler(this.drawBox_Click);
            this.drawBox.MouseHover += new System.EventHandler(this.drawBox_MouseHover);
            // 
            // drawThoi
            // 
            this.drawThoi.BackColor = System.Drawing.Color.White;
            this.drawThoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.drawThoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.drawThoi.Location = new System.Drawing.Point(12, 241);
            this.drawThoi.Name = "drawThoi";
            this.drawThoi.Size = new System.Drawing.Size(110, 23);
            this.drawThoi.TabIndex = 10;
            this.drawThoi.Text = "Hình bình hành";
            this.drawThoi.UseVisualStyleBackColor = false;
            this.drawThoi.Click += new System.EventHandler(this.drawThoi_Click);
            this.drawThoi.MouseHover += new System.EventHandler(this.drawThoi_MouseHover);
            // 
            // drawTron
            // 
            this.drawTron.BackColor = System.Drawing.Color.White;
            this.drawTron.Cursor = System.Windows.Forms.Cursors.Hand;
            this.drawTron.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.drawTron.Location = new System.Drawing.Point(12, 290);
            this.drawTron.Name = "drawTron";
            this.drawTron.Size = new System.Drawing.Size(110, 23);
            this.drawTron.TabIndex = 11;
            this.drawTron.Text = "Hình tròn";
            this.drawTron.UseVisualStyleBackColor = false;
            this.drawTron.Click += new System.EventHandler(this.drawTron_Click);
            this.drawTron.MouseHover += new System.EventHandler(this.drawTron_MouseHover);
            // 
            // drawElip
            // 
            this.drawElip.BackColor = System.Drawing.Color.White;
            this.drawElip.Cursor = System.Windows.Forms.Cursors.Hand;
            this.drawElip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.drawElip.Location = new System.Drawing.Point(12, 337);
            this.drawElip.Name = "drawElip";
            this.drawElip.Size = new System.Drawing.Size(108, 23);
            this.drawElip.TabIndex = 12;
            this.drawElip.Text = "Hình elip";
            this.drawElip.UseVisualStyleBackColor = false;
            this.drawElip.Click += new System.EventHandler(this.drawElip_Click);
            this.drawElip.MouseHover += new System.EventHandler(this.drawElip_MouseHover);
            // 
            // drawTG
            // 
            this.drawTG.BackColor = System.Drawing.Color.White;
            this.drawTG.Cursor = System.Windows.Forms.Cursors.Hand;
            this.drawTG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.drawTG.Location = new System.Drawing.Point(12, 389);
            this.drawTG.Name = "drawTG";
            this.drawTG.Size = new System.Drawing.Size(108, 23);
            this.drawTG.TabIndex = 13;
            this.drawTG.Text = "Hình tam giác";
            this.drawTG.UseVisualStyleBackColor = false;
            this.drawTG.Click += new System.EventHandler(this.drawTG_Click);
            this.drawTG.MouseHover += new System.EventHandler(this.drawTG_MouseHover);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(951, 384);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(192, 238);
            this.listBox2.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(948, 363);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Các hình đã vẽ";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(177, 652);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(103, 17);
            this.checkBox1.TabIndex = 17;
            this.checkBox1.Text = "Hiện trục tọa độ";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // doiXungOy
            // 
            this.doiXungOy.BackColor = System.Drawing.Color.White;
            this.doiXungOy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.doiXungOy.Location = new System.Drawing.Point(399, 120);
            this.doiXungOy.Name = "doiXungOy";
            this.doiXungOy.Size = new System.Drawing.Size(89, 23);
            this.doiXungOy.TabIndex = 18;
            this.doiXungOy.Text = "Đối xứng Oy";
            this.doiXungOy.UseVisualStyleBackColor = false;
            this.doiXungOy.Click += new System.EventHandler(this.doiXungOy_Click_1);
            // 
            // doiXungOx
            // 
            this.doiXungOx.BackColor = System.Drawing.Color.White;
            this.doiXungOx.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.doiXungOx.Location = new System.Drawing.Point(304, 120);
            this.doiXungOx.Name = "doiXungOx";
            this.doiXungOx.Size = new System.Drawing.Size(89, 23);
            this.doiXungOx.TabIndex = 19;
            this.doiXungOx.Text = "Đối xứng Ox";
            this.doiXungOx.UseVisualStyleBackColor = false;
            this.doiXungOx.MouseClick += new System.Windows.Forms.MouseEventHandler(this.doiXungOx_MouseClick);
            // 
            // doiXungO
            // 
            this.doiXungO.BackColor = System.Drawing.Color.White;
            this.doiXungO.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.doiXungO.Location = new System.Drawing.Point(494, 120);
            this.doiXungO.Name = "doiXungO";
            this.doiXungO.Size = new System.Drawing.Size(89, 23);
            this.doiXungO.TabIndex = 20;
            this.doiXungO.Text = "Đối xứng O";
            this.doiXungO.UseVisualStyleBackColor = false;
            this.doiXungO.MouseClick += new System.Windows.Forms.MouseEventHandler(this.doiXungO_MouseClick);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(595, 94);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(54, 20);
            this.numericUpDown1.TabIndex = 22;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(647, 94);
            this.numericUpDown2.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(54, 20);
            this.numericUpDown2.TabIndex = 23;
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // tinhtien
            // 
            this.tinhtien.BackColor = System.Drawing.Color.White;
            this.tinhtien.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tinhtien.Location = new System.Drawing.Point(595, 120);
            this.tinhtien.Name = "tinhtien";
            this.tinhtien.Size = new System.Drawing.Size(106, 23);
            this.tinhtien.TabIndex = 24;
            this.tinhtien.Text = "Tịnh Tiến";
            this.tinhtien.UseVisualStyleBackColor = false;
            this.tinhtien.Click += new System.EventHandler(this.tinhtien_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(637, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "x";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(689, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(12, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "y";
            // 
            // Rota
            // 
            this.Rota.BackColor = System.Drawing.Color.White;
            this.Rota.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Rota.Location = new System.Drawing.Point(707, 120);
            this.Rota.Name = "Rota";
            this.Rota.Size = new System.Drawing.Size(89, 23);
            this.Rota.TabIndex = 27;
            this.Rota.Text = "Quay";
            this.Rota.UseVisualStyleBackColor = false;
            this.Rota.Click += new System.EventHandler(this.Rota_Click);
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(707, 94);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(89, 20);
            this.numericUpDown3.TabIndex = 28;
            this.numericUpDown3.Value = new decimal(new int[] {
            45,
            0,
            0,
            0});
            this.numericUpDown3.ValueChanged += new System.EventHandler(this.numericUpDown3_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(744, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Góc quay";
            // 
            // vebutt
            // 
            this.vebutt.Location = new System.Drawing.Point(13, 429);
            this.vebutt.Name = "vebutt";
            this.vebutt.Size = new System.Drawing.Size(107, 23);
            this.vebutt.TabIndex = 32;
            this.vebutt.Text = "Vẽ đồng hồ";
            this.vebutt.UseVisualStyleBackColor = true;
            this.vebutt.Click += new System.EventHandler(this.vebutt_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // stop
            // 
            this.stop.Location = new System.Drawing.Point(13, 458);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(107, 23);
            this.stop.TabIndex = 33;
            this.stop.Text = "Stop";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(457, 656);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(51, 500);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 35;
            // 
            // Form2D
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1169, 699);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.vebutt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericUpDown3);
            this.Controls.Add(this.Rota);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tinhtien);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.doiXungO);
            this.Controls.Add(this.doiXungOx);
            this.Controls.Add(this.doiXungOy);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.drawTG);
            this.Controls.Add(this.drawElip);
            this.Controls.Add(this.drawTron);
            this.Controls.Add(this.drawThoi);
            this.Controls.Add(this.drawBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.drawLine);
            this.Controls.Add(this.size);
            this.Controls.Add(this.screen1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2D";
            this.Text = "Form2D";
            this.screen1.ResumeLayout(false);
            this.screen1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel screen1;
        private System.Windows.Forms.Label xmax;
        private System.Windows.Forms.Label ymax;
        private System.Windows.Forms.Label size;
        private System.Windows.Forms.Button drawLine;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel mousePos;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button Refresh;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button drawBox;
        private System.Windows.Forms.Button drawThoi;
        private System.Windows.Forms.Button drawTron;
        private System.Windows.Forms.Button drawElip;
        private System.Windows.Forms.Button drawTG;
        private System.Windows.Forms.ToolTip help;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ColorDialog colorDialog2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button doiXungOy;
        private System.Windows.Forms.Button doiXungOx;
        private System.Windows.Forms.Button doiXungO;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Button tinhtien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Rota;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button vebutt;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}