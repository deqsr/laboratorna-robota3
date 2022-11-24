using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Title
    {
        string titlename = "";
        public string TitleName
        { set { titlename = value; } get { return titlename; } }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(TitleName);
        }



    }
}