using Automated_Car_Wash.Domain;
using System.Collections.Generic;
using System.Linq;

namespace Automated_Car_Wash.Repository
{
    public class ClientStorage
    {
        private readonly Dictionary<int, Client> _Clients = new();

        public Client Create(Client client)
        {

            _Clients.Add(client.ClientId, client);
            return client;

        }

        public Client Read(int ClientId)
        {
            return _Clients[ClientId];
        }

        public Client Update(int ClientId, Client newClient)
        {
            _Clients[ClientId] = newClient;
            return _Clients[ClientId];
        }

        public bool Delete(int ClientId)
        {
            return _Clients.Remove(ClientId);
        }
    }
}