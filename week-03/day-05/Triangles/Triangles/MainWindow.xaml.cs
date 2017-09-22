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

namespace Triangles
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

            int zero = 0;
            int szazotven = 150;
            int haromszaz = 300;

            DrawLines(zero, szazotven, haromszaz);

        }

        private int DrawLines(int zero, int szazotven, int haromszaz)
        {
            var foxDraw = new FoxDraw(canvas);

            foxDraw.DrawLine(zero, zero, haromszaz, zero);
            foxDraw.DrawLine(zero, zero, szazotven, haromszaz);
            foxDraw.DrawLine(haromszaz, zero, szazotven, haromszaz);

            if (haromszaz > 5)
            {
                DrawLines(zero / 2, szazotven / 2, haromszaz / 2);
                DrawLines(szazotven / 2, haromszaz / 2, haromszaz / 2);
            }
            return 0;
        }                    
    }
}
