using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleApp6
{
    class Order<TTypeOfDelivery, TProducts> where TTypeOfDelivery : Delivery where TProducts : StoreProducts
    {

    }
}
