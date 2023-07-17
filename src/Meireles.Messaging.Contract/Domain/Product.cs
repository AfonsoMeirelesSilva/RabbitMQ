using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meireles.Messaging.Contract.Domain
{
    public class Product : BaseDomain
    {
        public float Price { get; set; }
        public string Name { get; set; }
    }
}
