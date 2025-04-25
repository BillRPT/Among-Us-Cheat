using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cheat_AmongUs
{
    internal class Impostor
    {
        private Memory.Mem uneMemoire;
        public Impostor(Memory.Mem uneMemoire)
        {
            this.uneMemoire = uneMemoire;   
        }

        public void changekillColdown()
        {
            uneMemoire.WriteMemory("GameAssembly.dll+023486D0,5C,8,80", "float", "0");
        }

        public void normalkillColdown()
        {
            uneMemoire.WriteMemory("GameAssembly.dll+023486D0,5C,0,8,80", "float", "15");
        }

        public void nocoldownVanish()
        {
            uneMemoire.WriteMemory("GameAssembly.dll+02336AB0,5C,0,58,48,68", "float", "0");
        }

        public void infinitevanishTime()
        {
            uneMemoire.WriteMemory("GameAssembly.dll+022DCE3C,5C,8,58,48,6C", "float", "999");
        }

        public void infiniteshifterTime()
        {
            uneMemoire.WriteMemory("GameAssembly.dll+02336AB0,5C,0,58,48,7C", "float", "99");
        }

        public void nocoldownShifter()
        {
            uneMemoire.WriteMemory("GameAssembly.dll+02336AB0,5C,0,58,48,78", "float", "0");
        }
    }
}
