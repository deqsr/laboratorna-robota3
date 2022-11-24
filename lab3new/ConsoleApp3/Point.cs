using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Point
    {
        private readonly int x;

        private readonly int y;

        private readonly string name;
        public int X => x;
        public int Y => y;
        public string Name => name;

        public Point(int x, int y, string figurename)
        {
            this.x = x;
            this.y = y;
            this.name = figurename;
        }
    }
}

