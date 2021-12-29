using System;
using System.Collections.Generic;
using System.Text;
using HomeWork_18.Service.DialogAddPurchase.ProductForPurchase;

namespace HomeWork_18.Service.DialogAddPurchase
{
    internal class DialogAddPurchaseService
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
