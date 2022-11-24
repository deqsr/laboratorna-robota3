using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Author
    {

        private string authorname = "";
        public string AuthorName
        { 
            set { authorname = value; } 
            get { return authorname; } 
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(AuthorName);
        }

    }
}
