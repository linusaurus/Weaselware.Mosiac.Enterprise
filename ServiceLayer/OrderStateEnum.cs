using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLayer
{
    public enum OrderStateEnum
    {
        Created,
        Ordered,
        RecievedComplete,
        RecievedIncomplete,
        Canceled,
        Returned
    }
}
