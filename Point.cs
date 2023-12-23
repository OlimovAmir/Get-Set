using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Get_Set
{
    internal class Point
    {
        private int X;

        public void SetX(int X)
        {
            if (X < 1)
            {
                this.X = 1;
                return;
            }
            if (X > 5)
            {
                this.X = 5;
                return;
            }
            this.X = X;
        }

        public int GetX()
        {
            return X;
        }

        private int y;

        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        public int Z { get; set; }
    }
}
