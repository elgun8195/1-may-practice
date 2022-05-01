using System;
using System.Collections.Generic;
using System.Text;

namespace _5._1._2022.Interfaces
{
    interface IPerson
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public string ShowInfo();

    }
}
