using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_18.Service.DialogAddPurchase.ProductForPurchase
{
    internal class Tablet : IPurchase
    {
        public string ProductName { get => "Планшет"; }
        public int ProductCode { get => 44; }

        public override string ToString()
        {
            return ProductName;
        }
    }
}
