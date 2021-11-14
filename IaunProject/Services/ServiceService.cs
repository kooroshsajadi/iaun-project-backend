using System;
using System.Collections.Generic;
using System.Linq;
using MongoDB.Driver;
using IaunProject.Models;

namespace IaunProject.Services
{
    public class ServiceService
    {
        private readonly IMongoCollection<Service> _services;

        public ServiceService(IVakilHouseDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _services = database.GetCollection<Service>(settings.ServicesCollectionName);
        }

        public List<Service> Get()
        {
            return _services.Find(service => true).ToList();
        }

        public Service Get(string id)
        {
            return _services.Find(service => service.Id == id).FirstOrDefault();
        }

        public List<Service> Get(List<string> ids)
        {
            return _services.Find(service => ids.Contains(service.Id)).ToList();
        }

        public Service Create(Service service)
        {
            _services.InsertOne(service);
            return service;
        }

        public void Update(string id, Service service)
        {
            _services.ReplaceOne(service => service.Id == id, service);
        }

        public void Remove(Service serviceIn)
        {
            _services.DeleteOne(service => service.Id == serviceIn.Id);
        }

        public void Remove(string id)
        {
            _services.DeleteOne(service => service.Id == id);
        }
    }
}
