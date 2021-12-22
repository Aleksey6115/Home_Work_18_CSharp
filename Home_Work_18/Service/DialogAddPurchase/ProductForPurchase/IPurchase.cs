using System;
using System.Collections.Generic;
using System.Text;

namespace Home_Work_18.Service.DialogAddPurchase.ProductForPurchase
{
    /// <summary>
    /// Товар для покупки
    /// </summary>
    public interface IPurchase
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
