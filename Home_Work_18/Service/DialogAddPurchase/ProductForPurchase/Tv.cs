using System;
using System.Collections.Generic;
using System.Text;

namespace Home_Work_18.Service.DialogAddPurchase.ProductForPurchase
{
    public class Tv : IPurchase
    {
        public string ProductName { get => "Телевизор"; }
        public int ProductCode { get => 22; }

        public override string ToString()
        {
            return ProductName;
        }
    }
}
