using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithematicOperations
{
    public class Arithematic
    {
        public static void Main(string[] args)
        {
        }
            public virtual bool Add
            {
                get{ 
                return false; 
            }
            set { }
            }
            public virtual bool sub
            {
            get { return false; }
            set { }
            }
            public int multiply(int x, int y)
            {
                return (x * y);
            }
    }
}
