using System;
using System.Windows;
using GreenFox;
using System.Windows.Media;

namespace CenteredSquare
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            // draw a green 10x10 square to the canvas' center.
            foxDraw.DrawRectangle(145, 145, 10, 10);
            foxDraw.FillColor(Colors.Green);

        }
    }
}