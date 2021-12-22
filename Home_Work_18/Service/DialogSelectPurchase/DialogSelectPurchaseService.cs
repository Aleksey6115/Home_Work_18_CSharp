using System;
using System.Collections.Generic;
using System.Text;
using Home_Work_18.Model;

namespace Home_Work_18.Service.DialogSelectPurchase
{
    /// <summary>
    /// Логика окна выборка по покупкам
    /// </summary>
    public class DialogSelectPurchaseService
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
