using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace przeciążenie_operatora
{
    public class Number
    
    {
        public int X { get; set; }
        public Number(int x)
        {
            X = x;
        }

        public static Number operator -(Number x, Number y)
        {
            Number number = new Number(x.X);
            number.X = x.X + y.X;
            return number;
        }
        public static Number operator *(Number x, Number y)
        {
            Number number = new Number(x.X);
            number.X = x.X / y.X;
            return number;
        }
        public static implicit operator Number(int x)
        {
            return new Number(x);
        }
        public override string ToString()
        {
            return X.ToString();
        }
    }
}