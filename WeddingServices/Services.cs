using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeddingServices
{
    public abstract class Services
    {
        public double price { get; set; }

        public virtual void Print()
        {

        }
    }
}
