using System;
using System.Windows;
using GreenFox;
using System.Windows.Media;

namespace RainbowBoxFunction
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            // create a square drawing function that takes 2 parameters:
            // the square size, and the fill color,
            // and draws a square of that size and color to the center of the canvas.
            // create a loop that fills the canvas with rainbow colored squares.
            //string color = foxDraw.FillColor(Colors.);
            byte colnum = 10;
            Byte[] color = new Byte[3] { colnum, colnum, colnum };
            int size = 300;
            SquareDraw(size, color, colnum);
        }

        private void SquareDraw(int size, byte[] color, byte colnum)
        {
            

            for (int i = 1; i < 30; i++)
            {
                colnum += Convert.ToByte(i * 2);
                foxDraw.DrawRectangle(150 - (size- 10*i / 2), 150 - (size - 10*i / 2), size - 10*i, size - 10*i);
                foxDraw.FillColor(Color.FromRgb(color[0], color[1], color[2]));
            }
        }
    }
}