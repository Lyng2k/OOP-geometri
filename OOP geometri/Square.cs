using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_geometri
{
    public class Square
    {
        private int side;

        public int Side
        {
            get
            {
                return side;
            }
            set
            {
                side = value;
            }
        }
        public Square()
        {

        }
        public Square(int side)
        {
            this.side = side;
        }
        public int area()
        {
            int resultat = side * side;
            return resultat;
        }
        public int circumference()
        {
            int resultat = side * 4;
            return resultat;
        }

    }
}
