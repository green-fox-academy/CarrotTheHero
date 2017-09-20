using System;
using System.Windows;
using GreenFox;
using System.Windows.Media;

namespace ColoredBox
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            // draw a box that has different colored lines on each edge.
            foxDraw.DrawLine(50, 50, 50, 200);
            foxDraw.StrokeColor(Colors.Red);

            foxDraw.DrawLine(50, 200, 200, 200);
            foxDraw.StrokeColor(Colors.Yellow);

            foxDraw.DrawLine(200, 200, 200, 50);
            foxDraw.StrokeColor(Colors.Green);

            foxDraw.DrawLine(200, 50, 50, 50);
            foxDraw.StrokeColor(Colors.PapayaWhip);
        }
    }
}