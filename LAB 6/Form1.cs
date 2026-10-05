using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            // Базова точка
            int x = 100;
            int y = 120;

            // Кузов
            g.FillRectangle(Brushes.Gray, x + 100, y, 140, 100);
            g.DrawRectangle(Pens.Black, x + 100, y, 140, 100);

            // Кабіна
            Point[] cabin =
            {
        new Point(x, y + 45),
        new Point(x + 35, y + 15),
        new Point(x + 85, y + 15),
        new Point(x + 100, y + 100),
        new Point(x, y + 100)
    };

            g.FillPolygon(Brushes.DarkSlateGray, cabin);
            g.DrawPolygon(Pens.Black, cabin);

            // Вікно
            Point[] window =
            {
        new Point(x + 35, y + 25),
        new Point(x + 70, y + 25),
        new Point(x + 78, y + 65),
        new Point(x + 25, y + 65)
    };

            g.FillPolygon(Brushes.Yellow, window);
            g.DrawPolygon(Pens.Black, window);

            // Нижня частина машини
            g.FillRectangle(Brushes.DarkSlateGray, x, y + 90, 240, 25);

            // Колеса
            g.FillEllipse(Brushes.White, x + 45, y + 90, 50, 50);
            g.DrawEllipse(new Pen(Color.Black, 3), x + 45, y + 90, 50, 50);

            g.FillEllipse(Brushes.White, x + 175, y + 90, 50, 50);
            g.DrawEllipse(new Pen(Color.Black, 3), x + 175, y + 90, 50, 50);

            // Центри коліс
            g.FillEllipse(Brushes.Gray, x + 60, y + 105, 20, 20);
            g.FillEllipse(Brushes.Gray, x + 190, y + 105, 20, 20);
        
    }
    }
}
