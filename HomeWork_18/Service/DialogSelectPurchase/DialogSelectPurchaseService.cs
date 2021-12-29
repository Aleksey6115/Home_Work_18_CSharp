using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeWork_18.Model;

namespace HomeWork_18.Service.DialogSelectPurchase
{
    internal class DialogSelectPurchaseService
    {
        /// <summary>
        /// Открыть окно выборки
        /// </summary>
        public void OpenDialogSelectPurchase(List<Product> pList)
        {
            DialogSelectPurchaseWindow DSPW = new DialogSelectPurchaseWindow();
            DSPW.dataPurchase.ItemsSource = pList;

            DSPW.ShowDialog();
        }
    }
}
