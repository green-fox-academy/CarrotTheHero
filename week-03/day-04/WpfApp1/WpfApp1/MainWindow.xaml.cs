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

namespace WpfApp1
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
            int whole = 300;
            int firstside = 100;
            int secside = 200;
            int zero = 0;
            DrawTheLines(firstside, secside, whole, zero);            
        }

        private void DrawTheLines(int firstside, int secside, int whole, int zero)
        {
            var foxDraw = new FoxDraw(canvas);

            foxDraw.BackgroundColor(Colors.Yellow);
            foxDraw.StrokeColor(Colors.Black);
            foxDraw.FillColor(Colors.Yellow);


            for (int i = 0; i < 10; i++)
            {
                whole = (300 / 3);
                secside = (200 / 3);
                firstside = (100 / 3);
                zero = (0 / 3);

                foxDraw.DrawLine(firstside, zero, firstside, whole);
                foxDraw.DrawLine(secside, zero, secside, whole);
                foxDraw.DrawLine(zero, firstside, whole, firstside);
                foxDraw.DrawLine(zero, secside, whole, secside);
            }
            
        }
    }
}
