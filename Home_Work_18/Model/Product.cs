using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;


namespace Home_Work_18.Model
{
    /// <summary>
    /// Модель отображает таблицу Product
    /// </summary>
    public class Product
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// email покупателя
        /// </summary>
        [Required]
        public string email { get; set; }

        /// <summary>
        /// Код товара
        /// </summary>
        [Required]
        public int productCode { get; set; }

        /// <summary>
        /// Наименование товара
        /// </summary>
        [Required]
        public string productName { get; set; }
    }
}
