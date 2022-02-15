using Automated_Car_Wash.Domain;
using System.Collections.Generic;
using System.Linq;

namespace Automated_Car_Wash.Repository
{
    public class ServiceStorage
    {
        private readonly Dictionary<int, Service> _Services = new();

        public Service Create(Service service)
        {

            _Services.Add(service.ServiceId, service);
            return service;

        }

        public Service Read(int ServiceId)
        {
            return _Services[ServiceId];
        }

        public Service Update(int ServiceId, Service newService)
        {
            _Services[ServiceId] = newService;
            return _Services[ServiceId];
        }

        public bool Delete(int ServiceId)
        {
            return _Services.Remove(ServiceId);
        }
    }
}