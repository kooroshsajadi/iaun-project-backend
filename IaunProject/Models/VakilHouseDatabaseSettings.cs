using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IaunProject.Models
{
    public class VakilHouseDatabaseSettings : IVakilHouseDatabaseSettings
    {
        public string UsersCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
    public interface IVakilHouseDatabaseSettings
    {
        string UsersCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}
