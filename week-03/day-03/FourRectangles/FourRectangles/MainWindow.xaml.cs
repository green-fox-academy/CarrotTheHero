using System;
using System.Windows;
using GreenFox;
using System.Windows.Media;

namespace FourRectangles
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            // draw four different size and color rectangles.
            foxDraw.DrawRectangle(10, 10, 100, 100);
            foxDraw.FillColor(Colors.Red);
            foxDraw.DrawRectangle(30, 10, 80, 100);
            foxDraw.FillColor(Colors.Black);
            foxDraw.DrawRectangle(10, 40, 100, 120);
            foxDraw.FillColor(Colors.Blue);
            foxDraw.DrawRectangle(20, 10, 60, 60);
            foxDraw.FillColor(Colors.Green);

        }
    }
}