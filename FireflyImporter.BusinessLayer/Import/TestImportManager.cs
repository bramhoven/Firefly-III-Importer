﻿using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using FireflyImporter.BusinessLayer.Configuration.Interfaces;
using FireflyImporter.BusinessLayer.Firefly;
using FireflyImporter.BusinessLayer.Import.Mappers;
using FireflyImporter.BusinessLayer.Logger;
using FireflyImporter.BusinessLayer.Nordigen;
using FireflyImporter.BusinessLayer.Nordigen.Models;
using Microsoft.Extensions.Logging;

namespace FireflyImporter.BusinessLayer.Import
{
    public class TestImportManager : ImportManagerBase
    {
        #region Constructors

        public TestImportManager(INordigenManager nordigenManager,
                                 IFireflyManager fireflyManager,
                                 IImportConfiguration importConfiguration,
                                 ILogger<ImportManager> logger,
                                 ICompositeLogger compositeLogger) : base(nordigenManager, fireflyManager, importConfiguration, logger, compositeLogger) { }

        #endregion

        #region Methods

        /// <inheritdoc />
        public override async ValueTask StartImport(CancellationToken cancellationToken)
        {
            var existingFireflyTransactions = await GetExistingFireflyTransactions();
            var requisitions = await GetRequisitions();

            Logger.LogInformation($"Start import for {requisitions.Count} connected banks");

            var firstImport = !existingFireflyTransactions.Any();
            var balances = new Dictionary<string, string>();
            var newTransactions = new List<Transaction>();
            foreach (var requisition in requisitions)
            {
                foreach (var account in requisition.Accounts)
                {
                    newTransactions.AddRange(await GetTransactionForRequisitionAccount(account, requisition));

                    var details = await NordigenManager.GetAccountDetails(account);
                    var balance = await NordigenManager.GetAccountBalance(account);
                    balances.Add(details.Iban, balance.FirstOrDefault()?.BalanceAmount.Amount);
                }
            }

            Logger.LogInformation($"Retrieved a total of {newTransactions.Count} transactions");

            var accounts = await FireflyManager.GetAccounts();
            var newFireflyTransactions = TransactionMapper.MapTransactionsToFireflyTransactions(newTransactions, accounts, null).ToList();

            newFireflyTransactions = RemoveExistingTransactions(newFireflyTransactions, existingFireflyTransactions).ToList();
            newFireflyTransactions = CheckForDuplicateTransfers(newFireflyTransactions, existingFireflyTransactions, balances.Keys).ToList();

            if (!newFireflyTransactions.Any())
            {
                Logger.LogInformation("No new transactions to import");
                return;
            }

            Logger.LogInformation($"Would import {newFireflyTransactions.Count} transactions");

            if (!firstImport)
                return;

            Logger.LogInformation("Would set asset account opening balances");
        }

        #endregion
    }
}