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

public class TowersOfHanoi
{
    public static void Main(String[] args)
    {
        char startPeg = 'A'; // start tower in output
        char endPeg = 'C'; // end tower in output
        char tempPeg = 'B'; // temporary tower in output
        int totalDisks = 3; // number of disks

        solveTowers(totalDisks, startPeg, endPeg, tempPeg);
    }

    private static void solveTowers(int n, char startPeg, char endPeg, char tempPeg)
    {
        if (n > 0)
        {
            solveTowers(n - 1, startPeg, tempPeg, endPeg);
            Console.WriteLine("Move disk from " + startPeg + ' ' + endPeg);
            solveTowers(n - 1, tempPeg, endPeg, startPeg);

        }
    }

}