using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tanki
{
    public class TankEnumerator2 : IEnumerator<Tank>
    {
        private Tank[] tankArr;
        private int tankIndex;
        public TankEnumerator2(Tank[] tanks)
        {
            tankArr = tanks.ToArray(); // заносим в массив танки
            tankIndex = tankArr.Length; //
        }
        public Tank Current => tankArr[tankIndex]; //текущий объект
        object IEnumerator.Current => tankArr[tankIndex];

        public bool MoveNext()
        {
            tankIndex--;
            return tankIndex >= 0;
        }

        public void Reset() // в конце 
        {
            tankIndex = tankArr.Length;
        }
        public void Dispose()
        {

        }
    }
}
