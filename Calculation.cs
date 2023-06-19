using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_XUnit_Acceptanstestning
{
    public class Calculation
    {
        public double Num1 { get; set; }
        public double Num2 { get; set; }
        public string Operator { get; set; }
        public double Result { get; set; }

        public override string ToString()
        {
            return $"{Num1} {Operator} {Num2} = {Result}";
        }
    }
}
