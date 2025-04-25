using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cheat_AmongUs
{
    internal class Engineer
    {
        private Memory.Mem uneMemoire;
        public Engineer(Memory.Mem unMemoire)
        {
            this.uneMemoire = unMemoire;
        }

        public void noventColdown()
        {
            uneMemoire.WriteMemory("GameAssembly.dll+02336AB0,5C,0,58,48,68", "float", "0");
        }

        public void noventTime()
        {
            uneMemoire.WriteMemory("GameAssembly.dll+022DCE3C,5C,8,58,48,6C", "float", "999");
        }
    }
}
