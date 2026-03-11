using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPModul4_Muh_Aqsa_Sirojudin_103082400004
{
    internal class DoorMachine
    {
        public enum DoorState { Terkunci, Terbuka }

        private DoorState currentState;

        public DoorMachine()
        {
            currentState = DoorState.Terkunci;
            Console.WriteLine("Pintu terkunci");
        }

        public void BukaPintu()
        {
            currentState = DoorState.Terbuka;
            Console.WriteLine("Pintu tidak terkunci");
        }

        public void KunciPintu()
        {
            currentState = DoorState.Terkunci;
            Console.WriteLine("Pintu terkunci");
        }
    }
}
