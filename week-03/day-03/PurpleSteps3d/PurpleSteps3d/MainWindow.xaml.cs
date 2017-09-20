using System;
using System.Windows;
using GreenFox;
using System.Windows.Media;

namespace PurpleSteps3d
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            // reproduce this:
            // [https://github.com/greenfox-academy/teaching-materials/blob/master/workshop/drawing/purple-steps-3d/r4.png]
            double x = 0;
            double y = 10;

            for (int i = 1; i < 6; i++)
            {
                y += 10;
                x += i*10;
                foxDraw.FillColor(Colors.Purple);
                foxDraw.DrawRectangle(x, x, y, y);

            }
        }
    }
}