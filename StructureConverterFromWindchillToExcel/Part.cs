using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructureConverterFromWindchillToExcel
{
    [Serializable]
    internal class Part : Component
    {
        public Part(Designation design, string name, double mass = 0, string material = "", Drawing drawing = null) : base(design, name, mass = 0, material = "", drawing) { }
    }
}
