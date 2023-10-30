using System;
using System.Collections.Generic;
using System.Text;

namespace StockManagement
{
    public class StockManager
    {
        private SortedDictionary<int, StockItem> _stockItems = new SortedDictionary<int, StockItem>();

        public SortedDictionary<int, StockItem> GetAllStockItems()
        {
            return _stockItems;
        }

        public StockItem CreateStockItem(int code, string name, int quantityInStock)
        {
            if (_stockItems.TryGetValue(code, out var item))
            {
                throw new Exception("Item code " + code + " already exists. Item not added.");
            }

            StockItem newItem = new StockItem(code, name, quantityInStock);
            _stockItems.Add(code, newItem);

            return newItem;
        }

        public StockItem FindStockItem(int code)
        {
            _stockItems.TryGetValue(code, out var item);

            return item;
        }

        public StockItem AddQuantityToStockItem(int code, int quantityToAdd)
        {
            if (!_stockItems.TryGetValue(code, out var item))
            {
                throw new Exception("Stock item " + code + " not found. Quantity not added.");
            }

            item.AddQuantity(quantityToAdd);

            return item;
        }

        public StockItem RemoveQuantityFromStockItem(int code, int quantityToRemove)
        {
            if (!_stockItems.TryGetValue(code, out var item))
            {
                throw new Exception("Stock item " + code + " not found. Quantity not removed.");
            }

            item.SubtractQuantity(quantityToRemove);

            return item;
        }

        public StockItem DeleteStockItem(int code)
        {
            if (!_stockItems.TryGetValue(code, out var item))
            {
                throw new Exception("Item has not been deleted because it cannot be found");
            }

            if (item.QuantityInStock > 0)
            {
                throw new Exception("Item cannot be deleted because quantity in stock is not zero");
            }

            _stockItems.Remove(code);

            return item;
        }
    }
}