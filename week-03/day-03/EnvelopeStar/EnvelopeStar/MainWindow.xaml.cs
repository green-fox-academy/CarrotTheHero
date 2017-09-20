using System;
using System.Windows;
using GreenFox;
using System.Windows.Media;

namespace EnvelopeStar
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            // reproduce this:
            // [https://github.com/greenfox-academy/teaching-materials/blob/master/workshop/drawing/envelope-star/r2.png]

            for (int i = 0; i < 10; i++)
            {
                foxDraw.StrokeColor(Colors.Lime);
                foxDraw.DrawLine(150, 10 + i * 15, 160 + i * 15, 150);
            }

            for (int i = 0; i < 10; i++)
            {
                foxDraw.StrokeColor(Colors.Lime);
                foxDraw.DrawLine(150, 160 + i * 15, 10 + i * 15, 150);
            }

            for (int i = 0; i < 10; i++)
            {
                foxDraw.StrokeColor(Colors.Lime);
                foxDraw.DrawLine(150, 10 + i * 15, 160 - i * 15, 150);
            }

            for (int i = 0; i < 10; i++)
            {
                foxDraw.StrokeColor(Colors.Lime);
                foxDraw.DrawLine(150, 280 - i * 15, 160 + i * 15, 150);
            }
        }
    }
}