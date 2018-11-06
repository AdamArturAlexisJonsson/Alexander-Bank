using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{

    class Customer
    {
        public string name { get; set; }
        public string balance { get; set; }
        public string customerInfo()
        {
            return this.name;
        }
    }

}