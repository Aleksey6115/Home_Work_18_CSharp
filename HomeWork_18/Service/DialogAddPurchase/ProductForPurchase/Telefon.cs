using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_18.Service.DialogAddPurchase.ProductForPurchase
{
    internal class Telefon : IPurchase
    {
        public string ProductName { get => "Телефон"; }
        public int ProductCode { get => 11; }

        public override string ToString()
        {
            return ProductName;
        }
    }
}
