using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class SilentBob  : AGambler
    {
        public SilentBob() : base("SilentBob")
        {
        }

        public override void FetchNewNuber(int i)
        {
            if (!i.IsEven())
            {
                Score++;
            }
        }
    }
}
