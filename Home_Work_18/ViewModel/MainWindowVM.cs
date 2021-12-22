using System;
using System.Collections.Generic;
using MVVMWpfLibraryBase;
using Home_Work_18.Service.DataBase;
using Home_Work_18.Model;
using System.ComponentModel;
using Home_Work_18.Service.DialogAuthorization;
using Home_Work_18.Service.DialogAddPurchase;
using System.Windows;
using Home_Work_18.Service.DialogSelectPurchase;

namespace Home_Work_18.ViewModel
{
    public class MainWindowVM : ViewModelBase
    {
        #region Поля
        private BindingList<Client> clientsList = new BindingList<Client>(); // Список клиентов
        private BindingList<Product> productList = new BindingList<Product>(); // Список покупок
        private Client selectedClient; // Выбранный клиент
        private Product selectedProduct; // Выбранная покупка
        #endregion

        #region Свойства

        /// <summary>
        /// Список клиентов
        /// </summary>
        public BindingList<Client> ClientsList
        {
            get => clientsList;
            set => Set(ref clientsList, value);
        }

        /// <summary>
        /// Список покупок
        /// </summary>
        public BindingList<Product> ProductList
        {
            get => productList;
            set => Set(ref productList, value);
        }

        /// <summary>
        /// Выбранный клиент
        /// </summary>
        public Client SelectedClient
        {
            get => selectedClient;
            set => Set(ref selectedClient, value);
        }

        /// <summary>
        /// Выбранная покупка
        /// </summary>
        public Product SelectedProduct
        {
            get => selectedProduct;
            set => Set(ref selectedProduct, value);
        }

        #endregion

        #region Сервисы
        DataBaseService DBService = new DataBaseService(); // Сервис работы с БД
        DialogAddPurchaseService AddPurchaseService = new DialogAddPurchaseService(); // Сервис окна добавить покупку
        DialogAuthorizationService AuthorizationService = new DialogAuthorizationService(); // Сервис окна авторизации
        DialogSelectPurchaseService SelectPurchaseService = new DialogSelectPurchaseService(); // Сервис окна выборки
        #endregion

        #region Комманды
        private RelayCommand connectionOpenCommand; // Подключиться к БД
        private RelayCommand addClientCommand; // Добавить нового клиента
        private RelayCommand dataBaseSaveCommand; // Сохранить изменения в БД
        private RelayCommand removeClientCommand; // Удалить клиента
        private RelayCommand addPurchaseCommand; // Добавить покупку
        private RelayCommand viewStatusConnection; // Показать состояние подключения
        private RelayCommand clearClientsCommand; // Очистить таблицу Clients
        private RelayCommand removeProductCommand; // Отменить покупку
        private RelayCommand clearProductsCommand; // Очистить таблицу Products
        private RelayCommand selectPurchaseCommand; // Выборка по покупкам
        private RelayCommand dataBaseDisposeCommand; // Закрыть подключение

        /// <summary>
        /// Подключиться к БД
        /// </summary>
        public RelayCommand ConnectionOpenCommand
        {
            get
            {
                return connectionOpenCommand ?? (connectionOpenCommand = new RelayCommand(async obj =>
                {
                    if (AuthorizationService.OpenAuthorizationDialog() == true)
                    {
                        if (await DBService.DataBaseConnectionOpenAsync() == true)
                        {
                            ClientsList = DBService.ClientsList;
                            ProductList = DBService.ProductList;
                        }
                    }
                },
                obj =>
                {
                    if (!DBService.ConnectionFlag) return true;
                    else return false;
                }));
            }
        }

        /// <summary>
        /// Добавить нового клиента
        /// </summary>
        public RelayCommand AddClientCommand
        {
            get
            {
                return addClientCommand ?? (addClientCommand = new RelayCommand(obj =>
                {
                    ClientsList.Add(new Client());
                },
                obj =>
                {
                    return DBService.ConnectionFlag;
                }));
            }
        }

        /// <summary>
        /// Сохранить БД
        /// </summary>
        public RelayCommand DataBaseSaveCommand
        {
            get
            {
                return dataBaseSaveCommand ?? (dataBaseSaveCommand = new RelayCommand(obj =>
                {
                    DBService.DataBaseSave();
                },
                obj =>
                {
                    return DBService.ConnectionFlag;
                }));
            }
        }

        /// <summary>
        /// Удалить клиента
        /// </summary>
        public RelayCommand RemoveClientCommand
        {
            get
            {
                return removeClientCommand ?? (removeClientCommand = new RelayCommand(obj =>
                {
                    ClientsList.Remove(SelectedClient);
                },
                obj =>
                {
                    if (SelectedClient != null) return true;
                    else return false;
                }));
            }
        }

        /// <summary>
        /// Добавить покупку
        /// </summary>
        public RelayCommand AddPurchaseCommand
        {
            get
            {
                return addPurchaseCommand ?? (addPurchaseCommand = new RelayCommand(obj =>
                {
                    if (AddPurchaseService.OpenAddPurchaseDialog() == true)
                    {
                        Product product = new Product()
                        {
                            email = SelectedClient.email,
                            productCode = AddPurchaseService.SelectedProduct.ProductCode,
                            productName = AddPurchaseService.SelectedProduct.ProductName
                        };

                        ProductList.Add(product);
                    }
                },
                obj =>
                {
                    if (SelectedClient != null) return true;
                    else return false;
                }));
            }
        }

        /// <summary>
        /// Показать состояние подключения
        /// </summary>
        public RelayCommand ViewStatusConnection
        {
            get
            {
                return viewStatusConnection ?? (viewStatusConnection = new RelayCommand(obj =>
                {
                    MessageBox.Show(DBService.ConnectionStatus, "Статус подключения", MessageBoxButton.OK, MessageBoxImage.Information);
                }));
            }
        }

        /// <summary>
        /// Очистить таблицу Clients
        /// </summary>
        public RelayCommand ClearClientsCommand
        {
            get
            {
                return clearClientsCommand ?? (clearClientsCommand = new RelayCommand(obj =>
                {
                    ClientsList.Clear();
                },
                obj =>
                {
                    return DBService.ConnectionFlag;
                }));
            }
        }

        /// <summary>
        /// Отменить покупку
        /// </summary>
        public RelayCommand RemoveProductCommand
        {
            get
            {
                return removeProductCommand ?? (removeProductCommand = new RelayCommand(obj =>
                {
                    ProductList.Remove(SelectedProduct);
                },
                obj =>
                {
                    if (SelectedProduct != null) return true;
                    else return false;
                }));
            }
        }

        /// <summary>
        /// Очистить таблицу Products
        /// </summary>
        public RelayCommand ClearProductsCommand
        {
            get
            {
                return clearProductsCommand ?? (clearProductsCommand = new RelayCommand(obj =>
                {
                    ProductList.Clear();
                },
                obj =>
                {
                    return DBService.ConnectionFlag;
                }));
            }
        }

        /// <summary>
        /// Выборка по покупкам
        /// </summary>
        public RelayCommand SelectPurchaseCommand
        {
            get
            {
                return selectPurchaseCommand ?? (selectPurchaseCommand = new RelayCommand(obj =>
                {
                    SelectPurchaseService.OpenDialogSelectPurchase(DBService.DBselectFromProduct(SelectedClient.email));
                },
                obj =>
                {
                    if (SelectedClient != null) return true;
                    else return false;
                }));
            }
        }

        /// <summary>
        /// Закрыть подключение
        /// </summary>
        public RelayCommand DataBaseDisposeCommand
        {
            get
            {
                return dataBaseDisposeCommand ?? (dataBaseDisposeCommand = new RelayCommand(obj =>
                {
                    DBService.DataBaseConnectionClose();
                },
                obj =>
                {
                    return DBService.ConnectionFlag;
                }));
            }
        }

        #endregion
    }
}
