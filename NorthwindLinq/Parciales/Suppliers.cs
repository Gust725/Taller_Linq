using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NorthwindLinq
{
    public partial class Suppliers
    {
        public string DescripcionSuppliers()
        {
            return CompanyName + " " + ContactName + " " + ContactTitle;
        }
    }
}