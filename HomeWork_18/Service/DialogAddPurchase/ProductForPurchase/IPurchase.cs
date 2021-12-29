using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_18.Service.DialogAddPurchase.ProductForPurchase
{
    internal interface IPurchase
    {
        /// <summary>
        /// Имя товара
        /// </summary>
        string ProductName { get; }

        /// <summary>
        /// Код товара
        /// </summary>
        int ProductCode { get; }
    }
}
