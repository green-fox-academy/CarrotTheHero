using System;
using System.Windows;
using GreenFox;
using System.Windows.Media;

namespace PurpleSteps
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            // reproduce this:
            // [https://github.com/greenfox-academy/teaching-materials/blob/master/workshop/drawing/purple-steps/r3.png]

            for (int i = 0; i < 15; i++)
            {

                foxDraw.FillColor(Colors.Purple);
                foxDraw.DrawRectangle(0 + 15 * i, 0 + 15 * i, 15, 15);

            }
        }
    }
}