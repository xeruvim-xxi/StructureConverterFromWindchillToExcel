using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructureConverterFromWindchillToExcel
{
    [Serializable]
    internal class Asm : Component
    {
        public Specification Specification { get; }
        public Asm(Designation design, string name, double mass = 0, string material = "") : base(design, name, mass = 0, material = "")
        {
            Specification = new Specification(design, name, this);
        }
    }
}
