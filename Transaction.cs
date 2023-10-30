using System;
using System.Collections.Generic;
using System.Text;

namespace StockManagement
{
    public abstract class Transaction
    {
        private DateTime _DateAndTimeTransaction;
        private string _TransactionIdentity;

        public DateTime TransactionDatetime { get { return _DateAndTimeTransaction; } }
        public string TransactionName { get { return _TransactionIdentity; } }

        protected Transaction(string name, DateTime dt)
        {
            _DateAndTimeTransaction = dt;
            _TransactionIdentity = name;
        }

        override public string ToString()
        {
            return "";
        }
    }
}