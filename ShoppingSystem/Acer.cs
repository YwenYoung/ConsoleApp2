using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingSystem
{
    class Acer:ProductFather
    {
        public Acer(string id, double price,double count)
            :base(id,price,count)
        {

        }  
    }
}
