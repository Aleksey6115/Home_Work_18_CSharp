using System;
using System.Data.Entity;
using Home_Work_18.Model;
using System.Windows;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;

namespace Home_Work_18.Service.DataBase
{
    /// <summary>
    /// Работа с Базами данных
    /// </summary>
    public class DataBaseService
    {

        #region поля
        private bool connectionFlag = false; // Есть ли подключение
        private ClientContext cc; // Подключение к Sql базе
        private ProductContext pc; // Подключение к БД Access
        #endregion

        #region свойства
        /// <summary>
        /// Список клиентов
        /// </summary>
        public BindingList<Client> ClientsList { get; set; }

        /// <summary>
        /// Список покупок
        /// </summary>
        public BindingList<Product> ProductList { get; set; }

        /// <summary>
        /// Есть ли подключение
        /// </summary>
        public bool ConnectionFlag 
        {
            get => connectionFlag;
        }

        /// <summary>
        /// Статус подключения
        /// </summary>
        public string ConnectionStatus
        {
            get => $"Статус подключения: {ConnectionFlag}";
        }
        #endregion

        #region методы
        /// <summary>
        /// Открыть подключение
        /// </summary>
        private bool DataBaseConnectionOpen()
        {
            try
            {
                cc = new ClientContext();
                pc = new ProductContext();

                cc.Clients.Load();
                ClientsList = cc.Clients.Local.ToBindingList<Client>();

                pc.Products.Load();
                ProductList = pc.Products.Local.ToBindingList<Product>();

                connectionFlag = true;

                MessageBox.Show(ConnectionStatus, "Статус подключения", MessageBoxButton.OK, MessageBoxImage.Information);
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
        }

        /// <summary>
        /// Закрыть подключения
        /// </summary>
        public void DataBaseConnectionClose()
        {
            if (ConnectionFlag)
            {
                try
                {
                    cc.Dispose();
                    pc.Dispose();

                    MessageBox.Show("Подключение закрыто", "Статус подключения", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        /// <summary>
        /// Сохранить изменения в БД
        /// </summary>
        public void DataBaseSave()
        {
            if (ConnectionFlag)
            {
                try
                {
                    cc.SaveChanges();
                    pc.SaveChanges();
                    MessageBox.Show("БД обновлена", "Сообщение", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        /// <summary>
        /// Выборка по покупкам
        /// </summary>
        /// <param name="emailClient"></param>
        /// <returns></returns>
        public List<Product> DBselectFromProduct(string emailClient)
        {
            List<Product> pList = new List<Product>();

            if (ConnectionFlag)
            {
                pList = ProductList.Where(p => p.email == emailClient).ToList();
            }
            return pList;
        }
        #endregion

        #region Задачи
        /// <summary>
        /// Ассинхронный запуск метода DataBaseConnectionOpen
        /// </summary>
        public async Task<bool> DataBaseConnectionOpenAsync()
        {
            return await Task.Run(() => DataBaseConnectionOpen());
        }
        #endregion
    }
}
