using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingSystem
{
    class SamSung:ProductFather
    {
        public SamSung(string id, double price, double count)
            : base(id, price, count)
        {

        }
    }
}
