using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop
{
    public class Cart
    {
        public int id;
        public int amount;
        public int totalPrice;

        public void Clear(int id)
        {
            this.id = 0;
            this.amount = 0;
            this.totalPrice = 0;
        }


    }
}
