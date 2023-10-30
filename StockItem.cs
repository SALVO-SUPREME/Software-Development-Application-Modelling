using System;
using System.Collections.Generic;
using System.Text;

namespace StockManagement
{
    public class StockItem
    {
        private int _code;
        private string _name;
        private int _quantityInStock;

        public int Code { get { return _code; } }
        public string Name { get { return _name; } }
        public int QuantityInStock { get { return _quantityInStock; } }

        private string _errorString;
        public StockItem(int code, string name, int quantityInStock)
        {
            if (code < 0) { _errorString += "Item code must be a positive integer. "; }
            if (String.IsNullOrEmpty(name)) { _errorString += "Item name cannot be blank. "; }
            else if (String.IsNullOrWhiteSpace(name)) { _errorString += "Item name cannot be just spaces. "; }
            if (quantityInStock < 1) { _errorString += "Quantity cannot be zero or negative. "; }
            if (!String.IsNullOrEmpty(_errorString)) { throw new Exception(_errorString); }

            _code = code;
            _name = name;
            _quantityInStock = quantityInStock;
        }

        public void AddQuantity(int quantity)
        {
            if (quantity < 0) { throw new Exception("Quantity cannot be negative"); }
            _quantityInStock += quantity;
        }

        public void SubtractQuantity(int quantity)
        {
            if (quantity < 0) { throw new Exception("Quantity cannot be negative"); }
            if (quantity > _quantityInStock) { throw new Exception("Insufficient quantity in stock"); }
            _quantityInStock -= quantity;
        }
    }
}