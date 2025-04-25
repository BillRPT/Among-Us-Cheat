using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cheat_AmongUs
{
    internal class Vision
    {
        private Memory.Mem laMemoire;

        public Vision(Memory.Mem uneMemoire)
        {
            this.laMemoire = uneMemoire;
        }

        public void changecrewmateVision(int visionValue)
        {
            //Changer la valeur de la vision
            laMemoire.WriteMemory("GameAssembly.dll+023486D0,5C,0,14,1C", "float", visionValue.ToString());
        }

        public void changementimposteurVision(int visionValue)
        {
            laMemoire.WriteMemory("GameAssembly.dll+023486D0,5C,0,14,20", "float", visionValue.ToString()); 
        }
    }
}
