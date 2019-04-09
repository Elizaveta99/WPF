using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Shooting_target
{
    public partial class Form1 : Form
    {
        private int rad;
        private int shAmount;
        private int missAmount;
        private int hitAmount;
        private int coordX;
        private int coordY;
        private int W;
        private int H;

        public Form1()
        {
            InitializeComponent();
        }
    
        private void DrawTarget(Rectangle r, Graphics g)
        {
            W = r.Width;
            H = r.Height;
            Point LU = new Point(0, 0);
            Rectangle rect = new Rectangle(LU.X + W / 2 - rad, LU.Y + H / 2 - rad, 2 * rad, 2 * rad);

            Pen pen = new Pen(Color.FromArgb(0, 0, 255)); 
            SolidBrush brush = new SolidBrush(Color.FromArgb(0, 0, 255));
            float startAngle = -90f;
            float sweepAngle = 45f;
            g.DrawPie(pen, rect, startAngle, sweepAngle);
            g.FillPie(brush, rect, startAngle, sweepAngle);

            startAngle = 90f;
            g.DrawPie(pen, rect, startAngle, sweepAngle);
            g.FillPie(brush, rect, startAngle, sweepAngle);

            pen.Dispose();
            brush.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                rad = Int32.Parse(textBox1.Text);
                shAmount = Int32.Parse(textBox2.Text);
                if (rad < 0 || shAmount < 0)
                    MessageBox.Show("Неверный ввод радиуса или количества выстрелов!");
                Rectangle temp = this.ClientRectangle;
                temp.Height -= panel1.Height;
                Graphics g = this.CreateGraphics();
                DrawTarget(temp, g);
                textBox1.ReadOnly = true;
                textBox2.ReadOnly = true;
                textBox3.Enabled = true;
                textBox4.Enabled = true;
                textBox5.Enabled = true;
                textBox6.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Неверный ввод радиуса или количества выстрелов!");
            }
        }

        bool isHit(int x, int y)
        {
            if (x > 0 && x < Math.Sqrt(2) / 2 * rad && y > x && y < rad)
                return true;
            if (x < 0 && Math.Abs(x) < Math.Sqrt(2) / 2 * rad && y < x && Math.Abs(y) < rad)
                return true;
            return false;
        }

        public void DrawPoint(int x, int y)
        {
            Graphics g = this.CreateGraphics();
            Pen pen = new Pen(Color.DarkRed);
            g.DrawEllipse(pen, W / 2 + x - 3,  H / 2 - y - 3, 6, 6);
            SolidBrush brush = new SolidBrush(Color.DarkRed);
            g.FillEllipse(brush, W / 2 + x - 3, H / 2 - y - 3, 6, 6);
            pen.Dispose();
            brush.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (shAmount == 0)
            {
                MessageBox.Show("Выстрелы закончились.");
                Application.Restart();
            }
            try
            {
                coordX = Int32.Parse(textBox3.Text);
                coordY = Int32.Parse(textBox4.Text);
                Point lu = new Point(0, 0);
                DrawPoint(coordX, coordY);
                shAmount--;
                textBox2.Text = shAmount.ToString();
                if (isHit(coordX, coordY))
                {
                    hitAmount++;
                    textBox6.Text = hitAmount.ToString();
                }
                else
                {
                    missAmount++;
                    textBox5.Text = missAmount.ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Неверный ввод координат!");
            }
        }
    }
}
