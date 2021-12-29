using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_18.Service.DialogAddPurchase.ProductForPurchase
{
    internal class Player : IPurchase
    {
        public string ProductName { get => "MP3 Плеер"; }
        public int ProductCode { get => 33; }

        public override string ToString()
        {
            return ProductName;
        }
    }
}
