using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace PostIT
{
    class Program
    {
        static void Main(string[] args)
        {
            PostIt postit1;
            postit1.BackgroundColor = "orange";
            postit1.Text = "Idea1";
            postit1.TextColor = "blue";

            PostIt postit2;
            postit2.BackgroundColor = "pink";
            postit2.Text = "Awesome";
            postit2.TextColor = "black";

            PostIt postit3;
            postit3.BackgroundColor = "yellow";
            postit3.Text = "SuperB";
            postit3.TextColor = "green";
        }
    }
}
