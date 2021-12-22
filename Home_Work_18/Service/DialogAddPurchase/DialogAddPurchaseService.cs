using System;
using System.Collections.Generic;
using System.Text;
using Home_Work_18.Service.DialogAddPurchase.ProductForPurchase;

namespace Home_Work_18.Service.DialogAddPurchase
{
    /// <summary>
    /// Логика окна добавить покупку
    /// </summary>
    public class DialogAddPurchaseService
    {
        /// <summary>
        /// Выбранный товар
        /// </summary>
        public IPurchase SelectedProduct { get; set; }

        private List<IPurchase> productList = new List<IPurchase>() { new Telefon(), new Tv(), new Tablet(), new Player(), new Computer() };

        public bool OpenAddPurchaseDialog()
        {
            DialogAddPurchaseWindow DAPW = new DialogAddPurchaseWindow();
            DAPW.comboProduct.ItemsSource = productList;

            if (DAPW.ShowDialog() == true)

            {
                if (DAPW.comboProduct.SelectedItem == null) return false;

                SelectedProduct = DAPW.comboProduct.SelectedItem as IPurchase;
                return true;
            }

            return false;
        }

    }
}
