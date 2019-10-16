using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tanki
{
    public class Armia : IEnumerable<Tank>
    {
        private List<Tank> _tankList;
        private IEnumerator<Tank> _enumerator;
        public Armia(List<Tank> tankList, IEnumerator<Tank> enumerator)
        {
            _tankList = tankList;
            _enumerator = enumerator;
        }
       
        public IEnumerator<Tank> GetEnumerator()
        {
            var rnd = new Random();
            return _tankList.OrderBy(t=>rnd.Next()).GetEnumerator(); //проходит по перемешанному списку танков
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
       
    }
}
