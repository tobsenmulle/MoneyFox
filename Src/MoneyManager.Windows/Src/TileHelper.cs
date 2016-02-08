﻿using MoneyManager.Core.ViewModels;
using MoneyManager.Foundation;

namespace MoneyManager.Windows
{
    public class TileHelper : BaseViewModel
    {
        public bool DoNavigation(string tileId)
        {
            switch (tileId)
            {
                case Constants.ADD_INCOME_TILE_ID:
                    ShowViewModel<ModifyPaymentViewModel>(new {typeString = Constants.INCOME_TILE_ID});
                    return true;

                case Constants.ADD_SPENDING_TILE_ID:
                    ShowViewModel<ModifyPaymentViewModel>(new {typeString = Constants.SPENDING_TILE_ID});
                    return true;

                case Constants.ADD_TRANSFER_TILE_ID:
                    ShowViewModel<ModifyPaymentViewModel>(new {typeString = Constants.TRANSFER_TILE_ID});
                    return true;
                default:
                    return false;
            }
        }
    }
}