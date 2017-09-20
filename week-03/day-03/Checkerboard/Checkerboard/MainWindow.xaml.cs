using System;
using System.Windows;
using GreenFox;
using System.Windows.Media;

namespace Checkerboard
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            // fill the canvas with a checkerboard pattern.
            int x = 0;
            int y = 0;
            foxDraw.FillColor(Colors.Black);

            for (int i = 1; i <= 8; i++)
            {                
                for (int j = 0; j < 4; j++)
                {
                    foxDraw.DrawRectangle(x, y, 30, 30);
                    x += 60;
                }
                if (i % 2 == 1)
                    x = 30;
                else
                    x = 0;
                    y += 30;
                               
            }
        }
    }
}