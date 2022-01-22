﻿using System;
using System.Collections.Generic;
using System.IO;
using Luciferin.BusinessLayer.Firefly.Models;
using Luciferin.BusinessLayer.Nordigen.Models;
using Newtonsoft.Json;

namespace Luciferin.BusinessLayer.Converters
{
    public abstract class ConverterBase : ITransactionConverter
    {
        #region Methods

        /// <inheritdoc />
        public virtual FireflyTransaction ConvertTransaction(Transaction transaction, string tag)
        {
            var amount = transaction.TransactionAmount.Amount.Replace("-", "");

            var fireflyTransaction = new FireflyTransaction
            {
                RequisitionIban = transaction.RequisitorIban,
                Amount = amount,
                Date = transaction.BookingDate,
                ExternalId = transaction.TransactionId ?? transaction.EntryReference
            };

            if (!string.IsNullOrWhiteSpace(tag))
                fireflyTransaction.Tags = new List<string> { tag };

            return FillTransactions(fireflyTransaction, transaction);
        }

        /// <summary>
        /// Gets the full notes description.
        /// </summary>
        /// <param name="transaction">The transaction.</param>
        /// <param name="otherNotes">Other notes to add.</param>
        /// <returns></returns>
        protected static string GetNotes(Transaction transaction, string otherNotes)
        {
            var mdNewLine = $"{Environment.NewLine}{Environment.NewLine}";
            
            var notes = new List<string>();

            notes.Add("# Import details");
            notes.Add($"Bank: {transaction.RequisitorBank.ToString()}");
            
            if(!string.IsNullOrWhiteSpace(transaction.CreditorName))
                notes.Add($"Creditor: {transaction.CreditorName}");
            
            if(!string.IsNullOrWhiteSpace(transaction.DebtorName))
                notes.Add($"Debtor: {transaction.DebtorName}");
            
            notes.Add("# Description");
            notes.Add(otherNotes);
            
            notes.Add("# Raw Data");
            notes.Add($"```json{Environment.NewLine}{transaction.RawData}{Environment.NewLine} ```");

            return string.Join(mdNewLine, notes);
        }

        /// <summary>
        /// Fills the transaction with correct data.
        /// </summary>
        /// <param name="fireflyTransaction">The new Firefly transaction.</param>
        /// <param name="transaction">The transaction to convert.</param>
        /// <returns></returns>
        protected abstract FireflyTransaction FillTransactions(FireflyTransaction fireflyTransaction, Transaction transaction);

        #endregion
    }
}