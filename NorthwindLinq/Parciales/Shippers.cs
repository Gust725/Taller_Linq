using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NorthwindLinq
{
    public partial class Shippers
    {
        public string DescripcionShippers()
        {
            return CompanyName + " " + Phone ;
        }
    }
}