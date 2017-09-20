using System;
using System.Windows;
using GreenFox;
using System.Windows.Media;

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            //  draw a red horizontal line to the canvas' middle.
            //  draw a green vertical line to the canvas' middle.
            var startingPoint = new Point(0, 150);
            var endingPoint = new Point(300, 150);


            foxDraw.StrokeColor(Colors.Red);
            foxDraw.DrawLine(startingPoint, endingPoint);


            var startingPoint2 = new Point(150, 0);
            var endingPoint2 = new Point(150, 300);


            foxDraw.StrokeColor(Colors.Green);
            foxDraw.DrawLine(startingPoint2, endingPoint2);
        }
    }
}