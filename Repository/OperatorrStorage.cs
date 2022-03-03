using Automated_Car_Wash.Domain;
using System.Collections.Generic;
using System.Linq;

namespace Automated_Car_Wash.Repository
{
    public class OperatorrStorage
    {
        private readonly Dictionary<int, Operatorr> _Operatorrs = new();

        public Operatorr Create(Operatorr operatorr)
        {

            _Operatorrs.Add(operatorr.OperatorrId, operatorr);
            return operatorr;

        }

        public Operatorr Read(int OperatorrId)
        {
            return _Operatorrs[OperatorrId];
        }

        public Operatorr Update(int OperatorrId, Operatorr newOperatorr)
        {
            _Operatorrs[OperatorrId] = newOperatorr;
            return _Operatorrs[OperatorrId];
        }

        public bool Delete(int OperatorrId)
        {
            return _Operatorrs.Remove(OperatorrId);
        }
    }
}