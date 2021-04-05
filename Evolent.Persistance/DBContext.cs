using Microsoft.Extensions.Options;
using Raven.Client.Documents;
using System;
using System.Collections.Generic;
using System.Text;
using Raven.Client.Documents.Operations;
using Raven.Client.ServerWide.Operations;
using Raven.Client.ServerWide;
using Raven.Client.Exceptions.Database;

namespace Evolent.Persistance
{
    public class DBContext : IDBContext
    {
        private readonly IDocumentStore _localStore;

        public IDocumentStore store => _localStore;


        private readonly PersistanceSettings _persistanceSettings;

        public DBContext(IOptionsMonitor<PersistanceSettings> settings)
        {
            _persistanceSettings = settings.CurrentValue;

            _localStore = new DocumentStore()
            {
                Database = _persistanceSettings.DatabaseName,
                Urls = _persistanceSettings.URLs
            };

            _localStore.Initialize();

            EnsureDatabaseIsDataCreated();

        }

       
        public void EnsureDatabaseIsDataCreated()
        {
            try
            {

                _localStore.Maintenance.ForDatabase(_persistanceSettings.DatabaseName).Send(new GetStatisticsOperation());

            }
            catch (DatabaseDoesNotExistException ex)
            {

                _localStore.Maintenance.Server.Send(new CreateDatabaseOperation(new DatabaseRecord(_persistanceSettings.DatabaseName)));
            }
        }
    }
}
