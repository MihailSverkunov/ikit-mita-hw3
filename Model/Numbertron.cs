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
        Random r = new Random();

        public void GenerateNumber()
        {
            NewNumber(r.Next(0, 99));
        }
    }
}
