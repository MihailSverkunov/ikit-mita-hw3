using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Jay : AGambler
    {
        public Jay() : base("Jay")
        {
        }

        public override void FetchNewNuber(int i)
        {
            if(i.IsEven())
            {
                Score++;
            }
        }
    }
}
