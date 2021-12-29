using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_18.Model
{
    internal class Client
    {
        /// <summary>
        /// Идентификатор клиента
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Фамилия клиента
        /// </summary>
        public string lastName { get; set; }

        /// <summary>
        /// Имя клиента
        /// </summary>
        public string firstName { get; set; }

        /// <summary>
        /// Телефонный номер клиента
        /// </summary>
        public string phoneNumber { get; set; }

        /// <summary>
        /// email Клиента
        /// </summary>
        public string email { get; set; }

        public string note { get; set; }

        public int age { get; set; }
    }
}
