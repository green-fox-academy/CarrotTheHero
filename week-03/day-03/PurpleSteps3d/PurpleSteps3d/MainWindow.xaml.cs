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
            double x = 5;

            for (int i = 0; i < 6; i++)
            {
                x *= 2;
                foxDraw.FillColor(Colors.Purple);
                foxDraw.DrawRectangle(x, x, x, x);

            }
        }
    }
}