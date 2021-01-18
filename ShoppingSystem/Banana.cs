using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingSystem
{
    class Banana:ProductFather
    {
        public Banana(string id, double price, double count)
            :base(id,price,count)
        {

        }
    }
}
