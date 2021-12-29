using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_18.Model
{
    internal class Product
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// email покупателя
        /// </summary>
        public string email { get; set; }

        /// <summary>
        /// Код товара
        /// </summary>
        public int productCode { get; set; }

        /// <summary>
        /// Наименование товара
        /// </summary>
        public string productName { get; set; }
    }
}
