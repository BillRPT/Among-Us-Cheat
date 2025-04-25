using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cheat_AmongUs
{
    internal class SpeedHack
    {
        private Memory.Mem laMemoire;
        public SpeedHack(Memory.Mem uneMemoire)
        {
            this.laMemoire = uneMemoire;
        }

        public void changeSpeed(int speed)
        {
            laMemoire.WriteMemory("GameAssembly.dll+023486D0,5C,0,14,18", "float", speed.ToString());
        }
    }
}
