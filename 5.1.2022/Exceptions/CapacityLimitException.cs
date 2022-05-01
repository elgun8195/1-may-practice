using System;
using System.Collections.Generic;
using System.Text;

namespace _5._1._2022.Exceptions
{
    class CapacityLimitException:Exception
    {
        public CapacityLimitException(string message):base(message)
        {
        }
    }
}
