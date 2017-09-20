using System;
using System.Windows;
using GreenFox;
using System.Windows.Media;

namespace GoToCenter
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            // create a line drawing function that takes 2 parameters:
            // the x and y coordinates of the line's starting point
            // and draws a line from that point to the center of the canvas.
            // draw 3 lines with that function.
            Point point1 = new Point(10, 50);
            Point point2 = new Point(100, 60);
            Point point3 = new Point(0, 200);
            LineToMiddle(point1);
            LineToMiddle(point2);
            LineToMiddle(point3);

        }

        private void LineToMiddle(Point point)
        {
            var foxDraw = new FoxDraw(canvas);
            var middlepoint = new Point(150, 150);
            foxDraw.DrawLine(point, middlepoint);                       
        }
    }
}