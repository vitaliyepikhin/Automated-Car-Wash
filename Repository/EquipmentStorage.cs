using Automated_Car_Wash.Domain;
using System.Collections.Generic;
using System.Linq;

namespace Automated_Car_Wash.Repository
{
    public class EquipmentStorage
    {
        private readonly Dictionary<int, Equipment> _Equipments = new();

        public Equipment Create(Equipment equipment)
        {

            _Equipments.Add(equipment.EquipmentId, equipment);
            return equipment;

        }

        public Equipment Read(int EquipmentId)
        {
            return _Equipments[EquipmentId];
        }

        public Equipment Update(int EquipmentId, Equipment newEquipment)
        {
            _Equipments[EquipmentId] = newEquipment;
            return _Equipments[EquipmentId];
        }

        public bool Delete(int EquipmentId)
        {
            return _Equipments.Remove(EquipmentId);
        }
    }
}