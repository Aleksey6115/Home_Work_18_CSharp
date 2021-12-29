using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_18.Service.DialogAddPurchase.ProductForPurchase
{
    internal class Computer : IPurchase
    {
        public string ProductName { get => "Компьютер"; }
        public int ProductCode { get => 55; }

        public override string ToString()
        {
            return ProductName;
        }
    }
}
