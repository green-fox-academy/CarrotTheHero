using System;
using System.Windows;
using GreenFox;
using System.Windows.Media;

namespace LinePlayQuarters
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            // divide the canvas into 4 parts
            // and repeat this pattern in each quarter:
            // [https://github.com/greenfox-academy/teaching-materials/blob/master/workshop/drawing/line-play/r1.png]


            for (int i = 0; i < 10; i++)
            {
                foxDraw.StrokeColor(Colors.Lime);
                foxDraw.DrawLine(0, 10 + i * 15, 10 + i * 15, 150);
            }

            for (int i = 0; i < 10; i++)
            {
                foxDraw.StrokeColor(Colors.MediumPurple);
                foxDraw.DrawLine(10 + i * 15, 0, 150, 10 + i * 15);
            }

            //-----------------------------------------------------------------
            for (int i = 0; i < 10; i++)
            {
                foxDraw.StrokeColor(Colors.Lime);
                foxDraw.DrawLine(150, 160 + i * 15, 160 + i * 15, 300);
            }

            for (int i = 0; i < 10; i++)
            {
                foxDraw.StrokeColor(Colors.MediumPurple);
                foxDraw.DrawLine(160 + i * 15, 150, 300, 160 + i * 15);
            }

            //------------------------------------------------------------------
            for (int i = 0; i < 10; i++)
            {
                foxDraw.StrokeColor(Colors.Lime);
                foxDraw.DrawLine(150, 10 + i * 15, 160 + i * 15, 150);
            }

            for (int i = 0; i < 10; i++)
            {
                foxDraw.StrokeColor(Colors.MediumPurple);
                foxDraw.DrawLine(160 + i * 15, 0, 300, 10 + i * 15);
            }

            //-------------------------------------------------------------------
            for (int i = 0; i < 10; i++)
            {
                foxDraw.StrokeColor(Colors.Lime);
                foxDraw.DrawLine(0, 160 + i * 15, 10 + i * 15, 300);
            }

            for (int i = 0; i < 10; i++)
            {
                foxDraw.StrokeColor(Colors.MediumPurple);
                foxDraw.DrawLine(10 + i * 15, 150, 150, 160 + i * 15);
            }
        }

    }
}
