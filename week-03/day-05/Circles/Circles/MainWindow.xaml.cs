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


            double x = 150;
            double y = 150;
            double rad = 300;

            DrawTheCicle(x,y,rad);
        }

        private double DrawTheCicle(double x, double y, double rad)
        {
            var foxDraw = new FoxDraw(canvas);

            foxDraw.FillColor(Colors.White);
            foxDraw.StrokeColor(Colors.Black);

            foxDraw.DrawEllipse(x, y, rad, rad);
            
            if (rad >= 50)
            {
                DrawTheCicle(x/2, y/2, rad/3);
                DrawTheCicle(x/3, y/3, rad/3);
                DrawTheCicle(x/4, y/4, rad/3);
            }
            return 0;
        }
    }
}
