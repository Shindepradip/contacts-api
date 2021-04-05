using Raven.Client.Documents;
using System;
using System.Collections.Generic;
using System.Text;

namespace Evolent.Persistance
{
    public interface IDBContext
    {
        public IDocumentStore store { get; }
    }
}
