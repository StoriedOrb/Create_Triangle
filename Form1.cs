using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Create_triangle
{
    public partial class Create : Form
    {
        double x1, x2, x3, y1, y2, y3;   //Координаты

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Clean_Click(object sender, EventArgs e)
        {
            this.X1TextBox.Clear(); this.X2TextBox.Clear(); this.X3TextBox.Clear(); this.Y1TextBox.Clear(); this.Y2TextBox.Clear(); this.Y3TextBox.Clear(); this.TriangleBox.Clear();
        }

        private void Random_Click(object sender, EventArgs e)
        {
            Random ran = new Random();    //Генератор случайных чисел

            int width, height;

            width = this.Width;           //Ширина формы
            height = this.Height;         //Высота формы
            
            x1 = ran.Next(width);         //Координата X1
            y1 = ran.Next(height);        //Координата Y1
            this.X1TextBox.Text = x1.ToString();
            this.Y1TextBox.Text = y1.ToString();
            
            x2 = ran.Next(width);         //Координата X2
            y2 = ran.Next(height);        //Координата Y2
            this.X2TextBox.Text = x2.ToString();
            this.Y2TextBox.Text = y2.ToString();
            
            x3 = ran.Next(width);         //Координата X3
            y3 = ran.Next(height);        //Координата Y3
            this.X3TextBox.Text = x3.ToString();
            this.Y3TextBox.Text = y3.ToString();
        }

        private void Calculation_Click(object sender, EventArgs e)
        {
            double a, b, c, P, p, S, R, r, ma, mb, mc, ba, bb, bc;
            this.TriangleBox.Clear();
            x1 = x2 = x3 = y1 = y2 = y3 = 0;     //Введённые данные
            try 
            {
                x1 = Convert.ToDouble(this.X1TextBox);
                x2 = Convert.ToDouble(this.X2TextBox);
                x3 = Convert.ToDouble(this.X3TextBox);
                y1 = Convert.ToDouble(this.Y1TextBox);
                y2 = Convert.ToDouble(this.Y2TextBox);
                y3 = Convert.ToDouble(this.Y3TextBox);
            }
            catch
            {
                MessageBox.Show("Неверные данные!");

                this.X1TextBox.Clear(); this.X2TextBox.Clear(); this.X3TextBox.Clear(); this.Y1TextBox.Clear(); this.Y2TextBox.Clear(); this.Y3TextBox.Clear(); this.TriangleBox.Clear();

                return;
            }
            a = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));                                           
            this.TriangleBox.Text += "Сторона a = " + a.ToString() + Environment.NewLine;                
            
            b = Math.Sqrt(Math.Pow(x2 - x3, 2) + Math.Pow(y2 - y3, 2));
            this.TriangleBox.Text += "Сторона b = " + b.ToString() + Environment.NewLine;
            
            c = Math.Sqrt(Math.Pow(x3 - x1, 2) + Math.Pow(y3 - y1, 2));
            this.TriangleBox.Text += "Сторона c = " + c.ToString() + Environment.NewLine;
            
            P = a + b + c;                                                                                         
            this.TriangleBox.Text += "Периметр треугольника = " + P.ToString() + Environment.NewLine;
            
            p = P / 2.0;
            this.TriangleBox.Text += "Полупериметр треугольника = " + p.ToString() + Environment.NewLine;
            
            S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            this.TriangleBox.Text += "Площадь треугольника = " + S.ToString() + Environment.NewLine;
            
            R = a * b * c / 4 / S;
            this.TriangleBox.Text += "Радиус описанной окружности = " + R.ToString() + Environment.NewLine;
            
            r = Math.Sqrt(((p - a) * (p - b) * (p - c)) / p);
            this.TriangleBox.Text += "Радиус вписанной окружности = " + r.ToString() + Environment.NewLine;
            
            ma = (1 / 2.0) * Math.Sqrt(2 * Math.Pow(c, 2) + (2 * Math.Pow(b, 2)) - (Math.Pow(a, 2)));
            this.TriangleBox.Text += "Медиана к стороне а = " + ma.ToString() + Environment.NewLine;
            
            mb = (1 / 2.0) * Math.Sqrt(2 * Math.Pow(a, 2) + (2 * Math.Pow(c, 2)) - (Math.Pow(b, 2)));
            this.TriangleBox.Text += "Медиана к стороне b = " + mb.ToString() + Environment.NewLine;
            
            mc = (1 / 2.0) * Math.Sqrt(2 * Math.Pow(a, 2) + (2 * Math.Pow(b, 2)) - (Math.Pow(c, 2)));
            this.TriangleBox.Text += "Медиана к стороне с = " + mc.ToString() + Environment.NewLine;

            ba = 2 * Math.Sqrt(a * b * p * (p - a)) / (c + b);
            this.TriangleBox.Text += "Биссектриса к стороне a = " + ba.ToString() + Environment.NewLine;

            bb = 2 * Math.Sqrt(a * b * p * (p - b)) / (a + b);
            this.TriangleBox.Text += "Биссектриса к стороне b = " + bb.ToString() + Environment.NewLine;

            bc = 2 * Math.Sqrt(a * b * p * (p - c)) / (a + b);
            this.TriangleBox.Text += "Биссектриса к стороне с = " + bc.ToString() + Environment.NewLine;
        }

        public Create()
        {
            InitializeComponent();
        }
    }
}
