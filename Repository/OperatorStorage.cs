using Automated_Car_Wash.Domain;
using System.Collections.Generic;
using System.Linq;

namespace Automated_Car_Wash.Repository
{
    public class OperatorStorage
    {
        private readonly Dictionary<int, Operator> _Operators = new();

        public Operator Create(Operator operator)
        {

            _Operators.Add(operator.OperatorId, operator);
            return operator;

        }

        public Operator Read(int OperatorId)
        {
            return _Operators[OperatorId];
        }

        public Operator Update(int OperatorId, Operator newOperator)
        {
            _Operators[OperatorId] = newOperator;
            return _Operators[OperatorId];
        }

        public bool Delete(int OperatorId)
        {
            return _Operators.Remove(OperatorId);
        }
    }
}