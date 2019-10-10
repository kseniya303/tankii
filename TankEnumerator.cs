using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tanki
{
    public class TankEnumerator : IEnumerator<Tank>
    {
        private Tank[] tankArr;
        private int tankIndex;
        public TankEnumerator(Tank[] tanks)
        {
            tankArr = tanks.ToArray(); // заносим в массив танки
            tankIndex = tankArr.Length; //
        }
        public Tank Current => tankArr[tankIndex]; //возвращает текущий объект
        object IEnumerator.Current => tankArr[tankIndex];

        public bool MoveNext()
        {
            tankIndex-=2;
            return tankIndex > 0;
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
