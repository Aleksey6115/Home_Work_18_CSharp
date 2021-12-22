using System;
using System.Collections.Generic;
using System.Text;

namespace Home_Work_18.Service.DialogAddPurchase.ProductForPurchase
{
    public class Telefon : IPurchase
    {
        public string ProductName { get => "Телефон"; }
        public int ProductCode { get => 11; }

        public override string ToString()
        {
            return ProductName;
        }
    }
}
