using System;
using System.Windows;
using GreenFox;
using System.Windows.Media;

namespace PositionSquare
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            // create a square drawing function that takes 2 parameters:
            // the x and y coordinates of the square's top left corner
            // and draws a 50x50 square from that point.
            // draw 3 squares with that function.
            int x1 = 30;
            int y1 = 90;

            int x2 = 60;
            int y2 = 10;

            int x3 = 120;
            int y3 = 30;

            Squarer(x1, y1);
            Squarer(x2, y2);
            Squarer(x3, y3);
        }

        private void Squarer(int x, int y)
        {
            var foxDraw = new FoxDraw(canvas);
            foxDraw.DrawRectangle(x, y, 50, 50);
        }
    }
}