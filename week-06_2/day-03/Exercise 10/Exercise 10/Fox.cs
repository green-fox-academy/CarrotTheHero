using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_10
{
    class Fox
    {
        private string color;
        private string name;
        private string type;

        public Fox(string name, string type, string color)
        {
            this.name = name;
            this.color = color;
            this.type = type;
        }

        public string Name
        {
            get
            {
                return name;
            }
        }
        public string Type
        {
            get
            {
                return type;
            }
        }
        public string Color
        {
            get
            {
                return color;
            }
        }
    }
}
