using System;
using System.Collections.Generic;
using System.Text;

namespace StockManagement
{
    public class QuantityRemovedTransaction : Transaction
    {

        private int _stockItemCode;
        private string _stockItemName;
        private int _quantityRemoved;
        private int _newQuantityInStock;


        public int StockItemCode
        {
            get
            {
                return _stockItemCode;
            }
            set
            {
                _stockItemCode = value;
            }
        }

        public string StockItemName
        {
            get
            {
                return _stockItemName;
            }
            set
            {
                _stockItemName = value;
            }
        }

        public int QuantityRemoved
        {
            get
            {
                return _quantityRemoved;
            }
            set
            {
                _quantityRemoved = value;
            }
        }

        public int NewQuantityInStock
        {
            get
            {
                return _newQuantityInStock;
            }
            set
            {
                _newQuantityInStock = value;
            }

        }

        public QuantityRemovedTransaction(DateTime transactionDateTime, int stockItemCode, string stockItemName, int quantityRemoved, int newQuantityInStock) : base(stockItemName, transactionDateTime)
        {


            StockItemCode = stockItemCode;

            StockItemName = stockItemName;

            QuantityRemoved = quantityRemoved;

            NewQuantityInStock = newQuantityInStock;

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