using System;
using System.Collections.Generic;
using System.Text;

namespace StockManagement
{
    public class TransactionManager
    {
        List<Transaction> _transaction = new List<Transaction>();

        public List<Transaction> GetAllTransactions()
        {
            return _transaction;
        }

        public void RecordItemAdded(StockItem stockItem)
        {
            Transaction transaction = new ItemAddedTransaction(DateTime.Now, stockItem.Code, stockItem.Name, stockItem.QuantityInStock);
            _transaction.Add(transaction);
        }

        public void RecordItemDeleted(StockItem stockItem)
        {
            Transaction transaction = new ItemDeletedTransaction(DateTime.Now, stockItem.Code, stockItem.Name);
            _transaction.Add(transaction);
        }

        public void RecordQuantityAdded(StockItem stockItem, int quantityAdded)
        {
            Transaction transaction = new QuantityAddedTransaction(DateTime.Now, stockItem.Code, stockItem.Name, quantityAdded, stockItem.QuantityInStock + quantityAdded);
            _transaction.Add(transaction);
        }

        public void RecordQuantityRemoved(StockItem stockItem, int quantityRemoved)
        {
            Transaction transaction = new QuantityRemovedTransaction(DateTime.Now, stockItem.Code, stockItem.Name, quantityRemoved, stockItem.QuantityInStock - quantityRemoved);
            _transaction.Add(transaction);
        }
    }
}
