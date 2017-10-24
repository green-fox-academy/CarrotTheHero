using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class Greeting
    {
        public long Id;
        public string Content;

        public Greeting()
        {
        }

        public Greeting(long id, string content)
        {
            Id = id;
            Content = content;
        }
    }
    
}
