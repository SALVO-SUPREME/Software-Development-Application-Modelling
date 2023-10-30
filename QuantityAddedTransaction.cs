using System;
using System.Collections.Generic;
using System.Text;

namespace StockManagement
{
    public class QuantityAddedTransaction : Transaction
    {

        private int _stockItemCode;
        private string _stockItemName;
        private int _quantityAdded;
        private int _newQuantityInStock;


        public int StockItemCode
        {
            get { return _stockItemCode; }
            set { _stockItemCode = value; }
        }

        public string StockItemName
        {
            get { return _stockItemName; }
            set { _stockItemName = value; }
        }

        public int QuantityAdded
        {
            get { return _quantityAdded; }
            set { _quantityAdded = value; }
        }

        public int NewQuantityInStock
        {
            get
            {
                return
                   _newQuantityInStock;
            }
            set
            {
                _newQuantityInStock = value;
            }

        }

        public QuantityAddedTransaction(DateTime transactionDateTime, int stockItemCode, string stockItemName, int quantityAdded, int newQuantityInStock) : base(stockItemName, transactionDateTime)
        {

            transactionDateTime = DateTime.Now;

            StockItemCode = stockItemCode;
            StockItemName = stockItemName;
            QuantityAdded = quantityAdded;
            NewQuantityInStock = newQuantityInStock;
            transactionDateTime = DateTime.Now;

        }

        public override string ToString()
        {
            DateTime transactionDateTime = DateTime.Now;
            string dateStr = transactionDateTime.ToString("dd/MM/yyyy HH:mm");
            return ($"{dateStr} Quantity added   - Item {StockItemCode}: { StockItemName}. Quantity added: { QuantityAdded}. New quantity in stock: {NewQuantityInStock}");

        }

    }

}