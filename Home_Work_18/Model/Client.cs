using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Home_Work_18.Model
{
    /// <summary>
    /// Модель отображающая таблицу Clients
    /// </summary>
    public class Client
    {
        /// <summary>
        /// Идентификатор клиента
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Фамилия клиента
        /// </summary>
        [Required]
        public string lastName { get; set; }

        /// <summary>
        /// Имя клиента
        /// </summary>
        [Required]
        public string firstName { get; set; }

        /// <summary>
        /// Телефонный номер клиента
        /// </summary>
        public string phoneNumber { get; set; }

        /// <summary>
        /// email Клиента
        /// </summary>
        [Required]
        public string email { get; set; }
    }
}
