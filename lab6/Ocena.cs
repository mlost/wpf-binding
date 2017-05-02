using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    public class Ocena
    {
        public double value { get; set; }
        public string subject { get; set; }
        public string description { get; set; }
        public Ocena(double a, string b, string c)
        {
            value = a;
            subject = b;
            description = c;
        }
    }
}
