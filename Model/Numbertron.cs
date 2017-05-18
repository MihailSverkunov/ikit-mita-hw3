using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Numbertron
    {
        public delegate void NewNumberDelegate(int i);
        public event NewNumberDelegate NewNumber;

        public void GenerateNumber(Random r)
        {
            NewNumber(r.Next(0, 99));
        }
    }
}
