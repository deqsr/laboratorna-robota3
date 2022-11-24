using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Content
    {

        private string contentname = "";
        public string ContentName
        { set { contentname = value; } get { return contentname; } }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(ContentName);
        }



    }
}

