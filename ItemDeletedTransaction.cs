using System;
using System.Collections.Generic;
using System.Text;

namespace StockManagement
{
    public class ItemDeletedTransaction : Transaction
    {
        private int _ItemCodeStock;
        private string _ItemNameStock;


        public int StockItemCode
        {
            get
            {
                return _ItemCodeStock;
            }
            set
            {
                _ItemCodeStock = value;
            }
        }

        public string StockItemName
        {
            get { return _ItemNameStock; }
            set { _ItemNameStock = value; }
        }


        public ItemDeletedTransaction(DateTime transactionDateTime, int stockItemCode, string stockItemName) : base(stockItemName, transactionDateTime)
        {


            StockItemCode = stockItemCode;

            StockItemName = stockItemName;

            transactionDateTime = DateTime.Now;


        }

        public override string ToString()
        {
            DateTime transactionDateTime = DateTime.Now;

            string dateStr = transactionDateTime.ToString("dd/MM/yyyy HH:mm");

            return (dateStr + "Quantity removed - Item " + StockItemCode + ": " + StockItemName + ". Quantity removed: " + QuantityRemoved + ". New quantity in stock: " + NewQuantityInStock + "");

        }


    }
}