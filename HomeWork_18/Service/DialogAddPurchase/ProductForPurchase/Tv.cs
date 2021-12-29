using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_18.Service.DialogAddPurchase.ProductForPurchase
{
    internal class Tv : IPurchase
    {
        public string ProductName { get => "Телевизор"; }
        public int ProductCode { get => 22; }

        public override string ToString()
        {
            return ProductName;
        }
    }
}
