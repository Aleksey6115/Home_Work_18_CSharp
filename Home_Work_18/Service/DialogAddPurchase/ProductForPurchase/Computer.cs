using System;
using System.Collections.Generic;
using System.Text;

namespace Home_Work_18.Service.DialogAddPurchase.ProductForPurchase
{
    public class Computer : IPurchase
    {
        public string ProductName { get => "Компьютер"; }
        public int ProductCode { get => 55; }

        public override string ToString()
        {
            return ProductName;
        }
    }
}
