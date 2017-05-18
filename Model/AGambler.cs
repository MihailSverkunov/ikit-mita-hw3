using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public abstract class AGambler
    {
        public AGambler(string n)
        {
            Name = n;
        }

        public string Name { get; }

        public int Score { get; protected set; }

        public abstract void FetchNewNuber(int i);
    }
}
