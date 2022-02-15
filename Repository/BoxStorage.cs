using Automated_Car_Wash.Domain;
using System.Collections.Generic;
using System.Linq;

namespace Automated_Car_Wash.Repository
{
    public class BoxStorage
    {
        private readonly Dictionary<int, Box> _Boxs = new();

        public Box Create(Box box)
        {

            _Boxs.Add(box.BoxId, box);
            return box;

        }

        public Box Read(int BoxId)
        {
            return _Boxs[BoxId];
        }

        public Box Update(int BoxId, Box newBox)
        {
            _Boxs[BoxId] = newBox;
            return _Boxs[BoxId];
        }

        public bool Delete(int BoxId)
        {
            return _Boxs.Remove(BoxId);
        }
    }
}