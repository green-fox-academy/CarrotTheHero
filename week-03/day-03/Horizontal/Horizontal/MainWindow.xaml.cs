using System;
using System.Windows;
using GreenFox;

namespace Horizontal
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            // create a line drawing function that takes 2 parameters:
            // the x and y coordinates of the line's starting point
            // and draws a 50 long horizontal line from that point.
            // draw 3 lines with that function.
            int x1 = 50;
            int y1 = 100;

            int x2 = 10;
            int y2 = 70;

            int x3 = 100;
            int y3 = 200;

            DrawLine(x1, y1);
            DrawLine(x2, y2);
            DrawLine(x3, y3);

        }

        private void DrawLine(int x, int y)
        {
            var foxDraw = new FoxDraw(canvas);
            foxDraw.DrawLine(x, y, x + 50, y);
        }
    }
}