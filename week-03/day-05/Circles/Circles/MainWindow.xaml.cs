using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using GreenFox;

namespace Circles
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);


            double x = 0;
            double y = 0;
            double rad = 300;

            DrawTheCicle(x,y,rad);
        }

        private double DrawTheCicle(double x, double y, double rad)
        {
            var foxDraw = new FoxDraw(canvas);

            foxDraw.FillColor(Colors.Transparent);
            foxDraw.StrokeColor(Colors.Black);

            foxDraw.DrawEllipse(x, y, rad, rad);
            
            if (rad >= 10)
            {
                DrawTheCicle(canvas.Width/4, 0, rad/2);
                DrawTheCicle(canvas.Width/25, canvas.Height/2.6, rad/2);
                DrawTheCicle(canvas.Width/2.18, canvas.Height/2.6, rad/2);
            }
            return 0;
        }
    }
}
