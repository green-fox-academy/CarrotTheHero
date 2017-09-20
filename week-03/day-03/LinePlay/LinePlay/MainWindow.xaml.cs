using System;
using System.Windows;
using GreenFox;
using System.Windows.Media;

namespace LinePlay
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            // reproduce this:
            // [https://github.com/greenfox-academy/teaching-materials/blob/master/workshop/drawing/line-play/r1.png]
            int x = 0;
            int y = 300;


            for (int i = 0; i < 20; i++)
            {
                foxDraw.StrokeColor(Colors.Lime);
                foxDraw.DrawLine(0, 10 + i * 15, 10 + i * 15, 300);           
            }

            for (int i = 0; i < 20; i++)
            {
                foxDraw.StrokeColor(Colors.MediumPurple);
                foxDraw.DrawLine(10 + i * 15, 0, 300, 10 + i * 15);
            }
        }
    }
}