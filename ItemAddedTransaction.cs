using System;
using System.Collections.Generic;
using System.Text;

namespace StockManagement
{
    public class ItemAddedTransaction : Transaction
    {

        private int _ItemCodeStock;
        private string _ItemNameStock;
        private int _QuantityPlus;

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
            get
            {
                return _ItemNameStock;
            }
            set
            {
                _ItemNameStock = value;
            }
        }

        public int QuantityAdded
        {
            get
            {
                return _QuantityPlus;
            }
            set
            {
                _QuantityPlus = value;
            }
        }

        public ItemAddedTransaction(DateTime transactionDateTime, int stockItemCode, string stockItemName, int quantityAdded) : base(stockItemName, transactionDateTime)
        {


            StockItemCode = stockItemCode;

            StockItemName = stockItemName;

            QuantityAdded = quantityAdded;

            transactionDateTime = DateTime.Now;
        }

        public override string ToString()
        {
            DateTime transactionDateTime = DateTime.Now; 
            string dateStr = transactionDateTime.ToString("dd/MM/yyyy HH:mm"); 
            return (dateStr + " Item added       - Item " + StockItemCode + ": " + StockItemName + " added. There is" + QuantityAdded "Quantity in stock"); 

        }

    }
}