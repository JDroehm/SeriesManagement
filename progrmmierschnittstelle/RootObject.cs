using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace progrmmierschnittstelle
{
   public class RootObject
    {
            public string status { get; set; }
            public int code { get; set; }
            public string message { get; set; }
            public Series data { get; set; }

        public RootObject()
        {

        }
    }
}
