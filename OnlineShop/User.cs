using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop
{
    public class User 
    {
        public int id;
        public string firstName;
        public string secondName;

    }

    public class Customer : User
    {
        public int Wallet { get; set; }

        public UserCart UserCart
        {
            get => default(UserCart);
            set
            {
            }
        }
    }

    public class Admin : User
    {

    }

    public class Manager : User
    {
        public string Company { get; set; }
    }
}
