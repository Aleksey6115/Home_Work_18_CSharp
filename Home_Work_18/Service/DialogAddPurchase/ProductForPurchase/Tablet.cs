using System;
using System.Collections.Generic;
using System.Text;

namespace Home_Work_18.Service.DialogAddPurchase.ProductForPurchase
{
    public class Tablet : IPurchase
    {
        public string ProductName { get => "Планшет"; }
        public int ProductCode { get => 44; }

        public override string ToString()
        {
            return ProductName;
        }
    }
}
